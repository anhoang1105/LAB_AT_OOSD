using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhuTroi : Form
    {
        private PhuTroiService srv = new PhuTroiService();
        private bool isAdding = false;

        public FrmPhuTroi()
        {
            InitializeComponent();
            this.Load += (s, e) => { cboNV.DataSource = srv.GetNhanVien(); cboNV.DisplayMember = "HoTen"; cboNV.ValueMember = "MaNV"; LoadData(); EnableInputs(false); };
            dgvData.CellClick += CellClick;
            btnThem.Click += (s, e) => { isAdding = true; EnableInputs(true); txtSoPhieu.Clear(); txtHinhThuc.Clear(); txtGio.Clear(); txtSoPhieu.Focus(); };
            btnSua.Click += (s, e) => { if (!string.IsNullOrEmpty(txtSoPhieu.Text)) { isAdding = false; EnableInputs(true); } };
            btnHuy.Click += (s, e) => { EnableInputs(false); isAdding = false; if (dgvData.CurrentRow != null) CellClick(null, new DataGridViewCellEventArgs(0, dgvData.CurrentRow.Index)); };
            btnThoat.Click += (s, e) => this.Close();
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        private void LoadData() { dgvData.DataSource = srv.GetDanhSach(); dgvData.Columns["MaNV"].Visible = false; dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; }
        private void EnableInputs(bool e) { txtSoPhieu.Enabled = e && isAdding; cboNV.Enabled = txtHinhThuc.Enabled = txtGio.Enabled = dtpNgay.Enabled = btnLuu.Enabled = btnHuy.Enabled = e; btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !e; }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                var r = dgvData.Rows[e.RowIndex];
                txtSoPhieu.Text = r.Cells["SoPhieuPT"].Value.ToString();
                cboNV.SelectedValue = r.Cells["MaNV"].Value.ToString();
                if (r.Cells["NgayPhuTroi"].Value != DBNull.Value) dtpNgay.Value = Convert.ToDateTime(r.Cells["NgayPhuTroi"].Value);
                txtHinhThuc.Text = r.Cells["HinhThuc"].Value.ToString();
                txtGio.Text = r.Cells["SoGio"].Value.ToString();
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text) || cboNV.SelectedValue == null) return;
            srv.Save(txtSoPhieu.Text, cboNV.SelectedValue.ToString(), dtpNgay.Value, txtHinhThuc.Text, decimal.Parse(txtGio.Text), isAdding);
            LoadData(); EnableInputs(false); isAdding = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;
            if (MessageBox.Show("Xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) { srv.Delete(txtSoPhieu.Text, cboNV.SelectedValue.ToString()); LoadData(); }
        }
    }
}