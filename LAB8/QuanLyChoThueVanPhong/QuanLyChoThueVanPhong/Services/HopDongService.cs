using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class HopDongService
    {
        public DataTable LayKhachHang() { return Db.Query("SELECT MaKH, TenKhachHang FROM KhachHang ORDER BY TenKhachHang"); }
        public DataTable LayPhongTrong() { return Db.Query("SELECT MaPhong, MaPhong + ' (Giá: ' + CAST(GiaCoSo AS varchar) + ')' AS HienThi FROM Phong WHERE TrangThai = N'Trống' ORDER BY MaPhong"); }
        public DataTable LayDanhSachHopDong() { return Db.Query("SELECT SoHopDong, MaKH, NgayLap, ThoiHanThue, TienDatCoc, NgayKetThuc, TrangThai FROM HopDongThue ORDER BY NgayLap DESC"); }

        public KetQuaXuLy LapHopDong(string soHD, string maKH, int thoiHan, decimal tienCoc, List<string> dsMaPhong)
        {
            if (string.IsNullOrWhiteSpace(soHD) || string.IsNullOrWhiteSpace(maKH)) return KetQuaXuLy.Fail("Số hợp đồng và khách hàng không được để trống.");
            if (thoiHan < 6) return KetQuaXuLy.Fail("Thời hạn thuê tối thiểu phải từ 6 tháng trở lên.");
            if (dsMaPhong == null || dsMaPhong.Count == 0) return KetQuaXuLy.Fail("Vui lòng chọn ít nhất 1 phòng để thuê.");
            if (tienCoc < 0) return KetQuaXuLy.Fail("Tiền cọc không được âm.");

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    DateTime ngayLap = DateTime.Today;
                    DateTime ngayKetThuc = ngayLap.AddMonths(thoiHan);

                    // 1. Lưu thông tin hợp đồng
                    Exec(cn, tr, "INSERT INTO HopDongThue(SoHopDong, MaKH, NgayLap, ThoiHanThue, TienDatCoc, NgayKetThuc, TrangThai) VALUES(@s, @k, @nl, @th, @tc, @nk, N'Đang hiệu lực')",
                        Db.P("@s", soHD), Db.P("@k", maKH), Db.P("@nl", ngayLap), Db.P("@th", thoiHan), Db.P("@tc", tienCoc), Db.P("@nk", ngayKetThuc));

                    decimal tongTien1Thang = 0;

                    // 2. Lưu chi tiết hợp đồng và khóa phòng
                    foreach (var p in dsMaPhong)
                    {
                        decimal donGia = Convert.ToDecimal(Db.Scalar("SELECT GiaCoSo FROM Phong WHERE MaPhong = @m", Db.P("@m", p)));
                        tongTien1Thang += donGia;

                        Exec(cn, tr, "INSERT INTO ChiTietHopDong(SoHopDong, MaPhong, DonGiaThue) VALUES(@s, @m, @g)",
                            Db.P("@s", soHD), Db.P("@m", p), Db.P("@g", donGia));

                        Exec(cn, tr, "UPDATE Phong SET TrangThai = N'Đã thuê' WHERE MaPhong = @m", Db.P("@m", p));
                    }

                    // 3. Khách bắt buộc trả trước 6 tháng đầu (tạo hóa đơn)
                    string maHDP = "HD-" + soHD.Replace("-", "");
                    string thangNam = ngayLap.ToString("MM/yyyy");
                    decimal tien6Thang = tongTien1Thang * 6;

                    Exec(cn, tr, "INSERT INTO HoaDonPhong(MaHDP, SoHopDong, ThangNam, SoTien, DaThanhToan, NgayThu) VALUES(@m, @s, @tn, @t, 1, @nt)",
                        Db.P("@m", maHDP), Db.P("@s", soHD), Db.P("@tn", thangNam), Db.P("@t", tien6Thang), Db.P("@nt", ngayLap));

                    tr.Commit();
                    return KetQuaXuLy.Ok($"Đã lập hợp đồng thành công! Khách hàng đã thanh toán {tien6Thang:N0} VNĐ cho 6 tháng đầu.");
                }
                catch (Exception ex)
                {
                    try { tr.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        private static void Exec(SqlConnection cn, SqlTransaction tr, string sql, params SqlParameter[] ps)
        {
            using (var cmd = new SqlCommand(sql, cn, tr)) { cmd.Parameters.AddRange(ps); cmd.ExecuteNonQuery(); }
        }
    }
}