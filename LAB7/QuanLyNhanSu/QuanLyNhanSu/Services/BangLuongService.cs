using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class BangLuongService
    {
        public DataTable GetDanhSach() => Db.Query("SELECT b.MaBL, b.MaNV, n.HoTen, b.Thang, b.Nam, b.TongThuNhap, b.TongKhauTru, b.ThucLanh FROM BangLuong b INNER JOIN NhanVien n ON b.MaNV = n.MaNV");
        public DataTable GetNhanVien() => Db.Query("SELECT MaNV, HoTen FROM NhanVien");

        public bool Save(string ma, string maNV, int thang, int nam, decimal thuNhap, decimal khauTru, bool isAdd)
        {
            decimal thucLanh = thuNhap - khauTru;
            string sql = isAdd ? "INSERT INTO BangLuong VALUES (@Ma, @NV, @T, @N, @TN, @KT, @TL)"
                               : "UPDATE BangLuong SET MaNV=@NV, Thang=@T, Nam=@N, TongThuNhap=@TN, TongKhauTru=@KT, ThucLanh=@TL WHERE MaBL=@Ma";
            return Db.Execute(sql, new SqlParameter("@Ma", ma), new SqlParameter("@NV", maNV), new SqlParameter("@T", thang),
                new SqlParameter("@N", nam), new SqlParameter("@TN", thuNhap), new SqlParameter("@KT", khauTru), new SqlParameter("@TL", thucLanh)) > 0;
        }
        public bool Delete(string ma) => Db.Execute("DELETE FROM BangLuong WHERE MaBL=@Ma", new SqlParameter("@Ma", ma)) > 0;
    }
}