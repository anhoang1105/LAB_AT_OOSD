using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVienLab2.Data;

namespace QuanLyThuVienLab2.Services
{
    public class YeuCauDatMuaService
    {
        // 1. Lấy danh sách yêu cầu đặt mua kèm tên độc giả
        public DataTable LayDanhSachYeuCau()
        {
            string sql = @"
                SELECT y.MaYeuCau, y.MaNguoiDung, n.HoTen AS TenDocGia, 
                       y.TenSach, y.TacGia, y.NamXuatBan, y.TrangThaiDuyet
                FROM YeuCauDatMua y
                JOIN NguoiDung n ON y.MaNguoiDung = n.MaNguoiDung
                ORDER BY y.MaYeuCau DESC";
            return Db.Query(sql);
        }

        // 2. Thêm mới hoặc Cập nhật yêu cầu
        public KetQuaXuLy Luu(int maYeuCau, int maNguoiDung, string tenSach, string tacGia, int namXB, string trangThaiDuyet, bool capNhat)
        {
            if (string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(tacGia))
                return KetQuaXuLy.Loi("Tên sách và tác giả không được để trống.");

            try
            {
                string sql = capNhat
                    ? @"UPDATE YeuCauDatMua SET MaNguoiDung=@MaND, TenSach=@TenSach, TacGia=@TacGia, NamXuatBan=@NamXB, TrangThaiDuyet=@TrangThai WHERE MaYeuCau=@MaYC"
                    : @"INSERT INTO YeuCauDatMua (MaNguoiDung, TenSach, TacGia, NamXuatBan, TrangThaiDuyet) VALUES (@MaND, @TenSach, @TacGia, @NamXB, @TrangThai)";

                int n = Db.Execute(sql,
                    new SqlParameter("@MaYC", maYeuCau),
                    new SqlParameter("@MaND", maNguoiDung),
                    new SqlParameter("@TenSach", tenSach.Trim()),
                    new SqlParameter("@TacGia", tacGia.Trim()),
                    new SqlParameter("@NamXB", namXB),
                    new SqlParameter("@TrangThai", trangThaiDuyet)
                );

                return n > 0
                    ? KetQuaXuLy.Ok(capNhat ? "Cập nhật yêu cầu thành công!" : "Gửi yêu cầu đặt mua thành công!")
                    : KetQuaXuLy.Loi("Không có dữ liệu nào được thay đổi.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        // 3. Xóa yêu cầu
        public KetQuaXuLy Xoa(int maYeuCau)
        {
            try
            {
                int n = Db.Execute("DELETE FROM YeuCauDatMua WHERE MaYeuCau = @Ma", new SqlParameter("@Ma", maYeuCau));
                return n > 0 ? KetQuaXuLy.Ok("Xóa yêu cầu thành công.") : KetQuaXuLy.Loi("Không tìm thấy yêu cầu.");
            }
            catch (SqlException ex)
            {
                return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }
        public DataTable LayDanhSachGoiYSach()
        {
            // Lấy danh sách sách không trùng lặp để làm gợi ý tìm kiếm
            return Db.Query("SELECT DISTINCT TuaSach, TacGia, NamXuatBan FROM TaiLieu ORDER BY TuaSach");
        }
    }
}
