using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSanLAB3.Data;

namespace QuanLyKhachSanLAB3.Services
{
    public class ThongKeService
    {
        public DataTable LayDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            // Điều chỉnh denNgay đến 23:59:59 để lấy trọn vẹn dữ liệu của ngày cuối cùng
            DateTime denNgayCuoi = denNgay.Date.AddDays(1).AddTicks(-1);

            // Truy vấn chính xác các cột từ bảng HoaDon trong SQL
            string sql = @"
                SELECT 
                    SoHoaDon AS [Số Hóa Đơn], 
                    SoPhieuDat AS [Số Phiếu Đặt], 
                    NgayLap AS [Ngày Thanh Toán], 
                    MaNV AS [Nhân Viên Thu], 
                    SoNgayTinhTien AS [Số Ngày Ở], 
                    TienPhong AS [Tiền Phòng], 
                    TienDichVu AS [Tiền Dịch Vụ], 
                    TongTien AS [Tổng Tiền]
                FROM HoaDon 
                WHERE NgayLap >= @tuNgay AND NgayLap <= @denNgay 
                  AND TrangThai = N'Đã thanh toán'
                ORDER BY NgayLap DESC";

            return Db.Query(sql,
                new SqlParameter("@tuNgay", tuNgay.Date),
                new SqlParameter("@denNgay", denNgayCuoi));
        }
    }
}