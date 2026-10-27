namespace QuanLyNhanSu.Forms
{
    partial class FrmHopDong
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
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.txtThoiHan);
            this.pnlTop.Controls.Add(this.lblThoiHan);
            this.pnlTop.Controls.Add(this.cboTrangThai);
            this.pnlTop.Controls.Add(this.lblTrangThai);
            this.pnlTop.Controls.Add(this.dtpNgayKy);
            this.pnlTop.Controls.Add(this.lblNgayKy);
            this.pnlTop.Controls.Add(this.cboLoaiHD);
            this.pnlTop.Controls.Add(this.lblLoaiHD);
            this.pnlTop.Controls.Add(this.cboNhanVien);
            this.pnlTop.Controls.Add(this.lblNhanVien);
            this.pnlTop.Controls.Add(this.txtSoHD);
            this.pnlTop.Controls.Add(this.lblSoHD);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(900, 100);

            // Dòng 1
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(20, 20);
            this.lblSoHD.Text = "Số HĐ:";
            this.txtSoHD.Location = new System.Drawing.Point(90, 17);
            this.txtSoHD.Size = new System.Drawing.Size(120, 23);

            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(230, 20);
            this.lblNhanVien.Text = "Nhân viên:";
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(310, 17);
            this.cboNhanVien.Size = new System.Drawing.Size(200, 23);

            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Location = new System.Drawing.Point(540, 20);
            this.lblLoaiHD.Text = "Loại HĐ:";
            this.cboLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHD.Items.AddRange(new object[] { "Dài hạn", "Ngắn hạn", "Thử việc" });
            this.cboLoaiHD.Location = new System.Drawing.Point(620, 17);
            this.cboLoaiHD.Size = new System.Drawing.Size(150, 23);

            // Dòng 2
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Location = new System.Drawing.Point(20, 60);
            this.lblNgayKy.Text = "Ngày ký:";
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKy.Location = new System.Drawing.Point(90, 57);
            this.dtpNgayKy.Size = new System.Drawing.Size(120, 23);

            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(230, 60);
            this.lblTrangThai.Text = "Trạng thái:";
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] { "Đang hiệu lực", "Đã hết hạn", "Đã hủy" });
            this.cboTrangThai.Location = new System.Drawing.Point(310, 57);
            this.cboTrangThai.Size = new System.Drawing.Size(200, 23);

            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Location = new System.Drawing.Point(540, 60);
            this.lblThoiHan.Text = "Thời hạn (Tháng):";
            this.txtThoiHan.Location = new System.Drawing.Point(660, 57);
            this.txtThoiHan.Size = new System.Drawing.Size(110, 23);

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

            // dgvHopDong
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(0, 145);
            this.dgvHopDong.Size = new System.Drawing.Size(900, 405);
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmHopDong
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvHopDong);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hợp đồng";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop, pnlButtons;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Label lblSoHD, lblNhanVien, lblLoaiHD, lblNgayKy, lblTrangThai, lblThoiHan;
        private System.Windows.Forms.TextBox txtSoHD, txtThoiHan;
        private System.Windows.Forms.ComboBox cboNhanVien, cboLoaiHD, cboTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}