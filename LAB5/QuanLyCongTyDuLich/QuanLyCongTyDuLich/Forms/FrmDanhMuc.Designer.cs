namespace QuanLyCongTyDuLich.Forms
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
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabPT = new System.Windows.Forms.TabPage();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.txtPTGhiChu = new System.Windows.Forms.TextBox();
            this.txtPTTen = new System.Windows.Forms.TextBox();
            this.txtPTMa = new System.Windows.Forms.TextBox();
            this.dgvPT = new System.Windows.Forms.DataGridView();

            this.tabDB = new System.Windows.Forms.TabPage();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.txtDBDT = new System.Windows.Forms.TextBox();
            this.txtDBDiaChi = new System.Windows.Forms.TextBox();
            this.txtDBTen = new System.Windows.Forms.TextBox();
            this.txtDBMa = new System.Windows.Forms.TextBox();
            this.dgvDB = new System.Windows.Forms.DataGridView();

            this.tabHDV = new System.Windows.Forms.TabPage();
            this.btnThemHDV = new System.Windows.Forms.Button();
            this.numLuong = new System.Windows.Forms.NumericUpDown();
            this.txtHDVDT = new System.Windows.Forms.TextBox();
            this.txtHDVTen = new System.Windows.Forms.TextBox();
            this.txtHDVMa = new System.Windows.Forms.TextBox();
            this.dgvHDV = new System.Windows.Forms.DataGridView();

            this.tabDTQ = new System.Windows.Forms.TabPage();
            this.btnThemDTQ = new System.Windows.Forms.Button();
            this.txtDTQYNghia = new System.Windows.Forms.TextBox();
            this.txtDTQNoiDung = new System.Windows.Forms.TextBox();
            this.txtDTQDiaDiem = new System.Windows.Forms.TextBox();
            this.txtDTQTen = new System.Windows.Forms.TextBox();
            this.txtDTQMa = new System.Windows.Forms.TextBox();
            this.dgvDTQ = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabDanhMuc.SuspendLayout();
            this.tabPT.SuspendLayout();
            this.tabDB.SuspendLayout();
            this.tabHDV.SuspendLayout();
            this.tabDTQ.SuspendLayout();
            this.SuspendLayout();

            // tabDanhMuc
            this.tabDanhMuc.Controls.Add(this.tabPT);
            this.tabDanhMuc.Controls.Add(this.tabDB);
            this.tabDanhMuc.Controls.Add(this.tabHDV);
            this.tabDanhMuc.Controls.Add(this.tabDTQ);
            this.tabDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(960, 500);

            // tabPT (Phương tiện)
            this.tabPT.Controls.Add(this.btnThemPT);
            this.tabPT.Controls.Add(this.txtPTGhiChu);
            this.tabPT.Controls.Add(this.txtPTTen);
            this.tabPT.Controls.Add(this.txtPTMa);
            this.tabPT.Controls.Add(this.dgvPT);
            this.tabPT.Location = new System.Drawing.Point(4, 25);
            this.tabPT.Name = "tabPT";
            this.tabPT.Text = "Phương tiện";

            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.Location = new System.Drawing.Point(20, 20);
            this.dgvPT.Size = new System.Drawing.Size(910, 350);

            this.txtPTMa.Location = new System.Drawing.Point(20, 400);
            this.txtPTMa.Text = "Mã PT";
            this.txtPTTen.Location = new System.Drawing.Point(150, 400);
            this.txtPTTen.Text = "Tên PT";
            this.txtPTGhiChu.Location = new System.Drawing.Point(300, 400);
            this.txtPTGhiChu.Text = "Ghi chú";
            this.btnThemPT.Location = new System.Drawing.Point(500, 395);
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);

            // tabDB (Điểm bán vé)
            this.tabDB.Controls.Add(this.btnThemDB);
            this.tabDB.Controls.Add(this.txtDBDT);
            this.tabDB.Controls.Add(this.txtDBDiaChi);
            this.tabDB.Controls.Add(this.txtDBTen);
            this.tabDB.Controls.Add(this.txtDBMa);
            this.tabDB.Controls.Add(this.dgvDB);
            this.tabDB.Location = new System.Drawing.Point(4, 25);
            this.tabDB.Name = "tabDB";
            this.tabDB.Text = "Điểm bán vé";

            this.dgvDB.Location = new System.Drawing.Point(20, 20);
            this.dgvDB.Size = new System.Drawing.Size(910, 350);
            this.txtDBMa.Location = new System.Drawing.Point(20, 400);
            this.txtDBMa.Text = "Mã";
            this.txtDBTen.Location = new System.Drawing.Point(130, 400);
            this.txtDBTen.Text = "Tên";
            this.txtDBDiaChi.Location = new System.Drawing.Point(250, 400);
            this.txtDBDiaChi.Text = "Địa chỉ";
            this.txtDBDT.Location = new System.Drawing.Point(400, 400);
            this.txtDBDT.Text = "SĐT";
            this.btnThemDB.Location = new System.Drawing.Point(550, 395);
            this.btnThemDB.Text = "Thêm";
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);

            // tabHDV (Hướng dẫn viên)
            this.tabHDV.Controls.Add(this.btnThemHDV);
            this.tabHDV.Controls.Add(this.numLuong);
            this.tabHDV.Controls.Add(this.txtHDVDT);
            this.tabHDV.Controls.Add(this.txtHDVTen);
            this.tabHDV.Controls.Add(this.txtHDVMa);
            this.tabHDV.Controls.Add(this.dgvHDV);
            this.tabHDV.Location = new System.Drawing.Point(4, 25);
            this.tabHDV.Name = "tabHDV";
            this.tabHDV.Text = "Hướng dẫn viên";

            this.dgvHDV.Location = new System.Drawing.Point(20, 20);
            this.dgvHDV.Size = new System.Drawing.Size(910, 350);
            this.txtHDVMa.Location = new System.Drawing.Point(20, 400);
            this.txtHDVMa.Text = "Mã";
            this.txtHDVTen.Location = new System.Drawing.Point(130, 400);
            this.txtHDVTen.Text = "Tên";
            this.txtHDVDT.Location = new System.Drawing.Point(250, 400);
            this.txtHDVDT.Text = "SĐT";
            this.numLuong.Location = new System.Drawing.Point(400, 400);
            this.numLuong.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.btnThemHDV.Location = new System.Drawing.Point(550, 395);
            this.btnThemHDV.Text = "Thêm";
            this.btnThemHDV.Click += new System.EventHandler(this.btnThemHDV_Click);

            // tabDTQ (Điểm tham quan)
            this.tabDTQ.Controls.Add(this.btnThemDTQ);
            this.tabDTQ.Controls.Add(this.txtDTQYNghia);
            this.tabDTQ.Controls.Add(this.txtDTQNoiDung);
            this.tabDTQ.Controls.Add(this.txtDTQDiaDiem);
            this.tabDTQ.Controls.Add(this.txtDTQTen);
            this.tabDTQ.Controls.Add(this.txtDTQMa);
            this.tabDTQ.Controls.Add(this.dgvDTQ);
            this.tabDTQ.Location = new System.Drawing.Point(4, 25);
            this.tabDTQ.Name = "tabDTQ";
            this.tabDTQ.Text = "Điểm tham quan";

            this.dgvDTQ.Location = new System.Drawing.Point(20, 20);
            this.dgvDTQ.Size = new System.Drawing.Size(910, 350);
            this.txtDTQMa.Location = new System.Drawing.Point(20, 400);
            this.txtDTQMa.Text = "Mã";
            this.txtDTQTen.Location = new System.Drawing.Point(100, 400);
            this.txtDTQTen.Text = "Tên";
            this.txtDTQDiaDiem.Location = new System.Drawing.Point(200, 400);
            this.txtDTQDiaDiem.Text = "Địa điểm";
            this.txtDTQNoiDung.Location = new System.Drawing.Point(320, 400);
            this.txtDTQNoiDung.Text = "Nội dung";
            this.txtDTQYNghia.Location = new System.Drawing.Point(450, 400);
            this.txtDTQYNghia.Text = "Ý nghĩa";
            this.btnThemDTQ.Location = new System.Drawing.Point(600, 395);
            this.btnThemDTQ.Text = "Thêm";
            this.btnThemDTQ.Click += new System.EventHandler(this.btnThemDTQ_Click);

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(850, 525);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // FrmDanhMuc
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabDanhMuc);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);

            this.tabDanhMuc.ResumeLayout(false);
            this.tabPT.ResumeLayout(false);
            this.tabDB.ResumeLayout(false);
            this.tabHDV.ResumeLayout(false);
            this.tabDTQ.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabPT;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.TextBox txtPTMa;
        private System.Windows.Forms.TextBox txtPTTen;
        private System.Windows.Forms.TextBox txtPTGhiChu;
        private System.Windows.Forms.Button btnThemPT;

        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.TextBox txtDBMa;
        private System.Windows.Forms.TextBox txtDBTen;
        private System.Windows.Forms.TextBox txtDBDiaChi;
        private System.Windows.Forms.TextBox txtDBDT;
        private System.Windows.Forms.Button btnThemDB;

        private System.Windows.Forms.TabPage tabHDV;
        private System.Windows.Forms.DataGridView dgvHDV;
        private System.Windows.Forms.TextBox txtHDVMa;
        private System.Windows.Forms.TextBox txtHDVTen;
        private System.Windows.Forms.TextBox txtHDVDT;
        private System.Windows.Forms.NumericUpDown numLuong;
        private System.Windows.Forms.Button btnThemHDV;

        private System.Windows.Forms.TabPage tabDTQ;
        private System.Windows.Forms.DataGridView dgvDTQ;
        private System.Windows.Forms.TextBox txtDTQMa;
        private System.Windows.Forms.TextBox txtDTQTen;
        private System.Windows.Forms.TextBox txtDTQDiaDiem;
        private System.Windows.Forms.TextBox txtDTQNoiDung;
        private System.Windows.Forms.TextBox txtDTQYNghia;
        private System.Windows.Forms.Button btnThemDTQ;

        private System.Windows.Forms.Button btnDong;
    }
}
