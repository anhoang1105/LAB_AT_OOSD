using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class NhanSuService
    {
        public DataTable LayPhongDaThue() { return Db.Query("SELECT MaPhong FROM Phong WHERE TrangThai = N'Đã thuê'"); }
        public DataTable LayNhanVien() { return Db.Query("SELECT MaNV, MaNV + ' - ' + HoTen AS HienThi, MaPhong, HoTen, ChucVu, CongTy FROM NhanVien ORDER BY MaNV"); }
        public DataTable LayTheXe() { return Db.Query("SELECT t.MaThe, t.MaNV, n.HoTen, t.BienSoXe, t.LoaiXe FROM TheGiuXe t JOIN NhanVien n ON t.MaNV = n.MaNV ORDER BY t.MaThe"); }

        public KetQuaXuLy ThemNhanVien(string maNV, string maPhong, string hoTen, string chucVu, string congTy)
        {
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(maPhong))
                return KetQuaXuLy.Fail("Mã nhân viên, họ tên và phòng làm việc không được trống.");
            try
            {
                Db.Execute("INSERT INTO NhanVien(MaNV, MaPhong, HoTen, ChucVu, CongTy) VALUES(@m, @p, @ht, @cv, @ct)",
                    Db.P("@m", maNV), Db.P("@p", maPhong), Db.P("@ht", hoTen), Db.P("@cv", chucVu), Db.P("@ct", congTy));
                return KetQuaXuLy.Ok("Thêm nhân viên thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy CapTheXe(string maThe, string maNV, string bienSo, string loaiXe)
        {
            if (string.IsNullOrWhiteSpace(maThe) || string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(bienSo))
                return KetQuaXuLy.Fail("Vui lòng nhập đủ Mã thẻ, Chọn nhân viên và Biển số xe.");
            try
            {
                int check = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM TheGiuXe WHERE MaNV = @m", Db.P("@m", maNV)));
                if (check > 0) return KetQuaXuLy.Fail("Nhân viên này đã được cấp thẻ xe. Mỗi nhân viên chỉ được 1 thẻ.");

                Db.Execute("INSERT INTO TheGiuXe(MaThe, MaNV, BienSoXe, LoaiXe) VALUES(@mt, @mn, @bs, @lx)",
                    Db.P("@mt", maThe), Db.P("@mn", maNV), Db.P("@bs", bienSo), Db.P("@lx", loaiXe));
                return KetQuaXuLy.Ok("Cấp thẻ xe thành công.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}