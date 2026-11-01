namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmMatBang_Phong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.NumericUpDown numDienTich;
        private System.Windows.Forms.TextBox txtHuong;
        private System.Windows.Forms.NumericUpDown numGiaCoSo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblHuong;
        private System.Windows.Forms.Label lblGiaCoSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.numDienTich = new System.Windows.Forms.NumericUpDown();
            this.txtHuong = new System.Windows.Forms.TextBox();
            this.numGiaCoSo = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTang = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblHuong = new System.Windows.Forms.Label();
            this.lblGiaCoSo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDienTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaCoSo)).BeginInit();
            this.SuspendLayout();

            // lblMaPhong
            this.lblMaPhong.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(80, 23);
            this.lblMaPhong.Text = "Mã phòng:";

            // txtMaPhong
            this.txtMaPhong.Location = new System.Drawing.Point(120, 27);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(150, 22);

            // lblTang
            this.lblTang.Location = new System.Drawing.Point(300, 30);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(80, 23);
            this.lblTang.Text = "Tầng:";

            // cboTang
            this.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTang.Location = new System.Drawing.Point(380, 27);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(150, 24);

            // lblDienTich
            this.lblDienTich.Location = new System.Drawing.Point(30, 70);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(80, 23);
            this.lblDienTich.Text = "Diện tích:";

            // numDienTich
            this.numDienTich.Location = new System.Drawing.Point(120, 67);
            this.numDienTich.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numDienTich.Name = "numDienTich";
            this.numDienTich.Size = new System.Drawing.Size(150, 22);

            // lblHuong
            this.lblHuong.Location = new System.Drawing.Point(300, 70);
            this.lblHuong.Name = "lblHuong";
            this.lblHuong.Size = new System.Drawing.Size(80, 23);
            this.lblHuong.Text = "Hướng:";

            // txtHuong
            this.txtHuong.Location = new System.Drawing.Point(380, 67);
            this.txtHuong.Name = "txtHuong";
            this.txtHuong.Size = new System.Drawing.Size(150, 22);

            // lblGiaCoSo
            this.lblGiaCoSo.Location = new System.Drawing.Point(30, 110);
            this.lblGiaCoSo.Name = "lblGiaCoSo";
            this.lblGiaCoSo.Size = new System.Drawing.Size(80, 23);
            this.lblGiaCoSo.Text = "Giá cơ sở:";

            // numGiaCoSo
            this.numGiaCoSo.Location = new System.Drawing.Point(120, 107);
            this.numGiaCoSo.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numGiaCoSo.Name = "numGiaCoSo";
            this.numGiaCoSo.Size = new System.Drawing.Size(150, 22);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(600, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.Text = "Thêm phòng";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(600, 80);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // dgvPhong
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(30, 160);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(720, 350);

            // FrmMatBang_Phong
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.cboTang);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.numDienTich);
            this.Controls.Add(this.lblHuong);
            this.Controls.Add(this.txtHuong);
            this.Controls.Add(this.lblGiaCoSo);
            this.Controls.Add(this.numGiaCoSo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvPhong);
            this.Name = "FrmMatBang_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Mặt Bằng & Phòng";
            this.Load += new System.EventHandler(this.FrmMatBang_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDienTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaCoSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}