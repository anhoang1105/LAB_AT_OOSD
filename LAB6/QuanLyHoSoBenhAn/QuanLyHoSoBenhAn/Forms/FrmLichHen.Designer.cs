namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLichHen
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBenhNhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayHen = new System.Windows.Forms.DateTimePicker();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Text = "Mã lịch hẹn:";

            this.txtMaLichHen.Location = new System.Drawing.Point(110, 20);
            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtMaLichHen.Size = new System.Drawing.Size(200, 20);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Text = "Bệnh nhân:";

            this.cboBenhNhan.FormattingEnabled = true;
            this.cboBenhNhan.Location = new System.Drawing.Point(110, 60);
            this.cboBenhNhan.Name = "cboBenhNhan";
            this.cboBenhNhan.Size = new System.Drawing.Size(200, 21);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Text = "Ngày giờ hẹn:";

            this.dtNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayHen.Location = new System.Drawing.Point(110, 100);
            this.dtNgayHen.Name = "dtNgayHen";
            this.dtNgayHen.Size = new System.Drawing.Size(200, 20);

            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.Location = new System.Drawing.Point(340, 20);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(130, 100);
            this.btnDatLich.Text = "ĐẶT LỊCH ĐỊNH KỲ (Miễn phí)";
            this.btnDatLich.UseVisualStyleBackColor = true;

            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Location = new System.Drawing.Point(20, 150);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.Size = new System.Drawing.Size(450, 200);

            this.ClientSize = new System.Drawing.Size(490, 371);
            this.Controls.Add(this.dgvLichHen);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.dtNgayHen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBenhNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLichHen);
            this.Controls.Add(this.label1);
            this.Name = "FrmLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Lịch Khám Định Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayHen;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DataGridView dgvLichHen;
    }
}