using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ChamCongService
    {
        public DataTable GetDanhSach() => Db.Query("SELECT b.MaBCC, b.MaNV, n.HoTen, b.Thang, b.Nam, b.TongGioLam FROM BangChamCong b INNER JOIN NhanVien n ON b.MaNV = n.MaNV");
        public DataTable GetDanhSachNhanVien() => Db.Query("SELECT MaNV, HoTen FROM NhanVien");

        public bool Add(string ma, string maNV, int thang, int nam, decimal tongGio) =>
            Db.Execute("INSERT INTO BangChamCong (MaBCC, MaNV, Thang, Nam, TongGioLam) VALUES (@Ma, @NV, @T, @N, @G)",
                new SqlParameter("@Ma", ma), new SqlParameter("@NV", maNV), new SqlParameter("@T", thang), new SqlParameter("@N", nam), new SqlParameter("@G", tongGio)) > 0;

        public bool Update(string ma, string maNV, int thang, int nam, decimal tongGio) =>
            Db.Execute("UPDATE BangChamCong SET MaNV=@NV, Thang=@T, Nam=@N, TongGioLam=@G WHERE MaBCC=@Ma",
                new SqlParameter("@Ma", ma), new SqlParameter("@NV", maNV), new SqlParameter("@T", thang), new SqlParameter("@N", nam), new SqlParameter("@G", tongGio)) > 0;

        public bool Delete(string ma) => Db.Execute("DELETE FROM BangChamCong WHERE MaBCC=@Ma", new SqlParameter("@Ma", ma)) > 0;
    }
}