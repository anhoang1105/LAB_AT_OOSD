using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienLab2.Services;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmYeuCauDatMua : Form
    {
        private readonly YeuCauDatMuaService service = new YeuCauDatMuaService();
        private readonly MuonTraService muonTraService = new MuonTraService();

        public FrmYeuCauDatMua()
        {
            InitializeComponent();

            this.Load += FrmYeuCauDatMua_Load;
            if (dgvYeuCau != null) dgvYeuCau.SelectionChanged += dgvYeuCau_SelectionChanged;

            // Bắt sự kiện khi người dùng chọn sách từ danh sách gợi ý
            if (cboTenSach != null) cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;

            if (btnThem != null) btnThem.Click += btnThem_Click;
            if (btnDuyet != null) btnDuyet.Click += btnDuyet_Click;
            if (btnXoa != null) btnXoa.Click += btnXoa_Click;
            if (btnLamMoi != null) btnLamMoi.Click += btnLamMoi_Click;
            if (btnDong != null) btnDong.Click += btnDong_Click;
        }

        private void FrmYeuCauDatMua_Load(object sender, EventArgs e)
        {
            // 1. Đổ dữ liệu Độc giả
            if (cboDocGia != null)
            {
                cboDocGia.DataSource = muonTraService.LayComboDocGia();
                cboDocGia.DisplayMember = "HoTen";
                cboDocGia.ValueMember = "MaNguoiDung";
            }

            // 2. Đổ dữ liệu Gợi ý Tên Sách vào ComboBox cboTenSach
            if (cboTenSach != null)
            {
                cboTenSach.DataSource = service.LayDanhSachGoiYSach();
                cboTenSach.DisplayMember = "TuaSach";
                cboTenSach.ValueMember = "TuaSach"; // Chọn hay nhập tự do đều lấy Tên sách
                cboTenSach.SelectedIndex = -1;      // Để trống lúc ban đầu
            }

            // 3. Đổ dữ liệu Trạng thái
            if (cboTrangThaiDuyet != null && cboTrangThaiDuyet.Items.Count == 0)
            {
                cboTrangThaiDuyet.Items.Add("Chờ duyệt");
                cboTrangThaiDuyet.Items.Add("Chấp nhận");
                cboTrangThaiDuyet.Items.Add("Từ chối");
            }
            if (cboTrangThaiDuyet != null) cboTrangThaiDuyet.SelectedIndex = 0;

            if (numNamXB != null) numNamXB.Value = DateTime.Today.Year;

            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu()
        {
            if (dgvYeuCau != null)
            {
                dgvYeuCau.DataSource = service.LayDanhSachYeuCau();
                if (dgvYeuCau.Columns["MaNguoiDung"] != null)
                    dgvYeuCau.Columns["MaNguoiDung"].Visible = false;
                dgvYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // --- TÍNH NĂNG BONUS: TỰ ĐỘNG ĐIỀN TÁC GIẢ & NĂM XUẤT BẢN ---
        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSach != null && cboTenSach.SelectedIndex >= 0)
            {
                DataRowView row = cboTenSach.SelectedItem as DataRowView;
                if (row != null)
                {
                    if (txtTacGia != null) txtTacGia.Text = row["TacGia"].ToString();
                    if (numNamXB != null && decimal.TryParse(row["NamXuatBan"].ToString(), out decimal nam))
                        numNamXB.Value = nam;
                }
            }
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
            if (cboDocGia == null || cboDocGia.SelectedValue == null) return;
            int maND = Convert.ToInt32(cboDocGia.SelectedValue);

            // Dùng cboTenSach.Text để lấy giá trị (dù là chọn trong list hay gõ tay từ mới)
            string tenSach = cboTenSach != null ? cboTenSach.Text : "";
            string tacGia = txtTacGia != null ? txtTacGia.Text : "";
            int namXB = numNamXB != null ? (int)numNamXB.Value : DateTime.Today.Year;
            string trangThai = cboTrangThaiDuyet != null ? cboTrangThaiDuyet.SelectedItem.ToString() : "Chờ duyệt";

            HienThongBao(service.Luu(0, maND, tenSach, tacGia, namXB, trangThai, false));
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (txtMaYeuCau == null || string.IsNullOrWhiteSpace(txtMaYeuCau.Text)) return;
            int maYC = Convert.ToInt32(txtMaYeuCau.Text);
            int maND = Convert.ToInt32(cboDocGia.SelectedValue);
            string tenSach = cboTenSach.Text; // Lấy Text từ ComboBox
            string tacGia = txtTacGia.Text;
            int namXB = (int)numNamXB.Value;
            string trangThai = cboTrangThaiDuyet.SelectedItem.ToString();

            HienThongBao(service.Luu(maYC, maND, tenSach, tacGia, namXB, trangThai, true));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaYeuCau == null || string.IsNullOrWhiteSpace(txtMaYeuCau.Text)) return;
            if (MessageBox.Show("Xóa yêu cầu đặt mua này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HienThongBao(service.Xoa(Convert.ToInt32(txtMaYeuCau.Text)));
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
            if (txtMaYeuCau != null) txtMaYeuCau.Clear();
            if (cboTenSach != null) { cboTenSach.SelectedIndex = -1; cboTenSach.Text = ""; } // Xóa trắng ô gõ
            if (txtTacGia != null) txtTacGia.Clear();
            if (numNamXB != null) numNamXB.Value = DateTime.Today.Year;
            if (cboTrangThaiDuyet != null && cboTrangThaiDuyet.Items.Count > 0) cboTrangThaiDuyet.SelectedIndex = 0;

            if (btnThem != null) btnThem.Enabled = true;
            if (btnDuyet != null) btnDuyet.Enabled = false;
            if (btnXoa != null) btnXoa.Enabled = false;
            if (cboTenSach != null) cboTenSach.Focus();
        }

        private void dgvYeuCau_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvYeuCau == null || dgvYeuCau.CurrentRow == null || dgvYeuCau.CurrentRow.DataBoundItem == null) return;
            DataRowView row = dgvYeuCau.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;

            if (txtMaYeuCau != null) txtMaYeuCau.Text = row["MaYeuCau"].ToString();
            if (cboDocGia != null && row["MaNguoiDung"] != DBNull.Value)
                cboDocGia.SelectedValue = row["MaNguoiDung"];

            // Load tên sách lên ComboBox (kể cả sách đó ko có trong list gợi ý nó vẫn hiển thị Text bình thường)
            if (cboTenSach != null) cboTenSach.Text = row["TenSach"].ToString();

            if (txtTacGia != null) txtTacGia.Text = row["TacGia"].ToString();
            if (numNamXB != null && decimal.TryParse(row["NamXuatBan"].ToString(), out decimal nam))
                numNamXB.Value = nam;
            if (cboTrangThaiDuyet != null)
                cboTrangThaiDuyet.SelectedItem = row["TrangThaiDuyet"].ToString();

            if (btnThem != null) btnThem.Enabled = false;
            if (btnDuyet != null) btnDuyet.Enabled = true;
            if (btnXoa != null) btnXoa.Enabled = true;
        }
    }
}