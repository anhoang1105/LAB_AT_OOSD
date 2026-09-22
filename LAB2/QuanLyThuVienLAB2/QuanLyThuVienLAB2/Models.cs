using System;

namespace QuanLyThuVienLab2
{
    public class TheThuVien
    {
        public string MaThe { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime HanSuDung { get; set; }
        public string TrangThai { get; set; }
    }

    public class NguoiDung
    {
        public int MaNguoiDung { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public string MaThe { get; set; }
    }

    public class ChuDe
    {
        public int MaChuDe { get; set; }
        public string TenChuDe { get; set; }
    }

    public class TaiLieu
    {
        public int MaTaiLieu { get; set; }
        public string TuaSach { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public int MaChuDe { get; set; }
        public string LoaiTaiLieu { get; set; }
        public int SoLuong { get; set; }
        public string DuongDanFile { get; set; }
    }

    public class PhieuMuon
    {
        public int MaPhieu { get; set; }
        public int MaNguoiDung { get; set; }
        public int MaTaiLieu { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTraThucTe { get; set; } // Nullable vì lúc mượn chưa trả
        public string TrangThai { get; set; }
        public int TienPhat { get; set; }
    }

    public class YeuCauDatMua
    {
        public int MaYeuCau { get; set; }
        public int MaNguoiDung { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public string TrangThaiDuyet { get; set; }
    }

    // Class tiện ích dùng chung để trả về thông báo lỗi/thành công (giữ nguyên mô hình của PDF)
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        private KetQuaXuLy(bool thanhCong, string thongBao)
        {
            ThanhCong = thanhCong;
            ThongBao = thongBao;
        }

        public static KetQuaXuLy Ok(string thongBao) { return new KetQuaXuLy(true, thongBao); }
        public static KetQuaXuLy Loi(string thongBao) { return new KetQuaXuLy(false, thongBao); }
    }
}