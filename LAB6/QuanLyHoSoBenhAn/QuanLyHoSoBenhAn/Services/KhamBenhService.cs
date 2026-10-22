using System;
using System.Data;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class KhamBenhService
    {
        public DataTable LayDanhSachHoSo() => Db.Query("SELECT MaHoSo, MaHoSo + ' - ' + MaBN AS HienThi FROM HoSoBenhAn");

        public KetQuaXuLy LuuKhamBenh(string maPK, string maHS, string maBS, string maKhoa, string trieuChung, string maToa, string chiTiet, string cachDung)
        {
            try
            {
                Db.Execute("EXEC sp_LuuKhamBenhVaToaThuoc @MaPK, @MaHS, @MaBS, @MaKhoa, @TrieuChung, @MaToa, @ChiTiet, @CachDung",
                    Db.P("@MaPK", maPK), Db.P("@MaHS", maHS), Db.P("@MaBS", maBS), Db.P("@MaKhoa", maKhoa),
                    Db.P("@TrieuChung", trieuChung), Db.P("@MaToa", maToa), Db.P("@ChiTiet", chiTiet), Db.P("@CachDung", cachDung));
                return KetQuaXuLy.Ok("Lưu hồ sơ khám và toa thuốc thành công!");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}