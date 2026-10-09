namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmTour
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblChonTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.tabTour = new System.Windows.Forms.TabControl();

            // Tab 1: Tour
            this.pageTour = new System.Windows.Forms.TabPage();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.numNgay = new System.Windows.Forms.NumericUpDown();
            this.numDem = new System.Windows.Forms.NumericUpDown();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThemTour = new System.Windows.Forms.Button();

            // Tab 2: Điểm dừng
            this.pageDiemDung = new System.Windows.Forms.TabPage();
            this.dgvDiemDung = new System.Windows.Forms.DataGridView();
            this.numThuTu = new System.Windows.Forms.NumericUpDown();
            this.txtDiemDung = new System.Windows.Forms.TextBox();
            this.chkDoiPT = new System.Windows.Forms.CheckBox();
            this.chkAn = new System.Windows.Forms.CheckBox();
            this.chkKS = new System.Windows.Forms.CheckBox();
            this.numSao = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChuDD = new System.Windows.Forms.TextBox();
            this.btnThemDD = new System.Windows.Forms.Button();

            // Tab 3: Phương tiện
            this.pageChang = new System.Windows.Forms.TabPage();
            this.dgvChang = new System.Windows.Forms.DataGridView();
            this.numChang = new System.Windows.Forms.NumericUpDown();
            this.cboPT = new System.Windows.Forms.ComboBox();
            this.txtGhiChuPT = new System.Windows.Forms.TextBox();
            this.btnThemChang = new System.Windows.Forms.Button();

            // Tab 4: Điểm TQ
            this.pageDTQ = new System.Windows.Forms.TabPage();
            this.dgvTQ = new System.Windows.Forms.DataGridView();
            this.cboDTQ = new System.Windows.Forms.ComboBox();
            this.numThuTuTQ = new System.Windows.Forms.NumericUpDown();
            this.btnThemTQ = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabTour.SuspendLayout();
            this.pageTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            this.pageDiemDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).BeginInit();
            this.pageChang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChang)).BeginInit();
            this.pageDTQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTuTQ)).BeginInit();
            this.SuspendLayout();

            // Top Header
            this.lblChonTour.AutoSize = true;
            this.lblChonTour.Location = new System.Drawing.Point(20, 25);
            this.lblChonTour.Name = "lblChonTour";
            this.lblChonTour.Text = "Tour đang chọn (cho các tab hành trình):";
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(280, 22);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(400, 24);
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.cboTour_SelectedIndexChanged);

            // TabControl
            this.tabTour.Controls.Add(this.pageTour);
            this.tabTour.Controls.Add(this.pageDiemDung);
            this.tabTour.Controls.Add(this.pageChang);
            this.tabTour.Controls.Add(this.pageDTQ);
            this.tabTour.Location = new System.Drawing.Point(20, 70);
            this.tabTour.Name = "tabTour";
            this.tabTour.SelectedIndex = 0;
            this.tabTour.Size = new System.Drawing.Size(1000, 500);

            // --- PAGE 1: TOUR ---
            this.pageTour.Text = "Tour";
            this.pageTour.Controls.Add(this.dgvTour);
            this.pageTour.Controls.Add(this.txtMa);
            this.pageTour.Controls.Add(this.txtTen);
            this.pageTour.Controls.Add(this.numNgay);
            this.pageTour.Controls.Add(this.numDem);
            this.pageTour.Controls.Add(this.numGia);
            this.pageTour.Controls.Add(this.txtMoTa);
            this.pageTour.Controls.Add(this.btnThemTour);

            this.dgvTour.Location = new System.Drawing.Point(15, 15);
            this.dgvTour.Size = new System.Drawing.Size(960, 350);

            this.txtMa.Location = new System.Drawing.Point(15, 390);
            this.txtMa.Text = "Mã tour";
            this.txtTen.Location = new System.Drawing.Point(135, 390);
            this.txtTen.Size = new System.Drawing.Size(250, 22);
            this.txtTen.Text = "Tên tour";

            this.numNgay.Location = new System.Drawing.Point(400, 390);
            this.numNgay.Size = new System.Drawing.Size(60, 22);
            this.numDem.Location = new System.Drawing.Point(480, 390);
            this.numDem.Size = new System.Drawing.Size(60, 22);

            this.numGia.Location = new System.Drawing.Point(560, 390);
            this.numGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numGia.Size = new System.Drawing.Size(120, 22);

            this.txtMoTa.Location = new System.Drawing.Point(15, 430);
            this.txtMoTa.Size = new System.Drawing.Size(665, 22);
            this.txtMoTa.Text = "Mô tả";

            this.btnThemTour.Location = new System.Drawing.Point(700, 390);
            this.btnThemTour.Size = new System.Drawing.Size(120, 40);
            this.btnThemTour.Text = "Thêm tour";
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);

            // --- PAGE 2: ĐIỂM DỪNG ---
            this.pageDiemDung.Text = "Điểm dừng";
            this.pageDiemDung.Controls.Add(this.dgvDiemDung);
            this.pageDiemDung.Controls.Add(this.numThuTu);
            this.pageDiemDung.Controls.Add(this.txtDiemDung);
            this.pageDiemDung.Controls.Add(this.chkDoiPT);
            this.pageDiemDung.Controls.Add(this.chkAn);
            this.pageDiemDung.Controls.Add(this.chkKS);
            this.pageDiemDung.Controls.Add(this.numSao);
            this.pageDiemDung.Controls.Add(this.txtGhiChuDD);
            this.pageDiemDung.Controls.Add(this.btnThemDD);

            this.dgvDiemDung.Location = new System.Drawing.Point(15, 15);
            this.dgvDiemDung.Size = new System.Drawing.Size(960, 350);

            this.numThuTu.Location = new System.Drawing.Point(15, 390);
            this.numThuTu.Size = new System.Drawing.Size(60, 22);
            this.txtDiemDung.Location = new System.Drawing.Point(100, 390);
            this.txtDiemDung.Size = new System.Drawing.Size(200, 22);
            this.txtDiemDung.Text = "Tên điểm dừng";

            this.chkDoiPT.AutoSize = true;
            this.chkDoiPT.Location = new System.Drawing.Point(320, 390);
            this.chkDoiPT.Text = "Đổi PT";
            this.chkAn.AutoSize = true;
            this.chkAn.Location = new System.Drawing.Point(400, 390);
            this.chkAn.Text = "Có nơi ăn";
            this.chkKS.AutoSize = true;
            this.chkKS.Location = new System.Drawing.Point(490, 390);
            this.chkKS.Text = "Có khách sạn";
            this.chkKS.CheckedChanged += new System.EventHandler(this.chkKS_CheckedChanged);

            this.numSao.Location = new System.Drawing.Point(600, 390);
            this.numSao.Size = new System.Drawing.Size(60, 22);
            this.numSao.Minimum = 2;
            this.numSao.Maximum = 5;
            this.numSao.Enabled = false;

            this.txtGhiChuDD.Location = new System.Drawing.Point(15, 430);
            this.txtGhiChuDD.Size = new System.Drawing.Size(645, 22);
            this.txtGhiChuDD.Text = "Ghi chú";

            this.btnThemDD.Location = new System.Drawing.Point(700, 390);
            this.btnThemDD.Size = new System.Drawing.Size(120, 40);
            this.btnThemDD.Text = "Thêm điểm dừng";
            this.btnThemDD.Click += new System.EventHandler(this.btnThemDD_Click);

            // --- PAGE 3: PHƯƠNG TIỆN ---
            this.pageChang.Text = "Phương tiện theo chặng";
            this.pageChang.Controls.Add(this.dgvChang);
            this.pageChang.Controls.Add(this.numChang);
            this.pageChang.Controls.Add(this.cboPT);
            this.pageChang.Controls.Add(this.txtGhiChuPT);
            this.pageChang.Controls.Add(this.btnThemChang);

            this.dgvChang.Location = new System.Drawing.Point(15, 15);
            this.dgvChang.Size = new System.Drawing.Size(960, 350);

            this.numChang.Location = new System.Drawing.Point(15, 390);
            this.numChang.Size = new System.Drawing.Size(80, 22);
            this.cboPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPT.Location = new System.Drawing.Point(120, 390);
            this.cboPT.Size = new System.Drawing.Size(200, 24);

            this.txtGhiChuPT.Location = new System.Drawing.Point(340, 390);
            this.txtGhiChuPT.Size = new System.Drawing.Size(300, 22);
            this.txtGhiChuPT.Text = "Ghi chú";

            this.btnThemChang.Location = new System.Drawing.Point(660, 385);
            this.btnThemChang.Size = new System.Drawing.Size(120, 40);
            this.btnThemChang.Text = "Gắn phương tiện";
            this.btnThemChang.Click += new System.EventHandler(this.btnThemChang_Click);

            // --- PAGE 4: ĐIỂM TQ ---
            this.pageDTQ.Text = "Điểm tham quan";
            this.pageDTQ.Controls.Add(this.dgvTQ);
            this.pageDTQ.Controls.Add(this.cboDTQ);
            this.pageDTQ.Controls.Add(this.numThuTuTQ);
            this.pageDTQ.Controls.Add(this.btnThemTQ);

            this.dgvTQ.Location = new System.Drawing.Point(15, 15);
            this.dgvTQ.Size = new System.Drawing.Size(960, 350);

            this.cboDTQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDTQ.Location = new System.Drawing.Point(15, 390);
            this.cboDTQ.Size = new System.Drawing.Size(250, 24);

            this.numThuTuTQ.Location = new System.Drawing.Point(280, 390);
            this.numThuTuTQ.Size = new System.Drawing.Size(80, 22);

            this.btnThemTQ.Location = new System.Drawing.Point(380, 385);
            this.btnThemTQ.Size = new System.Drawing.Size(120, 40);
            this.btnThemTQ.Text = "Gắn điểm TQ";
            this.btnThemTQ.Click += new System.EventHandler(this.btnThemTQ_Click);

            // Nút Đóng
            this.btnDong.Location = new System.Drawing.Point(880, 580);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.lblChonTour);
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.tabTour);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tour - Hành trình";
            this.Load += new System.EventHandler(this.FrmTour_Load);

            this.tabTour.ResumeLayout(false);
            this.pageTour.ResumeLayout(false);
            this.pageTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.pageDiemDung.ResumeLayout(false);
            this.pageDiemDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).EndInit();
            this.pageChang.ResumeLayout(false);
            this.pageChang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChang)).EndInit();
            this.pageDTQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTuTQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblChonTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.TabControl tabTour;

        private System.Windows.Forms.TabPage pageTour;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown numNgay;
        private System.Windows.Forms.NumericUpDown numDem;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThemTour;

        private System.Windows.Forms.TabPage pageDiemDung;
        private System.Windows.Forms.DataGridView dgvDiemDung;
        private System.Windows.Forms.NumericUpDown numThuTu;
        private System.Windows.Forms.TextBox txtDiemDung;
        private System.Windows.Forms.CheckBox chkDoiPT;
        private System.Windows.Forms.CheckBox chkAn;
        private System.Windows.Forms.CheckBox chkKS;
        private System.Windows.Forms.NumericUpDown numSao;
        private System.Windows.Forms.TextBox txtGhiChuDD;
        private System.Windows.Forms.Button btnThemDD;

        private System.Windows.Forms.TabPage pageChang;
        private System.Windows.Forms.DataGridView dgvChang;
        private System.Windows.Forms.NumericUpDown numChang;
        private System.Windows.Forms.ComboBox cboPT;
        private System.Windows.Forms.TextBox txtGhiChuPT;
        private System.Windows.Forms.Button btnThemChang;

        private System.Windows.Forms.TabPage pageDTQ;
        private System.Windows.Forms.DataGridView dgvTQ;
        private System.Windows.Forms.ComboBox cboDTQ;
        private System.Windows.Forms.NumericUpDown numThuTuTQ;
        private System.Windows.Forms.Button btnThemTQ;

        private System.Windows.Forms.Button btnDong;
    }
}