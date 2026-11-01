namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMatBang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnChiSoDV;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnNhanSu;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.btnMatBang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnChiSoDV = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnNhanSu = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 32);
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ VĂN PHÒNG";

            // CỘT 1 (X = 120)
            this.btnMatBang.Location = new System.Drawing.Point(120, 100);
            this.btnMatBang.Size = new System.Drawing.Size(250, 45);
            this.btnMatBang.Text = "Quản lý Mặt bằng && Phòng";
            this.btnMatBang.Click += new System.EventHandler(this.btnMatBang_Click);

            this.btnKhachHang.Location = new System.Drawing.Point(120, 160);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 45);
            this.btnKhachHang.Text = "Quản lý Khách hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);

            this.btnHopDong.Location = new System.Drawing.Point(120, 220);
            this.btnHopDong.Size = new System.Drawing.Size(250, 45);
            this.btnHopDong.Text = "Lập Hợp đồng thuê";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);

            this.btnGiaHan.Location = new System.Drawing.Point(120, 280);
            this.btnGiaHan.Size = new System.Drawing.Size(250, 45);
            this.btnGiaHan.Text = "Phiếu gia hạn hợp đồng";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);

            // CỘT 2 (X = 400)
            this.btnChiSoDV.Location = new System.Drawing.Point(400, 100);
            this.btnChiSoDV.Size = new System.Drawing.Size(250, 45);
            this.btnChiSoDV.Text = "Ghi nhận Chỉ số Dịch vụ";
            this.btnChiSoDV.Click += new System.EventHandler(this.btnChiSoDV_Click);

            this.btnHoaDon.Location = new System.Drawing.Point(400, 160);
            this.btnHoaDon.Size = new System.Drawing.Size(250, 45);
            this.btnHoaDon.Text = "Thu tiền Hóa đơn";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);

            this.btnNhanSu.Location = new System.Drawing.Point(400, 220);
            this.btnNhanSu.Size = new System.Drawing.Size(250, 45);
            this.btnNhanSu.Text = "Nhân sự && Thẻ xe";
            this.btnNhanSu.Click += new System.EventHandler(this.btnNhanSu_Click);

            this.btnKiemTra.Location = new System.Drawing.Point(400, 280);
            this.btnKiemTra.Size = new System.Drawing.Size(250, 45);
            this.btnKiemTra.Text = "Kiểm tra định kỳ";
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);

            // BOTTOM CENTER (X = 120, bọc 2 cột, Rộng = 530)
            this.btnThoat.Location = new System.Drawing.Point(120, 350);
            this.btnThoat.Size = new System.Drawing.Size(530, 45);
            this.btnThoat.Text = "Thoát Hệ Thống";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // FrmMain
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMatBang);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnChiSoDV);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnNhanSu);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnThoat);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Tòa nhà Cao ốc";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}