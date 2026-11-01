using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKhachHang : Form
    {
        private readonly KhachHangService svc = new KhachHangService();

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            Tai();
        }

        private void Tai()
        {
            dgvKhachHang.DataSource = svc.LayDanhSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.LuuKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text)))
            {
                Tai();
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtDienThoai.Clear();
                txtMaKH.Focus();
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = FormHelper.O(dgvKhachHang, "MaKH");
            txtTenKH.Text = FormHelper.O(dgvKhachHang, "TenKhachHang");
            txtDiaChi.Text = FormHelper.O(dgvKhachHang, "DiaChi");
            txtDienThoai.Text = FormHelper.O(dgvKhachHang, "DienThoai");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}