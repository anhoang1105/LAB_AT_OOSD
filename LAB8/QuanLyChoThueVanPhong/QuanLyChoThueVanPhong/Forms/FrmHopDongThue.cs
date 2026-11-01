using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHopDongThue : Form
    {
        private readonly HopDongService svc = new HopDongService();

        public FrmHopDongThue()
        {
            InitializeComponent();
        }

        private void FrmHopDongThue_Load(object sender, EventArgs e)
        {
            FormHelper.Nap(cboKhachHang, svc.LayKhachHang(), "TenKhachHang", "MaKH");
            Tai();
        }

        private void Tai()
        {
            dgvHopDong.DataSource = svc.LayDanhSachHopDong();

            // Đổ danh sách phòng trống vào CheckedListBox
            chklPhong.DataSource = svc.LayPhongTrong();
            chklPhong.DisplayMember = "HienThi";
            chklPhong.ValueMember = "MaPhong";
        }

        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            // Lấy danh sách mã phòng đã check
            List<string> phongs = new List<string>();
            foreach (DataRowView item in chklPhong.CheckedItems)
            {
                phongs.Add(item["MaPhong"].ToString());
            }

            if (FormHelper.Bao(svc.LapHopDong(txtSoHD.Text, FormHelper.Gia(cboKhachHang), (int)numThoiHan.Value, numCoc.Value, phongs)))
            {
                Tai(); // Load lại lưới và reset danh sách phòng trống
            }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}