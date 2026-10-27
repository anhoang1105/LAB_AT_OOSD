using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class DanhMucService
    {
        public DataTable GetDanhSachPhongBan() => Db.Query("SELECT MaPB, TenPhongBan FROM PhongBan");

        public bool AddPhongBan(string maPB, string tenPB) =>
            Db.Execute("INSERT INTO PhongBan (MaPB, TenPhongBan) VALUES (@MaPB, @TenPB)",
                new SqlParameter("@MaPB", maPB), new SqlParameter("@TenPB", tenPB)) > 0;

        public bool UpdatePhongBan(string maPB, string tenPB) =>
            Db.Execute("UPDATE PhongBan SET TenPhongBan = @TenPB WHERE MaPB = @MaPB",
                new SqlParameter("@MaPB", maPB), new SqlParameter("@TenPB", tenPB)) > 0;

        public bool DeletePhongBan(string maPB) =>
            Db.Execute("DELETE FROM PhongBan WHERE MaPB = @MaPB", new SqlParameter("@MaPB", maPB)) > 0;
    }
}