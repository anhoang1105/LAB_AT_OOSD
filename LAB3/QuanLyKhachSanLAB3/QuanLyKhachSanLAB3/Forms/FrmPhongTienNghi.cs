using System;
using System.Windows.Forms;
using QuanLyKhachSanLAB3.Services;

namespace QuanLyKhachSanLAB3.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        readonly PhongTienNghiService s = new PhongTienNghiService();
        readonly DanhMucService dm = new DanhMucService();
        readonly InAnService inAn = new InAnService();
        public FrmPhongTienNghi()
        {
            InitializeComponent();
            // Dùng code để tự động nối sự kiện:
            dgvPhong.SelectionChanged += dgvPhong_SelectionChanged;
            dgvTN.SelectionChanged += dgvTN_SelectionChanged;
            if (btnInPhieuTrang != null)
                btnInPhieuTrang.Click += (sender, e) => inAn.InPhieuLapDat();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            cboKhu.DataSource = dm.LayKhuVuc();
            cboKhu.DisplayMember = "TenKhuVuc";
            cboKhu.ValueMember = "MaKhuVuc";

            cboLoai.DataSource = dm.LayLoaiTienNghi();
            cboLoai.DisplayMember = "TenLoaiTN";
            cboLoai.ValueMember = "MaLoaiTN";

            cboTN.DataSource = s.LayTienNghi();
            cboTN.DisplayMember = "MaTienNghi";
            cboTN.ValueMember = "MaTienNghi";

            cboPhong.DataSource = s.LayPhong();
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "SoPhong";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            Tai();
        }

        void Tai()
        {
            dgvPhong.DataSource = s.LayPhong();
            dgvTN.DataSource = s.LayTienNghi();
            dgvLD.DataSource = s.LayLapDat();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        // --- CÁC HÀM THÊM DỮ LIỆU ---
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            H(s.ThemPhong(txtPhong.Text.Trim(), V(cboKhu), (int)numMax.Value, numGia.Value));
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            H(s.ThemTienNghi(txtMaTN.Text.Trim(), V(cboLoai), (int)numSTT.Value, txtTinhTrang.Text.Trim()));
        }

        private void btnLapDat_Click(object sender, EventArgs e)
        {
            H(s.LapDat(txtSoLD.Text.Trim(), V(cboTN), V(cboPhong), dtNgay.Value, txtTTLD.Text.Trim(), V(cboNV), txtGhiChu.Text.Trim()));
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow != null)
            {
                txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
                cboKhu.SelectedValue = Convert.ToString(dgvPhong.CurrentRow.Cells["MaKhuVuc"].Value);
                numMax.Value = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["SoNguoiToiDa"].Value);
                numGia.Value = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);
            }
        }

        private void dgvTN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTN.CurrentRow != null)
            {
                txtMaTN.Text = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
                cboLoai.SelectedValue = Convert.ToString(dgvTN.CurrentRow.Cells["MaLoaiTN"].Value);
                numSTT.Value = Convert.ToDecimal(dgvTN.CurrentRow.Cells["SoThuTu"].Value);
                txtTinhTrang.Text = Convert.ToString(dgvTN.CurrentRow.Cells["TinhTrangHienTai"].Value);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}