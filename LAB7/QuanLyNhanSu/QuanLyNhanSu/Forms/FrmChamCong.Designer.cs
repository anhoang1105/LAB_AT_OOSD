namespace QuanLyNhanSu.Forms
{
    partial class FrmChamCong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMa = new System.Windows.Forms.Label(); this.txtMa = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label(); this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label(); this.txtThang = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label(); this.txtNam = new System.Windows.Forms.TextBox();
            this.lblGio = new System.Windows.Forms.Label(); this.txtGio = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button(); this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button(); this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button(); this.btnThoat = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout(); this.pnlButtons.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit(); this.SuspendLayout();

            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblMa, this.txtMa, this.lblNV, this.cboNV, this.lblThang, this.txtThang, this.lblNam, this.txtNam, this.lblGio, this.txtGio });

            this.lblMa.Location = new System.Drawing.Point(20, 20); this.lblMa.Text = "Mã BCC:"; this.lblMa.AutoSize = true;
            this.txtMa.Location = new System.Drawing.Point(80, 17); this.txtMa.Width = 100;

            this.lblNV.Location = new System.Drawing.Point(200, 20); this.lblNV.Text = "Nhân viên:"; this.lblNV.AutoSize = true;
            this.cboNV.Location = new System.Drawing.Point(270, 17); this.cboNV.Width = 180; this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblThang.Location = new System.Drawing.Point(470, 20); this.lblThang.Text = "Tháng:"; this.lblThang.AutoSize = true;
            this.txtThang.Location = new System.Drawing.Point(520, 17); this.txtThang.Width = 50;

            this.lblNam.Location = new System.Drawing.Point(590, 20); this.lblNam.Text = "Năm:"; this.lblNam.AutoSize = true;
            this.txtNam.Location = new System.Drawing.Point(630, 17); this.txtNam.Width = 50;

            this.lblGio.Location = new System.Drawing.Point(700, 20); this.lblGio.Text = "Tổng giờ:"; this.lblGio.AutoSize = true;
            this.txtGio.Location = new System.Drawing.Point(770, 17); this.txtGio.Width = 80;

            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top; this.pnlButtons.Height = 45;
            this.pnlButtons.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnThem, this.btnSua, this.btnXoa, this.btnLuu, this.btnHuy, this.btnThoat });

            this.btnThem.Location = new System.Drawing.Point(20, 7); this.btnThem.Text = "Thêm"; this.btnThem.Width = 80;
            this.btnSua.Location = new System.Drawing.Point(110, 7); this.btnSua.Text = "Sửa"; this.btnSua.Width = 80;
            this.btnXoa.Location = new System.Drawing.Point(200, 7); this.btnXoa.Text = "Xóa"; this.btnXoa.Width = 80;
            this.btnLuu.Location = new System.Drawing.Point(290, 7); this.btnLuu.Text = "Lưu"; this.btnLuu.Width = 80;
            this.btnHuy.Location = new System.Drawing.Point(380, 7); this.btnHuy.Text = "Hủy"; this.btnHuy.Width = 80;
            this.btnThoat.Location = new System.Drawing.Point(800, 7); this.btnThoat.Text = "Thoát"; this.btnThoat.Width = 80;

            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvData.AllowUserToAddRows = false; this.dgvData.ReadOnly = true; this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvData); this.Controls.Add(this.pnlButtons); this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F); this.Text = "Bảng Chấm Công"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout(); this.pnlButtons.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlTop, pnlButtons; private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblMa, lblNV, lblThang, lblNam, lblGio;
        private System.Windows.Forms.TextBox txtMa, txtThang, txtNam, txtGio;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}