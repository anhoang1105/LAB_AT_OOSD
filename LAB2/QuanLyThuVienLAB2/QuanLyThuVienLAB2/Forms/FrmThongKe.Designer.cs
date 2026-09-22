namespace QuanLyThuVienLab2.Forms
{
    partial class FrmThongKe
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
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.lblTienPhat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDangMuon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongDocGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(878, -5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 25);
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(8, 104);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(960, 478);
            this.dgvBaoCao.TabIndex = 24;
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Items.AddRange(new object[] {
            "Danh sách sách đang mượn",
            "Danh sách sách mượn quá hạn",
            "Top sách được mượn nhiều nhất"});
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(648, 60);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(236, 21);
            this.cboLoaiBaoCao.TabIndex = 23;
            // 
            // lblTienPhat
            // 
            this.lblTienPhat.AutoSize = true;
            this.lblTienPhat.Location = new System.Drawing.Point(788, 9);
            this.lblTienPhat.Name = "lblTienPhat";
            this.lblTienPhat.Size = new System.Drawing.Size(13, 13);
            this.lblTienPhat.TabIndex = 22;
            this.lblTienPhat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(645, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tổng tiền phạt đã thu:";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Location = new System.Drawing.Point(495, 60);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(13, 13);
            this.lblQuaHan.TabIndex = 20;
            this.lblQuaHan.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sách đang quá hạn:";
            // 
            // lblDangMuon
            // 
            this.lblDangMuon.AutoSize = true;
            this.lblDangMuon.Location = new System.Drawing.Point(495, 9);
            this.lblDangMuon.Name = "lblDangMuon";
            this.lblDangMuon.Size = new System.Drawing.Size(13, 13);
            this.lblDangMuon.TabIndex = 18;
            this.lblDangMuon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phiếu đang mượn:";
            // 
            // lblTongDocGia
            // 
            this.lblTongDocGia.AutoSize = true;
            this.lblTongDocGia.Location = new System.Drawing.Point(163, 60);
            this.lblTongDocGia.Name = "lblTongDocGia";
            this.lblTongDocGia.Size = new System.Drawing.Size(13, 13);
            this.lblTongDocGia.TabIndex = 16;
            this.lblTongDocGia.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng số Độc giả:";
            // 
            // lblTongSach
            // 
            this.lblTongSach.AutoSize = true;
            this.lblTongSach.Location = new System.Drawing.Point(163, 9);
            this.lblTongSach.Name = "lblTongSach";
            this.lblTongSach.Size = new System.Drawing.Size(13, 13);
            this.lblTongSach.TabIndex = 14;
            this.lblTongSach.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng sách trong kho:";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 599);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.cboLoaiBaoCao);
            this.Controls.Add(this.lblTienPhat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblQuaHan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDangMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTongSach);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongKe";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDangMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongSach;
        private System.Windows.Forms.Label label1;
    }
}