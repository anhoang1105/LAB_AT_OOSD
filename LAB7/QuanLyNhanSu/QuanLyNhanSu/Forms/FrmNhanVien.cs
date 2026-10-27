using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienService nhanVienService = new NhanVienService();
        private bool isAdding = false;

        public FrmNhanVien()
        {
            InitializeComponent();

            // Gán sự kiện
            this.Load += FrmNhanVien_Load;
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
            EnableInputs(false);
        }

        private void LoadComboBox()
        {
            cboPhongBan.DataSource = nhanVienService.GetDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPB";
        }

        private void LoadData()
        {
            dgvNhanVien.DataSource = nhanVienService.GetDanhSachNhanVien();
            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvNhanVien.Columns["TenPhongBan"].HeaderText = "Phòng Ban";
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện Thoại";
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
                dgvNhanVien.Columns["MaPB"].Visible = false;

                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void EnableInputs(bool enable)
        {
            txtMaNV.Enabled = enable && isAdding;
            txtHoTen.Enabled = enable;
            cboPhongBan.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtDienThoai.Enabled = enable;
            dtpNgayVaoLam.Enabled = enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                cboPhongBan.SelectedValue = row.Cells["MaPB"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            EnableInputs(true);
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtMaNV.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            EnableInputs(true);
            txtHoTen.Focus();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            EnableInputs(false);
            isAdding = false;
            if (dgvNhanVien.CurrentRow != null) DgvNhanVien_CellClick(dgvNhanVien, new DataGridViewCellEventArgs(0, dgvNhanVien.CurrentRow.Index));
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã NV và Họ tên không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isAdding)
                {
                    nhanVienService.AddNhanVien(txtMaNV.Text.Trim(), cboPhongBan.SelectedValue.ToString(),
                                                txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(),
                                                txtDienThoai.Text.Trim(), dtpNgayVaoLam.Value);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nhanVienService.UpdateNhanVien(txtMaNV.Text.Trim(), cboPhongBan.SelectedValue.ToString(),
                                                   txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(),
                                                   txtDienThoai.Text.Trim(), dtpNgayVaoLam.Value);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
                EnableInputs(false);
                isAdding = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thao tác cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {txtHoTen.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    nhanVienService.DeleteNhanVien(txtMaNV.Text);
                    LoadData();
                    txtMaNV.Clear(); txtHoTen.Clear(); txtDiaChi.Clear(); txtDienThoai.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa nhân viên này do đang có dữ liệu liên quan (Hợp đồng, Bảng lương...)\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}