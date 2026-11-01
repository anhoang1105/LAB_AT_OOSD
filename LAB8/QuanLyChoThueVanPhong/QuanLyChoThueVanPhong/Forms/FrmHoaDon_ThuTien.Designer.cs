namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHoaDon_ThuTien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTienPhong;
        private System.Windows.Forms.TabPage tabTienDV;
        private System.Windows.Forms.DataGridView dgvTienPhong;
        private System.Windows.Forms.DataGridView dgvTienDV;
        private System.Windows.Forms.Button btnThuTienPhong;
        private System.Windows.Forms.Button btnThuTienDV;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTienPhong = new System.Windows.Forms.TabPage();
            this.tabTienDV = new System.Windows.Forms.TabPage();
            this.dgvTienPhong = new System.Windows.Forms.DataGridView();
            this.dgvTienDV = new System.Windows.Forms.DataGridView();
            this.btnThuTienPhong = new System.Windows.Forms.Button();
            this.btnThuTienDV = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTienPhong.SuspendLayout();
            this.tabTienDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDV)).BeginInit();
            this.SuspendLayout();

            this.tabControl1.Controls.Add(this.tabTienPhong);
            this.tabControl1.Controls.Add(this.tabTienDV);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Size = new System.Drawing.Size(760, 420);

            this.tabTienPhong.Controls.Add(this.dgvTienPhong);
            this.tabTienPhong.Controls.Add(this.btnThuTienPhong);
            this.tabTienPhong.Text = "Hóa Đơn Tiền Phòng";

            this.dgvTienPhong.Location = new System.Drawing.Point(15, 60);
            this.dgvTienPhong.Size = new System.Drawing.Size(720, 320);

            this.btnThuTienPhong.Location = new System.Drawing.Point(15, 15);
            this.btnThuTienPhong.Size = new System.Drawing.Size(150, 35);
            this.btnThuTienPhong.Text = "Thu Tiền Phòng (Chọn lưới)";
            this.btnThuTienPhong.Click += new System.EventHandler(this.btnThuTienPhong_Click);

            this.tabTienDV.Controls.Add(this.dgvTienDV);
            this.tabTienDV.Controls.Add(this.btnThuTienDV);
            this.tabTienDV.Text = "Hóa Đơn Dịch Vụ";

            this.dgvTienDV.Location = new System.Drawing.Point(15, 60);
            this.dgvTienDV.Size = new System.Drawing.Size(720, 320);

            this.btnThuTienDV.Location = new System.Drawing.Point(15, 15);
            this.btnThuTienDV.Size = new System.Drawing.Size(150, 35);
            this.btnThuTienDV.Text = "Thu Tiền DV (Chọn lưới)";
            this.btnThuTienDV.Click += new System.EventHandler(this.btnThuTienDV_Click);

            this.btnDong.Location = new System.Drawing.Point(670, 440);
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDong);
            this.Text = "Quản Lý Hóa Đơn & Thu Tiền";
            this.Load += new System.EventHandler(this.FrmHoaDon_ThuTien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTienPhong.ResumeLayout(false);
            this.tabTienDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDV)).EndInit();
            this.ResumeLayout(false);
        }
    }
}