using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class DichVuService
    {
        public DataTable LayDichVu() { return Db.Query("SELECT MaDV, TenDV + ' (Đơn giá: ' + CAST(DonGia AS varchar) + ')' AS HienThi FROM DichVu ORDER BY TenDV"); }
        public DataTable LayPhongDangThue() { return Db.Query("SELECT MaPhong FROM Phong WHERE TrangThai = N'Đã thuê' ORDER BY MaPhong"); }
        public DataTable LayDanhSachChiSo() { return Db.Query("SELECT MaDV, MaPhong, ThangNam, ChiSoDau, ChiSoCuoi, TieuThu, ThanhTien, DaThanhToan FROM SuDungDichVu ORDER BY ThangNam DESC, MaPhong"); }

        public KetQuaXuLy ChotChiSo(string maDV, string maPhong, string thangNam, int chiSoDau, int chiSoCuoi)
        {
            if (string.IsNullOrWhiteSpace(maDV) || string.IsNullOrWhiteSpace(maPhong) || string.IsNullOrWhiteSpace(thangNam))
                return KetQuaXuLy.Fail("Dịch vụ, phòng và tháng năm không được để trống.");
            if (chiSoCuoi < chiSoDau)
                return KetQuaXuLy.Fail("Chỉ số cuối không được nhỏ hơn chỉ số đầu.");

            try
            {
                decimal donGia = Convert.ToDecimal(Db.Scalar("SELECT DonGia FROM DichVu WHERE MaDV = @m", Db.P("@m", maDV)));
                int tieuThu = chiSoCuoi - chiSoDau;
                decimal thanhTien = tieuThu * donGia;

                Db.Execute("INSERT INTO SuDungDichVu(MaDV, MaPhong, ThangNam, ChiSoDau, ChiSoCuoi, TieuThu, ThanhTien, DaThanhToan) VALUES(@md, @mp, @tn, @d, @c, @tt, @t, 0)",
                    Db.P("@md", maDV), Db.P("@mp", maPhong), Db.P("@tn", thangNam), Db.P("@d", chiSoDau), Db.P("@c", chiSoCuoi), Db.P("@tt", tieuThu), Db.P("@t", thanhTien));

                return KetQuaXuLy.Ok($"Đã chốt chỉ số thành công. Tổng tiền DV phát sinh: {thanhTien:N0} đ.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}