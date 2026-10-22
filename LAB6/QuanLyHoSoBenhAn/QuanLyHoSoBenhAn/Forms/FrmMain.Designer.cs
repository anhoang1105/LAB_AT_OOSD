namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(55, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 32);
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ BỆNH ÁN";

            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDanhMuc.Location = new System.Drawing.Point(50, 100);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(400, 60);
            this.btnDanhMuc.Text = "1. Quản lý Danh mục (Khoa, Bác sĩ)";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);

            this.btnTiepNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTiepNhan.Location = new System.Drawing.Point(50, 180);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(400, 60);
            this.btnTiepNhan.Text = "2. Tiếp nhận & Cấp hồ sơ";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);

            this.btnKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnKhamBenh.Location = new System.Drawing.Point(50, 260);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(400, 60);
            this.btnKhamBenh.Text = "3. Khám bệnh, Xét nghiệm & Kê toa";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);

            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.btnThoat.Location = new System.Drawing.Point(50, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(400, 60);
            this.btnThoat.Text = "Thoát hệ thống";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhamBenh);
            this.Controls.Add(this.btnTiepNhan);
            this.Controls.Add(this.btnDanhMuc);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Bệnh án";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
    }
}