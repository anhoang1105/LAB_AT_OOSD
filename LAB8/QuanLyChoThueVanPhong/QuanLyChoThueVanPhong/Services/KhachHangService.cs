using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class KhachHangService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query("SELECT MaKH, TenKhachHang, DiaChi, DienThoai FROM KhachHang ORDER BY TenKhachHang");
        }

        public KetQuaXuLy LuuKhachHang(string maKH, string tenKH, string diaChi, string dienThoai)
        {
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(tenKH))
                return KetQuaXuLy.Fail("Mã và tên khách hàng không được để trống.");

            try
            {
                int exists = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM KhachHang WHERE MaKH = @m", Db.P("@m", maKH)));

                if (exists > 0)
                {
                    Db.Execute("UPDATE KhachHang SET TenKhachHang = @t, DiaChi = @d, DienThoai = @p WHERE MaKH = @m",
                        Db.P("@m", maKH), Db.P("@t", tenKH), Db.P("@d", diaChi), Db.P("@p", dienThoai));
                    return KetQuaXuLy.Ok("Cập nhật thông tin khách hàng thành công.");
                }
                else
                {
                    Db.Execute("INSERT INTO KhachHang(MaKH, TenKhachHang, DiaChi, DienThoai) VALUES(@m, @t, @d, @p)",
                        Db.P("@m", maKH), Db.P("@t", tenKH), Db.P("@d", diaChi), Db.P("@p", dienThoai));
                    return KetQuaXuLy.Ok("Thêm khách hàng mới thành công.");
                }
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}