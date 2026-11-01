namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmKiemTra_ViPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaKT;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.TextBox txtBienBan;
        private System.Windows.Forms.NumericUpDown numTienPhat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvKiemTra;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtMaKT = new System.Windows.Forms.TextBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtBienBan = new System.Windows.Forms.TextBox();
            this.numTienPhat = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvKiemTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTra)).BeginInit();
            this.SuspendLayout();

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label() { Text = "Mã KT:", Location = new System.Drawing.Point(30, 30), Size = new System.Drawing.Size(80, 23) };
            this.txtMaKT.Location = new System.Drawing.Point(120, 27); this.txtMaKT.Size = new System.Drawing.Size(150, 22);

            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label() { Text = "Phòng:", Location = new System.Drawing.Point(300, 30), Size = new System.Drawing.Size(60, 23) };
            this.cboPhong.Location = new System.Drawing.Point(370, 27); this.cboPhong.Size = new System.Drawing.Size(150, 24); this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label() { Text = "Ngày KT:", Location = new System.Drawing.Point(540, 30), Size = new System.Drawing.Size(70, 23) };
            this.dtNgayKT.Location = new System.Drawing.Point(620, 27); this.dtNgayKT.Size = new System.Drawing.Size(130, 22); this.dtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label() { Text = "Biên bản:", Location = new System.Drawing.Point(30, 70), Size = new System.Drawing.Size(80, 23) };
            this.txtBienBan.Location = new System.Drawing.Point(120, 67); this.txtBienBan.Size = new System.Drawing.Size(400, 22);

            System.Windows.Forms.Label l5 = new System.Windows.Forms.Label() { Text = "Tiền phạt:", Location = new System.Drawing.Point(540, 70), Size = new System.Drawing.Size(70, 23) };
            this.numTienPhat.Location = new System.Drawing.Point(620, 67); this.numTienPhat.Size = new System.Drawing.Size(130, 22); this.numTienPhat.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });

            this.btnLuu.Location = new System.Drawing.Point(490, 110); this.btnLuu.Size = new System.Drawing.Size(120, 40); this.btnLuu.Text = "Lập Biên Bản"; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnDong.Location = new System.Drawing.Point(630, 110); this.btnDong.Size = new System.Drawing.Size(120, 40); this.btnDong.Text = "Đóng"; this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvKiemTra.Location = new System.Drawing.Point(30, 170); this.dgvKiemTra.Size = new System.Drawing.Size(720, 250); this.dgvKiemTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { l1, txtMaKT, l2, cboPhong, l3, dtNgayKT, l4, txtBienBan, l5, numTienPhat, btnLuu, btnDong, dgvKiemTra });
            this.Name = "FrmKiemTra_ViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm Tra Định Kỳ & Xử Lý Vi Phạm";
            this.Load += new System.EventHandler(this.FrmKiemTra_ViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTienPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTra)).EndInit();
            this.ResumeLayout(false);
        }
    }
}