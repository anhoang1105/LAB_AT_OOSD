using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService svc = new DanhMucService();

        public FrmDanhMuc() { InitializeComponent(); }

        private void FrmDanhMuc_Load(object sender, EventArgs e) { Tai(); }

        private void Tai()
        {
            dgvKhoa.DataSource = svc.LayKhoa();
            dgvBacSi.DataSource = svc.LayBacSi();
            FormHelper.Nap(cboKhoaBS, svc.LayKhoa(), "TenKhoa", "MaKhoa");
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ThemKhoa(txtMaKhoa.Text, txtTenKhoa.Text))) Tai();
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ThemBacSi(txtMaBS.Text, txtTenBS.Text, FormHelper.Gia(cboKhoaBS)))) Tai();
        }
    }
}