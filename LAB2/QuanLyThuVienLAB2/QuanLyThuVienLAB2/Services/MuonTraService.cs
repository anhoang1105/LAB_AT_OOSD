using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVienLab2.Data;

namespace QuanLyThuVienLab2.Services
{
    public class MuonTraService
    {
        // 1. Lấy danh sách độc giả cho ComboBox
        public DataTable LayComboDocGia()
        {
            return Db.Query("SELECT MaNguoiDung, HoTen FROM NguoiDung WHERE VaiTro = N'DocGia' ORDER BY HoTen");
        }

        // 2. Lấy danh sách Thủ thư / Nhân viên cho ComboBox
        public DataTable LayComboThuThu()
        {
            return Db.Query("SELECT MaNguoiDung, HoTen FROM NguoiDung WHERE VaiTro = N'ThuThu' ORDER BY HoTen");
        }

        // 3. Lấy sách còn trong kho (SoLuong > 0)
        public DataTable LaySachConTrongKho()
        {
            return Db.Query("SELECT MaTaiLieu, TuaSach, TacGia, NamXuatBan, SoLuong FROM TaiLieu WHERE SoLuong > 0 ORDER BY TuaSach");
        }

        // 4. Kiểm tra điều kiện trước khi cho mượn
        public KetQuaXuLy KiemTraDieuKienMuon(int maNguoiDung)
        {
            // Kiểm tra xem độc giả đã có mã thẻ chưa và thẻ còn hoạt động không
            string sqlThe = @"
                SELECT TOP 1 t.HanSuDung, t.TrangThai 
                FROM NguoiDung n 
                JOIN TheThuVien t ON n.MaThe = t.MaThe 
                WHERE n.MaNguoiDung = @MaND";
            DataTable dtThe = Db.Query(sqlThe, new SqlParameter("@MaND", maNguoiDung));

            if (dtThe.Rows.Count == 0)
                return KetQuaXuLy.Loi("Độc giả này chưa liên kết thẻ thư viện hợp lệ!");

            DateTime hanSuDung = Convert.ToDateTime(dtThe.Rows[0]["HanSuDung"]);
            string trangThaiThe = dtThe.Rows[0]["TrangThai"].ToString();

            if (trangThaiThe != "Hoạt động")
                return KetQuaXuLy.Loi("Thẻ thư viện của độc giả đang ở trạng thái: " + trangThaiThe);

            if (hanSuDung.Date < DateTime.Today)
                return KetQuaXuLy.Loi("Thẻ thư viện đã hết hạn sử dụng vào ngày: " + hanSuDung.ToString("dd/MM/yyyy"));

            // Kiểm tra xem có đang giữ sách quá hạn không
            string sqlQuaHan = @"
                SELECT COUNT(*) FROM PhieuMuon 
                WHERE MaNguoiDung = @MaND AND TrangThai = N'Quá hạn'";
            int soSachQuaHan = Convert.ToInt32(Db.Scalar(sqlQuaHan, new SqlParameter("@MaND", maNguoiDung)));

            if (soSachQuaHan > 0)
                return KetQuaXuLy.Loi("Độc giả đang có sách quá hạn chưa trả, không được phép mượn thêm!");

            return KetQuaXuLy.Ok("Độc giả đủ điều kiện mượn sách.");
        }

        // 5. Lập phiếu mượn sách (Có Transaction)
        public KetQuaXuLy LapPhieuMuon(int maNguoiDung, int maTaiLieu, DateTime ngayMuon, DateTime hanTra)
        {
            if (hanTra.Date < ngayMuon.Date)
                return KetQuaXuLy.Loi("Ngày hẹn trả không thể nhỏ hơn ngày mượn.");

            var kqKiemTra = KiemTraDieuKienMuon(maNguoiDung);
            if (!kqKiemTra.ThanhCong) return kqKiemTra;

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    // Kiểm tra tồn kho
                    int soLuongTon = Convert.ToInt32(Db.Scalar("SELECT SoLuong FROM TaiLieu WHERE MaTaiLieu = @MaTL", new SqlParameter("@MaTL", maTaiLieu)));
                    if (soLuongTon <= 0)
                    {
                        tx.Rollback();
                        return KetQuaXuLy.Loi("Sách đã hết trong kho.");
                    }

                    // Thêm vào bảng PhieuMuon
                    string sqlPhieu = @"
                        INSERT INTO PhieuMuon (MaNguoiDung, MaTaiLieu, NgayMuon, HanTra, TrangThai, TienPhat) 
                        VALUES (@MaND, @MaTL, @NgayMuon, @HanTra, N'Đang mượn', 0)";
                    using (SqlCommand cmd = new SqlCommand(sqlPhieu, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@MaND", maNguoiDung);
                        cmd.Parameters.AddWithValue("@MaTL", maTaiLieu);
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon.Date);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra.Date);
                        cmd.ExecuteNonQuery();
                    }

                    // Giảm tồn kho đi 1
                    string sqlKho = "UPDATE TaiLieu SET SoLuong = SoLuong - 1 WHERE MaTaiLieu = @MaTL";
                    using (SqlCommand cmdKho = new SqlCommand(sqlKho, cn, tx))
                    {
                        cmdKho.Parameters.AddWithValue("@MaTL", maTaiLieu);
                        cmdKho.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Lập phiếu mượn thành công!");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Loi("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        // 6. Lấy danh sách sách đang mượn của độc giả
        public DataTable LayDanhSachDangMuon(int maNguoiDung)
        {
            string sql = @"
                SELECT p.MaPhieu, p.MaTaiLieu, t.TuaSach, p.NgayMuon, p.HanTra, p.TrangThai
                FROM PhieuMuon p
                JOIN TaiLieu t ON p.MaTaiLieu = t.MaTaiLieu
                WHERE p.MaNguoiDung = @MaND AND (p.TrangThai = N'Đang mượn' OR p.TrangThai = N'Quá hạn')";
            return Db.Query(sql, new SqlParameter("@MaND", maNguoiDung));
        }

        // 7. Tính tiền phạt
        public int TinhTienPhat(DateTime hanTra, DateTime ngayTraThucTe)
        {
            if (ngayTraThucTe.Date <= hanTra.Date) return 0;

            int soNgayTre = (ngayTraThucTe.Date - hanTra.Date).Days;
            object val = Db.Scalar("SELECT GiaTri FROM QuyDinhThuVien WHERE MaQuyDinh = 'PHAT_QUA_HAN'");
            int mucPhatMoiNgay = val != null ? Convert.ToInt32(val) : 5000;

            return soNgayTre * mucPhatMoiNgay;
        }

        // 8. Trả sách
        public KetQuaXuLy TraSach(int maPhieu, int maTaiLieu, DateTime hanTra, DateTime ngayTraThucTe)
        {
            int tienPhat = TinhTienPhat(hanTra, ngayTraThucTe);
            string trangThaiMoi = ngayTraThucTe.Date > hanTra.Date ? "Quá hạn (Đã trả)" : "Đã trả";

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    string sqlPhieu = @"
                        UPDATE PhieuMuon 
                        SET NgayTraThucTe = @NgayTra, TrangThai = @TrangThai, TienPhat = @TienPhat 
                        WHERE MaPhieu = @MaPhieu";
                    using (SqlCommand cmd = new SqlCommand(sqlPhieu, cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@NgayTra", ngayTraThucTe.Date);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                        cmd.Parameters.AddWithValue("@TienPhat", tienPhat);
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlKho = "UPDATE TaiLieu SET SoLuong = SoLuong + 1 WHERE MaTaiLieu = @MaTL";
                    using (SqlCommand cmdKho = new SqlCommand(sqlKho, cn, tx))
                    {
                        cmdKho.Parameters.AddWithValue("@MaTL", maTaiLieu);
                        cmdKho.ExecuteNonQuery();
                    }

                    tx.Commit();
                    string thongBao = "Trả sách thành công!";
                    if (tienPhat > 0) thongBao += $" Trả trễ hạn, tiền phạt là: {tienPhat:N0} VNĐ.";
                    return KetQuaXuLy.Ok(thongBao);
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Loi("Lỗi trả sách: " + ex.Message);
                }
            }
        }
    }
}