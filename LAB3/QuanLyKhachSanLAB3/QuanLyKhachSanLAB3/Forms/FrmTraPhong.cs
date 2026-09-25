using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSanLAB3.Services;

namespace QuanLyKhachSanLAB3.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        readonly InAnService inAn = new InAnService();

        public FrmTraPhong()
        {
            InitializeComponent();

            // TỰ ĐỘNG NỐI SỰ KIỆN: Không cần thao tác ở giao diện Design
            this.Load += FrmTraPhong_Load;
            cboPhieu.SelectedIndexChanged += cboPhieu_SelectedIndexChanged;
            dtNgayTra.ValueChanged += TinhToan;
            numPhuThu.ValueChanged += TinhToan;
            btnThanhToan.Click += btnThanhToan_Click;

            if (btnDong != null)
                btnDong.Click += (sender, e) => Close();
            if (btnInPhieuTrang != null)
                btnInPhieuTrang.Click += (sender, e) => inAn.InHoaDonTrang();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            TaiPhieu();

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";
        }

        void TaiPhieu()
        {
            var dt = s.LayPhieuDangO();
            cboPhieu.DataSource = dt;
            cboPhieu.DisplayMember = "SoPhieuDat";
            cboPhieu.ValueMember = "SoPhieuDat";
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        // Tự động load Tên khách và Bảng chi tiết khi chọn phiếu
        private void cboPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhieu.SelectedItem is DataRowView r)
            {
                txtKhach.Text = Convert.ToString(r["HoTen"]);
                dgvChiTiet.DataSource = s.LayDanhSachPhongChiTiet(V(cboPhieu));
            }
            TinhToan(sender, e);
        }

        // Hàm tính toán tổng tiền
        private void TinhToan(object sender, EventArgs e)
        {
            if (cboPhieu.SelectedValue == null) return;

            string soPhieu = cboPhieu.SelectedValue.ToString();
            var ct = s.TinhTien(soPhieu, dtNgayTra.Value);

            txtTienPhong.Text = ct.TienPhong.ToString("N0");
            txtTienDV.Text = ct.TienDichVu.ToString("N0");
            txtTienCoc.Text = ct.TienCoc.ToString("N0");

            decimal tong = ct.TienPhong + ct.TienDichVu + numPhuThu.Value - ct.TienCoc;
            txtTongTien.Text = tong.ToString("N0");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboPhieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần thanh toán.");
                return;
            }

            var xn = MessageBox.Show($"Xác nhận thanh toán cho khách {txtKhach.Text} (Phiếu {cboPhieu.SelectedValue})?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xn == DialogResult.Yes)
            {
                var k = s.ThanhToan(V(cboPhieu), V(cboNV), dtNgayTra.Value, numPhuThu.Value);
                MessageBox.Show(k.ThongBao);

                if (k.ThanhCong)
                {
                    TaiPhieu();
                    txtKhach.Clear();
                    txtTienPhong.Clear();
                    txtTienDV.Clear();
                    txtTienCoc.Clear();
                    txtTongTien.Clear();
                    numPhuThu.Value = 0;
                    if (dgvChiTiet.DataSource != null)
                        ((DataTable)dgvChiTiet.DataSource).Clear();
                }
            }
        }
    }
}