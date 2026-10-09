using System;
using System.Drawing; // Bắt buộc phải có để dùng Color.Gray và Color.Black
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmTour : Form
    {
        private readonly TourService svc = new TourService();
        private readonly DanhMucService dm = new DanhMucService();

        // 1. Khai báo các câu chữ mờ (Placeholder)
        private readonly string pMa = "Nhập mã tour...";
        private readonly string pTen = "Nhập tên tour...";
        private readonly string pMoTa = "Nhập mô tả...";
        private readonly string pDiemDung = "Nhập tên điểm dừng...";
        private readonly string pGhiChuDD = "Nhập ghi chú điểm dừng...";
        private readonly string pGhiChuPT = "Nhập ghi chú phương tiện...";

        public FrmTour()
        {
            InitializeComponent();
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {
            // Gắn hiệu ứng chữ mờ cho các ô TextBox
            TaoHieuUngChuMo(txtMa, pMa);
            TaoHieuUngChuMo(txtTen, pTen);
            TaoHieuUngChuMo(txtMoTa, pMoTa);
            TaoHieuUngChuMo(txtDiemDung, pDiemDung);
            TaoHieuUngChuMo(txtGhiChuDD, pGhiChuDD);
            TaoHieuUngChuMo(txtGhiChuPT, pGhiChuPT);

            // Nạp dữ liệu vào ComboBox Phương tiện và Điểm TQ từ DanhMucService
            FormHelper.Nap(cboPT, dm.LayPhuongTien(), "TenPT", "MaPT");
            FormHelper.Nap(cboDTQ, dm.LayDiemThamQuan(), "TenDiemTQ", "MaDiemTQ");
            TaiTour();
        }

        // =========================================================
        // CÁC HÀM XỬ LÝ GIAO DIỆN CHỮ MỜ (PLACEHOLDER)
        // =========================================================

        private void TaoHieuUngChuMo(TextBox txt, string chuMo)
        {
            // Thiết lập trạng thái ban đầu khi vừa mở Form
            txt.Text = chuMo;
            txt.ForeColor = Color.Gray;

            // Khi click chuột vào ô để gõ (Xóa chữ mờ)
            txt.Enter += (sender, e) =>
            {
                if (txt.Text == chuMo)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            // Khi click chuột sang chỗ khác (Hiện lại chữ mờ nếu để trống)
            txt.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = chuMo;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // Hàm này cực kỳ quan trọng: Nếu ô đang chứa chữ mờ thì trả về rỗng "", ngăn lưu nhầm vào CSDL
        private string LayText(TextBox txt, string chuMo)
        {
            return txt.Text == chuMo ? "" : txt.Text;
        }

        // =========================================================

        private void TaiTour()
        {
            dgvTour.DataSource = svc.LayTour();
            FormHelper.Nap(cboTour, svc.LayTour(), "TenTour", "MaTour");
            TaiChiTiet();
        }

        private void TaiChiTiet()
        {
            string ma = FormHelper.Gia(cboTour);
            dgvDiemDung.DataSource = svc.LayDiemDung(ma);
            dgvChang.DataSource = svc.LayChang(ma);
            dgvTQ.DataSource = svc.LayDiemTQTour(ma);
        }

        private void cboTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTour.ValueMember == "MaTour") TaiChiTiet();
        }

        private void chkKS_CheckedChanged(object sender, EventArgs e)
        {
            numSao.Enabled = chkKS.Checked;
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            // Dùng hàm LayText() thay vì lấy txt.Text trực tiếp
            string ma = LayText(txtMa, pMa);
            string ten = LayText(txtTen, pTen);
            string moTa = LayText(txtMoTa, pMoTa);

            if (FormHelper.Bao(svc.ThemTour(ma, ten, (int)numNgay.Value, (int)numDem.Value, numGia.Value, moTa)))
            {
                // Thành công thì reset lại chữ mờ cho đẹp
                txtMa.Text = pMa; txtMa.ForeColor = Color.Gray;
                txtTen.Text = pTen; txtTen.ForeColor = Color.Gray;
                txtMoTa.Text = pMoTa; txtMoTa.ForeColor = Color.Gray;
                TaiTour();
            }
        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            string ten = LayText(txtDiemDung, pDiemDung);
            string ghiChu = LayText(txtGhiChuDD, pGhiChuDD);

            if (FormHelper.Bao(svc.ThemDiemDung(FormHelper.Gia(cboTour), (int)numThuTu.Value, ten, chkDoiPT.Checked, chkAn.Checked,
                chkKS.Checked, (int)numSao.Value, ghiChu)))
            {
                txtDiemDung.Text = pDiemDung; txtDiemDung.ForeColor = Color.Gray;
                txtGhiChuDD.Text = pGhiChuDD; txtGhiChuDD.ForeColor = Color.Gray;
                TaiChiTiet();
            }
        }

        private void btnThemChang_Click(object sender, EventArgs e)
        {
            string ghiChu = LayText(txtGhiChuPT, pGhiChuPT);

            if (FormHelper.Bao(svc.ThemChang(FormHelper.Gia(cboTour), (int)numChang.Value, FormHelper.Gia(cboPT), ghiChu)))
            {
                txtGhiChuPT.Text = pGhiChuPT; txtGhiChuPT.ForeColor = Color.Gray;
                TaiChiTiet();
            }
        }

        private void btnThemTQ_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ThemDiemTQTour(FormHelper.Gia(cboTour), FormHelper.Gia(cboDTQ), (int)numThuTuTQ.Value))) TaiChiTiet();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}