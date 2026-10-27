namespace QuanLyNhanSu.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.txtTenPB);
            this.pnlTop.Controls.Add(this.lblTenPB);
            this.pnlTop.Controls.Add(this.txtMaPB);
            this.pnlTop.Controls.Add(this.lblMaPB);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(600, 60);

            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(20, 20);
            this.lblMaPB.Text = "Mã phòng ban:";
            this.txtMaPB.Location = new System.Drawing.Point(120, 17);
            this.txtMaPB.Size = new System.Drawing.Size(120, 23);

            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(280, 20);
            this.lblTenPB.Text = "Tên phòng ban:";
            this.txtTenPB.Location = new System.Drawing.Point(380, 17);
            this.txtTenPB.Size = new System.Drawing.Size(180, 23);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Controls.Add(this.btnHuy);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 60);
            this.pnlButtons.Size = new System.Drawing.Size(600, 45);

            this.btnThem.Location = new System.Drawing.Point(20, 7);
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.Text = "Thêm";

            this.btnSua.Location = new System.Drawing.Point(100, 7);
            this.btnSua.Size = new System.Drawing.Size(70, 30);
            this.btnSua.Text = "Sửa";

            this.btnXoa.Location = new System.Drawing.Point(180, 7);
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.Text = "Xóa";

            this.btnLuu.Location = new System.Drawing.Point(260, 7);
            this.btnLuu.Size = new System.Drawing.Size(70, 30);
            this.btnLuu.Text = "Lưu";

            this.btnHuy.Location = new System.Drawing.Point(340, 7);
            this.btnHuy.Size = new System.Drawing.Size(70, 30);
            this.btnHuy.Text = "Hủy";

            this.btnThoat.Location = new System.Drawing.Point(510, 7);
            this.btnThoat.Size = new System.Drawing.Size(70, 30);
            this.btnThoat.Text = "Thoát";

            // dgvPhongBan
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.Location = new System.Drawing.Point(0, 105);
            this.dgvPhongBan.Size = new System.Drawing.Size(600, 345);
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmDanhMuc
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng Ban";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop, pnlButtons;
        private System.Windows.Forms.Label lblMaPB, lblTenPB;
        private System.Windows.Forms.TextBox txtMaPB, txtTenPB;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
        private System.Windows.Forms.DataGridView dgvPhongBan;
    }
}