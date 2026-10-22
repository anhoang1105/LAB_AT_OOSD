using System;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }

        private void Mo(Form f) { using (f) f.ShowDialog(this); }

        private void btnDanhMuc_Click(object sender, EventArgs e) => Mo(new FrmDanhMuc());
        private void btnTiepNhan_Click(object sender, EventArgs e) => Mo(new FrmTiepNhan());
        private void btnKhamBenh_Click(object sender, EventArgs e) => Mo(new FrmKhamBenh());

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
        }
    }
}