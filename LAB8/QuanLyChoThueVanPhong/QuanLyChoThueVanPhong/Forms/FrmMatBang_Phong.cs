using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMatBang_Phong : Form
    {
        private readonly MatBangService svc = new MatBangService();

        public FrmMatBang_Phong()
        {
            InitializeComponent();
        }

        private void FrmMatBang_Phong_Load(object sender, EventArgs e)
        {
            // Đổ danh sách Tầng vào ComboBox, và đổ dữ liệu lưới
            FormHelper.Nap(cboTang, svc.LayTang(), "TenTang", "MaTang");
            Tai();
        }

        private void Tai()
        {
            dgvPhong.DataSource = svc.LayPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra validate logic nằm ở Service, Form chỉ hiển thị thông báo
            if (FormHelper.Bao(svc.ThemPhong(txtMaPhong.Text, FormHelper.Gia(cboTang), numDienTich.Value, txtHuong.Text, numGiaCoSo.Value)))
            {
                Tai(); // Nếu thêm thành công thì load lại DataGridView
            }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}