using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmChiSoDichVu : Form
    {
        private readonly DichVuService svc = new DichVuService();

        public FrmChiSoDichVu() { InitializeComponent(); }

        private void FrmChiSoDichVu_Load(object sender, EventArgs e)
        {
            txtThangNam.Text = DateTime.Today.ToString("MM/yyyy");
            FormHelper.Nap(cboPhong, svc.LayPhongDangThue(), "MaPhong", "MaPhong");
            FormHelper.Nap(cboDichVu, svc.LayDichVu(), "HienThi", "MaDV");
            Tai();
        }

        private void Tai() { dgvChiSo.DataSource = svc.LayDanhSachChiSo(); }

        private void btnChotChiSo_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ChotChiSo(FormHelper.Gia(cboDichVu), FormHelper.Gia(cboPhong), txtThangNam.Text, (int)numChiSoDau.Value, (int)numChiSoCuoi.Value)))
            {
                Tai();
            }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}