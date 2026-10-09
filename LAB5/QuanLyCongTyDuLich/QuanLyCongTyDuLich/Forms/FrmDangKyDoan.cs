using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmDangKyDoan : Form
    {
        private readonly DangKyDoanService svc = new DangKyDoanService();
        private readonly BindingList<ThanhVienDoanItem> thanhVien = new BindingList<ThanhVienDoanItem>();

        // Khai báo câu chữ mờ
        private readonly string pMaDoan = "Nhập mã đoàn...";
        private readonly string pTenCQ = "Nhập tên cơ quan/gia đình...";
        private readonly string pDiaChi = "Nhập địa chỉ...";
        private readonly string pDT = "Nhập số ĐT...";
        private readonly string pDaiDien = "Nhập người đại diện...";
        private readonly string pSoPhieu = "Nhập số phiếu...";
        private readonly string pDon = "Nhập địa điểm đón...";

        public FrmDangKyDoan()
        {
            InitializeComponent();
        }

        private void FrmDangKyDoan_Load(object sender, EventArgs e)
        {
            TaoHieuUngChuMo(txtMaDoan, pMaDoan);
            TaoHieuUngChuMo(txtTenCQ, pTenCQ);
            TaoHieuUngChuMo(txtDiaChi, pDiaChi);
            TaoHieuUngChuMo(txtDT, pDT);
            TaoHieuUngChuMo(txtDaiDien, pDaiDien);
            TaoHieuUngChuMo(txtSo, pSoPhieu);
            TaoHieuUngChuMo(txtDon, pDon);

            FormHelper.Nap(cboTour, new TourService().LayTourMoBan(), "HienThi", "MaTour");
            dtDi.Value = DateTime.Today.AddDays(14); // Mặc định ngày đi cách 2 tuần

            dgvThanhVien.DataSource = thanhVien;
            Tai();
            TinhTong(sender, e);
            chkBH_CheckedChanged(sender, e);
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

        private void TinhTong(object sender, EventArgs e)
        {
            var r = cboTour.SelectedItem as DataRowView;
            if (r == null) { lblTong.Text = "0 đ"; lblKetThuc.Text = "-"; return; }
            lblTong.Text = (Convert.ToDecimal(r["DonGiaKhach"]) * numNguoi.Value).ToString("N0") + " đ";
            lblKetThuc.Text = dtDi.Value.Date.AddDays(Convert.ToInt32(r["SoNgay"]) - 1).ToString("dd/MM/yyyy");
        }

        private void chkBH_CheckedChanged(object sender, EventArgs e)
        {
            // Chỉ bật lưới nhập thành viên nếu đoàn mua bảo hiểm
            dgvThanhVien.Enabled = chkBH.Checked;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            dgvThanhVien.EndEdit();
            var ds = thanhVien.Where(x => x != null && !string.IsNullOrWhiteSpace(x.HoTen)).ToList();

            var k = svc.DangKy(
                LayText(txtSo, pSoPhieu), LayText(txtMaDoan, pMaDoan), LayText(txtTenCQ, pTenCQ),
                LayText(txtDiaChi, pDiaChi), LayText(txtDT, pDT), LayText(txtDaiDien, pDaiDien),
                FormHelper.Gia(cboTour), dtDi.Value, (int)numNguoi.Value, LayText(txtDon, pDon),
                chkBH.Checked, numCoc.Value, ds);

            if (FormHelper.Bao(k))
            {
                thanhVien.Clear();
                txtSo.Text = pSoPhieu; txtSo.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string so = FormHelper.O(dgv, "SoDKDoan");
            if (so == "") { MessageBox.Show("Chọn phiếu đăng ký đoàn cần hủy."); return; }
            if (MessageBox.Show("Đoàn không đi sẽ mất tiền cọc. Hủy phiếu " + so + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            if (FormHelper.Bao(svc.HuyDangKy(so))) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}