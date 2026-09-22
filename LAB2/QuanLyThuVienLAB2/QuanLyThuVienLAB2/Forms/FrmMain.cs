using System;
using System.Windows.Forms;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            using (FrmTaiLieu f = new FrmTaiLieu()) f.ShowDialog(this);
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            using (FrmNguoiDung f = new FrmNguoiDung()) f.ShowDialog(this);
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            using (FrmMuonTra f = new FrmMuonTra()) f.ShowDialog(this);
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            using (FrmYeuCauDatMua f = new FrmYeuCauDatMua()) f.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (FrmThongKe f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}