using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class KhenThuongService
    {
        public DataTable GetDanhSach() => Db.Query("SELECT q.SoQDKTKL, q.MaNV, n.HoTen, q.LoaiQD, q.SoTien, q.NgayKy FROM QDKhenThuongKyLuat q INNER JOIN NhanVien n ON q.MaNV = n.MaNV");
        public DataTable GetNhanVien() => Db.Query("SELECT MaNV, HoTen FROM NhanVien");

        public bool Add(string soQD, string maNV, string loai, decimal tien, DateTime ngay) =>
            Db.Execute("INSERT INTO QDKhenThuongKyLuat VALUES (@So, @NV, @Loai, @Tien, @Ngay)",
                new SqlParameter("@So", soQD), new SqlParameter("@NV", maNV), new SqlParameter("@Loai", loai), new SqlParameter("@Tien", tien), new SqlParameter("@Ngay", ngay)) > 0;

        public bool Update(string soQD, string maNV, string loai, decimal tien, DateTime ngay) =>
            Db.Execute("UPDATE QDKhenThuongKyLuat SET MaNV=@NV, LoaiQD=@Loai, SoTien=@Tien, NgayKy=@Ngay WHERE SoQDKTKL=@So",
                new SqlParameter("@So", soQD), new SqlParameter("@NV", maNV), new SqlParameter("@Loai", loai), new SqlParameter("@Tien", tien), new SqlParameter("@Ngay", ngay)) > 0;

        public bool Delete(string soQD) => Db.Execute("DELETE FROM QDKhenThuongKyLuat WHERE SoQDKTKL=@So", new SqlParameter("@So", soQD)) > 0;
    }
}