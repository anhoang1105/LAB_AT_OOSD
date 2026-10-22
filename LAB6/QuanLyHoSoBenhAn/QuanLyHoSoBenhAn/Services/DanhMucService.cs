using System;
using System.Data;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class DanhMucService
    {
        public DataTable LayKhoa() => Db.Query("SELECT MaKhoa, TenKhoa FROM KhoaDieuTri");
        public DataTable LayBacSi() => Db.Query("SELECT b.MaBS, b.TenBS, k.TenKhoa FROM BacSi b JOIN KhoaDieuTri k ON b.MaKhoa = k.MaKhoa");

        public KetQuaXuLy ThemKhoa(string ma, string ten)
        {
            try { Db.Execute("INSERT INTO KhoaDieuTri VALUES(@m, @t)", Db.P("@m", ma), Db.P("@t", ten)); return KetQuaXuLy.Ok("Đã thêm khoa!"); }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy ThemBacSi(string ma, string ten, string maKhoa)
        {
            try { Db.Execute("INSERT INTO BacSi VALUES(@m, @t, @k)", Db.P("@m", ma), Db.P("@t", ten), Db.P("@k", maKhoa)); return KetQuaXuLy.Ok("Đã thêm bác sĩ!"); }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}