namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmChuyenLe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVeTitle = new System.Windows.Forms.Label();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.lblDon = new System.Windows.Forms.Label();
            this.txtDon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDongDK = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // Row 1
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 25);
            this.lblMa.Text = "Mã chuyến:";

            this.txtMa.Location = new System.Drawing.Point(120, 22);
            this.txtMa.Size = new System.Drawing.Size(150, 22);

            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(320, 25);
            this.lblTour.Text = "Tour:";

            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(380, 22);
            this.cboTour.Size = new System.Drawing.Size(350, 24);
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.TinhNgayVe);

            // Row 2
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(20, 75);
            this.lblNgayDi.Text = "Ngày đi:";

            this.dtDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDi.Location = new System.Drawing.Point(120, 72);
            this.dtDi.Size = new System.Drawing.Size(150, 22);
            this.dtDi.ValueChanged += new System.EventHandler(this.TinhNgayVe);

            this.lblNgayVeTitle.AutoSize = true;
            this.lblNgayVeTitle.Location = new System.Drawing.Point(320, 75);
            this.lblNgayVeTitle.Text = "Ngày về:";

            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayVe.Location = new System.Drawing.Point(380, 75);
            this.lblNgayVe.Text = "-";

            // Row 3
            this.lblDon.AutoSize = true;
            this.lblDon.Location = new System.Drawing.Point(20, 125);
            this.lblDon.Text = "Địa điểm đón:";

            this.txtDon.Location = new System.Drawing.Point(120, 122);
            this.txtDon.Size = new System.Drawing.Size(450, 22);

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(610, 115);
            this.btnThem.Size = new System.Drawing.Size(120, 35);
            this.btnThem.Text = "Tạo chuyến";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnDongDK.Location = new System.Drawing.Point(750, 115);
            this.btnDongDK.Size = new System.Drawing.Size(120, 35);
            this.btnDongDK.Text = "Đóng đăng ký";
            this.btnDongDK.Click += new System.EventHandler(this.btnDongDK_Click);

            // DataGridView
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 170);
            this.dgv.Size = new System.Drawing.Size(850, 320);

            // Close Button
            this.btnDong.Location = new System.Drawing.Point(750, 500);
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnDongDK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDon);
            this.Controls.Add(this.lblDon);
            this.Controls.Add(this.lblNgayVe);
            this.Controls.Add(this.lblNgayVeTitle);
            this.Controls.Add(this.dtDi);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Name = "FrmChuyenLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch chuyến khách lẻ";
            this.Load += new System.EventHandler(this.FrmChuyenLe_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtDi;
        private System.Windows.Forms.Label lblNgayVeTitle;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.Label lblDon;
        private System.Windows.Forms.TextBox txtDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDongDK;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;
    }
}