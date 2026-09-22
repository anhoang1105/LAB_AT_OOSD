namespace QuanLyThuVienLab2.Forms
{
    partial class FrmMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.dtHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhanTra = new System.Windows.Forms.Button();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.dtNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.btnTaiSachDangMuon = new System.Windows.Forms.Button();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDong.Location = new System.Drawing.Point(979, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 28);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMuon);
            this.tabControl1.Controls.Add(this.tabTra);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 587);
            this.tabControl1.TabIndex = 7;
            // 
            // tabMuon
            // 
            this.tabMuon.Controls.Add(this.label5);
            this.tabMuon.Controls.Add(this.label4);
            this.tabMuon.Controls.Add(this.label3);
            this.tabMuon.Controls.Add(this.label2);
            this.tabMuon.Controls.Add(this.btnLapPhieu);
            this.tabMuon.Controls.Add(this.dgvSachChon);
            this.tabMuon.Controls.Add(this.btnBoSach);
            this.tabMuon.Controls.Add(this.btnChonSach);
            this.tabMuon.Controls.Add(this.dgvSachCon);
            this.tabMuon.Controls.Add(this.dtHanSuDung);
            this.tabMuon.Controls.Add(this.dtNgayMuon);
            this.tabMuon.Controls.Add(this.cboNhanVien);
            this.tabMuon.Controls.Add(this.cboDocGia);
            this.tabMuon.Location = new System.Drawing.Point(4, 22);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1051, 561);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(228, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hạn Sử Dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(235, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Độc Giả";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLapPhieu.Location = new System.Drawing.Point(870, 72);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(119, 26);
            this.btnLapPhieu.TabIndex = 8;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Location = new System.Drawing.Point(526, 157);
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.Size = new System.Drawing.Size(519, 397);
            this.dgvSachChon.TabIndex = 7;
            // 
            // btnBoSach
            // 
            this.btnBoSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBoSach.Location = new System.Drawing.Point(647, 71);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(105, 27);
            this.btnBoSach.TabIndex = 6;
            this.btnBoSach.Text = "<< Bỏ chọn";
            this.btnBoSach.UseVisualStyleBackColor = true;
            // 
            // btnChonSach
            // 
            this.btnChonSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnChonSach.Location = new System.Drawing.Point(647, 17);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(105, 28);
            this.btnChonSach.TabIndex = 5;
            this.btnChonSach.Text = ">> Chọn sách";
            this.btnChonSach.UseVisualStyleBackColor = true;
            // 
            // dgvSachCon
            // 
            this.dgvSachCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachCon.Location = new System.Drawing.Point(6, 157);
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.Size = new System.Drawing.Size(513, 397);
            this.dgvSachCon.TabIndex = 4;
            // 
            // dtHanSuDung
            // 
            this.dtHanSuDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHanSuDung.Location = new System.Drawing.Point(319, 71);
            this.dtHanSuDung.Name = "dtHanSuDung";
            this.dtHanSuDung.Size = new System.Drawing.Size(200, 25);
            this.dtHanSuDung.TabIndex = 3;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(319, 20);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(200, 25);
            this.dtNgayMuon.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(88, 73);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(121, 25);
            this.cboNhanVien.TabIndex = 1;
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(88, 19);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(121, 25);
            this.cboDocGia.TabIndex = 0;
            // 
            // tabTra
            // 
            this.tabTra.Controls.Add(this.label7);
            this.tabTra.Controls.Add(this.label6);
            this.tabTra.Controls.Add(this.label1);
            this.tabTra.Controls.Add(this.btnXacNhanTra);
            this.tabTra.Controls.Add(this.txtTienPhat);
            this.tabTra.Controls.Add(this.dtNgayTraThucTe);
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.btnTaiSachDangMuon);
            this.tabTra.Controls.Add(this.cboDocGiaTra);
            this.tabTra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabTra.Location = new System.Drawing.Point(4, 22);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1051, 561);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách";
            this.tabTra.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tiền Phạt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Trả Thực Tế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Độc Giả";
            // 
            // btnXacNhanTra
            // 
            this.btnXacNhanTra.Location = new System.Drawing.Point(742, 47);
            this.btnXacNhanTra.Name = "btnXacNhanTra";
            this.btnXacNhanTra.Size = new System.Drawing.Size(204, 23);
            this.btnXacNhanTra.TabIndex = 5;
            this.btnXacNhanTra.Text = "Xác nhận trả sách - Tính tiền phạt";
            this.btnXacNhanTra.UseVisualStyleBackColor = true;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(473, 68);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(100, 25);
            this.txtTienPhat.TabIndex = 4;
            // 
            // dtNgayTraThucTe
            // 
            this.dtNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTraThucTe.Location = new System.Drawing.Point(473, 23);
            this.dtNgayTraThucTe.Name = "dtNgayTraThucTe";
            this.dtNgayTraThucTe.Size = new System.Drawing.Size(200, 25);
            this.dtNgayTraThucTe.TabIndex = 3;
            // 
            // dgvDangMuon
            // 
            this.dgvDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangMuon.Location = new System.Drawing.Point(6, 128);
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.Size = new System.Drawing.Size(1039, 426);
            this.dgvDangMuon.TabIndex = 2;
            // 
            // btnTaiSachDangMuon
            // 
            this.btnTaiSachDangMuon.Location = new System.Drawing.Point(112, 66);
            this.btnTaiSachDangMuon.Name = "btnTaiSachDangMuon";
            this.btnTaiSachDangMuon.Size = new System.Drawing.Size(145, 23);
            this.btnTaiSachDangMuon.TabIndex = 1;
            this.btnTaiSachDangMuon.Text = "Tải danh sách mượn";
            this.btnTaiSachDangMuon.UseVisualStyleBackColor = true;
            // 
            // cboDocGiaTra
            // 
            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(112, 22);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(121, 25);
            this.cboDocGiaTra.TabIndex = 0;
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 617);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMuonTra";
            this.Text = "FrmMuonTra";
            this.tabControl1.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            this.tabTra.ResumeLayout(false);
            this.tabTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.DateTimePicker dtHanSuDung;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanTra;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.DateTimePicker dtNgayTraThucTe;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.Button btnTaiSachDangMuon;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
    }
}