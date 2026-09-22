using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienLab2.Services;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmMuonTra : Form
    {
        private readonly MuonTraService service = new MuonTraService();
        private DataTable dtGioHang;

        public FrmMuonTra()
        {
            InitializeComponent();

            this.Load += FrmMuonTra_Load;

            if (dgvDangMuon != null) dgvDangMuon.SelectionChanged += dgvDangMuon_SelectionChanged;
            if (btnChonSach != null) btnChonSach.Click += btnChonSach_Click;
            if (btnBoSach != null) btnBoSach.Click += btnBoSach_Click;
            if (btnLapPhieu != null) btnLapPhieu.Click += btnLapPhieu_Click;

            if (cboDocGiaTra != null) cboDocGiaTra.SelectedIndexChanged += cboDocGiaTra_SelectedIndexChanged;
            if (btnTaiSachDangMuon != null) btnTaiSachDangMuon.Click += btnTaiSachDangMuon_Click;
            if (dtNgayTraThucTe != null) dtNgayTraThucTe.ValueChanged += dtNgayTraThucTe_ValueChanged;
            if (btnXacNhanTra != null) btnXacNhanTra.Click += btnXacNhanTra_Click;
            if (btnDong != null) btnDong.Click += btnDong_Click;
        }

        private void FrmMuonTra_Load(object sender, EventArgs e)
        {
            var dtDocGia = service.LayComboDocGia();
            if (cboDocGia != null)
            {
                cboDocGia.DataSource = dtDocGia.Copy();
                cboDocGia.DisplayMember = "HoTen";
                cboDocGia.ValueMember = "MaNguoiDung";
            }

            if (cboDocGiaTra != null)
            {
                cboDocGiaTra.DataSource = dtDocGia.Copy();
                cboDocGiaTra.DisplayMember = "HoTen";
                cboDocGiaTra.ValueMember = "MaNguoiDung";
            }

            if (cboNhanVien != null)
            {
                cboNhanVien.DataSource = service.LayComboThuThu();
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNguoiDung";
            }

            if (dtNgayMuon != null) dtNgayMuon.Value = DateTime.Today;
            if (dtHanSuDung != null) dtHanSuDung.Value = DateTime.Today.AddDays(14);
            if (dtNgayTraThucTe != null) dtNgayTraThucTe.Value = DateTime.Today;

            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaTaiLieu", typeof(int));
            dtGioHang.Columns.Add("TuaSach", typeof(string));
            dtGioHang.Columns.Add("TacGia", typeof(string));

            if (dgvSachChon != null) dgvSachChon.DataSource = dtGioHang;

            TaiSachConTrongKho();

            if (cboDocGiaTra != null && cboDocGiaTra.SelectedValue != null)
            {
                if (int.TryParse(cboDocGiaTra.SelectedValue.ToString(), out int maND))
                {
                    TaiDanhSachDangMuon(maND);
                }
            }
        }

        private void TaiSachConTrongKho()
        {
            if (dgvSachCon != null)
            {
                dgvSachCon.DataSource = service.LaySachConTrongKho();
                dgvSachCon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            if (dgvSachCon == null || dgvSachCon.CurrentRow == null || dgvSachCon.CurrentRow.DataBoundItem == null) return;
            DataRowView row = dgvSachCon.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;

            int maTL = Convert.ToInt32(row["MaTaiLieu"]);

            foreach (DataRow r in dtGioHang.Rows)
            {
                if (Convert.ToInt32(r["MaTaiLieu"]) == maTL)
                {
                    MessageBox.Show("Sách này đã có trong danh sách chọn mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dtGioHang.Rows.Add(maTL, row["TuaSach"].ToString(), row["TacGia"].ToString());
        }

        private void btnBoSach_Click(object sender, EventArgs e)
        {
            if (dgvSachChon != null && dgvSachChon.CurrentRow != null)
            {
                dgvSachChon.Rows.Remove(dgvSachChon.CurrentRow);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (cboDocGia == null || cboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sách để lập phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(cboDocGia.SelectedValue.ToString(), out int maND);
            DateTime ngayMuon = dtNgayMuon != null ? dtNgayMuon.Value : DateTime.Today;
            DateTime hanTra = dtHanSuDung != null ? dtHanSuDung.Value : DateTime.Today.AddDays(14);

            foreach (DataRow r in dtGioHang.Rows)
            {
                int maTL = Convert.ToInt32(r["MaTaiLieu"]);
                KetQuaXuLy kq = service.LapPhieuMuon(maND, maTL, ngayMuon, hanTra);

                if (!kq.ThanhCong)
                {
                    MessageBox.Show(kq.ThongBao, "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Lập phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtGioHang.Rows.Clear();
            TaiSachConTrongKho();
        }

        private void cboDocGiaTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrichXuatSachDangMuonTheoDocGia();
        }

        private void btnTaiSachDangMuon_Click(object sender, EventArgs e)
        {
            TrichXuatSachDangMuonTheoDocGia();
        }

        private void TrichXuatSachDangMuonTheoDocGia()
        {
            if (cboDocGiaTra != null && cboDocGiaTra.SelectedValue != null)
            {
                if (int.TryParse(cboDocGiaTra.SelectedValue.ToString(), out int maND))
                {
                    TaiDanhSachDangMuon(maND);
                }
            }
        }

        private void TaiDanhSachDangMuon(int maND)
        {
            if (dgvDangMuon != null)
            {
                dgvDangMuon.DataSource = service.LayDanhSachDangMuon(maND);
                dgvDangMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TinhVaHienThiTienPhat();
            }
        }

        private void dgvDangMuon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDangMuon == null || dgvDangMuon.CurrentRow == null || dgvDangMuon.CurrentRow.DataBoundItem == null) return;
            DataRowView row = dgvDangMuon.CurrentRow.DataBoundItem as DataRowView;
            if (row != null && row["HanTra"] != DBNull.Value && dtNgayTraThucTe != null)
            {
                DateTime hanTra = Convert.ToDateTime(row["HanTra"]);
                // FIX: Tránh lỗi dữ liệu mẫu năm cũ bị đẩy tiền phạt lên hàng triệu,
                // ta đồng bộ ngày trả thực tế bằng đúng hạn trả (0đ) hoặc bạn có thể tự chọn ngày trên giao diện.
                if (dtNgayTraThucTe.Value < hanTra)
                {
                    dtNgayTraThucTe.Value = hanTra;
                }
            }
            TinhVaHienThiTienPhat();
        }

        private void dtNgayTraThucTe_ValueChanged(object sender, EventArgs e)
        {
            TinhVaHienThiTienPhat();
        }

        private void TinhVaHienThiTienPhat()
        {
            if (dgvDangMuon == null || dgvDangMuon.CurrentRow == null || dgvDangMuon.CurrentRow.DataBoundItem == null)
            {
                if (txtTienPhat != null) txtTienPhat.Text = "0 VNĐ";
                return;
            }

            DataRowView row = dgvDangMuon.CurrentRow.DataBoundItem as DataRowView;
            if (row != null && row["HanTra"] != DBNull.Value && dtNgayTraThucTe != null)
            {
                DateTime hanTra = Convert.ToDateTime(row["HanTra"]);
                int tienPhat = service.TinhTienPhat(hanTra, dtNgayTraThucTe.Value);
                if (txtTienPhat != null) txtTienPhat.Text = tienPhat.ToString("N0") + " VNĐ";
            }
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            if (dgvDangMuon == null || dgvDangMuon.CurrentRow == null || dgvDangMuon.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn dòng sách cần trả trên lưới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView row = dgvDangMuon.CurrentRow.DataBoundItem as DataRowView;
            if (row == null) return;

            int maPhieu = Convert.ToInt32(row["MaPhieu"]);
            int maTL = Convert.ToInt32(row["MaTaiLieu"]);
            DateTime hanTra = Convert.ToDateTime(row["HanTra"]);
            DateTime ngayTra = dtNgayTraThucTe != null ? dtNgayTraThucTe.Value : DateTime.Today;

            KetQuaXuLy kq = service.TraSach(maPhieu, maTL, hanTra, ngayTra);
            MessageBox.Show(kq.ThongBao, kq.ThanhCong ? "Thông báo" : "Lỗi", MessageBoxButtons.OK, kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TrichXuatSachDangMuonTheoDocGia();
                TaiSachConTrongKho();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}