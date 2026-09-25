using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSanLAB3.Data;

namespace QuanLyKhachSanLAB3.Services
{
    public class ChiTietTien
    {
        public int SoNgay { get; set; }
        public decimal TienPhong { get; set; }
        public decimal TienDichVu { get; set; }
        public decimal TienCoc { get; set; }
    }

    public class TraPhongService
    {
        public DataTable LayPhieuDangO()
        {
            return Db.Query("SELECT d.SoPhieuDat, k.HoTen FROM PhieuDatPhong d JOIN KhachHang k ON d.MaKhach = k.MaKhach WHERE d.TrangThai = N'Đang ở' ORDER BY d.SoPhieuDat");
        }

        public DataTable LayDanhSachPhongChiTiet(string soPhieu)
        {
            string sql = @"
                SELECT c.SoPhong, p.DonGiaNgay, 
                ISNULL((SELECT SUM(cts.ThanhTien) FROM PhieuSuDungDV ps JOIN ChiTietPhieuSuDungDV cts ON ps.SoPhieuSDDV = cts.SoPhieuSDDV WHERE ps.SoPhieuDat = c.SoPhieuDat AND ps.SoPhong = c.SoPhong), 0) AS TienDichVu 
                FROM ChiTietDatPhong c JOIN Phong p ON c.SoPhong = p.SoPhong 
                WHERE c.SoPhieuDat = @s";
            return Db.Query(sql, new SqlParameter("@s", soPhieu));
        }

        public ChiTietTien TinhTien(string soPhieu, DateTime ngayTra)
        {
            var ct = new ChiTietTien();

            var dtPhieu = Db.Query("SELECT TienCoc, NgayNhanThucTe FROM PhieuDatPhong WHERE SoPhieuDat = @s", new SqlParameter("@s", soPhieu));
            if (dtPhieu.Rows.Count == 0) return ct;

            ct.TienCoc = Convert.ToDecimal(dtPhieu.Rows[0]["TienCoc"]);
            DateTime ngayNhan = Convert.ToDateTime(dtPhieu.Rows[0]["NgayNhanThucTe"]);

            int soNgay = (int)(ngayTra.Date - ngayNhan.Date).TotalDays;
            if (soNgay <= 0) soNgay = 1;
            ct.SoNgay = soNgay; // Lưu số ngày để insert vào bảng HoaDon

            var dtPhong = LayDanhSachPhongChiTiet(soPhieu);
            decimal tongPhong = 0;
            decimal tongDV = 0;

            foreach (DataRow r in dtPhong.Rows)
            {
                tongPhong += Convert.ToDecimal(r["DonGiaNgay"]) * soNgay;
                tongDV += Convert.ToDecimal(r["TienDichVu"]);
            }

            ct.TienPhong = tongPhong;
            ct.TienDichVu = tongDV;

            return ct;
        }

        public KetQuaXuLy ThanhToan(string soPhieu, string maNV, DateTime ngayTra, decimal phuThu)
        {
            if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maNV))
                return KetQuaXuLy.Fail("Thiếu thông tin phiếu hoặc nhân viên.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    var ct = TinhTien(soPhieu, ngayTra);
                    decimal soTienKhachTra = ct.TienPhong + ct.TienDichVu + phuThu - ct.TienCoc;

                    string soHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    // 1. Lưu Hóa Đơn (Đúng theo SQL: SoHoaDon, NgayLap, SoNgayTinhTien, TienPhong, TienDichVu)
                    var cmdHD = new SqlCommand("INSERT INTO HoaDon(SoHoaDon, SoPhieuDat, NgayLap, MaNV, SoNgayTinhTien, TienPhong, TienDichVu, TrangThai) VALUES(@shd, @s, @n, @nv, @sn, @tp, @tdv, N'Đã thanh toán')", cn, tx);
                    cmdHD.Parameters.AddWithValue("@shd", soHD);
                    cmdHD.Parameters.AddWithValue("@s", soPhieu);
                    cmdHD.Parameters.AddWithValue("@n", ngayTra);
                    cmdHD.Parameters.AddWithValue("@nv", maNV);
                    cmdHD.Parameters.AddWithValue("@sn", ct.SoNgay);
                    cmdHD.Parameters.AddWithValue("@tp", ct.TienPhong);
                    cmdHD.Parameters.AddWithValue("@tdv", ct.TienDichVu);
                    cmdHD.ExecuteNonQuery();

                    // 2. Lưu Lịch sử Thanh Toán (Chỉ lưu nếu số tiền phải trả > 0 vì điều kiện CHECK(SoTien > 0) trong SQL)
                    if (soTienKhachTra > 0)
                    {
                        string maTT = "TT" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        var cmdTT = new SqlCommand("INSERT INTO ThanhToan(MaThanhToan, SoHoaDon, NgayThanhToan, HinhThuc, SoTien) VALUES(@mtt, @shd, @n, N'Tiền mặt', @t)", cn, tx);
                        cmdTT.Parameters.AddWithValue("@mtt", maTT);
                        cmdTT.Parameters.AddWithValue("@shd", soHD);
                        cmdTT.Parameters.AddWithValue("@n", ngayTra);
                        cmdTT.Parameters.AddWithValue("@t", soTienKhachTra);
                        cmdTT.ExecuteNonQuery();
                    }

                    // 3. Chuyển trạng thái Phiếu đặt
                    var cmdPhieu = new SqlCommand("UPDATE PhieuDatPhong SET TrangThai = N'Đã trả', NgayTraThucTe = @n WHERE SoPhieuDat = @s", cn, tx);
                    cmdPhieu.Parameters.AddWithValue("@n", ngayTra);
                    cmdPhieu.Parameters.AddWithValue("@s", soPhieu);
                    cmdPhieu.ExecuteNonQuery();

                    // 4. Giải phóng phòng
                    var cmdPhong = new SqlCommand("UPDATE Phong SET TrangThai = N'Trống' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)", cn, tx);
                    cmdPhong.Parameters.AddWithValue("@s", soPhieu);
                    cmdPhong.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok($"Đã thanh toán thành công!\nMã hóa đơn: {soHD}\nKhách cần thanh toán: {soTienKhachTra:N0} VNĐ");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }
    }
}