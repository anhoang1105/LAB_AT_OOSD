namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmLuongThongKe
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.tabTK = new System.Windows.Forms.TabControl();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.numThang = new System.Windows.Forms.NumericUpDown(); this.numNam = new System.Windows.Forms.NumericUpDown(); this.btnLuong = new System.Windows.Forms.Button(); this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.tabTH = new System.Windows.Forms.TabPage();
            this.dtTu = new System.Windows.Forms.DateTimePicker(); this.dtDen = new System.Windows.Forms.DateTimePicker(); this.btnTongHop = new System.Windows.Forms.Button(); this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabTK.SuspendLayout(); this.tabLuong.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.tabTH.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit(); this.SuspendLayout();

            this.tabTK.Controls.Add(this.tabLuong); this.tabTK.Controls.Add(this.tabTH); this.tabTK.Location = new System.Drawing.Point(10, 10); this.tabTK.Size = new System.Drawing.Size(860, 400);

            // Tab Luong
            this.tabLuong.Text = "Lương hướng dẫn viên"; this.tabLuong.Controls.Add(this.numThang); this.tabLuong.Controls.Add(this.numNam); this.tabLuong.Controls.Add(this.btnLuong); this.tabLuong.Controls.Add(this.dgvLuong);
            this.numThang.Location = new System.Drawing.Point(20, 20); this.numThang.Size = new System.Drawing.Size(60, 22); this.numThang.Minimum = 1; this.numThang.Maximum = 12;
            this.numNam.Location = new System.Drawing.Point(90, 20); this.numNam.Size = new System.Drawing.Size(80, 22); this.numNam.Minimum = 2000; this.numNam.Maximum = 2100;
            this.btnLuong.Location = new System.Drawing.Point(190, 15); this.btnLuong.Size = new System.Drawing.Size(100, 30); this.btnLuong.Text = "Tính lương"; this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            this.dgvLuong.Location = new System.Drawing.Point(20, 60); this.dgvLuong.Size = new System.Drawing.Size(810, 290);

            // Tab Thong ke
            this.tabTH.Text = "Thống kê tổng hợp"; this.tabTH.Controls.Add(this.dtTu); this.tabTH.Controls.Add(this.dtDen); this.tabTH.Controls.Add(this.btnTongHop); this.tabTH.Controls.Add(this.dgvTongHop);
            this.dtTu.Location = new System.Drawing.Point(20, 20); this.dtTu.Size = new System.Drawing.Size(120, 22); this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(150, 20); this.dtDen.Size = new System.Drawing.Size(120, 22); this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnTongHop.Location = new System.Drawing.Point(280, 15); this.btnTongHop.Size = new System.Drawing.Size(100, 30); this.btnTongHop.Text = "Thống kê"; this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            this.dgvTongHop.Location = new System.Drawing.Point(20, 60); this.dgvTongHop.Size = new System.Drawing.Size(810, 290);

            this.btnDong.Location = new System.Drawing.Point(750, 420); this.btnDong.Size = new System.Drawing.Size(120, 35); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.ClientSize = new System.Drawing.Size(890, 470); this.Controls.Add(this.tabTK); this.Controls.Add(this.btnDong);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "Lương - Thống kê"; this.Load += new System.EventHandler(this.FrmLuongThongKe_Load);
            this.tabTK.ResumeLayout(false); this.tabLuong.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.tabTH.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.TabControl tabTK; private System.Windows.Forms.TabPage tabLuong; private System.Windows.Forms.NumericUpDown numThang; private System.Windows.Forms.NumericUpDown numNam; private System.Windows.Forms.Button btnLuong; private System.Windows.Forms.DataGridView dgvLuong; private System.Windows.Forms.TabPage tabTH; private System.Windows.Forms.DateTimePicker dtTu; private System.Windows.Forms.DateTimePicker dtDen; private System.Windows.Forms.Button btnTongHop; private System.Windows.Forms.DataGridView dgvTongHop; private System.Windows.Forms.Button btnDong;
    }
}