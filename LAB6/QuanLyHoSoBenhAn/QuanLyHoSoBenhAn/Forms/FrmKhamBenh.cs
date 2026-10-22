using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        private readonly KhamBenhService svc = new KhamBenhService();
        private readonly DanhMucService dm = new DanhMucService();

        public FrmKhamBenh() { InitializeComponent(); }

        private void FrmKhamBenh_Load(object sender, EventArgs e)
        {
            FormHelper.Nap(cboHoSo, svc.LayDanhSachHoSo(), "HienThi", "MaHoSo");
            FormHelper.Nap(cboBacSi, dm.LayBacSi(), "TenBS", "MaBS");
            FormHelper.Nap(cboKhoa, dm.LayKhoa(), "TenKhoa", "MaKhoa");
        }

        private void btnLuuToa_Click(object sender, EventArgs e)
        {
            // Nút Lưu Toa (hoặc Lưu phiếu) sẽ gom dữ liệu trên giao diện gọi hàm Transaction
            var kq = svc.LuuKhamBenh(txtMaPhieuKham.Text, FormHelper.Gia(cboHoSo), FormHelper.Gia(cboBacSi),
                                     FormHelper.Gia(cboKhoa), txtTrieuChung.Text,
                                     txtMaToa.Text, txtChiTietThuoc.Text, txtCachDung.Text);

            if (FormHelper.Bao(kq))
            {
                txtTrieuChung.Clear(); txtChiTietThuoc.Clear(); txtCachDung.Clear();
            }
        }
    }
}