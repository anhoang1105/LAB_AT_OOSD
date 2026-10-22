namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabPageKhoa = new System.Windows.Forms.TabPage();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBacSi = new System.Windows.Forms.TabPage();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.btnThemBS = new System.Windows.Forms.Button();
            this.cboKhoaBS = new System.Windows.Forms.ComboBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDanhMuc.SuspendLayout();
            this.tabPageKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.tabPageBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.tabPageKhoa);
            this.tabDanhMuc.Controls.Add(this.tabPageBacSi);
            this.tabDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(912, 551);
            this.tabDanhMuc.TabIndex = 0;
            // 
            // tabPageKhoa
            // 
            this.tabPageKhoa.Controls.Add(this.dgvKhoa);
            this.tabPageKhoa.Controls.Add(this.btnThemKhoa);
            this.tabPageKhoa.Controls.Add(this.txtTenKhoa);
            this.tabPageKhoa.Controls.Add(this.txtMaKhoa);
            this.tabPageKhoa.Controls.Add(this.label2);
            this.tabPageKhoa.Controls.Add(this.label1);
            this.tabPageKhoa.Location = new System.Drawing.Point(4, 22);
            this.tabPageKhoa.Name = "tabPageKhoa";
            this.tabPageKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhoa.Size = new System.Drawing.Size(904, 525);
            this.tabPageKhoa.TabIndex = 0;
            this.tabPageKhoa.Text = "Khoa Điều Trị";
            this.tabPageKhoa.UseVisualStyleBackColor = true;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(8, 100);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Size = new System.Drawing.Size(890, 417);
            this.dgvKhoa.TabIndex = 0;
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(260, 15);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(100, 50);
            this.btnThemKhoa.TabIndex = 1;
            this.btnThemKhoa.Text = "Thêm Khoa";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(80, 45);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(150, 20);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(80, 15);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(150, 20);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khoa:";
            // 
            // tabPageBacSi
            // 
            this.tabPageBacSi.Controls.Add(this.dgvBacSi);
            this.tabPageBacSi.Controls.Add(this.btnThemBS);
            this.tabPageBacSi.Controls.Add(this.cboKhoaBS);
            this.tabPageBacSi.Controls.Add(this.txtTenBS);
            this.tabPageBacSi.Controls.Add(this.txtMaBS);
            this.tabPageBacSi.Controls.Add(this.label5);
            this.tabPageBacSi.Controls.Add(this.label4);
            this.tabPageBacSi.Controls.Add(this.label3);
            this.tabPageBacSi.Location = new System.Drawing.Point(4, 22);
            this.tabPageBacSi.Name = "tabPageBacSi";
            this.tabPageBacSi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBacSi.Size = new System.Drawing.Size(576, 335);
            this.tabPageBacSi.TabIndex = 1;
            this.tabPageBacSi.Text = "Bác Sĩ";
            this.tabPageBacSi.UseVisualStyleBackColor = true;
            // 
            // dgvBacSi
            // 
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.Location = new System.Drawing.Point(8, 100);
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.Size = new System.Drawing.Size(560, 227);
            this.dgvBacSi.TabIndex = 0;
            // 
            // btnThemBS
            // 
            this.btnThemBS.Location = new System.Drawing.Point(260, 15);
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Size = new System.Drawing.Size(100, 75);
            this.btnThemBS.TabIndex = 1;
            this.btnThemBS.Text = "Thêm Bác Sĩ";
            this.btnThemBS.UseVisualStyleBackColor = true;
            this.btnThemBS.Click += new System.EventHandler(this.btnThemBS_Click);
            // 
            // cboKhoaBS
            // 
            this.cboKhoaBS.FormattingEnabled = true;
            this.cboKhoaBS.Location = new System.Drawing.Point(80, 70);
            this.cboKhoaBS.Name = "cboKhoaBS";
            this.cboKhoaBS.Size = new System.Drawing.Size(150, 21);
            this.cboKhoaBS.TabIndex = 2;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(80, 42);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(150, 20);
            this.txtTenBS.TabIndex = 3;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(80, 15);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(150, 20);
            this.txtMaBS.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên BS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã BS:";
            // 
            // FrmDanhMuc
            // 
            this.ClientSize = new System.Drawing.Size(912, 551);
            this.Controls.Add(this.tabDanhMuc);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabDanhMuc.ResumeLayout(false);
            this.tabPageKhoa.ResumeLayout(false);
            this.tabPageKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.tabPageBacSi.ResumeLayout(false);
            this.tabPageBacSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabPageKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageBacSi;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.Button btnThemBS;
        private System.Windows.Forms.ComboBox cboKhoaBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}