using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmPhanCongHDV : Form
    {
        private readonly PhanCongService svc = new PhanCongService();
        private readonly string pMaPC = "Nhập mã phân công...";

        public FrmPhanCongHDV() { InitializeComponent(); }

        private void FrmPhanCongHDV_Load(object sender, EventArgs e)
        {
            TaoHieuUngChuMo(txtMaPC, pMaPC);
            FormHelper.Nap(cboHDV, svc.LayHDVDangLam(), "HienThi", "MaHDV");
            cboLoai.Items.AddRange(new object[] { QuyDinh.Le, QuyDinh.Doan });
            cboLoai.SelectedIndex = 0;
            Tai();
        }

        private void TaoHieuUngChuMo(TextBox txt, string chuMo)
        {
            txt.Text = chuMo; txt.ForeColor = Color.Gray;
            txt.Enter += (sender, e) => { if (txt.Text == chuMo) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (sender, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = chuMo; txt.ForeColor = Color.Gray; } };
        }
        private string LayText(TextBox txt, string chuMo) { return txt.Text == chuMo ? "" : txt.Text; }

        private void Tai() { dgv.DataSource = svc.LayDanhSach(); }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHelper.Nap(cboDoiTuong, svc.LayDoiTuong(cboLoai.Text), "HienThi", "Ma");
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.PhanCong(LayText(txtMaPC, pMaPC), FormHelper.Gia(cboHDV), cboLoai.Text, FormHelper.Gia(cboDoiTuong), numThuLao.Value)))
            {
                txtMaPC.Text = pMaPC; txtMaPC.ForeColor = Color.Gray;
                Tai();
                cboLoai_SelectedIndexChanged(sender, e);
            }
        }
        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}