using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKiemTra_ViPham : Form
    {
        private readonly KiemTraService svc = new KiemTraService();

        public FrmKiemTra_ViPham()
        {
            InitializeComponent();
        }

        private void FrmKiemTra_ViPham_Load(object sender, EventArgs e)
        {
            FormHelper.Nap(cboPhong, svc.LayPhong(), "MaPhong", "MaPhong");
            Tai();
        }

        private void Tai()
        {
            dgvKiemTra.DataSource = svc.LayDanhSachKiemTra();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.LapBienBan(txtMaKT.Text, FormHelper.Gia(cboPhong), dtNgayKT.Value, txtBienBan.Text, numTienPhat.Value)))
            {
                Tai(); // Nạp lại lưới sau khi lưu thành công
                txtMaKT.Clear();
                txtBienBan.Clear();
                numTienPhat.Value = 0;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}