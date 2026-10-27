namespace QuanLyNhanSu.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLoai = new System.Windows.Forms.Label(); this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label(); this.txtThang = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label(); this.txtNam = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button(); this.btnThoat = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit(); this.SuspendLayout();

            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblLoai, this.cboLoai, this.lblThang, this.txtThang, this.lblNam, this.txtNam, this.btnXem, this.btnThoat });

            this.lblLoai.Location = new System.Drawing.Point(20, 20); this.lblLoai.Text = "Loại thống kê:"; this.lblLoai.AutoSize = true;
            this.cboLoai.Location = new System.Drawing.Point(110, 17); this.cboLoai.Width = 250; this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Items.AddRange(new object[] { "1. Thống kê số lượng nhân sự theo phòng ban", "2. Thống kê bảng lương theo tháng" });

            this.lblThang.Location = new System.Drawing.Point(380, 20); this.lblThang.Text = "Tháng:"; this.lblThang.AutoSize = true;
            this.txtThang.Location = new System.Drawing.Point(430, 17); this.txtThang.Width = 50;

            this.lblNam.Location = new System.Drawing.Point(500, 20); this.lblNam.Text = "Năm:"; this.lblNam.AutoSize = true;
            this.txtNam.Location = new System.Drawing.Point(540, 17); this.txtNam.Width = 50;

            this.btnXem.Location = new System.Drawing.Point(610, 15); this.btnXem.Text = "Xem Báo Cáo"; this.btnXem.Width = 100; this.btnXem.Height = 28;
            this.btnThoat.Location = new System.Drawing.Point(720, 15); this.btnThoat.Text = "Thoát"; this.btnThoat.Width = 80; this.btnThoat.Height = 28;

            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvData.AllowUserToAddRows = false; this.dgvData.ReadOnly = true; this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvData); this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F); this.Text = "Thống Kê & Báo Cáo"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlTop; private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblLoai, lblThang, lblNam;
        private System.Windows.Forms.TextBox txtThang, txtNam;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button btnXem, btnThoat;
    }
}