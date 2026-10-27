using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangLuong : Form
    {
        private BangLuongService srv = new BangLuongService();
        private bool isAdding = false;

        public FrmBangLuong()
        {
            InitializeComponent();
            this.Load += (s, e) => { cboNV.DataSource = srv.GetNhanVien(); cboNV.DisplayMember = "HoTen"; cboNV.ValueMember = "MaNV"; LoadData(); EnableInputs(false); };
            dgvData.CellClick += CellClick;
            btnThem.Click += (s, e) => { isAdding = true; EnableInputs(true); txtMa.Clear(); txtThuNhap.Clear(); txtKhauTru.Clear(); txtThang.Clear(); txtNam.Clear(); txtMa.Focus(); };
            btnSua.Click += (s, e) => { if (!string.IsNullOrEmpty(txtMa.Text)) { isAdding = false; EnableInputs(true); } };
            btnHuy.Click += (s, e) => { EnableInputs(false); isAdding = false; if (dgvData.CurrentRow != null) CellClick(null, new DataGridViewCellEventArgs(0, dgvData.CurrentRow.Index)); };
            btnThoat.Click += (s, e) => this.Close();
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        private void LoadData() { dgvData.DataSource = srv.GetDanhSach(); dgvData.Columns["MaNV"].Visible = false; dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; }
        private void EnableInputs(bool e) { txtMa.Enabled = e && isAdding; cboNV.Enabled = txtThang.Enabled = txtNam.Enabled = txtThuNhap.Enabled = txtKhauTru.Enabled = btnLuu.Enabled = btnHuy.Enabled = e; btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !e; }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var r = dgvData.Rows[e.RowIndex];
                txtMa.Text = r.Cells["MaBL"].Value.ToString();
                cboNV.SelectedValue = r.Cells["MaNV"].Value.ToString();
                txtThang.Text = r.Cells["Thang"].Value.ToString();
                txtNam.Text = r.Cells["Nam"].Value.ToString();
                txtThuNhap.Text = r.Cells["TongThuNhap"].Value.ToString();
                txtKhauTru.Text = r.Cells["TongKhauTru"].Value.ToString();
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text)) return;
            srv.Save(txtMa.Text, cboNV.SelectedValue.ToString(), int.Parse(txtThang.Text), int.Parse(txtNam.Text), decimal.Parse(txtThuNhap.Text), decimal.Parse(txtKhauTru.Text), isAdding);
            LoadData(); EnableInputs(false); isAdding = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text)) return;
            if (MessageBox.Show("Xóa bảng lương này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) { srv.Delete(txtMa.Text); LoadData(); }
        }
    }
}