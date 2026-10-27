using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void btnHoSoNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            FrmHopDong frm = new FrmHopDong();
            frm.ShowDialog();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            FrmChamCong frm = new FrmChamCong();
            frm.ShowDialog();
        }

        private void btnPhuTroi_Click(object sender, EventArgs e)
        {
            FrmPhuTroi frm = new FrmPhuTroi();
            frm.ShowDialog();
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            FrmKhenThuong frm = new FrmKhenThuong();
            frm.ShowDialog();
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            FrmBangLuong frm = new FrmBangLuong();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}