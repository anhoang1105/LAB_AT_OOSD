namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmGiaHan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaGH;
        private System.Windows.Forms.TextBox txtMaGH;
        private System.Windows.Forms.Label lblHopDong;
        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvGiaHan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaGH = new System.Windows.Forms.Label();
            this.txtMaGH = new System.Windows.Forms.TextBox();
            this.lblHopDong = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvGiaHan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHan)).BeginInit();
            this.SuspendLayout();

            this.lblMaGH.Location = new System.Drawing.Point(30, 30);
            this.lblMaGH.Size = new System.Drawing.Size(100, 23);
            this.lblMaGH.Text = "Mã Phiếu GH:";

            this.txtMaGH.Location = new System.Drawing.Point(130, 27);
            this.txtMaGH.Size = new System.Drawing.Size(150, 22);

            this.lblHopDong.Location = new System.Drawing.Point(30, 70);
            this.lblHopDong.Size = new System.Drawing.Size(100, 23);
            this.lblHopDong.Text = "Hợp đồng:";

            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.Location = new System.Drawing.Point(130, 67);
            this.cboHopDong.Size = new System.Drawing.Size(150, 24);

            this.lblThoiGian.Location = new System.Drawing.Point(310, 30);
            this.lblThoiGian.Size = new System.Drawing.Size(120, 23);
            this.lblThoiGian.Text = "T/Gian GH (tháng):";

            this.numThoiGian.Location = new System.Drawing.Point(430, 27);
            this.numThoiGian.Size = new System.Drawing.Size(100, 22);

            this.btnGiaHan.Location = new System.Drawing.Point(580, 25);
            this.btnGiaHan.Size = new System.Drawing.Size(120, 40);
            this.btnGiaHan.Text = "Lập Phiếu GH";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);

            this.btnDong.Location = new System.Drawing.Point(580, 75);
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvGiaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaHan.Location = new System.Drawing.Point(30, 130);
            this.dgvGiaHan.Size = new System.Drawing.Size(670, 300);

            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.lblMaGH);
            this.Controls.Add(this.txtMaGH);
            this.Controls.Add(this.lblHopDong);
            this.Controls.Add(this.cboHopDong);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.numThoiGian);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvGiaHan);
            this.Name = "FrmGiaHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gia Hạn Hợp Đồng Thuê";
            this.Load += new System.EventHandler(this.FrmGiaHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}