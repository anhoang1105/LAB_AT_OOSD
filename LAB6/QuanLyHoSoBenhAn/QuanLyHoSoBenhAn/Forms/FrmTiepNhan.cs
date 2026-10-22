using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmTiepNhan : Form
    {
        private readonly TiepNhanService svc = new TiepNhanService();

        public FrmTiepNhan() { InitializeComponent(); }

        private void FrmTiepNhan_Load(object sender, EventArgs e) { Tai(); }

        private void Tai() { dgvBenhNhan.DataSource = svc.LayDanhSachBenhNhan(); }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var kq = svc.DangKyVaCapHoSo(txtMaBN.Text, txtHoTen.Text, txtDiaChi.Text, dtNgaySinh.Value,
                                         txtDienThoai.Text, txtMaPhieuDK.Text, txtMaHoSo.Text, chkLePhi.Checked);
            if (FormHelper.Bao(kq)) Tai();
        }
    }
}