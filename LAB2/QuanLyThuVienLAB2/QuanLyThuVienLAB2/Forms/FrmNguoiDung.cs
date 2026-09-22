using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienLab2.Services;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmNguoiDung : Form
    {
        private readonly NguoiDungService service = new NguoiDungService();

        public FrmNguoiDung()
        {
            InitializeComponent();

            // TỰ ĐỘNG NỐI SỰ KIỆN
            this.Load += FrmNguoiDung_Load;

            if (dgvNguoiDung != null) dgvNguoiDung.SelectionChanged += dgvNguoiDung_SelectionChanged;

            if (btnThem != null) btnThem.Click += btnThem_Click;
            if (btnCapNhat != null) btnCapNhat.Click += btnCapNhat_Click;
            if (btnXoa != null) btnXoa.Click += btnXoa_Click;
            if (btnLamMoi != null) btnLamMoi.Click += btnLamMoi_Click;
            if (btnDong != null) btnDong.Click += btnDong_Click;
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định
            if (cboTrangThai.Items.Count == 0)
            {
                cboTrangThai.Items.Add("Hoạt động");
                cboTrangThai.Items.Add("Bị khóa");
            }
            cboTrangThai.SelectedIndex = 0;

            dtNgayCap.Value = DateTime.Today;
            dtHanSuDung.Value = DateTime.Today.AddYears(4); // Mặc định thẻ hạn 4 năm

            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu()
        {
            dgvNguoiDung.DataSource = service.LayDanhSachDocGia();

            // Tùy chỉnh ẩn hiện cột cho đẹp
            if (dgvNguoiDung.Columns["MatKhau"] != null) dgvNguoiDung.Columns["MatKhau"].Visible = false;

            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Lấy thông tin từ 2 bảng trên Form
        private (NguoiDung, TheThuVien) LayDuLieuForm()
        {
            NguoiDung nd = new NguoiDung
            {
                MaNguoiDung = string.IsNullOrWhiteSpace(txtMaND.Text) ? 0 : Convert.ToInt32(txtMaND.Text),
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                TenDangNhap = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text
            };

            TheThuVien the = new TheThuVien
            {
                MaThe = txtMaThe.Text,
                NgayCap = dtNgayCap.Value,
                HanSuDung = dtHanSuDung.Value,
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };

            return (nd, the);
        }

        private void HienThongBao(KetQuaXuLy kq)
        {
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDuLieu();
                LamMoi();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var data = LayDuLieuForm();
            HienThongBao(service.Luu(data.Item1, data.Item2, false));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaND.Text)) return;
            var data = LayDuLieuForm();
            HienThongBao(service.Luu(data.Item1, data.Item2, true));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaND.Text)) return;
            if (MessageBox.Show("Xóa độc giả và thẻ thư viện này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HienThongBao(service.Xoa(Convert.ToInt32(txtMaND.Text), txtMaThe.Text));
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LamMoi()
        {
            txtMaND.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtMaThe.Clear();

            dtNgayCap.Value = DateTime.Today;
            dtHanSuDung.Value = DateTime.Today.AddYears(4);
            cboTrangThai.SelectedIndex = 0;

            txtMaThe.ReadOnly = false; // Mở lại để nhập mã thẻ mới
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;

            txtHoTen.Focus();
        }

        private void dgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguoiDung.CurrentRow == null || dgvNguoiDung.CurrentRow.DataBoundItem == null) return;

            DataRowView row = dgvNguoiDung.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;

            txtMaND.Text = row["MaNguoiDung"].ToString();
            txtHoTen.Text = row["HoTen"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtTaiKhoan.Text = row["TenDangNhap"].ToString();
            txtMatKhau.Text = row["MatKhau"].ToString();

            txtMaThe.Text = row["MaThe"].ToString();
            if (row["NgayCap"] != DBNull.Value) dtNgayCap.Value = Convert.ToDateTime(row["NgayCap"]);
            if (row["HanSuDung"] != DBNull.Value) dtHanSuDung.Value = Convert.ToDateTime(row["HanSuDung"]);
            cboTrangThai.SelectedItem = row["TrangThai"].ToString();

            // Khóa mã thẻ và nút Thêm khi đang chọn dữ liệu cũ
            txtMaThe.ReadOnly = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}