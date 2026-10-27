using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKhenThuong : Form
    {
        private KhenThuongService srv = new KhenThuongService();
        private bool isAdding = false;

        public FrmKhenThuong()
        {
            InitializeComponent();
            this.Load += (s, e) => { cboNV.DataSource = srv.GetNhanVien(); cboNV.DisplayMember = "HoTen"; cboNV.ValueMember = "MaNV"; if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0; LoadData(); EnableInputs(false); };
            dgvData.CellClick += CellClick;
            btnThem.Click += (s, e) => { isAdding = true; EnableInputs(true); txtSo.Clear(); txtTien.Clear(); txtSo.Focus(); };
            btnSua.Click += (s, e) => { if (!string.IsNullOrEmpty(txtSo.Text)) { isAdding = false; EnableInputs(true); } };
            btnHuy.Click += (s, e) => { EnableInputs(false); isAdding = false; if (dgvData.CurrentRow != null) CellClick(null, new DataGridViewCellEventArgs(0, dgvData.CurrentRow.Index)); };
            btnThoat.Click += (s, e) => this.Close();
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        private void LoadData() { dgvData.DataSource = srv.GetDanhSach(); dgvData.Columns["MaNV"].Visible = false; dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; }
        private void EnableInputs(bool e) { txtSo.Enabled = e && isAdding; cboNV.Enabled = cboLoai.Enabled = txtTien.Enabled = dtpNgay.Enabled = btnLuu.Enabled = btnHuy.Enabled = e; btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !e; }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var r = dgvData.Rows[e.RowIndex];
                txtSo.Text = r.Cells["SoQDKTKL"].Value.ToString();
                cboNV.SelectedValue = r.Cells["MaNV"].Value.ToString();
                cboLoai.Text = r.Cells["LoaiQD"].Value.ToString();
                txtTien.Text = r.Cells["SoTien"].Value.ToString();
                if (r.Cells["NgayKy"].Value != DBNull.Value) dtpNgay.Value = Convert.ToDateTime(r.Cells["NgayKy"].Value);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text)) return;
            if (isAdding) srv.Add(txtSo.Text, cboNV.SelectedValue.ToString(), cboLoai.Text, decimal.Parse(txtTien.Text), dtpNgay.Value);
            else srv.Update(txtSo.Text, cboNV.SelectedValue.ToString(), cboLoai.Text, decimal.Parse(txtTien.Text), dtpNgay.Value);
            LoadData(); EnableInputs(false); isAdding = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text)) return;
            if (MessageBox.Show("Xóa quyết định này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) { srv.Delete(txtSo.Text); LoadData(); }
        }
    }
}