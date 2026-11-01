namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmChiSoDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.Label lblChiSoDau;
        private System.Windows.Forms.NumericUpDown numChiSoDau;
        private System.Windows.Forms.Label lblChiSoCuoi;
        private System.Windows.Forms.NumericUpDown numChiSoCuoi;
        private System.Windows.Forms.Button btnChotChiSo;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvChiSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.txtThangNam = new System.Windows.Forms.TextBox();
            this.lblChiSoDau = new System.Windows.Forms.Label();
            this.numChiSoDau = new System.Windows.Forms.NumericUpDown();
            this.lblChiSoCuoi = new System.Windows.Forms.Label();
            this.numChiSoCuoi = new System.Windows.Forms.NumericUpDown();
            this.btnChotChiSo = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvChiSo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numChiSoDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChiSoCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).BeginInit();
            this.SuspendLayout();

            this.lblPhong.Location = new System.Drawing.Point(30, 30);
            this.lblPhong.Size = new System.Drawing.Size(80, 23);
            this.lblPhong.Text = "Phòng:";

            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(120, 27);
            this.cboPhong.Size = new System.Drawing.Size(150, 24);

            this.lblDichVu.Location = new System.Drawing.Point(300, 30);
            this.lblDichVu.Size = new System.Drawing.Size(80, 23);
            this.lblDichVu.Text = "Dịch vụ:";

            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.Location = new System.Drawing.Point(380, 27);
            this.cboDichVu.Size = new System.Drawing.Size(200, 24);

            this.lblThangNam.Location = new System.Drawing.Point(30, 70);
            this.lblThangNam.Size = new System.Drawing.Size(90, 23);
            this.lblThangNam.Text = "Kỳ (MM/yyyy):";

            this.txtThangNam.Location = new System.Drawing.Point(120, 67);
            this.txtThangNam.Size = new System.Drawing.Size(150, 22);

            this.lblChiSoDau.Location = new System.Drawing.Point(30, 110);
            this.lblChiSoDau.Size = new System.Drawing.Size(80, 23);
            this.lblChiSoDau.Text = "Chỉ số đầu:";

            this.numChiSoDau.Location = new System.Drawing.Point(120, 107);
            this.numChiSoDau.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numChiSoDau.Size = new System.Drawing.Size(150, 22);

            this.lblChiSoCuoi.Location = new System.Drawing.Point(300, 110);
            this.lblChiSoCuoi.Size = new System.Drawing.Size(80, 23);
            this.lblChiSoCuoi.Text = "Chỉ số cuối:";

            this.numChiSoCuoi.Location = new System.Drawing.Point(380, 107);
            this.numChiSoCuoi.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numChiSoCuoi.Size = new System.Drawing.Size(150, 22);

            this.btnChotChiSo.Location = new System.Drawing.Point(620, 27);
            this.btnChotChiSo.Size = new System.Drawing.Size(120, 40);
            this.btnChotChiSo.Text = "Chốt Chỉ Số";
            this.btnChotChiSo.Click += new System.EventHandler(this.btnChotChiSo_Click);

            this.btnDong.Location = new System.Drawing.Point(620, 80);
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvChiSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSo.Location = new System.Drawing.Point(30, 160);
            this.dgvChiSo.Size = new System.Drawing.Size(710, 300);

            this.ClientSize = new System.Drawing.Size(780, 490);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.cboDichVu);
            this.Controls.Add(this.lblThangNam);
            this.Controls.Add(this.txtThangNam);
            this.Controls.Add(this.lblChiSoDau);
            this.Controls.Add(this.numChiSoDau);
            this.Controls.Add(this.lblChiSoCuoi);
            this.Controls.Add(this.numChiSoCuoi);
            this.Controls.Add(this.btnChotChiSo);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvChiSo);
            this.Name = "FrmChiSoDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi Nhận Chỉ Số Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmChiSoDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChiSoDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChiSoCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}