namespace QuanLyThuVienLab2.Forms
{
    partial class FrmYeuCauDatMua
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenSach = new System.Windows.Forms.ComboBox();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThaiDuyet = new System.Windows.Forms.ComboBox();
            this.numNamXB = new System.Windows.Forms.NumericUpDown();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.txtMaYeuCau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Trạng thái duyệt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã";
            // 
            // cboTenSach
            // 
            this.cboTenSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTenSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTenSach.FormattingEnabled = true;
            this.cboTenSach.Location = new System.Drawing.Point(89, 116);
            this.cboTenSach.Name = "cboTenSach";
            this.cboTenSach.Size = new System.Drawing.Size(121, 21);
            this.cboTenSach.TabIndex = 30;
            // 
            // dgvYeuCau
            // 
            this.dgvYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeuCau.Location = new System.Drawing.Point(18, 168);
            this.dgvYeuCau.Name = "dgvYeuCau";
            this.dgvYeuCau.ReadOnly = true;
            this.dgvYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCau.Size = new System.Drawing.Size(960, 380);
            this.dgvYeuCau.TabIndex = 29;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(888, 11);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 25);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(772, 96);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 25);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm ";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(772, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 25);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(555, 96);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(90, 25);
            this.btnDuyet.TabIndex = 25;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(555, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Gửi yêu cầu";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cboTrangThaiDuyet
            // 
            this.cboTrangThaiDuyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiDuyet.FormattingEnabled = true;
            this.cboTrangThaiDuyet.Items.AddRange(new object[] {
            "Chờ duyệt",
            "Chấp nhận",
            "Từ chối"});
            this.cboTrangThaiDuyet.Location = new System.Drawing.Point(340, 116);
            this.cboTrangThaiDuyet.Name = "cboTrangThaiDuyet";
            this.cboTrangThaiDuyet.Size = new System.Drawing.Size(121, 21);
            this.cboTrangThaiDuyet.TabIndex = 23;
            // 
            // numNamXB
            // 
            this.numNamXB.Location = new System.Drawing.Point(340, 63);
            this.numNamXB.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numNamXB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNamXB.Name = "numNamXB";
            this.numNamXB.Size = new System.Drawing.Size(120, 20);
            this.numNamXB.TabIndex = 22;
            this.numNamXB.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(340, 12);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(100, 20);
            this.txtTacGia.TabIndex = 21;
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(89, 63);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(121, 21);
            this.cboDocGia.TabIndex = 20;
            // 
            // txtMaYeuCau
            // 
            this.txtMaYeuCau.Location = new System.Drawing.Point(89, 12);
            this.txtMaYeuCau.Name = "txtMaYeuCau";
            this.txtMaYeuCau.ReadOnly = true;
            this.txtMaYeuCau.Size = new System.Drawing.Size(100, 20);
            this.txtMaYeuCau.TabIndex = 19;
            // 
            // FrmYeuCauDatMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTenSach);
            this.Controls.Add(this.dgvYeuCau);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTrangThaiDuyet);
            this.Controls.Add(this.numNamXB);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.cboDocGia);
            this.Controls.Add(this.txtMaYeuCau);
            this.Name = "FrmYeuCauDatMua";
            this.Text = "FrmYeuCauDatMua";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenSach;
        private System.Windows.Forms.DataGridView dgvYeuCau;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTrangThaiDuyet;
        private System.Windows.Forms.NumericUpDown numNamXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.TextBox txtMaYeuCau;
    }
}