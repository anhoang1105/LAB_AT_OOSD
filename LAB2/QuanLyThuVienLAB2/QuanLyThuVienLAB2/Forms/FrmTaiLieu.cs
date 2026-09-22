using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienLab2.Services;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmTaiLieu : Form
    {
        private readonly TaiLieuService service = new TaiLieuService();

        public FrmTaiLieu()
        {
            InitializeComponent();

            // TỰ ĐỘNG NỐI SỰ KIỆN TẠI ĐÂY (Không cần chỉnh trong bảng Properties)
            this.Load += FrmTaiLieu_Load;

            // Nối sự kiện cho lưới
            if (dgvTaiLieu != null) dgvTaiLieu.SelectionChanged += dgvTaiLieu_SelectionChanged;

            // Nối sự kiện cho các nút bấm
            if (btnThem != null) btnThem.Click += btnThem_Click;
            if (btnCapNhat != null) btnCapNhat.Click += btnCapNhat_Click;
            if (btnXoa != null) btnXoa.Click += btnXoa_Click;
            if (btnLamMoi != null) btnLamMoi.Click += btnLamMoi_Click;
            if (btnTim != null) btnTim.Click += btnTim_Click;
            if (btnDong != null) btnDong.Click += btnDong_Click;
        }

        private void FrmTaiLieu_Load(object sender, EventArgs e)
        {
            // Tải danh mục Chủ đề vào ComboBox
            cboChuDe.DataSource = service.LayDanhSachChuDe();
            cboChuDe.DisplayMember = "TenChuDe";
            cboChuDe.ValueMember = "MaChuDe";

            // Nếu ComboBox Loại Tài liệu chưa có dữ liệu, dùng code thêm cứng vào
            if (cboLoaiTaiLieu.Items.Count == 0)
            {
                cboLoaiTaiLieu.Items.Add("Bản cứng");
                cboLoaiTaiLieu.Items.Add("Điện tử");
            }
            cboLoaiTaiLieu.SelectedIndex = 0;

            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu(string tuKhoa = "")
        {
            dgvTaiLieu.DataSource = service.LayDanhSachTaiLieu(tuKhoa);

            // Ẩn cột ID Chủ đề
            if (dgvTaiLieu.Columns["MaChuDe"] != null)
                dgvTaiLieu.Columns["MaChuDe"].Visible = false;

            dgvTaiLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private TaiLieu LayDuLieuForm()
        {
            return new TaiLieu
            {
                MaTaiLieu = string.IsNullOrWhiteSpace(txtMa.Text) ? 0 : Convert.ToInt32(txtMa.Text),
                TuaSach = txtTuaSach.Text,
                TacGia = txtTacGia.Text,
                NamXuatBan = (int)numNamXB.Value,
                MaChuDe = Convert.ToInt32(cboChuDe.SelectedValue),
                LoaiTaiLieu = cboLoaiTaiLieu.SelectedItem.ToString(),
                SoLuong = (int)numSoLuong.Value,
                DuongDanFile = txtDuongDan.Text
            };
        }

        private void HienThongBao(KetQuaXuLy kq)
        {
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDuLieu(txtTim.Text); // Tải lại lưới giữ nguyên từ khóa đang tìm
                LamMoi();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HienThongBao(service.Luu(LayDuLieuForm(), false));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text)) return;
            HienThongBao(service.Luu(LayDuLieuForm(), true));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text)) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa tài liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HienThongBao(service.Xoa(Convert.ToInt32(txtMa.Text)));
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TaiDuLieu(txtTim.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LamMoi()
        {
            txtMa.Clear();
            txtTuaSach.Clear();
            txtTacGia.Clear();
            txtDuongDan.Clear();
            numNamXB.Value = DateTime.Today.Year;
            numSoLuong.Value = 0;

            // Trạng thái nút bấm bảo vệ dữ liệu
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;

            txtTuaSach.Focus();
        }

        private void dgvTaiLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiLieu.CurrentRow == null || dgvTaiLieu.CurrentRow.DataBoundItem == null) return;

            DataRowView row = dgvTaiLieu.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;

            txtMa.Text = row["MaTaiLieu"].ToString();
            txtTuaSach.Text = row["TuaSach"].ToString();
            txtTacGia.Text = row["TacGia"].ToString();

            // Parse cẩn thận để tránh lỗi
            if (decimal.TryParse(row["NamXuatBan"].ToString(), out decimal namXB)) numNamXB.Value = namXB;
            if (decimal.TryParse(row["SoLuong"].ToString(), out decimal soLuong)) numSoLuong.Value = soLuong;

            cboChuDe.SelectedValue = row["MaChuDe"];
            cboLoaiTaiLieu.SelectedItem = row["LoaiTaiLieu"].ToString();
            txtDuongDan.Text = row["DuongDanFile"].ToString();

            // Khóa nút Thêm khi đang chọn dữ liệu cũ
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}