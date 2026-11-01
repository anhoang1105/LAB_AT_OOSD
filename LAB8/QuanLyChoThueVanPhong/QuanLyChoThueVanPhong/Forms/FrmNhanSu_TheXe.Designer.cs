namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmNhanSu_TheXe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridView dgvTheXe;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.dgvTheXe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).BeginInit();
            this.SuspendLayout();

            // Khu vực nhập Nhân Viên
            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label() { Text = "Mã NV:", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(60, 23) };
            this.txtMaNV.Location = new System.Drawing.Point(80, 17); this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label() { Text = "Phòng:", Location = new System.Drawing.Point(200, 20), Size = new System.Drawing.Size(60, 23) };
            this.cboPhong.Location = new System.Drawing.Point(260, 17); this.cboPhong.Size = new System.Drawing.Size(100, 24); this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label() { Text = "Họ tên:", Location = new System.Drawing.Point(380, 20), Size = new System.Drawing.Size(60, 23) };
            this.txtHoTen.Location = new System.Drawing.Point(440, 17); this.txtHoTen.Size = new System.Drawing.Size(150, 22);
            this.btnThemNV.Location = new System.Drawing.Point(610, 17); this.btnThemNV.Size = new System.Drawing.Size(150, 30); this.btnThemNV.Text = "Thêm Nhân Viên"; this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);

            this.dgvNV.Location = new System.Drawing.Point(20, 60); this.dgvNV.Size = new System.Drawing.Size(740, 150);

            // Khu vực Cấp Thẻ Xe
            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label() { Text = "Mã Thẻ:", Location = new System.Drawing.Point(20, 230), Size = new System.Drawing.Size(60, 23) };
            this.txtMaThe.Location = new System.Drawing.Point(80, 227); this.txtMaThe.Size = new System.Drawing.Size(100, 22);
            System.Windows.Forms.Label l5 = new System.Windows.Forms.Label() { Text = "Nhân viên:", Location = new System.Drawing.Point(200, 230), Size = new System.Drawing.Size(80, 23) };
            this.cboNhanVien.Location = new System.Drawing.Point(280, 227); this.cboNhanVien.Size = new System.Drawing.Size(150, 24); this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            System.Windows.Forms.Label l6 = new System.Windows.Forms.Label() { Text = "Biển số:", Location = new System.Drawing.Point(450, 230), Size = new System.Drawing.Size(60, 23) };
            this.txtBienSo.Location = new System.Drawing.Point(510, 227); this.txtBienSo.Size = new System.Drawing.Size(100, 22);
            this.btnCapThe.Location = new System.Drawing.Point(630, 227); this.btnCapThe.Size = new System.Drawing.Size(130, 30); this.btnCapThe.Text = "Cấp Thẻ Xe"; this.btnCapThe.Click += new System.EventHandler(this.btnCapThe_Click);

            this.dgvTheXe.Location = new System.Drawing.Point(20, 270); this.dgvTheXe.Size = new System.Drawing.Size(740, 150);

            this.btnDong.Location = new System.Drawing.Point(660, 430); this.btnDong.Size = new System.Drawing.Size(100, 30); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { l1, txtMaNV, l2, cboPhong, l3, txtHoTen, btnThemNV, dgvNV, l4, txtMaThe, l5, cboNhanVien, l6, txtBienSo, btnCapThe, dgvTheXe, btnDong });
            this.Text = "Quản Lý Nhân Sự & Thẻ Xe";
            this.Load += new System.EventHandler(this.FrmNhanSu_TheXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).EndInit();
            this.ResumeLayout(false);
        }
    }
}