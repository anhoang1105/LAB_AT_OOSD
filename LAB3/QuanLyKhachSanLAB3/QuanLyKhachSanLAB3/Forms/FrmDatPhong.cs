using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSanLAB3.Services;

namespace QuanLyKhachSanLAB3.Forms
{
    public partial class FrmDatPhong : Form
    {
        readonly DatPhongService s = new DatPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<PhongDatItem> chon = new BindingList<PhongDatItem>();
        readonly InAnService inAn = new InAnService();
        public FrmDatPhong()
        {
            InitializeComponent();
            // Dùng code để tự động nối sự kiện click vào các lưới:
            dgvKhach.SelectionChanged += dgvKhach_SelectionChanged;
            dgvPhieu.SelectionChanged += dgvPhieu_SelectionChanged;
            dgvCT.SelectionChanged += dgvCT_SelectionChanged;

            if (btnInPhieuTrang != null)
                btnInPhieuTrang.Click += (sender, e) => inAn.InPhieuLuuTru();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            cboKhach.DataSource = s.LayKhach();
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKhach";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            cboKenh.Items.Clear();
            cboKenh.Items.AddRange(new object[] { "Điện thoại", "Website", "Trực tiếp" });
            cboKenh.SelectedIndex = 0;

            dgvChon.DataSource = chon;
            Tai();
        }

        void Tai()
        {
            dgvKhach.DataSource = s.LayKhach();
            dgvPhong.DataSource = s.LayPhong();
            dgvPhieu.DataSource = s.LayPhieuDat();
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        // --- TAB 1: KHÁCH HÀNG ---
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            H(s.ThemKhach(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtCMND.Text.Trim(), txtQT.Text.Trim(), txtSDT.Text.Trim()));
        }

        // Tự động điền dữ liệu khi click vào lưới Khách hàng
        private void dgvKhach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhach.CurrentRow != null)
            {
                txtMaKH.Text = Convert.ToString(dgvKhach.CurrentRow.Cells["MaKhach"].Value);
                txtTenKH.Text = Convert.ToString(dgvKhach.CurrentRow.Cells["HoTen"].Value);
                txtCMND.Text = Convert.ToString(dgvKhach.CurrentRow.Cells["SoCMND"].Value);
                txtQT.Text = Convert.ToString(dgvKhach.CurrentRow.Cells["QuocTich"].Value);
                txtSDT.Text = Convert.ToString(dgvKhach.CurrentRow.Cells["SoDienThoai"].Value);
            }
        }

        // --- TAB 2: ĐẶT PHÒNG ---
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            string p = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);

            foreach (var x in chon)
            {
                if (x.SoPhong == p)
                {
                    MessageBox.Show("Phòng đã có trong phiếu.");
                    return;
                }
            }

            int n = (int)numSoNguoi.Value;
            decimal g = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);
            chon.Add(new PhongDatItem { SoPhong = p, SoNguoi = n, DonGiaNgay = g });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null && dgvChon.CurrentRow.Index >= 0 && dgvChon.CurrentRow.Index < chon.Count)
            {
                chon.RemoveAt(dgvChon.CurrentRow.Index);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            H(s.TaoDatPhong(txtSoPhieu.Text.Trim(), V(cboKhach), V(cboNV), dtLap.Value, dtNhan.Value, dtTra.Value, numCoc.Value, cboKenh.Text, new List<PhongDatItem>(chon)));
            if (chon.Count > 0) chon.Clear();
        }

        // Tự động tải dữ liệu sang Tab 3 khi click chọn phiếu
        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) return;
            string so = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);
            txtPhieuChon.Text = so;
            dgvCT.DataSource = s.LayChiTiet(so);
            dgvNguoi.DataSource = s.LayNguoiLuuTru(so);
        }

        // --- TAB 3: NHẬN PHÒNG / NGƯỜI LƯU TRÚ ---

        // Tự động điền mã phòng khi click vào lưới chi tiết phòng ở Tab 3
        private void dgvCT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCT.CurrentRow != null)
            {
                txtNguoiPhong.Text = Convert.ToString(dgvCT.CurrentRow.Cells["SoPhong"].Value);
            }
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            H(s.ThemNguoiLuuTru(txtPhieuChon.Text.Trim(), txtNguoiPhong.Text.Trim(), txtNguoiTen.Text.Trim(), txtNguoiCMND.Text.Trim(), txtNguoiQT.Text.Trim()));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            H(s.NhanPhong(txtPhieuChon.Text.Trim(), DateTime.Now));
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            H(s.DanhDauNoShow(txtPhieuChon.Text.Trim()));
        }
    }
}