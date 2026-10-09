using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmDangKyLe : Form
    {
        private readonly DangKyLeService svc = new DangKyLeService();

        // Khai báo chữ mờ (Placeholder)
        private readonly string pSo = "Nhập số ĐK...";
        private readonly string pTen = "Nhập tên người đăng ký...";
        private readonly string pDT = "Nhập số ĐT...";

        public FrmDangKyLe()
        {
            InitializeComponent();
        }

        private void FrmDangKyLe_Load(object sender, EventArgs e)
        {
            TaoHieuUngChuMo(txtSo, pSo);
            TaoHieuUngChuMo(txtTen, pTen);
            TaoHieuUngChuMo(txtDT, pDT);

            // Nạp dữ liệu các chuyến đang mở và các điểm bán vé
            FormHelper.Nap(cboChuyen, new ChuyenLeService().LayChuyenMo(), "HienThi", "MaChuyen");
            FormHelper.Nap(cboDiemBan, new DanhMucService().LayDiemBan(), "TenDiemBan", "MaDiemBan");

            Tai();
            TinhTien(sender, e);
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

        private void Tai() { dgv.DataSource = svc.LayDanhSach(); }

        private void TinhTien(object sender, EventArgs e)
        {
            var r = cboChuyen.SelectedItem as DataRowView;
            lblThanhTien.Text = r == null ? "0 đ" : (Convert.ToDecimal(r["DonGiaKhach"]) * numNguoi.Value).ToString("N0") + " đ";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string so = LayText(txtSo, pSo);
            string ten = LayText(txtTen, pTen);
            string dt = LayText(txtDT, pDT);

            if (FormHelper.Bao(svc.DangKy(so, FormHelper.Gia(cboChuyen), FormHelper.Gia(cboDiemBan), ten, dt, (int)numNguoi.Value)))
            {
                txtSo.Text = pSo; txtSo.ForeColor = Color.Gray;
                txtTen.Text = pTen; txtTen.ForeColor = Color.Gray;
                txtDT.Text = pDT; txtDT.ForeColor = Color.Gray;
                numNguoi.Value = 1;
                Tai();
            }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}