using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class HoaDonService
    {
        public DataTable LayHoaDonPhong() { return Db.Query("SELECT MaHDP, SoHopDong, ThangNam, SoTien, DaThanhToan, NgayThu FROM HoaDonPhong ORDER BY DaThanhToan, ThangNam DESC"); }
        public DataTable LayHoaDonDichVu() { return Db.Query("SELECT s.MaDV, d.TenDV, s.MaPhong, s.ThangNam, s.TieuThu, s.ThanhTien, s.DaThanhToan FROM SuDungDichVu s JOIN DichVu d ON s.MaDV = d.MaDV ORDER BY s.DaThanhToan, s.ThangNam DESC"); }

        public KetQuaXuLy ThuTienPhong(string maHDP)
        {
            if (string.IsNullOrWhiteSpace(maHDP)) return KetQuaXuLy.Fail("Chưa chọn hóa đơn phòng.");
            int n = Db.Execute("UPDATE HoaDonPhong SET DaThanhToan = 1, NgayThu = @nt WHERE MaHDP = @m AND DaThanhToan = 0", Db.P("@nt", DateTime.Today), Db.P("@m", maHDP));
            return n > 0 ? KetQuaXuLy.Ok($"Đã thu tiền hóa đơn phòng {maHDP}.") : KetQuaXuLy.Fail("Hóa đơn này đã thanh toán hoặc không tồn tại.");
        }

        public KetQuaXuLy ThuTienDichVu(string maDV, string maPhong, string thangNam)
        {
            if (string.IsNullOrWhiteSpace(maDV) || string.IsNullOrWhiteSpace(maPhong)) return KetQuaXuLy.Fail("Chưa chọn hóa đơn dịch vụ.");
            int n = Db.Execute("UPDATE SuDungDichVu SET DaThanhToan = 1 WHERE MaDV = @md AND MaPhong = @mp AND ThangNam = @tn AND DaThanhToan = 0",
                Db.P("@md", maDV), Db.P("@mp", maPhong), Db.P("@tn", thangNam));
            return n > 0 ? KetQuaXuLy.Ok("Đã thu tiền dịch vụ thành công.") : KetQuaXuLy.Fail("Hóa đơn dịch vụ này đã thanh toán hoặc không tồn tại.");
        }
    }
}