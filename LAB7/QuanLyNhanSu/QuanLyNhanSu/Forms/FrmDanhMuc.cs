using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private DanhMucService danhMucService = new DanhMucService();
        private bool isAdding = false;

        public FrmDanhMuc()
        {
            InitializeComponent();
            this.Load += FrmDanhMuc_Load;
            dgvPhongBan.CellClick += DgvPhongBan_CellClick;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableInputs(false);
        }

        private void LoadData()
        {
            dgvPhongBan.DataSource = danhMucService.GetDanhSachPhongBan();
            if (dgvPhongBan.Columns.Count > 0)
            {
                dgvPhongBan.Columns["MaPB"].HeaderText = "Mã Phòng Ban";
                dgvPhongBan.Columns["TenPhongBan"].HeaderText = "Tên Phòng Ban";
                dgvPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void EnableInputs(bool enable)
        {
            txtMaPB.Enabled = enable && isAdding;
            txtTenPB.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        private void DgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];
                txtMaPB.Text = row.Cells["MaPB"].Value.ToString();
                txtTenPB.Text = row.Cells["TenPhongBan"].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            EnableInputs(true);
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaPB.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPB.Text)) return;
            isAdding = false;
            EnableInputs(true);
            txtTenPB.Focus();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            EnableInputs(false);
            isAdding = false;
            if (dgvPhongBan.CurrentRow != null) DgvPhongBan_CellClick(dgvPhongBan, new DataGridViewCellEventArgs(0, dgvPhongBan.CurrentRow.Index));
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text) || string.IsNullOrWhiteSpace(txtTenPB.Text)) return;
            if (isAdding) danhMucService.AddPhongBan(txtMaPB.Text.Trim(), txtTenPB.Text.Trim());
            else danhMucService.UpdatePhongBan(txtMaPB.Text.Trim(), txtTenPB.Text.Trim());
            LoadData();
            EnableInputs(false);
            isAdding = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPB.Text)) return;
            if (MessageBox.Show($"Xóa phòng ban {txtMaPB.Text}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    danhMucService.DeletePhongBan(txtMaPB.Text);
                    LoadData();
                    txtMaPB.Clear(); txtTenPB.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ràng buộc dữ liệu: " + ex.Message);
                }
            }
        }
    }
}