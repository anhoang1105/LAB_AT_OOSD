using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmGiaHan : Form
    {
        private readonly GiaHanService svc = new GiaHanService();

        public FrmGiaHan() { InitializeComponent(); }

        private void FrmGiaHan_Load(object sender, EventArgs e)
        {
            FormHelper.Nap(cboHopDong, svc.LayHopDong(), "HienThi", "SoHopDong");
            Tai();
        }

        private void Tai() { dgvGiaHan.DataSource = svc.LayPhieuGiaHan(); }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.LapPhieuGiaHan(txtMaGH.Text, FormHelper.Gia(cboHopDong), (int)numThoiGian.Value))) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}