using System;
using System.Windows.Forms;
using QuanLyKhachSanLAB3.Services;

namespace QuanLyKhachSanLAB3.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
            // Dùng code để tự động nối sự kiện click vào lưới, không cần bấm tia sét:
            dgvKhu.SelectionChanged += dgvKhu_SelectionChanged;
            dgvNV.SelectionChanged += dgvNV_SelectionChanged;
            dgvLoaiTN.SelectionChanged += dgvLoaiTN_SelectionChanged;
            dgvDV.SelectionChanged += dgvDV_SelectionChanged;
            dgvQD.SelectionChanged += dgvQD_SelectionChanged;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            Tai();
        }

        void Tai()
        {
            dgvKhu.DataSource = s.LayKhuVuc();
            dgvNV.DataSource = s.LayNhanVien();
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            dgvDV.DataSource = s.LayDichVu();
            dgvQD.DataSource = s.LayQuyDinhDenBu();

            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            H(s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim()));
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            H(s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim()));
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            H(s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(), txtDVDVT.Text.Trim(), numDVGia.Value));
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string loai = cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString();
            H(s.ThemQuyDinh(txtQDMa.Text.Trim(), loai, txtQDMucDo.Text.Trim(), numQDTien.Value));
        }

        private void dgvKhu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhu.CurrentRow != null)
            {
                txtKhuMa.Text = Convert.ToString(dgvKhu.CurrentRow.Cells["MaKhuVuc"].Value);
                txtKhuTen.Text = Convert.ToString(dgvKhu.CurrentRow.Cells["TenKhuVuc"].Value);
            }
        }

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.CurrentRow != null)
            {
                txtNVMa.Text = Convert.ToString(dgvNV.CurrentRow.Cells["MaNV"].Value);
                txtNVTen.Text = Convert.ToString(dgvNV.CurrentRow.Cells["HoTen"].Value);
                txtNVVaiTro.Text = Convert.ToString(dgvNV.CurrentRow.Cells["VaiTro"].Value);
                txtNVSDT.Text = Convert.ToString(dgvNV.CurrentRow.Cells["SoDienThoai"].Value);
            }
        }

        private void dgvLoaiTN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiTN.CurrentRow != null)
            {
                txtLoaiMa.Text = Convert.ToString(dgvLoaiTN.CurrentRow.Cells["MaLoaiTN"].Value);
                txtLoaiTen.Text = Convert.ToString(dgvLoaiTN.CurrentRow.Cells["TenLoaiTN"].Value);
            }
        }

        private void dgvDV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDV.CurrentRow != null)
            {
                txtDVMa.Text = Convert.ToString(dgvDV.CurrentRow.Cells["MaDV"].Value);
                txtDVTen.Text = Convert.ToString(dgvDV.CurrentRow.Cells["TenDV"].Value);
                txtDVDVT.Text = Convert.ToString(dgvDV.CurrentRow.Cells["DonViTinh"].Value);
                numDVGia.Value = Convert.ToDecimal(dgvDV.CurrentRow.Cells["DonGia"].Value);
            }
        }

        private void dgvQD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQD.CurrentRow != null)
            {
                txtQDMa.Text = Convert.ToString(dgvQD.CurrentRow.Cells["MaQuyDinh"].Value);
                cboQDLoai.SelectedValue = Convert.ToString(dgvQD.CurrentRow.Cells["MaLoaiTN"].Value);
                txtQDMucDo.Text = Convert.ToString(dgvQD.CurrentRow.Cells["MucDoThietHai"].Value);
                numQDTien.Value = Convert.ToDecimal(dgvQD.CurrentRow.Cells["MucDenBu"].Value);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}