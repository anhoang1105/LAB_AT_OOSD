using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Services;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmKetThucKhaoSat : Form
    {
        private readonly KetThucService svc = new KetThucService();
        private readonly string pSoTT = "Số thanh toán...";
        private readonly string pSoDK = "Số ĐK...";
        private readonly string pGhiChu = "Ghi chú...";
        private readonly string pMaKS = "Mã KS...";
        private readonly string pKSChon = "Phiếu chọn...";
        private readonly string pGopY = "Nhập góp ý...";

        public FrmKetThucKhaoSat() { InitializeComponent(); }

        private void FrmKetThucKhaoSat_Load(object sender, EventArgs e)
        {
            TaoHieuUngChuMo(txtSoTT, pSoTT); TaoHieuUngChuMo(txtSoDK, pSoDK); TaoHieuUngChuMo(txtGhiChu, pGhiChu);
            TaoHieuUngChuMo(txtMaKS, pMaKS); TaoHieuUngChuMo(txtKSChon, pKSChon); TaoHieuUngChuMo(txtGopY, pGopY);

            cboLoaiKS.Items.AddRange(new object[] { QuyDinh.Le, QuyDinh.Doan });
            cboLoaiKS.SelectedIndex = 0;
            TaiThanhToan(); TaiKhaoSat();
        }

        private void TaoHieuUngChuMo(TextBox txt, string chuMo)
        {
            txt.Text = chuMo; txt.ForeColor = Color.Gray;
            txt.Enter += (sender, e) => { if (txt.Text == chuMo) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (sender, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = chuMo; txt.ForeColor = Color.Gray; } };
        }
        private string LayText(TextBox txt, string chuMo) { return txt.Text == chuMo ? "" : txt.Text; }

        private void TaiThanhToan() { dgvDoan.DataSource = svc.DoanCanThanhToan(); }
        private void TaiKhaoSat() { dgvKS.DataSource = svc.LayKhaoSat(); }

        private void dgvDoan_SelectionChanged(object sender, EventArgs e)
        {
            string ma = FormHelper.O(dgvDoan, "SoDKDoan");
            if (ma != "") { txtSoDK.Text = ma; txtSoDK.ForeColor = Color.Black; }
            string con = FormHelper.O(dgvDoan, "ConLai");
            if (con != "") numTien.Value = Math.Max(0, Math.Min(numTien.Maximum, Convert.ToDecimal(con)));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.ThanhToanDoan(LayText(txtSoTT, pSoTT), LayText(txtSoDK, pSoDK), dtTT.Value, numTien.Value, LayText(txtGhiChu, pGhiChu)))) { txtSoTT.Text = pSoTT; txtGhiChu.Text = pGhiChu; TaiThanhToan(); }
        }

        private void cboLoaiKS_SelectedIndexChanged(object sender, EventArgs e) { FormHelper.Nap(cboDangKy, svc.LayDangKyChoKhaoSat(cboLoaiKS.Text), "HienThi", "Ma"); }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.GuiKhaoSat(LayText(txtMaKS, pMaKS), cboLoaiKS.Text, FormHelper.Gia(cboDangKy), dtGui.Value))) { txtMaKS.Text = pMaKS; TaiKhaoSat(); cboLoaiKS_SelectedIndexChanged(sender, e); }
        }

        private void dgvKS_SelectionChanged(object sender, EventArgs e)
        {
            string ma = FormHelper.O(dgvKS, "MaKhaoSat");
            if (ma != "") { txtKSChon.Text = ma; txtKSChon.ForeColor = Color.Black; }
        }

        private void btnGhiPH_Click(object sender, EventArgs e)
        {
            if (FormHelper.Bao(svc.GhiPhanHoi(LayText(txtKSChon, pKSChon), dtPH.Value, (int)numDiem.Value, LayText(txtGopY, pGopY)))) { txtKSChon.Text = pKSChon; txtGopY.Text = pGopY; TaiKhaoSat(); }
        }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}