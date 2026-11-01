namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvKhachHang;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label() { Text = "Mã KH:", Location = new System.Drawing.Point(30, 30), Size = new System.Drawing.Size(80, 23) };
            this.txtMaKH.Location = new System.Drawing.Point(120, 27); this.txtMaKH.Size = new System.Drawing.Size(150, 22);

            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label() { Text = "Tên KH:", Location = new System.Drawing.Point(300, 30), Size = new System.Drawing.Size(60, 23) };
            this.txtTenKH.Location = new System.Drawing.Point(370, 27); this.txtTenKH.Size = new System.Drawing.Size(200, 22);

            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label() { Text = "Địa chỉ:", Location = new System.Drawing.Point(30, 70), Size = new System.Drawing.Size(80, 23) };
            this.txtDiaChi.Location = new System.Drawing.Point(120, 67); this.txtDiaChi.Size = new System.Drawing.Size(250, 22);

            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label() { Text = "Điện thoại:", Location = new System.Drawing.Point(400, 70), Size = new System.Drawing.Size(70, 23) };
            this.txtDienThoai.Location = new System.Drawing.Point(480, 67); this.txtDienThoai.Size = new System.Drawing.Size(120, 22);

            this.btnLuu.Location = new System.Drawing.Point(620, 25); this.btnLuu.Size = new System.Drawing.Size(120, 35); this.btnLuu.Text = "Lưu Khách Hàng"; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnDong.Location = new System.Drawing.Point(620, 70); this.btnDong.Size = new System.Drawing.Size(120, 35); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvKhachHang.Location = new System.Drawing.Point(30, 120); this.dgvKhachHang.Size = new System.Drawing.Size(710, 300); this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);

            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { l1, txtMaKH, l2, txtTenKH, l3, txtDiaChi, l4, txtDienThoai, btnLuu, btnDong, dgvKhachHang });
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
        }
    }
}