namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhieuKham = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn phiếu khám chưa TT:";
            // 
            // cboPhieuKham
            // 
            this.cboPhieuKham.FormattingEnabled = true;
            this.cboPhieuKham.Location = new System.Drawing.Point(170, 20);
            this.cboPhieuKham.Name = "cboPhieuKham";
            this.cboPhieuKham.Size = new System.Drawing.Size(250, 21);
            this.cboPhieuKham.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Location = new System.Drawing.Point(440, 15);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 40);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "THANH TOÁN & XUẤT VIỆN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Location = new System.Drawing.Point(20, 70);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.Size = new System.Drawing.Size(550, 200);
            this.dgvChiPhi.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 290);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(291, 21);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng viện phí cần thanh toán: 0 VNĐ";
            // 
            // FrmThanhToan
            // 
            this.ClientSize = new System.Drawing.Size(590, 341);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvChiPhi);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cboPhieuKham);
            this.Controls.Add(this.label1);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Viện Phí & Xuất Viện";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhieuKham;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvChiPhi;
        private System.Windows.Forms.Label lblTongTien;
    }
}