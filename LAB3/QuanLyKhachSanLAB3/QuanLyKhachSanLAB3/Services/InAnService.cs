using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyKhachSanLAB3.Services
{
    public class InAnService
    {
        // Hàm hỗ trợ mở cửa sổ Preview dùng chung
        private void MoCuaSoIn(PrintPageEventHandler hamVeGiay)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += hamVeGiay;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.WindowState = FormWindowState.Maximized;
            ppd.ShowDialog();
        }

        // Các hàm gọi in từ bên ngoài
        public void InPhieuLuuTru() => MoCuaSoIn(VePhieuLuuTru);
        public void InPhieuDichVu() => MoCuaSoIn(VePhieuDichVu);
        public void InPhieuLapDat() => MoCuaSoIn(VePhieuLapDat);
        public void InHoaDonTrang() => MoCuaSoIn(VeHoaDonTrang);

        // --- 1. MẪU DÀNH CHO FRM ĐẶT PHÒNG ---
        private void VePhieuLuuTru(object sender, PrintPageEventArgs e)
        {
            VeTieuDeChung(e.Graphics, e.PageBounds.Width, "PHIẾU ĐĂNG KÝ NHẬN PHÒNG/ REGISTRATION FORM");
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 13, FontStyle.Regular);
            int y = 220; int l = 50; int step = 45;
            string dot = "....................................................................................................";

            g.DrawString("Họ và tên khách (Full name): " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Số CMND/CCCD/Passport: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Quốc tịch (Nationality): " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Phòng (Room): .................... Số người (Pax): .................... Kênh đặt: ....................", f, Brushes.Black, l, y); y += step;
            g.DrawString("Ngày đến: ......./......./20.....    Ngày đi dự kiến: ......./......./20.....", f, Brushes.Black, l, y); y += step;
            g.DrawString("Tiền đặt cọc (Deposit): " + dot, f, Brushes.Black, l, y);
            VeChuKy(g, e.PageBounds.Width, y + 80, "Nhân viên lễ tân", "Khách hàng");
        }

        // --- 2. MẪU DÀNH CHO FRM DỊCH VỤ ---
        private void VePhieuDichVu(object sender, PrintPageEventArgs e)
        {
            VeTieuDeChung(e.Graphics, e.PageBounds.Width, "PHIẾU YÊU CẦU DỊCH VỤ / SERVICE ORDER");
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 13, FontStyle.Regular);
            int y = 220; int l = 50; int step = 45;

            g.DrawString("Số phòng (Room No.): .......................... Ngày (Date): ......./......./20.....", f, Brushes.Black, l, y); y += step;
            g.DrawString("Tên khách hàng (Guest Name): ................................................................................", f, Brushes.Black, l, y); y += step;

            g.DrawString("Danh sách dịch vụ yêu cầu:", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, l, y); y += 30;
            for (int i = 1; i <= 6; i++)
            {
                g.DrawString($"{i}. Dịch vụ: ....................................... SL: ............ Đơn giá: ..............................", f, Brushes.Black, l, y);
                y += step;
            }
            g.DrawString("Ghi chú (Notes): ........................................................................................................", f, Brushes.Black, l, y);
            VeChuKy(g, e.PageBounds.Width, y + 80, "Nhân viên phục vụ", "Khách hàng");
        }

        // --- 3. MẪU DÀNH CHO FRM PHÒNG & TIỆN NGHI ---
        private void VePhieuLapDat(object sender, PrintPageEventArgs e)
        {
            VeTieuDeChung(e.Graphics, e.PageBounds.Width, "PHIẾU LẮP ĐẶT / BẢO TRÌ TIỆN NGHI");
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 13, FontStyle.Regular);
            int y = 220; int l = 50; int step = 45;
            string dot = "....................................................................................................";

            g.DrawString("Ngày thực hiện: ......./......./20.....", f, Brushes.Black, l, y); y += step;
            g.DrawString("Khu vực / Số phòng: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Tên thiết bị / Tiện nghi: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Mã tài sản: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Tình trạng hiện tại: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Ghi chú / Đề xuất: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString(dot + dot, f, Brushes.Black, l, y);
            VeChuKy(g, e.PageBounds.Width, y + 80, "Người bàn giao", "Nhân viên kỹ thuật");
        }

        // --- 4. MẪU DÀNH CHO FRM TRẢ PHÒNG ---
        private void VeHoaDonTrang(object sender, PrintPageEventArgs e)
        {
            VeTieuDeChung(e.Graphics, e.PageBounds.Width, "HÓA ĐƠN THANH TOÁN / INVOICE");
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 13, FontStyle.Regular);
            int y = 220; int l = 50; int step = 40;
            string dot = "..........................................................................";

            g.DrawString($"Số Hóa đơn: ........................   Ngày lập: ......./......./20.....", f, Brushes.Black, l, y); y += step;
            g.DrawString("Tên khách hàng: " + dot, f, Brushes.Black, l, y); y += step;
            g.DrawString("Số phòng: .............................. Số ngày ở: ..............................", f, Brushes.Black, l, y); y += step;
            g.DrawString("1. Tiền phòng (Room charge): .............................................................. VNĐ", f, Brushes.Black, l, y); y += step;
            g.DrawString("2. Tiền dịch vụ (Services): ................................................................... VNĐ", f, Brushes.Black, l, y); y += step;
            g.DrawString("3. Phụ thu/Đền bù (Surcharge): ........................................................... VNĐ", f, Brushes.Black, l, y); y += step;
            g.DrawString("4. Trừ tiền cọc (Deposit): ....................................................................... VNĐ", f, Brushes.Black, l, y); y += step;

            g.DrawString("TỔNG CỘNG PHẢI THANH TOÁN:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, l, y);
            g.DrawString("............................................. VNĐ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 400, y); y += step;

            g.DrawString("Số tiền viết bằng chữ: .......................................................................................", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, l, y);
            VeChuKy(g, e.PageBounds.Width, y + 70, "Thu ngân (Cashier)", "Khách hàng (Guest)");
        }

        // --- HÀM VẼ GIAO DIỆN CHUNG (Header & Chữ ký) ---
        private void VeTieuDeChung(Graphics g, int width, string tieuDePhieu)
        {
            Font fBold = new Font("Arial", 12, FontStyle.Bold);
            Font fTitle = new Font("Arial", 18, FontStyle.Bold);

            g.DrawString("KHÁCH SẠN:", fBold, Brushes.Black, 50, 50);
            g.DrawString("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", fBold, Brushes.Black, width - 420, 50);
            g.DrawString("Địa chỉ:", new Font("Arial", 11), Brushes.Black, 50, 75);
            g.DrawString("Độc lập - Tự do - Hạnh phúc", fBold, Brushes.Black, width - 330, 75);

            g.DrawLine(Pens.Black, width - 350, 100, width - 100, 100); // Gạch chân tiêu ngữ

            SizeF s = g.MeasureString(tieuDePhieu, fTitle);
            g.DrawString(tieuDePhieu, fTitle, Brushes.Black, (width - s.Width) / 2, 140);
        }

        private void VeChuKy(Graphics g, int width, int y, string nguoiTrai, string nguoiPhai)
        {   
            Font fBold = new Font("Arial", 12, FontStyle.Bold);
            Font fItalic = new Font("Arial", 11, FontStyle.Italic);

            g.DrawString(nguoiTrai, fBold, Brushes.Black, 100, y);
            g.DrawString(nguoiPhai, fBold, Brushes.Black, width - 300, y);

            g.DrawString("(Ký, ghi rõ họ tên)", fItalic, Brushes.Black, 110, y + 25);
            g.DrawString("(Ký, ghi rõ họ tên)", fItalic, Brushes.Black, width - 290, y + 25);
        }
    }
}