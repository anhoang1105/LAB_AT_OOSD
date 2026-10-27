namespace QuanLyNhanSu.Forms
{
    partial class FrmKhenThuong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSo = new System.Windows.Forms.Label(); this.txtSo = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label(); this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label(); this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblTien = new System.Windows.Forms.Label(); this.txtTien = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label(); this.dtpNgay = new System.Windows.Forms.DateTimePicker();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button(); this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button(); this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button(); this.btnThoat = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout(); this.pnlButtons.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit(); this.SuspendLayout();

            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 100;
            this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblSo, this.txtSo, this.lblNV, this.cboNV, this.lblLoai, this.cboLoai, this.lblTien, this.txtTien, this.lblNgay, this.dtpNgay });

            this.lblSo.Location = new System.Drawing.Point(20, 20); this.lblSo.Text = "Số QĐ:"; this.lblSo.AutoSize = true;
            this.txtSo.Location = new System.Drawing.Point(80, 17); this.txtSo.Width = 120;

            this.lblNV.Location = new System.Drawing.Point(230, 20); this.lblNV.Text = "Nhân viên:"; this.lblNV.AutoSize = true;
            this.cboNV.Location = new System.Drawing.Point(300, 17); this.cboNV.Width = 180; this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblLoai.Location = new System.Drawing.Point(520, 20); this.lblLoai.Text = "Loại QĐ:"; this.lblLoai.AutoSize = true;
            this.cboLoai.Location = new System.Drawing.Point(580, 17); this.cboLoai.Width = 150; this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboLoai.Items.AddRange(new object[] { "Khen thưởng", "Kỷ luật" });

            this.lblTien.Location = new System.Drawing.Point(20, 60); this.lblTien.Text = "Số tiền:"; this.lblTien.AutoSize = true;
            this.txtTien.Location = new System.Drawing.Point(80, 57); this.txtTien.Width = 120;

            this.lblNgay.Location = new System.Drawing.Point(230, 60); this.lblNgay.Text = "Ngày ký:"; this.lblNgay.AutoSize = true;
            this.dtpNgay.Location = new System.Drawing.Point(300, 57); this.dtpNgay.Width = 180; this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;

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
            this.Font = new System.Drawing.Font("Segoe UI", 9F); this.Text = "Quyết Định Khen Thưởng - Kỷ Luật"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlTop.ResumeLayout(false); this.pnlTop.PerformLayout(); this.pnlButtons.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlTop, pnlButtons; private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblSo, lblNV, lblLoai, lblTien, lblNgay;
        private System.Windows.Forms.TextBox txtSo, txtTien;
        private System.Windows.Forms.ComboBox cboNV, cboLoai; private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}