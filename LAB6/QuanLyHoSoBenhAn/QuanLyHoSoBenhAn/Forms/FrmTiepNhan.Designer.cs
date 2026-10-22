namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmTiepNhan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpBenhNhan = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHoSo = new System.Windows.Forms.GroupBox();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieuDK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLePhi = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.grpBenhNhan.SuspendLayout();
            this.grpHoSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBenhNhan
            // 
            this.grpBenhNhan.Controls.Add(this.txtDiaChi);
            this.grpBenhNhan.Controls.Add(this.label5);
            this.grpBenhNhan.Controls.Add(this.dtNgaySinh);
            this.grpBenhNhan.Controls.Add(this.label4);
            this.grpBenhNhan.Controls.Add(this.txtDienThoai);
            this.grpBenhNhan.Controls.Add(this.label3);
            this.grpBenhNhan.Controls.Add(this.txtHoTen);
            this.grpBenhNhan.Controls.Add(this.label2);
            this.grpBenhNhan.Controls.Add(this.txtMaBN);
            this.grpBenhNhan.Controls.Add(this.label1);
            this.grpBenhNhan.Location = new System.Drawing.Point(12, 12);
            this.grpBenhNhan.Name = "grpBenhNhan";
            this.grpBenhNhan.Size = new System.Drawing.Size(320, 180);
            this.grpBenhNhan.TabIndex = 3;
            this.grpBenhNhan.TabStop = false;
            this.grpBenhNhan.Text = "Thông tin Bệnh nhân";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 137);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(100, 107);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaySinh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(100, 77);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ và tên:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(100, 17);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(200, 20);
            this.txtMaBN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã bệnh nhân:";
            // 
            // grpHoSo
            // 
            this.grpHoSo.Controls.Add(this.txtMaHoSo);
            this.grpHoSo.Controls.Add(this.label7);
            this.grpHoSo.Controls.Add(this.txtMaPhieuDK);
            this.grpHoSo.Controls.Add(this.label6);
            this.grpHoSo.Controls.Add(this.chkLePhi);
            this.grpHoSo.Location = new System.Drawing.Point(350, 12);
            this.grpHoSo.Name = "grpHoSo";
            this.grpHoSo.Size = new System.Drawing.Size(260, 110);
            this.grpHoSo.TabIndex = 2;
            this.grpHoSo.TabStop = false;
            this.grpHoSo.Text = "Hồ sơ & Đăng ký";
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(100, 77);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(140, 20);
            this.txtMaHoSo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã hồ sơ BA:";
            // 
            // txtMaPhieuDK
            // 
            this.txtMaPhieuDK.Location = new System.Drawing.Point(100, 47);
            this.txtMaPhieuDK.Name = "txtMaPhieuDK";
            this.txtMaPhieuDK.Size = new System.Drawing.Size(140, 20);
            this.txtMaPhieuDK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã phiếu ĐK:";
            // 
            // chkLePhi
            // 
            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Location = new System.Drawing.Point(20, 20);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(148, 17);
            this.chkLePhi.TabIndex = 4;
            this.chkLePhi.Text = "Đã đóng lệ phí hằng năm";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.Location = new System.Drawing.Point(350, 137);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(260, 55);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký - Cấp Hồ sơ ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Location = new System.Drawing.Point(12, 210);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Size = new System.Drawing.Size(967, 325);
            this.dgvBenhNhan.TabIndex = 0;
            // 
            // FrmTiepNhan
            // 
            this.ClientSize = new System.Drawing.Size(991, 547);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpHoSo);
            this.Controls.Add(this.grpBenhNhan);
            this.Name = "FrmTiepNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp Nhận & Đăng Ký";
            this.Load += new System.EventHandler(this.FrmTiepNhan_Load);
            this.grpBenhNhan.ResumeLayout(false);
            this.grpBenhNhan.PerformLayout();
            this.grpHoSo.ResumeLayout(false);
            this.grpHoSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpBenhNhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieuDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkLePhi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
    }
}