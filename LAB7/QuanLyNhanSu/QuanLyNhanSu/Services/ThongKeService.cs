using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ThongKeService
    {
        public DataTable NhanSuTheoPhongBan() =>
            Db.Query(@"SELECT p.TenPhongBan AS [Tên Phòng Ban], COUNT(n.MaNV) AS [Số Lượng Nhân Viên] 
                       FROM PhongBan p LEFT JOIN NhanVien n ON p.MaPB = n.MaPB 
                       GROUP BY p.TenPhongBan");

        public DataTable LuongTheoThang(int thang, int nam) =>
            Db.Query(@"SELECT n.HoTen AS [Họ Tên], b.TongThuNhap AS [Tổng Thu Nhập], b.TongKhauTru AS [Khấu Trừ], b.ThucLanh AS [Thực Lãnh] 
                       FROM BangLuong b INNER JOIN NhanVien n ON b.MaNV = n.MaNV 
                       WHERE b.Thang = @T AND b.Nam = @N",
                new SqlParameter("@T", thang), new SqlParameter("@N", nam));
    }
}