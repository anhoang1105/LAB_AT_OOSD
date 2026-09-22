using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienLab2.Services;

namespace QuanLyThuVienLab2.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly BaoCaoService service = new BaoCaoService();

        public FrmThongKe()
        {
            InitializeComponent();

            // Tự động gán sự kiện với tên mới
            this.Load += FrmThongKe_Load;

            if (cboLoaiBaoCao != null) cboLoaiBaoCao.SelectedIndexChanged += cboLoaiBaoCao_SelectedIndexChanged;
            if (btnDong != null) btnDong.Click += btnDong_Click;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            TaiThongKeTongQuan();

            // Chọn báo cáo mặc định
            if (cboLoaiBaoCao != null && cboLoaiBaoCao.Items.Count > 0)
            {
                cboLoaiBaoCao.SelectedIndex = 0;
            }
        }

        private void TaiThongKeTongQuan()
        {
            DataTable dtTongQuan = service.LayThongKeTongQuan();
            if (dtTongQuan.Rows.Count > 0)
            {
                DataRow row = dtTongQuan.Rows[0];

                // Hiển thị số liệu lên các Label
                if (lblTongSach != null) lblTongSach.Text = row["TongSachConTrongKho"].ToString() + " cuốn";
                if (lblTongDocGia != null) lblTongDocGia.Text = row["TongDocGia"].ToString() + " người";
                if (lblDangMuon != null) lblDangMuon.Text = row["TongPhieuDangMuon"].ToString() + " phiếu";

                // Cảnh báo màu đỏ cho sách quá hạn
                if (lblQuaHan != null)
                {
                    int quaHan = Convert.ToInt32(row["TongPhieuQuaHan"]);
                    lblQuaHan.Text = quaHan.ToString() + " phiếu";
                    if (quaHan > 0) lblQuaHan.ForeColor = System.Drawing.Color.Red;
                }

                if (lblTienPhat != null)
                {
                    decimal tienPhat = Convert.ToDecimal(row["TongDoanhThuPhat"]);
                    lblTienPhat.Text = tienPhat.ToString("N0") + " VNĐ";
                }
            }
        }

        private void cboLoaiBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiBaoCao == null || dgvBaoCao == null) return;

            string luaChon = cboLoaiBaoCao.SelectedItem.ToString();

            if (luaChon == "Danh sách sách đang mượn")
            {
                dgvBaoCao.DataSource = service.LayBaoCaoSachDangMuon();
            }
            else if (luaChon == "Danh sách sách mượn quá hạn")
            {
                dgvBaoCao.DataSource = service.LayBaoCaoSachQuaHan();
            }
            else if (luaChon == "Top sách được mượn nhiều nhất")
            {
                dgvBaoCao.DataSource = service.LayBaoCaoTopSach();
            }

            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}