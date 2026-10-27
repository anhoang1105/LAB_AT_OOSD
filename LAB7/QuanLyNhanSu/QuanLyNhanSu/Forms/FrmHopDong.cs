using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmHopDong : Form
    {
        private HopDongService hopDongService = new HopDongService();
        private bool isAdding = false;

        public FrmHopDong()
        {
            InitializeComponent();
            this.Load += FrmHopDong_Load;
            dgvHopDong.CellClick += DgvHopDong_CellClick;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
            EnableInputs(false);
        }

        private void LoadComboBox()
        {
            cboNhanVien.DataSource = hopDongService.GetDanhSachNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";

            if (cboLoaiHD.Items.Count > 0) cboLoaiHD.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvHopDong.DataSource = hopDongService.GetDanhSachHopDong();
            if (dgvHopDong.Columns.Count > 0)
            {
                dgvHopDong.Columns["SoHD"].HeaderText = "Số Hợp Đồng";
                dgvHopDong.Columns["HoTen"].HeaderText = "Tên Nhân Viên";
                dgvHopDong.Columns["LoaiHD"].HeaderText = "Loại Hợp Đồng";
                dgvHopDong.Columns["NgayKy"].HeaderText = "Ngày Ký";
                dgvHopDong.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvHopDong.Columns["ThoiHan"].HeaderText = "Thời Hạn (Tháng)";
                dgvHopDong.Columns["MaNV"].Visible = false;
                dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void EnableInputs(bool enable)
        {
            txtSoHD.Enabled = enable && isAdding;
            cboNhanVien.Enabled = enable;
            cboLoaiHD.Enabled = enable;
            dtpNgayKy.Enabled = enable;
            cboTrangThai.Enabled = enable;
            txtThoiHan.Enabled = enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        private void DgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];
                txtSoHD.Text = row.Cells["SoHD"].Value.ToString();
                cboNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cboLoaiHD.Text = row.Cells["LoaiHD"].Value.ToString();

                if (row.Cells["NgayKy"].Value != DBNull.Value) dtpNgayKy.Value = Convert.ToDateTime(row.Cells["NgayKy"].Value);

                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                txtThoiHan.Text = row.Cells["ThoiHan"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            EnableInputs(true);
            txtSoHD.Clear();
            txtThoiHan.Clear();
            txtSoHD.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoHD.Text)) return;
            isAdding = false;
            EnableInputs(true);
            cboNhanVien.Focus();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            EnableInputs(false);
            isAdding = false;
            if (dgvHopDong.CurrentRow != null) DgvHopDong_CellClick(dgvHopDong, new DataGridViewCellEventArgs(0, dgvHopDong.CurrentRow.Index));
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoHD.Text) || cboNhanVien.SelectedValue == null) return;

            int? thoiHan = null;
            if (!string.IsNullOrWhiteSpace(txtThoiHan.Text))
            {
                if (int.TryParse(txtThoiHan.Text.Trim(), out int parsed)) thoiHan = parsed;
                else
                {
                    MessageBox.Show("Thời hạn phải là số hoặc để trống!");
                    return;
                }
            }

            if (isAdding) hopDongService.AddHopDong(txtSoHD.Text.Trim(), cboNhanVien.SelectedValue.ToString(), cboLoaiHD.Text, dtpNgayKy.Value, cboTrangThai.Text, thoiHan);
            else hopDongService.UpdateHopDong(txtSoHD.Text.Trim(), cboNhanVien.SelectedValue.ToString(), cboLoaiHD.Text, dtpNgayKy.Value, cboTrangThai.Text, thoiHan);

            LoadData();
            EnableInputs(false);
            isAdding = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoHD.Text)) return;
            if (MessageBox.Show($"Xóa hợp đồng {txtSoHD.Text}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                hopDongService.DeleteHopDong(txtSoHD.Text);
                LoadData();
                txtSoHD.Clear(); txtThoiHan.Clear();
            }
        }
    }
}