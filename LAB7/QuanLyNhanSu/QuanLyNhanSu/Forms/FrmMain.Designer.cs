namespace QuanLyNhanSu.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnHoSoNhanVien = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnPhuTroi = new System.Windows.Forms.Button();
            this.btnKhenThuong = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ CÔNG TY SƠN ĐÔNG Á";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Nút: Danh mục Phòng ban
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDanhMuc.Location = new System.Drawing.Point(100, 110);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(260, 60);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục Phòng ban";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);

            // Nút: Hồ sơ Nhân viên
            this.btnHoSoNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHoSoNhanVien.Location = new System.Drawing.Point(420, 110);
            this.btnHoSoNhanVien.Name = "btnHoSoNhanVien";
            this.btnHoSoNhanVien.Size = new System.Drawing.Size(260, 60);
            this.btnHoSoNhanVien.TabIndex = 2;
            this.btnHoSoNhanVien.Text = "Hồ sơ Nhân viên";
            this.btnHoSoNhanVien.UseVisualStyleBackColor = true;
            this.btnHoSoNhanVien.Click += new System.EventHandler(this.btnHoSoNhanVien_Click);

            // Nút: Quản lý Hợp đồng
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHopDong.Location = new System.Drawing.Point(100, 190);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(260, 60);
            this.btnHopDong.TabIndex = 3;
            this.btnHopDong.Text = "Quản lý Hợp đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);

            // Nút: Chấm công
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChamCong.Location = new System.Drawing.Point(420, 190);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(260, 60);
            this.btnChamCong.TabIndex = 4;
            this.btnChamCong.Text = "Bảng Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);

            // Nút: Quản lý Phụ trội
            this.btnPhuTroi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPhuTroi.Location = new System.Drawing.Point(100, 270);
            this.btnPhuTroi.Name = "btnPhuTroi";
            this.btnPhuTroi.Size = new System.Drawing.Size(260, 60);
            this.btnPhuTroi.TabIndex = 5;
            this.btnPhuTroi.Text = "Quản lý Phụ trội (Làm thêm)";
            this.btnPhuTroi.UseVisualStyleBackColor = true;
            this.btnPhuTroi.Click += new System.EventHandler(this.btnPhuTroi_Click);

            // Nút: Khen thưởng - Kỷ luật
            this.btnKhenThuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnKhenThuong.Location = new System.Drawing.Point(420, 270);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Size = new System.Drawing.Size(260, 60);
            this.btnKhenThuong.TabIndex = 6;
            this.btnKhenThuong.Text = "Khen thưởng - Kỷ luật";
            this.btnKhenThuong.UseVisualStyleBackColor = true;
            this.btnKhenThuong.Click += new System.EventHandler(this.btnKhenThuong_Click);

            // Nút: Tính Lương
            this.btnBangLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBangLuong.Location = new System.Drawing.Point(100, 350);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(260, 60);
            this.btnBangLuong.TabIndex = 7;
            this.btnBangLuong.Text = "Tính Lương";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);

            // Nút: Thống kê
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.Location = new System.Drawing.Point(420, 350);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(260, 60);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê - Báo cáo";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // Nút: Thoát
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(260, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(260, 60);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát phần mềm";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // FrmMain
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnBangLuong);
            this.Controls.Add(this.btnKhenThuong);
            this.Controls.Add(this.btnPhuTroi);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnHoSoNhanVien);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ - Hệ thống Quản lý Nhân sự";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnHoSoNhanVien;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnPhuTroi;
        private System.Windows.Forms.Button btnKhenThuong;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}