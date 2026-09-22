using System;
using System.Data;
using QuanLyThuVienLab2.Data;

namespace QuanLyThuVienLab2.Services
{
    public class BaoCaoService
    {
        // 1. Lấy 5 con số tổng quan cho nửa trên Form
        public DataTable LayThongKeTongQuan()
        {
            string sql = @"
                SELECT 
                    (SELECT ISNULL(SUM(SoLuong), 0) FROM TaiLieu) AS TongSachConTrongKho,
                    (SELECT COUNT(*) FROM NguoiDung WHERE VaiTro = N'DocGia') AS TongDocGia,
                    (SELECT COUNT(*) FROM PhieuMuon WHERE NgayTraThucTe IS NULL) AS TongPhieuDangMuon,
                    (SELECT COUNT(*) FROM PhieuMuon WHERE NgayTraThucTe IS NULL AND HanTra < CAST(GETDATE() AS DATE)) AS TongPhieuQuaHan,
                    (SELECT ISNULL(SUM(TienPhat), 0) FROM PhieuMuon) AS TongDoanhThuPhat";
            return Db.Query(sql);
        }

        // 2. Lưới: Sách đang được mượn
        public DataTable LayBaoCaoSachDangMuon()
        {
            string sql = @"
                SELECT p.MaPhieu, n.HoTen AS TenDocGia, t.TuaSach, p.NgayMuon, p.HanTra
                FROM PhieuMuon p
                JOIN NguoiDung n ON p.MaNguoiDung = n.MaNguoiDung
                JOIN TaiLieu t ON p.MaTaiLieu = t.MaTaiLieu
                WHERE p.NgayTraThucTe IS NULL
                ORDER BY p.NgayMuon DESC";
            return Db.Query(sql);
        }

        // 3. Lưới: Sách đang bị quá hạn
        public DataTable LayBaoCaoSachQuaHan()
        {
            string sql = @"
                SELECT p.MaPhieu, n.HoTen AS TenDocGia, t.TuaSach, p.NgayMuon, p.HanTra, 
                       DATEDIFF(day, p.HanTra, GETDATE()) AS SoNgayTre
                FROM PhieuMuon p
                JOIN NguoiDung n ON p.MaNguoiDung = n.MaNguoiDung
                JOIN TaiLieu t ON p.MaTaiLieu = t.MaTaiLieu
                WHERE p.NgayTraThucTe IS NULL AND p.HanTra < CAST(GETDATE() AS DATE)
                ORDER BY SoNgayTre DESC";
            return Db.Query(sql);
        }

        // 4. Lưới: Top sách mượn nhiều nhất
        public DataTable LayBaoCaoTopSach()
        {
            string sql = @"
                SELECT t.MaTaiLieu, t.TuaSach, t.TacGia, COUNT(p.MaPhieu) AS SoLuotMuon
                FROM PhieuMuon p
                JOIN TaiLieu t ON p.MaTaiLieu = t.MaTaiLieu
                GROUP BY t.MaTaiLieu, t.TuaSach, t.TacGia
                ORDER BY SoLuotMuon DESC";
            return Db.Query(sql);
        }
    }
}