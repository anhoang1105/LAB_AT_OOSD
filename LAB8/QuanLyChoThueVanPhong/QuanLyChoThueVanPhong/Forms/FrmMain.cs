using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Mo(Form f) { using (f) f.ShowDialog(this); }

        private void btnMatBang_Click(object sender, EventArgs e) { Mo(new FrmMatBang_Phong()); }
        private void btnKhachHang_Click(object sender, EventArgs e) { Mo(new FrmKhachHang()); }
        private void btnHopDong_Click(object sender, EventArgs e) { Mo(new FrmHopDongThue()); }
        private void btnGiaHan_Click(object sender, EventArgs e) { Mo(new FrmGiaHan()); }
        private void btnChiSoDV_Click(object sender, EventArgs e) { Mo(new FrmChiSoDichVu()); }
        private void btnHoaDon_Click(object sender, EventArgs e) { Mo(new FrmHoaDon_ThuTien()); }
        private void btnNhanSu_Click(object sender, EventArgs e) { Mo(new FrmNhanSu_TheXe()); }
        private void btnKiemTra_Click(object sender, EventArgs e) { Mo(new FrmKiemTra_ViPham()); }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}