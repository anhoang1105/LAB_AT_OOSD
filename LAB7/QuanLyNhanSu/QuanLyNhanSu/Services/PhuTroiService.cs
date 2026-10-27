using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhuTroiService
    {
        public DataTable GetDanhSach() => Db.Query(@"SELECT c.SoPhieuPT, c.MaNV, n.HoTen, p.NgayPhuTroi, p.HinhThuc, c.SoGio 
                                                     FROM ChiTietPhuTroi c 
                                                     INNER JOIN NhanVien n ON c.MaNV = n.MaNV 
                                                     INNER JOIN PhieuPhuTroi p ON c.SoPhieuPT = p.SoPhieuPT");
        public DataTable GetNhanVien() => Db.Query("SELECT MaNV, HoTen FROM NhanVien");

        public bool Save(string soPhieu, string maNV, DateTime ngay, string hinhThuc, decimal soGio, bool isAdd)
        {
            // Tự động tạo Phiếu nếu chưa tồn tại, hoặc cập nhật nếu đã có
            Db.Execute(@"IF NOT EXISTS (SELECT 1 FROM PhieuPhuTroi WHERE SoPhieuPT=@So) 
                            INSERT INTO PhieuPhuTroi VALUES (@So, @Ngay, @HT) 
                         ELSE 
                            UPDATE PhieuPhuTroi SET NgayPhuTroi=@Ngay, HinhThuc=@HT WHERE SoPhieuPT=@So",
                new SqlParameter("@So", soPhieu), new SqlParameter("@Ngay", ngay), new SqlParameter("@HT", hinhThuc));

            if (isAdd)
                return Db.Execute("INSERT INTO ChiTietPhuTroi VALUES (@So, @NV, @Gio)",
                    new SqlParameter("@So", soPhieu), new SqlParameter("@NV", maNV), new SqlParameter("@Gio", soGio)) > 0;
            else
                return Db.Execute("UPDATE ChiTietPhuTroi SET SoGio=@Gio WHERE SoPhieuPT=@So AND MaNV=@NV",
                    new SqlParameter("@So", soPhieu), new SqlParameter("@NV", maNV), new SqlParameter("@Gio", soGio)) > 0;
        }

        public bool Delete(string soPhieu, string maNV) =>
            Db.Execute("DELETE FROM ChiTietPhuTroi WHERE SoPhieuPT=@So AND MaNV=@NV",
                new SqlParameter("@So", soPhieu), new SqlParameter("@NV", maNV)) > 0;
    }
}