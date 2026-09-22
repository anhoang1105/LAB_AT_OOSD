using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVienLab2.Data;

namespace QuanLyThuVienLab2.Services
{
    public class TaiLieuService
    {
        // 1. Lấy danh sách Chủ đề cho ComboBox
        public DataTable LayDanhSachChuDe()
        {
            return Db.Query("SELECT MaChuDe, TenChuDe FROM ChuDe ORDER BY TenChuDe");
        }

        // 2. Lấy danh sách Tài liệu kèm tìm kiếm
        public DataTable LayDanhSachTaiLieu(string tuKhoa = "")
        {
            string sql = @"
                SELECT t.MaTaiLieu, t.TuaSach, t.TacGia, t.NamXuatBan, 
                       t.MaChuDe, c.TenChuDe, t.LoaiTaiLieu, t.SoLuong, t.DuongDanFile 
                FROM TaiLieu t
                JOIN ChuDe c ON t.MaChuDe = c.MaChuDe
                WHERE t.TuaSach LIKE @TuKhoa OR t.TacGia LIKE @TuKhoa
                ORDER BY t.MaTaiLieu DESC";

            return Db.Query(sql, new SqlParameter("@TuKhoa", "%" + tuKhoa.Trim() + "%"));
        }

        // 3. Xử lý Thêm mới hoặc Cập nhật
        public KetQuaXuLy Luu(TaiLieu t, bool capNhat)
        {
            if (string.IsNullOrWhiteSpace(t.TuaSach) || string.IsNullOrWhiteSpace(t.TacGia))
                return KetQuaXuLy.Loi("Tựa sách và Tác giả không được để trống.");

            if (t.SoLuong < 0)
                return KetQuaXuLy.Loi("Số lượng không được nhỏ hơn 0.");

            try
            {
                string sql = capNhat
                    ? @"UPDATE TaiLieu SET TuaSach=@TuaSach, TacGia=@TacGia, NamXuatBan=@NamXuatBan, 
                               MaChuDe=@MaChuDe, LoaiTaiLieu=@LoaiTaiLieu, SoLuong=@SoLuong, DuongDanFile=@DuongDanFile
                        WHERE MaTaiLieu=@MaTaiLieu"
                    : @"INSERT INTO TaiLieu (TuaSach, TacGia, NamXuatBan, MaChuDe, LoaiTaiLieu, SoLuong, DuongDanFile) 
                        VALUES (@TuaSach, @TacGia, @NamXuatBan, @MaChuDe, @LoaiTaiLieu, @SoLuong, @DuongDanFile)";

                int rows = Db.Execute(sql,
                    new SqlParameter("@MaTaiLieu", t.MaTaiLieu),
                    new SqlParameter("@TuaSach", t.TuaSach.Trim()),
                    new SqlParameter("@TacGia", t.TacGia.Trim()),
                    new SqlParameter("@NamXuatBan", t.NamXuatBan),
                    new SqlParameter("@MaChuDe", t.MaChuDe),
                    new SqlParameter("@LoaiTaiLieu", t.LoaiTaiLieu),
                    new SqlParameter("@SoLuong", t.SoLuong),
                    new SqlParameter("@DuongDanFile", string.IsNullOrWhiteSpace(t.DuongDanFile) ? (object)DBNull.Value : t.DuongDanFile.Trim())
                );

                return rows > 0
                    ? KetQuaXuLy.Ok(capNhat ? "Cập nhật tài liệu thành công." : "Thêm tài liệu mới thành công.")
                    : KetQuaXuLy.Loi("Không có dữ liệu nào được thay đổi.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        // 4. Xử lý Xóa
        public KetQuaXuLy Xoa(int maTaiLieu)
        {
            try
            {
                int rows = Db.Execute("DELETE FROM TaiLieu WHERE MaTaiLieu = @Ma", new SqlParameter("@Ma", maTaiLieu));
                return rows > 0 ? KetQuaXuLy.Ok("Xóa tài liệu thành công.") : KetQuaXuLy.Loi("Không tìm thấy tài liệu.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) return KetQuaXuLy.Loi("Không thể xóa tài liệu này vì đang có phiếu mượn liên quan.");
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }
    }
}