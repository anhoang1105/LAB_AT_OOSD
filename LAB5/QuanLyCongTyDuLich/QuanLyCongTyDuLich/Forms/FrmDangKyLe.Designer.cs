namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyLe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.lblDiemBan = new System.Windows.Forms.Label();
            this.cboDiemBan = new System.Windows.Forms.ComboBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.numNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTienTitle = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // Row 1: Số ĐK & Chuyến
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(20, 25);
            this.lblSo.Text = "Số đăng ký:";

            this.txtSo.Location = new System.Drawing.Point(110, 22);
            this.txtSo.Size = new System.Drawing.Size(120, 22);

            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(250, 25);
            this.lblChuyen.Text = "Chuyến:";

            this.cboChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyen.Location = new System.Drawing.Point(320, 22);
            this.cboChuyen.Size = new System.Drawing.Size(550, 24);
            this.cboChuyen.SelectedIndexChanged += new System.EventHandler(this.TinhTien);

            // Row 2: Điểm bán, Người ĐK, Điện thoại
            this.lblDiemBan.AutoSize = true;
            this.lblDiemBan.Location = new System.Drawing.Point(20, 75);
            this.lblDiemBan.Text = "Điểm bán vé:";

            this.cboDiemBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemBan.Location = new System.Drawing.Point(110, 72);
            this.cboDiemBan.Size = new System.Drawing.Size(180, 24);

            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(310, 75);
            this.lblTen.Text = "Người đăng ký:";

            this.txtTen.Location = new System.Drawing.Point(420, 72);
            this.txtTen.Size = new System.Drawing.Size(220, 22);

            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(660, 75);
            this.lblDT.Text = "Điện thoại:";

            this.txtDT.Location = new System.Drawing.Point(740, 72);
            this.txtDT.Size = new System.Drawing.Size(130, 22);

            // Row 3: Số người, Thành tiền & Nút bấm
            this.lblNguoi.AutoSize = true;
            this.lblNguoi.Location = new System.Drawing.Point(20, 125);
            this.lblNguoi.Text = "Số người:";

            this.numNguoi.Location = new System.Drawing.Point(110, 122);
            this.numNguoi.Size = new System.Drawing.Size(60, 22);
            this.numNguoi.Minimum = 1;
            this.numNguoi.Maximum = 11;
            this.numNguoi.Value = 1;
            this.numNguoi.ValueChanged += new System.EventHandler(this.TinhTien);

            this.lblThanhTienTitle.AutoSize = true;
            this.lblThanhTienTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblThanhTienTitle.Location = new System.Drawing.Point(200, 124);
            this.lblThanhTienTitle.Text = "Thành tiền:";

            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.ForeColor = System.Drawing.Color.DarkRed;
            this.lblThanhTien.Location = new System.Drawing.Point(290, 124);
            this.lblThanhTien.Text = "0 đ";

            this.btnDangKy.Location = new System.Drawing.Point(670, 115);
            this.btnDangKy.Size = new System.Drawing.Size(200, 35);
            this.btnDangKy.Text = "Đăng ký và thanh toán vé";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // DataGridView
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 170);
            this.dgv.Size = new System.Drawing.Size(850, 320);

            // Close Button
            this.btnDong.Location = new System.Drawing.Point(750, 500);
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblThanhTienTitle);
            this.Controls.Add(this.numNguoi);
            this.Controls.Add(this.lblNguoi);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.cboDiemBan);
            this.Controls.Add(this.lblDiemBan);
            this.Controls.Add(this.cboChuyen);
            this.Controls.Add(this.lblChuyen);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSo);
            this.Name = "FrmDangKyLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký khách lẻ theo chuyến";
            this.Load += new System.EventHandler(this.FrmDangKyLe_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.Label lblDiemBan;
        private System.Windows.Forms.ComboBox cboDiemBan;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.NumericUpDown numNguoi;
        private System.Windows.Forms.Label lblThanhTienTitle;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;
    }
}