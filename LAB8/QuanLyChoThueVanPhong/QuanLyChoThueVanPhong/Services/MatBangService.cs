using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class MatBangService
    {
        public DataTable LayTang()
        {
            return Db.Query("SELECT MaTang, TenTang FROM Tang ORDER BY MaTang");
        }

        public DataTable LayPhong()
        {
            return Db.Query("SELECT MaPhong, MaTang, DienTich, Huong, GiaCoSo, TrangThai FROM Phong ORDER BY MaTang, MaPhong");
        }

        public KetQuaXuLy ThemPhong(string maPhong, string maTang, decimal dienTich, string huong, decimal giaCoSo)
        {
            if (string.IsNullOrWhiteSpace(maPhong) || string.IsNullOrWhiteSpace(maTang))
                return KetQuaXuLy.Fail("Mã phòng và mã tầng không được để trống.");
            if (dienTich <= 0) return KetQuaXuLy.Fail("Diện tích phải lớn hơn 0.");
            if (giaCoSo < 0) return KetQuaXuLy.Fail("Giá cơ sở không được âm.");

            try
            {
                Db.Execute("INSERT INTO Phong(MaPhong, MaTang, DienTich, Huong, GiaCoSo, TrangThai) VALUES(@m, @t, @d, @h, @g, N'Trống')",
                    Db.P("@m", maPhong), Db.P("@t", maTang), Db.P("@d", dienTich), Db.P("@h", huong), Db.P("@g", giaCoSo));
                return KetQuaXuLy.Ok("Đã thêm phòng thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}