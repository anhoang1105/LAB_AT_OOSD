using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class HopDongService
    {
        public DataTable GetDanhSachHopDong() => Db.Query(
            "SELECT hd.SoHD, hd.MaNV, nv.HoTen, hd.LoaiHD, hd.NgayKy, hd.TrangThai, hd.ThoiHan FROM HopDong hd INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV");

        public DataTable GetDanhSachNhanVien() => Db.Query("SELECT MaNV, HoTen FROM NhanVien");

        public bool AddHopDong(string soHD, string maNV, string loaiHD, DateTime ngayKy, string trangThai, int? thoiHan)
        {
            SqlParameter pThoiHan = thoiHan.HasValue ? new SqlParameter("@ThoiHan", thoiHan.Value) : new SqlParameter("@ThoiHan", DBNull.Value);
            return Db.Execute("INSERT INTO HopDong (SoHD, MaNV, LoaiHD, NgayKy, TrangThai, ThoiHan) VALUES (@SoHD, @MaNV, @LoaiHD, @NgayKy, @TrangThai, @ThoiHan)",
                new SqlParameter("@SoHD", soHD), new SqlParameter("@MaNV", maNV), new SqlParameter("@LoaiHD", loaiHD),
                new SqlParameter("@NgayKy", ngayKy), new SqlParameter("@TrangThai", trangThai), pThoiHan) > 0;
        }

        public bool UpdateHopDong(string soHD, string maNV, string loaiHD, DateTime ngayKy, string trangThai, int? thoiHan)
        {
            SqlParameter pThoiHan = thoiHan.HasValue ? new SqlParameter("@ThoiHan", thoiHan.Value) : new SqlParameter("@ThoiHan", DBNull.Value);
            return Db.Execute("UPDATE HopDong SET MaNV = @MaNV, LoaiHD = @LoaiHD, NgayKy = @NgayKy, TrangThai = @TrangThai, ThoiHan = @ThoiHan WHERE SoHD = @SoHD",
                new SqlParameter("@SoHD", soHD), new SqlParameter("@MaNV", maNV), new SqlParameter("@LoaiHD", loaiHD),
                new SqlParameter("@NgayKy", ngayKy), new SqlParameter("@TrangThai", trangThai), pThoiHan) > 0;
        }

        public bool DeleteHopDong(string soHD) => Db.Execute("DELETE FROM HopDong WHERE SoHD = @SoHD", new SqlParameter("@SoHD", soHD)) > 0;
    }
}