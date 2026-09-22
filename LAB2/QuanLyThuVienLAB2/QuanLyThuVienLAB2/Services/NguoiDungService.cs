using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVienLab2.Data;

namespace QuanLyThuVienLab2.Services
{
    public class NguoiDungService
    {
        // 1. Lấy danh sách độc giả (VaiTro = 'DocGia') kèm thông tin thẻ
        public DataTable LayDanhSachDocGia()
        {
            string sql = @"
                SELECT n.MaNguoiDung, n.HoTen, n.Email, n.TenDangNhap, n.MatKhau, 
                       n.MaThe, t.NgayCap, t.HanSuDung, t.TrangThai
                FROM NguoiDung n
                LEFT JOIN TheThuVien t ON n.MaThe = t.MaThe
                WHERE n.VaiTro = N'DocGia'
                ORDER BY n.MaNguoiDung DESC";

            return Db.Query(sql);
        }

        // 2. Thêm hoặc Cập nhật Độc giả & Thẻ thư viện
        public KetQuaXuLy Luu(NguoiDung nd, TheThuVien the, bool capNhat)
        {
            if (string.IsNullOrWhiteSpace(nd.HoTen) || string.IsNullOrWhiteSpace(the.MaThe))
                return KetQuaXuLy.Loi("Họ tên và Mã thẻ không được để trống.");

            if (the.HanSuDung.Date < the.NgayCap.Date)
                return KetQuaXuLy.Loi("Hạn sử dụng phải từ ngày cấp trở đi.");

            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction()) // Dùng Transaction bảo vệ dữ liệu
            {
                try
                {
                    // A. XỬ LÝ BẢNG THẺ THƯ VIỆN TRƯỚC
                    string sqlThe = capNhat
                        ? @"UPDATE TheThuVien SET NgayCap=@NgayCap, HanSuDung=@HanSuDung, TrangThai=@TrangThai WHERE MaThe=@MaThe"
                        : @"INSERT INTO TheThuVien (MaThe, NgayCap, HanSuDung, TrangThai) VALUES (@MaThe, @NgayCap, @HanSuDung, @TrangThai)";

                    using (SqlCommand cmdThe = new SqlCommand(sqlThe, cn, tx))
                    {
                        cmdThe.Parameters.AddWithValue("@MaThe", the.MaThe.Trim());
                        cmdThe.Parameters.AddWithValue("@NgayCap", the.NgayCap.Date);
                        cmdThe.Parameters.AddWithValue("@HanSuDung", the.HanSuDung.Date);
                        cmdThe.Parameters.AddWithValue("@TrangThai", the.TrangThai);
                        cmdThe.ExecuteNonQuery();
                    }

                    // B. XỬ LÝ BẢNG NGƯỜI DÙNG SAU
                    string sqlND = capNhat
                        ? @"UPDATE NguoiDung SET HoTen=@HoTen, Email=@Email, TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, MaThe=@MaThe 
                            WHERE MaNguoiDung=@MaNguoiDung"
                        : @"INSERT INTO NguoiDung (HoTen, Email, TenDangNhap, MatKhau, VaiTro, MaThe) 
                            VALUES (@HoTen, @Email, @TenDangNhap, @MatKhau, N'DocGia', @MaThe)";

                    using (SqlCommand cmdND = new SqlCommand(sqlND, cn, tx))
                    {
                        cmdND.Parameters.AddWithValue("@MaNguoiDung", nd.MaNguoiDung);
                        cmdND.Parameters.AddWithValue("@HoTen", nd.HoTen.Trim());
                        cmdND.Parameters.AddWithValue("@Email", nd.Email.Trim());
                        cmdND.Parameters.AddWithValue("@TenDangNhap", nd.TenDangNhap.Trim());
                        cmdND.Parameters.AddWithValue("@MatKhau", nd.MatKhau.Trim());
                        cmdND.Parameters.AddWithValue("@MaThe", the.MaThe.Trim());
                        cmdND.ExecuteNonQuery();
                    }

                    tx.Commit(); // Xác nhận lưu cả 2 bảng
                    return KetQuaXuLy.Ok(capNhat ? "Cập nhật độc giả thành công!" : "Thêm mới độc giả và cấp thẻ thành công!");
                }
                catch (SqlException ex)
                {
                    tx.Rollback(); // Nếu lỗi thì hủy bỏ toàn bộ, không lưu bảng nào hết
                    if (ex.Number == 2627 || ex.Number == 2601)
                        return KetQuaXuLy.Loi("Mã thẻ, Email hoặc Tên đăng nhập đã tồn tại trong hệ thống.");
                    return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        // 3. Xóa Độc giả (Xóa Người dùng trước, xóa Thẻ sau)
        public KetQuaXuLy Xoa(int maNguoiDung, string maThe)
        {
            using (SqlConnection cn = Db.OpenConnection())
            using (SqlTransaction tx = cn.BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmdND = new SqlCommand("DELETE FROM NguoiDung WHERE MaNguoiDung = @MaND", cn, tx))
                    {
                        cmdND.Parameters.AddWithValue("@MaND", maNguoiDung);
                        cmdND.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdThe = new SqlCommand("DELETE FROM TheThuVien WHERE MaThe = @MaThe", cn, tx))
                    {
                        cmdThe.Parameters.AddWithValue("@MaThe", maThe);
                        cmdThe.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Xóa độc giả thành công.");
                }
                catch (SqlException ex)
                {
                    tx.Rollback();
                    if (ex.Number == 547) return KetQuaXuLy.Loi("Không thể xóa độc giả này vì đang có phiếu mượn/yêu cầu liên quan.");
                    return KetQuaXuLy.Loi("Lỗi cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}