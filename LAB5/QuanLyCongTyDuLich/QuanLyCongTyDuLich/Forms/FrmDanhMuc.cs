using System;
using System.Drawing; // Dùng để đổi màu chữ Gray/Black
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService svc = new DanhMucService();

        // 1. Khai báo các câu chữ mờ (Placeholder) cho cả 4 Tab
        // Tab Phương tiện
        private readonly string pPTMa = "Nhập mã PT...";
        private readonly string pPTTen = "Nhập tên PT...";
        private readonly string pPTGhiChu = "Nhập ghi chú...";

        // Tab Điểm bán vé
        private readonly string pDBMa = "Nhập mã điểm bán...";
        private readonly string pDBTen = "Nhập tên điểm bán...";
        private readonly string pDBDiaChi = "Nhập địa chỉ...";
        private readonly string pDBDT = "Nhập số điện thoại...";

        // Tab Hướng dẫn viên
        private readonly string pHDVMa = "Nhập mã HDV...";
        private readonly string pHDVTen = "Nhập tên HDV...";
        private readonly string pHDVDT = "Nhập số điện thoại...";

        // Tab Điểm tham quan
        private readonly string pDTQMa = "Nhập mã điểm TQ...";
        private readonly string pDTQTen = "Nhập tên điểm TQ...";
        private readonly string pDTQDiaDiem = "Nhập địa điểm...";
        private readonly string pDTQNoiDung = "Nhập nội dung...";
        private readonly string pDTQYNghia = "Nhập ý nghĩa...";

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            // Gọi hàm tạo hiệu ứng cho tất cả TextBox trên form
            TaoHieuUngChuMo(txtPTMa, pPTMa);
            TaoHieuUngChuMo(txtPTTen, pPTTen);
            TaoHieuUngChuMo(txtPTGhiChu, pPTGhiChu);

            TaoHieuUngChuMo(txtDBMa, pDBMa);
            TaoHieuUngChuMo(txtDBTen, pDBTen);
            TaoHieuUngChuMo(txtDBDiaChi, pDBDiaChi);
            TaoHieuUngChuMo(txtDBDT, pDBDT);

            TaoHieuUngChuMo(txtHDVMa, pHDVMa);
            TaoHieuUngChuMo(txtHDVTen, pHDVTen);
            TaoHieuUngChuMo(txtHDVDT, pHDVDT);

            TaoHieuUngChuMo(txtDTQMa, pDTQMa);
            TaoHieuUngChuMo(txtDTQTen, pDTQTen);
            TaoHieuUngChuMo(txtDTQDiaDiem, pDTQDiaDiem);
            TaoHieuUngChuMo(txtDTQNoiDung, pDTQNoiDung);
            TaoHieuUngChuMo(txtDTQYNghia, pDTQYNghia);

            Tai();
        }

        // =========================================================
        // CÁC HÀM XỬ LÝ GIAO DIỆN CHỮ MỜ (PLACEHOLDER)
        // =========================================================

        private void TaoHieuUngChuMo(TextBox txt, string chuMo)
        {
            txt.Text = chuMo;
            txt.ForeColor = Color.Gray;

            txt.Enter += (sender, e) =>
            {
                if (txt.Text == chuMo)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = chuMo;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private string LayText(TextBox txt, string chuMo)
        {
            return txt.Text == chuMo ? "" : txt.Text;
        }

        // =========================================================

        private void Tai()
        {
            dgvPT.DataSource = svc.LayPhuongTien();
            dgvDB.DataSource = svc.LayDiemBan();
            dgvHDV.DataSource = svc.LayHDV();
            dgvDTQ.DataSource = svc.LayDiemThamQuan();
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            string ma = LayText(txtPTMa, pPTMa);
            string ten = LayText(txtPTTen, pPTTen);
            string ghiChu = LayText(txtPTGhiChu, pPTGhiChu);

            if (FormHelper.Bao(svc.ThemPhuongTien(ma, ten, ghiChu)))
            {
                // Reset giao diện sau khi thêm thành công
                txtPTMa.Text = pPTMa; txtPTMa.ForeColor = Color.Gray;
                txtPTTen.Text = pPTTen; txtPTTen.ForeColor = Color.Gray;
                txtPTGhiChu.Text = pPTGhiChu; txtPTGhiChu.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            string ma = LayText(txtDBMa, pDBMa);
            string ten = LayText(txtDBTen, pDBTen);
            string diaChi = LayText(txtDBDiaChi, pDBDiaChi);
            string dienThoai = LayText(txtDBDT, pDBDT);

            if (FormHelper.Bao(svc.ThemDiemBan(ma, ten, diaChi, dienThoai)))
            {
                txtDBMa.Text = pDBMa; txtDBMa.ForeColor = Color.Gray;
                txtDBTen.Text = pDBTen; txtDBTen.ForeColor = Color.Gray;
                txtDBDiaChi.Text = pDBDiaChi; txtDBDiaChi.ForeColor = Color.Gray;
                txtDBDT.Text = pDBDT; txtDBDT.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnThemHDV_Click(object sender, EventArgs e)
        {
            string ma = LayText(txtHDVMa, pHDVMa);
            string ten = LayText(txtHDVTen, pHDVTen);
            string dienThoai = LayText(txtHDVDT, pHDVDT);

            if (FormHelper.Bao(svc.ThemHDV(ma, ten, dienThoai, numLuong.Value)))
            {
                txtHDVMa.Text = pHDVMa; txtHDVMa.ForeColor = Color.Gray;
                txtHDVTen.Text = pHDVTen; txtHDVTen.ForeColor = Color.Gray;
                txtHDVDT.Text = pHDVDT; txtHDVDT.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnThemDTQ_Click(object sender, EventArgs e)
        {
            string ma = LayText(txtDTQMa, pDTQMa);
            string ten = LayText(txtDTQTen, pDTQTen);
            string diaDiem = LayText(txtDTQDiaDiem, pDTQDiaDiem);
            string noiDung = LayText(txtDTQNoiDung, pDTQNoiDung);
            string yNghia = LayText(txtDTQYNghia, pDTQYNghia);

            if (FormHelper.Bao(svc.ThemDiemThamQuan(ma, ten, diaDiem, noiDung, yNghia)))
            {
                txtDTQMa.Text = pDTQMa; txtDTQMa.ForeColor = Color.Gray;
                txtDTQTen.Text = pDTQTen; txtDTQTen.ForeColor = Color.Gray;
                txtDTQDiaDiem.Text = pDTQDiaDiem; txtDTQDiaDiem.ForeColor = Color.Gray;
                txtDTQNoiDung.Text = pDTQNoiDung; txtDTQNoiDung.ForeColor = Color.Gray;
                txtDTQYNghia.Text = pDTQYNghia; txtDTQYNghia.ForeColor = Color.Gray;
                Tai();
            }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}