using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmNhanSu_TheXe : Form
    {
        private readonly NhanSuService svc = new NhanSuService();
        public FrmNhanSu_TheXe() { InitializeComponent(); }

        private void FrmNhanSu_TheXe_Load(object sender, EventArgs e)
        {
            FormHelper.Nap(cboPhong, svc.LayPhongDaThue(), "MaPhong", "MaPhong");
            Tai();
        }

        private void Tai()
        {
            dgvNV.DataSource = svc.LayNhanVien();
            dgvTheXe.DataSource = svc.LayTheXe();
            FormHelper.Nap(cboNhanVien, svc.LayNhanVien(), "HienThi", "MaNV");
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ThemNhanVien(txtMaNV.Text, FormHelper.Gia(cboPhong), txtHoTen.Text, txtChucVu.Text, txtCongTy.Text))) Tai();
        }

        private void btnCapThe_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.CapTheXe(txtMaThe.Text, FormHelper.Gia(cboNhanVien), txtBienSo.Text, txtLoaiXe.Text))) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}