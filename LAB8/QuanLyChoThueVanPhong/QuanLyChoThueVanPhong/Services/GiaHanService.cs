using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class GiaHanService
    {
        public DataTable LayHopDong() { return Db.Query("SELECT SoHopDong, SoHopDong + ' (Hạn: ' + CAST(ThoiHanThue AS varchar) + 'T)' AS HienThi FROM HopDongThue WHERE TrangThai = N'Đang hiệu lực'"); }

        public DataTable LayPhieuGiaHan() { return Db.Query("SELECT MaGiaHan, SoHopDong, ThoiGianGiaHan, NgayLap FROM PhieuGiaHan ORDER BY NgayLap DESC"); }

        public KetQuaXuLy LapPhieuGiaHan(string maGiaHan, string soHD, int thoiGianGiaHan)
        {
            if (string.IsNullOrWhiteSpace(maGiaHan) || string.IsNullOrWhiteSpace(soHD))
                return KetQuaXuLy.Fail("Mã gia hạn và số hợp đồng không được trống.");
            if (thoiGianGiaHan <= 0)
                return KetQuaXuLy.Fail("Thời gian gia hạn phải lớn hơn 0.");

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    int thoiHanGoc = Convert.ToInt32(Db.Scalar("SELECT ThoiHanThue FROM HopDongThue WHERE SoHopDong = @s", Db.P("@s", soHD)));
                    if (thoiGianGiaHan > thoiHanGoc / 2)
                    {
                        tr.Rollback();
                        return KetQuaXuLy.Fail($"Gia hạn ({thoiGianGiaHan}T) không được vượt 1/2 thời gian thuê gốc ({thoiHanGoc / 2}T).");
                    }

                    int noPhong = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM HoaDonPhong WHERE SoHopDong = @s AND DaThanhToan = 0", Db.P("@s", soHD)));
                    if (noPhong > 0) { tr.Rollback(); return KetQuaXuLy.Fail("Hợp đồng còn nợ tiền phòng, không thể gia hạn."); }

                    int noDV = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM SuDungDichVu s JOIN ChiTietHopDong c ON s.MaPhong = c.MaPhong WHERE c.SoHopDong = @s AND s.DaThanhToan = 0", Db.P("@s", soHD)));
                    if (noDV > 0) { tr.Rollback(); return KetQuaXuLy.Fail("Hợp đồng còn nợ tiền dịch vụ, không thể gia hạn."); }

                    DateTime ngayLap = DateTime.Today;
                    DateTime ngayKetThucCu = Convert.ToDateTime(Db.Scalar("SELECT NgayKetThuc FROM HopDongThue WHERE SoHopDong = @s", Db.P("@s", soHD)));
                    DateTime ngayKetThucMoi = ngayKetThucCu.AddMonths(thoiGianGiaHan);

                    using (var cmd = new SqlCommand("INSERT INTO PhieuGiaHan(MaGiaHan, SoHopDong, ThoiGianGiaHan, NgayLap) VALUES(@m, @s, @t, @nl)", cn, tr))
                    {
                        cmd.Parameters.Add(Db.P("@m", maGiaHan)); cmd.Parameters.Add(Db.P("@s", soHD));
                        cmd.Parameters.Add(Db.P("@t", thoiGianGiaHan)); cmd.Parameters.Add(Db.P("@nl", ngayLap));
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new SqlCommand("UPDATE HopDongThue SET NgayKetThuc = @nk, ThoiHanThue = ThoiHanThue + @t WHERE SoHopDong = @s", cn, tr))
                    {
                        cmd.Parameters.Add(Db.P("@nk", ngayKetThucMoi)); cmd.Parameters.Add(Db.P("@t", thoiGianGiaHan)); cmd.Parameters.Add(Db.P("@s", soHD));
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok($"Gia hạn thành công! Ngày kết thúc mới dời sang: {ngayKetThucMoi:dd/MM/yyyy}");
                }
                catch (Exception ex) { try { tr.Rollback(); } catch { } return KetQuaXuLy.Fail(ex.Message); }
            }
        }
    }
}