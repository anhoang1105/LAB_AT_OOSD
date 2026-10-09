namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmPhanCongHDV
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.numThuLao = new System.Windows.Forms.NumericUpDown();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThuLao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            this.txtMaPC.Location = new System.Drawing.Point(20, 20); this.txtMaPC.Size = new System.Drawing.Size(150, 22);
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboHDV.Location = new System.Drawing.Point(190, 20); this.cboHDV.Size = new System.Drawing.Size(250, 24);
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboLoai.Location = new System.Drawing.Point(20, 60); this.cboLoai.Size = new System.Drawing.Size(150, 24); this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboDoiTuong.Location = new System.Drawing.Point(190, 60); this.cboDoiTuong.Size = new System.Drawing.Size(450, 24);
            this.numThuLao.Location = new System.Drawing.Point(660, 60); this.numThuLao.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 }); this.numThuLao.Size = new System.Drawing.Size(120, 22);
            this.btnPhanCong.Location = new System.Drawing.Point(800, 50); this.btnPhanCong.Size = new System.Drawing.Size(120, 35); this.btnPhanCong.Text = "Phân công"; this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            this.dgv.Location = new System.Drawing.Point(20, 100); this.dgv.Size = new System.Drawing.Size(900, 300);
            this.btnDong.Location = new System.Drawing.Point(800, 420); this.btnDong.Size = new System.Drawing.Size(120, 35); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(940, 470);
            this.Controls.Add(this.btnDong); this.Controls.Add(this.dgv); this.Controls.Add(this.btnPhanCong); this.Controls.Add(this.numThuLao); this.Controls.Add(this.cboDoiTuong); this.Controls.Add(this.cboLoai); this.Controls.Add(this.cboHDV); this.Controls.Add(this.txtMaPC);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "Phân công hướng dẫn viên";
            this.Load += new System.EventHandler(this.FrmPhanCongHDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThuLao)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit(); this.ResumeLayout(false);
        }
        private System.Windows.Forms.TextBox txtMaPC; private System.Windows.Forms.ComboBox cboHDV; private System.Windows.Forms.ComboBox cboLoai; private System.Windows.Forms.ComboBox cboDoiTuong; private System.Windows.Forms.NumericUpDown numThuLao; private System.Windows.Forms.Button btnPhanCong; private System.Windows.Forms.DataGridView dgv; private System.Windows.Forms.Button btnDong;
    }
}