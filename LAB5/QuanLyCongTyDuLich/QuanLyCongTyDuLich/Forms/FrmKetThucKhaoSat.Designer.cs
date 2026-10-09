namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmKetThucKhaoSat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.tabKT = new System.Windows.Forms.TabControl();
            this.tabTT = new System.Windows.Forms.TabPage();
            this.dgvDoan = new System.Windows.Forms.DataGridView();
            this.txtSoTT = new System.Windows.Forms.TextBox(); this.txtSoDK = new System.Windows.Forms.TextBox(); this.dtTT = new System.Windows.Forms.DateTimePicker(); this.numTien = new System.Windows.Forms.NumericUpDown(); this.txtGhiChu = new System.Windows.Forms.TextBox(); this.btnThanhToan = new System.Windows.Forms.Button();
            this.tabKS = new System.Windows.Forms.TabPage();
            this.cboLoaiKS = new System.Windows.Forms.ComboBox(); this.cboDangKy = new System.Windows.Forms.ComboBox(); this.txtMaKS = new System.Windows.Forms.TextBox(); this.dtGui = new System.Windows.Forms.DateTimePicker(); this.btnGui = new System.Windows.Forms.Button();
            this.dgvKS = new System.Windows.Forms.DataGridView();
            this.txtKSChon = new System.Windows.Forms.TextBox(); this.dtPH = new System.Windows.Forms.DateTimePicker(); this.numDiem = new System.Windows.Forms.NumericUpDown(); this.txtGopY = new System.Windows.Forms.TextBox(); this.btnGhiPH = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabKT.SuspendLayout(); this.tabTT.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.numTien)).BeginInit();
            this.tabKS.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit(); this.SuspendLayout();

            this.tabKT.Controls.Add(this.tabTT); this.tabKT.Controls.Add(this.tabKS); this.tabKT.Location = new System.Drawing.Point(10, 10); this.tabKT.Size = new System.Drawing.Size(960, 500);

            // Tab Thanh Toan
            this.tabTT.Text = "Thanh toán sau tour (đoàn)"; this.tabTT.Controls.Add(this.dgvDoan); this.tabTT.Controls.Add(this.txtSoTT); this.tabTT.Controls.Add(this.txtSoDK); this.tabTT.Controls.Add(this.dtTT); this.tabTT.Controls.Add(this.numTien); this.tabTT.Controls.Add(this.txtGhiChu); this.tabTT.Controls.Add(this.btnThanhToan);
            this.dgvDoan.Location = new System.Drawing.Point(10, 10); this.dgvDoan.Size = new System.Drawing.Size(930, 380); this.dgvDoan.SelectionChanged += new System.EventHandler(this.dgvDoan_SelectionChanged);
            this.txtSoTT.Location = new System.Drawing.Point(10, 410); this.txtSoTT.Size = new System.Drawing.Size(120, 22);
            this.txtSoDK.Location = new System.Drawing.Point(140, 410); this.txtSoDK.Size = new System.Drawing.Size(120, 22);
            this.dtTT.Location = new System.Drawing.Point(270, 410); this.dtTT.Size = new System.Drawing.Size(120, 22); this.dtTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numTien.Location = new System.Drawing.Point(400, 410); this.numTien.Size = new System.Drawing.Size(120, 22); this.numTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.txtGhiChu.Location = new System.Drawing.Point(530, 410); this.txtGhiChu.Size = new System.Drawing.Size(250, 22);
            this.btnThanhToan.Location = new System.Drawing.Point(800, 400); this.btnThanhToan.Size = new System.Drawing.Size(120, 40); this.btnThanhToan.Text = "Ghi nhận"; this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // Tab Khao Sat
            this.tabKS.Text = "Khảo sát khách hàng"; this.tabKS.Controls.Add(this.cboLoaiKS); this.tabKS.Controls.Add(this.cboDangKy); this.tabKS.Controls.Add(this.txtMaKS); this.tabKS.Controls.Add(this.dtGui); this.tabKS.Controls.Add(this.btnGui); this.tabKS.Controls.Add(this.dgvKS); this.tabKS.Controls.Add(this.txtKSChon); this.tabKS.Controls.Add(this.dtPH); this.tabKS.Controls.Add(this.numDiem); this.tabKS.Controls.Add(this.txtGopY); this.tabKS.Controls.Add(this.btnGhiPH);
            this.cboLoaiKS.Location = new System.Drawing.Point(10, 15); this.cboLoaiKS.Size = new System.Drawing.Size(80, 24); this.cboLoaiKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboLoaiKS.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKS_SelectedIndexChanged);
            this.cboDangKy.Location = new System.Drawing.Point(100, 15); this.cboDangKy.Size = new System.Drawing.Size(300, 24); this.cboDangKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKS.Location = new System.Drawing.Point(410, 15); this.txtMaKS.Size = new System.Drawing.Size(120, 22);
            this.dtGui.Location = new System.Drawing.Point(540, 15); this.dtGui.Size = new System.Drawing.Size(120, 22); this.dtGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnGui.Location = new System.Drawing.Point(680, 10); this.btnGui.Size = new System.Drawing.Size(120, 35); this.btnGui.Text = "Gửi khảo sát"; this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            this.dgvKS.Location = new System.Drawing.Point(10, 60); this.dgvKS.Size = new System.Drawing.Size(930, 330); this.dgvKS.SelectionChanged += new System.EventHandler(this.dgvKS_SelectionChanged);
            this.txtKSChon.Location = new System.Drawing.Point(10, 410); this.txtKSChon.Size = new System.Drawing.Size(120, 22);
            this.dtPH.Location = new System.Drawing.Point(140, 410); this.dtPH.Size = new System.Drawing.Size(120, 22); this.dtPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numDiem.Location = new System.Drawing.Point(270, 410); this.numDiem.Size = new System.Drawing.Size(60, 22); this.numDiem.Minimum = 1; this.numDiem.Maximum = 5;
            this.txtGopY.Location = new System.Drawing.Point(340, 410); this.txtGopY.Size = new System.Drawing.Size(440, 22);
            this.btnGhiPH.Location = new System.Drawing.Point(800, 400); this.btnGhiPH.Size = new System.Drawing.Size(120, 40); this.btnGhiPH.Text = "Ghi phản hồi"; this.btnGhiPH.Click += new System.EventHandler(this.btnGhiPH_Click);

            this.btnDong.Location = new System.Drawing.Point(850, 520); this.btnDong.Size = new System.Drawing.Size(120, 40); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.ClientSize = new System.Drawing.Size(990, 570); this.Controls.Add(this.tabKT); this.Controls.Add(this.btnDong);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "Kết thúc tour - Thanh toán - Khảo sát"; this.Load += new System.EventHandler(this.FrmKetThucKhaoSat_Load);
            this.tabKT.ResumeLayout(false); this.tabTT.ResumeLayout(false); this.tabTT.PerformLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.numTien)).EndInit();
            this.tabKS.ResumeLayout(false); this.tabKS.PerformLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.TabControl tabKT; private System.Windows.Forms.TabPage tabTT; private System.Windows.Forms.DataGridView dgvDoan; private System.Windows.Forms.TextBox txtSoTT; private System.Windows.Forms.TextBox txtSoDK; private System.Windows.Forms.DateTimePicker dtTT; private System.Windows.Forms.NumericUpDown numTien; private System.Windows.Forms.TextBox txtGhiChu; private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TabPage tabKS; private System.Windows.Forms.ComboBox cboLoaiKS; private System.Windows.Forms.ComboBox cboDangKy; private System.Windows.Forms.TextBox txtMaKS; private System.Windows.Forms.DateTimePicker dtGui; private System.Windows.Forms.Button btnGui; private System.Windows.Forms.DataGridView dgvKS; private System.Windows.Forms.TextBox txtKSChon; private System.Windows.Forms.DateTimePicker dtPH; private System.Windows.Forms.NumericUpDown numDiem; private System.Windows.Forms.TextBox txtGopY; private System.Windows.Forms.Button btnGhiPH; private System.Windows.Forms.Button btnDong;
    }
}