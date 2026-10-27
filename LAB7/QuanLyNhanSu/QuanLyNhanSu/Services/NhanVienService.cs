using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class NhanVienService
    {
        public DataTable GetDanhSachNhanVien()
        {
            string sql = @"SELECT nv.MaNV, nv.HoTen, pb.TenPhongBan, nv.DiaChi, nv.DienThoai, nv.NgayVaoLam, nv.MaPB 
                           FROM NhanVien nv 
                           INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
            return Db.Query(sql);
        }

        public DataTable GetDanhSachPhongBan()
        {
            string sql = "SELECT MaPB, TenPhongBan FROM PhongBan";
            return Db.Query(sql);
        }

        public bool AddNhanVien(string maNV, string maPB, string hoTen, string diaChi, string dienThoai, DateTime ngayVaoLam)
        {
            string sql = "INSERT INTO NhanVien (MaNV, MaPB, HoTen, DiaChi, DienThoai, NgayVaoLam) VALUES (@MaNV, @MaPB, @HoTen, @DiaChi, @DienThoai, @NgayVaoLam)";
            SqlParameter[] ps = {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@DienThoai", dienThoai),
                new SqlParameter("@NgayVaoLam", ngayVaoLam)
            };
            return Db.Execute(sql, ps) > 0;
        }

        public bool UpdateNhanVien(string maNV, string maPB, string hoTen, string diaChi, string dienThoai, DateTime ngayVaoLam)
        {
            string sql = "UPDATE NhanVien SET MaPB = @MaPB, HoTen = @HoTen, DiaChi = @DiaChi, DienThoai = @DienThoai, NgayVaoLam = @NgayVaoLam WHERE MaNV = @MaNV";
            SqlParameter[] ps = {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@DienThoai", dienThoai),
                new SqlParameter("@NgayVaoLam", ngayVaoLam)
            };
            return Db.Execute(sql, ps) > 0;
        }

        public bool DeleteNhanVien(string maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            return Db.Execute(sql, new SqlParameter("@MaNV", maNV)) > 0;
        }
    }
}