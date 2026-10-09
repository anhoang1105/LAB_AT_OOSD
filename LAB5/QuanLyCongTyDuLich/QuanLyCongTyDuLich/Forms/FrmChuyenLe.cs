using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmChuyenLe : Form
    {
        private readonly ChuyenLeService svc = new ChuyenLeService();
        private readonly TourService tour = new TourService();

        // Khai báo câu chữ mờ
        private readonly string pMa = "Nhập mã chuyến...";
        private readonly string pDon = "Nhập địa điểm đón...";

        public FrmChuyenLe()
        {
            InitializeComponent();
        }

        private void FrmChuyenLe_Load(object sender, EventArgs e)
        {
            // Kích hoạt chữ mờ
            TaoHieuUngChuMo(txtMa, pMa);
            TaoHieuUngChuMo(txtDon, pDon);

            // Nạp danh sách tour đang mở bán vào ComboBox
            FormHelper.Nap(cboTour, tour.LayTourMoBan(), "HienThi", "MaTour");
            dtDi.Value = DateTime.Today.AddDays(7);

            Tai();
            TinhNgayVe(sender, e);
        }

        // ================= CÁC HÀM XỬ LÝ CHỮ MỜ =================
        private void TaoHieuUngChuMo(TextBox txt, string chuMo)
        {
            txt.Text = chuMo; txt.ForeColor = Color.Gray;
            txt.Enter += (sender, e) => { if (txt.Text == chuMo) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (sender, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = chuMo; txt.ForeColor = Color.Gray; } };
        }

        private string LayText(TextBox txt, string chuMo) { return txt.Text == chuMo ? "" : txt.Text; }
        // =========================================================

        private void Tai() { dgv.DataSource = svc.LayChuyen(); }

        private void TinhNgayVe(object sender, EventArgs e)
        {
            var r = cboTour.SelectedItem as DataRowView;
            lblNgayVe.Text = r == null ? "-" : dtDi.Value.Date.AddDays(Convert.ToInt32(r["SoNgay"]) - 1).ToString("dd/MM/yyyy");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = LayText(txtMa, pMa);
            string don = LayText(txtDon, pDon);

            if (FormHelper.Bao(svc.ThemChuyen(ma, FormHelper.Gia(cboTour), dtDi.Value, don)))
            {
                txtMa.Text = pMa; txtMa.ForeColor = Color.Gray;
                txtDon.Text = pDon; txtDon.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnDongDK_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.DongDangKy(FormHelper.O(dgv, "MaChuyen")))) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}