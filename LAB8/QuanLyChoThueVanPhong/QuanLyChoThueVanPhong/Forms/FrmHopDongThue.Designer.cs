namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHopDongThue
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.NumericUpDown numThoiHan;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label lblDSPhong;
        private System.Windows.Forms.CheckedListBox chklPhong;
        private System.Windows.Forms.Button btnLapHopDong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvHopDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.numThoiHan = new System.Windows.Forms.NumericUpDown();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblDSPhong = new System.Windows.Forms.Label();
            this.chklPhong = new System.Windows.Forms.CheckedListBox();
            this.btnLapHopDong = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();

            this.lblSoHD.Location = new System.Drawing.Point(30, 30);
            this.lblSoHD.Size = new System.Drawing.Size(100, 23);
            this.lblSoHD.Text = "Số Hợp đồng:";

            this.txtSoHD.Location = new System.Drawing.Point(130, 27);
            this.txtSoHD.Size = new System.Drawing.Size(150, 22);

            this.lblKhachHang.Location = new System.Drawing.Point(300, 30);
            this.lblKhachHang.Size = new System.Drawing.Size(100, 23);
            this.lblKhachHang.Text = "Khách hàng:";

            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(400, 27);
            this.cboKhachHang.Size = new System.Drawing.Size(150, 24);

            this.lblThoiHan.Location = new System.Drawing.Point(30, 70);
            this.lblThoiHan.Size = new System.Drawing.Size(100, 23);
            this.lblThoiHan.Text = "Hạn (tháng):";

            this.numThoiHan.Location = new System.Drawing.Point(130, 67);
            this.numThoiHan.Value = new decimal(new int[] { 6, 0, 0, 0 });
            this.numThoiHan.Size = new System.Drawing.Size(150, 22);

            this.lblCoc.Location = new System.Drawing.Point(300, 70);
            this.lblCoc.Size = new System.Drawing.Size(100, 23);
            this.lblCoc.Text = "Tiền cọc:";

            this.numCoc.Location = new System.Drawing.Point(400, 67);
            this.numCoc.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            this.numCoc.Size = new System.Drawing.Size(150, 22);

            this.lblDSPhong.Location = new System.Drawing.Point(30, 110);
            this.lblDSPhong.Size = new System.Drawing.Size(100, 23);
            this.lblDSPhong.Text = "Phòng trống:";

            this.chklPhong.FormattingEnabled = true;
            this.chklPhong.Location = new System.Drawing.Point(130, 110);
            this.chklPhong.Size = new System.Drawing.Size(420, 80);

            this.btnLapHopDong.Location = new System.Drawing.Point(600, 27);
            this.btnLapHopDong.Size = new System.Drawing.Size(130, 40);
            this.btnLapHopDong.Text = "Lập Hợp đồng";
            this.btnLapHopDong.Click += new System.EventHandler(this.btnLapHopDong_Click);

            this.btnDong.Location = new System.Drawing.Point(600, 80);
            this.btnDong.Size = new System.Drawing.Size(130, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(30, 210);
            this.dgvHopDong.Size = new System.Drawing.Size(700, 280);

            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.lblThoiHan);
            this.Controls.Add(this.numThoiHan);
            this.Controls.Add(this.lblCoc);
            this.Controls.Add(this.numCoc);
            this.Controls.Add(this.lblDSPhong);
            this.Controls.Add(this.chklPhong);
            this.Controls.Add(this.btnLapHopDong);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvHopDong);
            this.Name = "FrmHopDongThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Hợp Đồng Thuê";
            this.Load += new System.EventHandler(this.FrmHopDongThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}