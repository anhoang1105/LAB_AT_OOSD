using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHoaDon_ThuTien : Form
    {
        private readonly HoaDonService svc = new HoaDonService();

        public FrmHoaDon_ThuTien() { InitializeComponent(); }

        private void FrmHoaDon_ThuTien_Load(object sender, EventArgs e) { Tai(); }

        private void Tai()
        {
            dgvTienPhong.DataSource = svc.LayHoaDonPhong();
            dgvTienDV.DataSource = svc.LayHoaDonDichVu();
        }

        private void btnThuTienPhong_Click(object sender, EventArgs e)
        {
            string ma = FormHelper.O(dgvTienPhong, "MaHDP");
            if (FormHelper.Bao(svc.ThuTienPhong(ma))) Tai();
        }

        private void btnThuTienDV_Click(object sender, EventArgs e)
        {
            string maDV = FormHelper.O(dgvTienDV, "MaDV");
            string maPhong = FormHelper.O(dgvTienDV, "MaPhong");
            string thangNam = FormHelper.O(dgvTienDV, "ThangNam");
            if (FormHelper.Bao(svc.ThuTienDichVu(maDV, maPhong, thangNam))) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}