using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class KiemTraService
    {
        public DataTable LayPhong() { return Db.Query("SELECT MaPhong FROM Phong ORDER BY MaPhong"); }
        public DataTable LayDanhSachKiemTra() { return Db.Query("SELECT MaKT, MaPhong, NgayKiemTra, BienBanViPham, TienPhat FROM KiemTraDinhKy ORDER BY NgayKiemTra DESC"); }

        public KetQuaXuLy LapBienBan(string maKT, string maPhong, DateTime ngayKiemTra, string bienBan, decimal tienPhat)
        {
            if (string.IsNullOrWhiteSpace(maKT) || string.IsNullOrWhiteSpace(maPhong)) return KetQuaXuLy.Fail("Mã kiểm tra và phòng không được trống.");
            if (tienPhat < 0) return KetQuaXuLy.Fail("Tiền phạt không được âm.");
            try
            {
                Db.Execute("INSERT INTO KiemTraDinhKy(MaKT, MaPhong, NgayKiemTra, BienBanViPham, TienPhat) VALUES(@m, @p, @n, @b, @t)",
                    Db.P("@m", maKT), Db.P("@p", maPhong), Db.P("@n", ngayKiemTra), Db.P("@b", bienBan), Db.P("@t", tienPhat));
                return KetQuaXuLy.Ok(tienPhat > 0 ? $"Đã lập biên bản vi phạm kết cấu, phạt {tienPhat:N0} đ." : "Đã ghi nhận tình trạng kiểm tra định kỳ bình thường.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}