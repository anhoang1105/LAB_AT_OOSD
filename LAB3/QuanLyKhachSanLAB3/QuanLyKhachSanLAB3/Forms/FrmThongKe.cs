using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSanLAB3.Services;

namespace QuanLyKhachSanLAB3.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();

            // TỰ ĐỘNG NỐI SỰ KIỆN: Khỏi cần dùng tia sét
            this.Load += FrmThongKe_Load;
            btnThongKe.Click += btnThongKe_Click;
            btnDong.Click += (sender, e) => Close();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // Mặc định lấy dữ liệu từ đầu tháng đến hiện tại
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            // Tự động load dữ liệu lần đầu mở Form
            btnThongKe_Click(sender, e);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Tải dữ liệu lên lưới
            DataTable dt = s.LayDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
            dgvThongKe.DataSource = dt;

            // 2. Tính toán các con số tổng kết trực tiếp từ DataTable
            int soHoaDon = dt.Rows.Count;
            decimal tongPhong = 0;
            decimal tongDV = 0;
            decimal tongDoanhThu = 0;

            foreach (DataRow row in dt.Rows)
            {
                tongPhong += Convert.ToDecimal(row["Tiền Phòng"]);
                tongDV += Convert.ToDecimal(row["Tiền Dịch Vụ"]);
                tongDoanhThu += Convert.ToDecimal(row["Tổng Tiền"]);
            }

            // 3. Hiển thị lên các Label với định dạng tiền tệ (N0)
            lblSoHoaDon.Text = $"Số hóa đơn: {soHoaDon}";
            lblTongPhong.Text = $"Tổng tiền phòng: {tongPhong:N0} VNĐ";
            lblTongDV.Text = $"Tổng tiền dịch vụ: {tongDV:N0} VNĐ";
            lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:N0} VNĐ";

            // Tùy chọn: Định dạng cột số tiền trong lưới (nếu lưới đã load dữ liệu)
            if (dgvThongKe.Columns.Contains("Tiền Phòng"))
                dgvThongKe.Columns["Tiền Phòng"].DefaultCellStyle.Format = "N0";
            if (dgvThongKe.Columns.Contains("Tiền Dịch Vụ"))
                dgvThongKe.Columns["Tiền Dịch Vụ"].DefaultCellStyle.Format = "N0";
            if (dgvThongKe.Columns.Contains("Tổng Tiền"))
                dgvThongKe.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
        }
    }
}