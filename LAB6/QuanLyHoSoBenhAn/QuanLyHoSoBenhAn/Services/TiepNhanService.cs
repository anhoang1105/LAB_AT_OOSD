using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class TiepNhanService
    {
        public DataTable LayDanhSachBenhNhan() => Db.Query("SELECT MaBN, HoTen, NgaySinh, DienThoai FROM BenhNhan ORDER BY MaBN DESC");

        public KetQuaXuLy DangKyVaCapHoSo(string maBN, string hoTen, string diaChi, DateTime ngaySinh, string dienThoai, string maPDK, string maHS, bool daDongPhi)
        {
            if (!daDongPhi) return KetQuaXuLy.Fail("Bệnh nhân phải đóng lệ phí để cấp hồ sơ.");
            try
            {
                // Gọi Stored Procedure Transaction đã viết ở bước CSDL
                Db.Execute("EXEC sp_DangKyBenhNhanMoi @MaBN, @HoTen, @DiaChi, @NgaySinh, @DienThoai, @MaPDK, @MaHS",
                    Db.P("@MaBN", maBN), Db.P("@HoTen", hoTen), Db.P("@DiaChi", diaChi),
                    Db.P("@NgaySinh", ngaySinh.Date), Db.P("@DienThoai", dienThoai),
                    Db.P("@MaPDK", maPDK), Db.P("@MaHS", maHS));
                return KetQuaXuLy.Ok("Cấp hồ sơ thành công!");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}