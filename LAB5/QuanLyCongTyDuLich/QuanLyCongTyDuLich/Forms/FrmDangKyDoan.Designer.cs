namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDoan = new System.Windows.Forms.GroupBox();
            this.lblMaDoan = new System.Windows.Forms.Label();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.lblTenCQ = new System.Windows.Forms.Label();
            this.txtTenCQ = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDaiDien = new System.Windows.Forms.Label();
            this.txtDaiDien = new System.Windows.Forms.TextBox();

            this.grpDangKy = new System.Windows.Forms.GroupBox();
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtDi = new System.Windows.Forms.DateTimePicker();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.numNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblDon = new System.Windows.Forms.Label();
            this.txtDon = new System.Windows.Forms.TextBox();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.chkBH = new System.Windows.Forms.CheckBox();
            this.lblKetThucTitle = new System.Windows.Forms.Label();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblTongTitle = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();

            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblCacPhieu = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpDoan.SuspendLayout();
            this.grpDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // GroupBox 1: Thông tin đoàn
            this.grpDoan.Controls.Add(this.lblDaiDien);
            this.grpDoan.Controls.Add(this.txtDaiDien);
            this.grpDoan.Controls.Add(this.lblDT);
            this.grpDoan.Controls.Add(this.txtDT);
            this.grpDoan.Controls.Add(this.lblDiaChi);
            this.grpDoan.Controls.Add(this.txtDiaChi);
            this.grpDoan.Controls.Add(this.lblTenCQ);
            this.grpDoan.Controls.Add(this.txtTenCQ);
            this.grpDoan.Controls.Add(this.lblMaDoan);
            this.grpDoan.Controls.Add(this.txtMaDoan);
            this.grpDoan.Location = new System.Drawing.Point(20, 20);
            this.grpDoan.Name = "grpDoan";
            this.grpDoan.Size = new System.Drawing.Size(460, 210);
            this.grpDoan.Text = "Thông tin đoàn khách";

            this.lblMaDoan.AutoSize = true;
            this.lblMaDoan.Location = new System.Drawing.Point(20, 35);
            this.lblMaDoan.Text = "Mã đoàn:";
            this.txtMaDoan.Location = new System.Drawing.Point(140, 32);
            this.txtMaDoan.Size = new System.Drawing.Size(150, 22);

            this.lblTenCQ.AutoSize = true;
            this.lblTenCQ.Location = new System.Drawing.Point(20, 70);
            this.lblTenCQ.Text = "Cơ quan / gia đình:";
            this.txtTenCQ.Location = new System.Drawing.Point(140, 67);
            this.txtTenCQ.Size = new System.Drawing.Size(300, 22);

            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 105);
            this.lblDiaChi.Text = "Địa chỉ:";
            this.txtDiaChi.Location = new System.Drawing.Point(140, 102);
            this.txtDiaChi.Size = new System.Drawing.Size(300, 22);

            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(20, 140);
            this.lblDT.Text = "Điện thoại:";
            this.txtDT.Location = new System.Drawing.Point(140, 137);
            this.txtDT.Size = new System.Drawing.Size(150, 22);

            this.lblDaiDien.AutoSize = true;
            this.lblDaiDien.Location = new System.Drawing.Point(20, 175);
            this.lblDaiDien.Text = "Người đại diện:";
            this.txtDaiDien.Location = new System.Drawing.Point(140, 172);
            this.txtDaiDien.Size = new System.Drawing.Size(300, 22);

            // GroupBox 2: Đăng ký tour
            this.grpDangKy.Controls.Add(this.lblTong);
            this.grpDangKy.Controls.Add(this.lblTongTitle);
            this.grpDangKy.Controls.Add(this.lblKetThuc);
            this.grpDangKy.Controls.Add(this.lblKetThucTitle);
            this.grpDangKy.Controls.Add(this.chkBH);
            this.grpDangKy.Controls.Add(this.numCoc);
            this.grpDangKy.Controls.Add(this.lblCoc);
            this.grpDangKy.Controls.Add(this.txtDon);
            this.grpDangKy.Controls.Add(this.lblDon);
            this.grpDangKy.Controls.Add(this.numNguoi);
            this.grpDangKy.Controls.Add(this.lblNguoi);
            this.grpDangKy.Controls.Add(this.dtDi);
            this.grpDangKy.Controls.Add(this.lblNgayDi);
            this.grpDangKy.Controls.Add(this.cboTour);
            this.grpDangKy.Controls.Add(this.lblTour);
            this.grpDangKy.Controls.Add(this.txtSo);
            this.grpDangKy.Controls.Add(this.lblSo);
            this.grpDangKy.Location = new System.Drawing.Point(500, 20);
            this.grpDangKy.Name = "grpDangKy";
            this.grpDangKy.Size = new System.Drawing.Size(660, 210);
            this.grpDangKy.Text = "Đăng ký tour";

            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(20, 35);
            this.lblSo.Text = "Số phiếu:";
            this.txtSo.Location = new System.Drawing.Point(100, 32);
            this.txtSo.Size = new System.Drawing.Size(120, 22);

            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(250, 35);
            this.lblTour.Text = "Tour:";
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(300, 32);
            this.cboTour.Size = new System.Drawing.Size(340, 24);
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.TinhTong);

            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(20, 70);
            this.lblNgayDi.Text = "Ngày đi:";
            this.dtDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDi.Location = new System.Drawing.Point(100, 67);
            this.dtDi.Size = new System.Drawing.Size(120, 22);
            this.dtDi.ValueChanged += new System.EventHandler(this.TinhTong);

            this.lblNguoi.AutoSize = true;
            this.lblNguoi.Location = new System.Drawing.Point(250, 70);
            this.lblNguoi.Text = "Số người:";
            this.numNguoi.Location = new System.Drawing.Point(320, 67);
            this.numNguoi.Size = new System.Drawing.Size(80, 22);
            this.numNguoi.Minimum = 13;
            this.numNguoi.Maximum = 1000;
            this.numNguoi.Value = 13;
            this.numNguoi.ValueChanged += new System.EventHandler(this.TinhTong);

            this.lblDon.AutoSize = true;
            this.lblDon.Location = new System.Drawing.Point(20, 105);
            this.lblDon.Text = "Điểm đón:";
            this.txtDon.Location = new System.Drawing.Point(100, 102);
            this.txtDon.Size = new System.Drawing.Size(540, 22);

            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(20, 140);
            this.lblCoc.Text = "Tiền cọc:";
            this.numCoc.Location = new System.Drawing.Point(100, 137);
            this.numCoc.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numCoc.Size = new System.Drawing.Size(150, 22);

            this.chkBH.AutoSize = true;
            this.chkBH.Location = new System.Drawing.Point(300, 139);
            this.chkBH.Text = "Mua bảo hiểm";
            this.chkBH.CheckedChanged += new System.EventHandler(this.chkBH_CheckedChanged);

            this.lblKetThucTitle.AutoSize = true;
            this.lblKetThucTitle.Location = new System.Drawing.Point(20, 175);
            this.lblKetThucTitle.Text = "Kết thúc DK:";
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblKetThuc.Location = new System.Drawing.Point(110, 175);
            this.lblKetThuc.Text = "-";

            this.lblTongTitle.AutoSize = true;
            this.lblTongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongTitle.Location = new System.Drawing.Point(300, 173);
            this.lblTongTitle.Text = "Tổng dự kiến:";
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTong.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTong.Location = new System.Drawing.Point(420, 173);
            this.lblTong.Text = "0 đ";

            // DataGridView: Thành viên (bảo hiểm)
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(20, 245);
            this.lblDanhSach.Text = "Danh sách người cùng đi (bắt buộc đủ số người khi mua bảo hiểm):";
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(20, 270);
            this.dgvThanhVien.Size = new System.Drawing.Size(1140, 180);

            // Buttons
            this.btnDangKy.Location = new System.Drawing.Point(860, 465);
            this.btnDangKy.Size = new System.Drawing.Size(140, 35);
            this.btnDangKy.Text = "Lập phiếu đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.btnHuy.Location = new System.Drawing.Point(1020, 465);
            this.btnHuy.Size = new System.Drawing.Size(140, 35);
            this.btnHuy.Text = "Hủy phiếu (mất cọc)";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // DataGridView: Các phiếu đoàn đã đăng ký
            this.lblCacPhieu.AutoSize = true;
            this.lblCacPhieu.Location = new System.Drawing.Point(20, 500);
            this.lblCacPhieu.Text = "Các phiếu đăng ký đoàn:";
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(20, 520);
            this.dgv.Size = new System.Drawing.Size(1140, 150);

            // Nút Đóng
            this.btnDong.Location = new System.Drawing.Point(1040, 680);
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(1180, 730);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblCacPhieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dgvThanhVien);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.grpDangKy);
            this.Controls.Add(this.grpDoan);
            this.Name = "FrmDangKyDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu đăng ký theo đoàn";
            this.Load += new System.EventHandler(this.FrmDangKyDoan_Load);

            this.grpDoan.ResumeLayout(false);
            this.grpDoan.PerformLayout();
            this.grpDangKy.ResumeLayout(false);
            this.grpDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpDoan;
        private System.Windows.Forms.Label lblMaDoan;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.Label lblTenCQ;
        private System.Windows.Forms.TextBox txtTenCQ;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDaiDien;
        private System.Windows.Forms.TextBox txtDaiDien;

        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtDi;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.NumericUpDown numNguoi;
        private System.Windows.Forms.Label lblDon;
        private System.Windows.Forms.TextBox txtDon;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.CheckBox chkBH;
        private System.Windows.Forms.Label lblKetThucTitle;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblTongTitle;
        private System.Windows.Forms.Label lblTong;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblCacPhieu;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;
    }
}