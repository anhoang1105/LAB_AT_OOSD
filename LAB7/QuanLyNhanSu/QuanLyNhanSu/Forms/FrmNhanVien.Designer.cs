namespace QuanLyNhanSu.Forms
{
    partial class FrmNhanVien
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
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.txtDienThoai);
            this.pnlTop.Controls.Add(this.lblDienThoai);
            this.pnlTop.Controls.Add(this.txtDiaChi);
            this.pnlTop.Controls.Add(this.lblDiaChi);
            this.pnlTop.Controls.Add(this.dtpNgayVaoLam);
            this.pnlTop.Controls.Add(this.lblNgayVaoLam);
            this.pnlTop.Controls.Add(this.cboPhongBan);
            this.pnlTop.Controls.Add(this.lblPhongBan);
            this.pnlTop.Controls.Add(this.txtHoTen);
            this.pnlTop.Controls.Add(this.lblHoTen);
            this.pnlTop.Controls.Add(this.txtMaNV);
            this.pnlTop.Controls.Add(this.lblMaNV);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(900, 100);

            // Dòng 1
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(20, 20);
            this.lblMaNV.Text = "Mã NV:";
            this.txtMaNV.Location = new System.Drawing.Point(90, 17);
            this.txtMaNV.Size = new System.Drawing.Size(120, 23);

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(230, 20);
            this.lblHoTen.Text = "Họ tên:";
            this.txtHoTen.Location = new System.Drawing.Point(290, 17);
            this.txtHoTen.Size = new System.Drawing.Size(200, 23);

            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(520, 20);
            this.lblPhongBan.Text = "Phòng ban:";
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Location = new System.Drawing.Point(600, 17);
            this.cboPhongBan.Size = new System.Drawing.Size(180, 23);

            // Dòng 2
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(20, 60);
            this.lblNgayVaoLam.Text = "Ngày vào:";
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(90, 57);
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(120, 23);

            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(230, 60);
            this.lblDiaChi.Text = "Địa chỉ:";
            this.txtDiaChi.Location = new System.Drawing.Point(290, 57);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 23);

            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(520, 60);
            this.lblDienThoai.Text = "Điện thoại:";
            this.txtDienThoai.Location = new System.Drawing.Point(600, 57);
            this.txtDienThoai.Size = new System.Drawing.Size(180, 23);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Controls.Add(this.btnHuy);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 100);
            this.pnlButtons.Size = new System.Drawing.Size(900, 45);

            this.btnThem.Location = new System.Drawing.Point(20, 7);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";

            this.btnSua.Location = new System.Drawing.Point(110, 7);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Text = "Sửa";

            this.btnXoa.Location = new System.Drawing.Point(200, 7);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";

            this.btnLuu.Location = new System.Drawing.Point(290, 7);
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.Text = "Lưu";

            this.btnHuy.Location = new System.Drawing.Point(380, 7);
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.Text = "Hủy";

            this.btnThoat.Location = new System.Drawing.Point(800, 7);
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Text = "Thoát";

            // dgvNhanVien
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 145);
            this.dgvNhanVien.Size = new System.Drawing.Size(900, 405);
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmNhanVien
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hồ sơ Nhân viên";

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop, pnlButtons;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblMaNV, lblHoTen, lblPhongBan, lblNgayVaoLam, lblDiaChi, lblDienThoai;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtDiaChi, txtDienThoai;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}