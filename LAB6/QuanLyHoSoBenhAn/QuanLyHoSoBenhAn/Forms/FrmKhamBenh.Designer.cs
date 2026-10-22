namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmKhamBenh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.lblLyLich = new System.Windows.Forms.Label();
            this.tabKhamBenh = new System.Windows.Forms.TabControl();
            this.tabPageKham = new System.Windows.Forms.TabPage();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageToaThuoc = new System.Windows.Forms.TabPage();
            this.btnLuuToa = new System.Windows.Forms.Button();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChiTietThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabKhamBenh.SuspendLayout();
            this.tabPageKham.SuspendLayout();
            this.tabPageToaThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Hồ sơ BN:";
            // 
            // cboHoSo
            // 
            this.cboHoSo.FormattingEnabled = true;
            this.cboHoSo.Location = new System.Drawing.Point(120, 17);
            this.cboHoSo.Name = "cboHoSo";
            this.cboHoSo.Size = new System.Drawing.Size(200, 21);
            this.cboHoSo.TabIndex = 2;
            // 
            // lblLyLich
            // 
            this.lblLyLich.AutoSize = true;
            this.lblLyLich.ForeColor = System.Drawing.Color.Red;
            this.lblLyLich.Location = new System.Drawing.Point(340, 20);
            this.lblLyLich.Name = "lblLyLich";
            this.lblLyLich.Size = new System.Drawing.Size(173, 13);
            this.lblLyLich.TabIndex = 1;
            this.lblLyLich.Text = "[Thông tin lý lịch sẽ hiển thị tại đây]";
            // 
            // tabKhamBenh
            // 
            this.tabKhamBenh.Controls.Add(this.tabPageKham);
            this.tabKhamBenh.Controls.Add(this.tabPageToaThuoc);
            this.tabKhamBenh.Location = new System.Drawing.Point(12, 60);
            this.tabKhamBenh.Name = "tabKhamBenh";
            this.tabKhamBenh.SelectedIndex = 0;
            this.tabKhamBenh.Size = new System.Drawing.Size(885, 460);
            this.tabKhamBenh.TabIndex = 0;
            // 
            // tabPageKham
            // 
            this.tabPageKham.Controls.Add(this.btnLuuPhieu);
            this.tabPageKham.Controls.Add(this.txtTrieuChung);
            this.tabPageKham.Controls.Add(this.label5);
            this.tabPageKham.Controls.Add(this.cboKhoa);
            this.tabPageKham.Controls.Add(this.label4);
            this.tabPageKham.Controls.Add(this.cboBacSi);
            this.tabPageKham.Controls.Add(this.label3);
            this.tabPageKham.Controls.Add(this.txtMaPhieuKham);
            this.tabPageKham.Controls.Add(this.label2);
            this.tabPageKham.Location = new System.Drawing.Point(4, 22);
            this.tabPageKham.Name = "tabPageKham";
            this.tabPageKham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKham.Size = new System.Drawing.Size(877, 434);
            this.tabPageKham.TabIndex = 0;
            this.tabPageKham.Text = "Khám Lâm Sàng";
            this.tabPageKham.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Location = new System.Drawing.Point(651, 31);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(150, 40);
            this.btnLuuPhieu.TabIndex = 0;
            this.btnLuuPhieu.Text = "Lưu Phiếu Khám";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(100, 110);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(763, 306);
            this.txtTrieuChung.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Triệu chứng:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(100, 80);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(200, 21);
            this.cboKhoa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khoa ĐT:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(100, 50);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(200, 21);
            this.cboBacSi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bác sĩ:";
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Location = new System.Drawing.Point(100, 20);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhieuKham.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Phiếu:";
            // 
            // tabPageToaThuoc
            // 
            this.tabPageToaThuoc.Controls.Add(this.btnLuuToa);
            this.tabPageToaThuoc.Controls.Add(this.txtCachDung);
            this.tabPageToaThuoc.Controls.Add(this.label8);
            this.tabPageToaThuoc.Controls.Add(this.txtChiTietThuoc);
            this.tabPageToaThuoc.Controls.Add(this.label7);
            this.tabPageToaThuoc.Controls.Add(this.txtMaToa);
            this.tabPageToaThuoc.Controls.Add(this.label6);
            this.tabPageToaThuoc.Location = new System.Drawing.Point(4, 22);
            this.tabPageToaThuoc.Name = "tabPageToaThuoc";
            this.tabPageToaThuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageToaThuoc.Size = new System.Drawing.Size(877, 434);
            this.tabPageToaThuoc.TabIndex = 1;
            this.tabPageToaThuoc.Text = "Kê Toa Thuốc";
            this.tabPageToaThuoc.UseVisualStyleBackColor = true;
            // 
            // btnLuuToa
            // 
            this.btnLuuToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLuuToa.Location = new System.Drawing.Point(648, 20);
            this.btnLuuToa.Name = "btnLuuToa";
            this.btnLuuToa.Size = new System.Drawing.Size(170, 50);
            this.btnLuuToa.TabIndex = 0;
            this.btnLuuToa.Text = "LƯU TOA THUỐC";
            this.btnLuuToa.UseCompatibleTextRendering = true;
            this.btnLuuToa.UseVisualStyleBackColor = true;
            this.btnLuuToa.Click += new System.EventHandler(this.btnLuuToa_Click);
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(100, 220);
            this.txtCachDung.Multiline = true;
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(530, 120);
            this.txtCachDung.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cách dùng:";
            // 
            // txtChiTietThuoc
            // 
            this.txtChiTietThuoc.Location = new System.Drawing.Point(100, 50);
            this.txtChiTietThuoc.Multiline = true;
            this.txtChiTietThuoc.Name = "txtChiTietThuoc";
            this.txtChiTietThuoc.Size = new System.Drawing.Size(530, 150);
            this.txtChiTietThuoc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chi tiết thuốc:";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(100, 20);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(200, 20);
            this.txtMaToa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã Toa:";
            // 
            // FrmKhamBenh
            // 
            this.ClientSize = new System.Drawing.Size(909, 532);
            this.Controls.Add(this.tabKhamBenh);
            this.Controls.Add(this.lblLyLich);
            this.Controls.Add(this.cboHoSo);
            this.Controls.Add(this.label1);
            this.Name = "FrmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám Bệnh & Kê Toa Thuốc";
            this.Load += new System.EventHandler(this.FrmKhamBenh_Load);
            this.tabKhamBenh.ResumeLayout(false);
            this.tabPageKham.ResumeLayout(false);
            this.tabPageKham.PerformLayout();
            this.tabPageToaThuoc.ResumeLayout(false);
            this.tabPageToaThuoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHoSo;
        private System.Windows.Forms.Label lblLyLich;
        private System.Windows.Forms.TabControl tabKhamBenh;
        private System.Windows.Forms.TabPage tabPageKham;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageToaThuoc;
        private System.Windows.Forms.Button btnLuuToa;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChiTietThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label label6;
    }
}