using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmThongKe : Form
    {
        private ThongKeService srv = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
            this.Load += (s, e) => { cboLoai.SelectedIndex = 0; txtThang.Text = DateTime.Now.Month.ToString(); txtNam.Text = DateTime.Now.Year.ToString(); };

            cboLoai.SelectedIndexChanged += (s, e) => {
                bool isBangLuong = cboLoai.SelectedIndex == 1;
                lblThang.Visible = txtThang.Visible = lblNam.Visible = txtNam.Visible = isBangLuong;
            };

            btnXem.Click += BtnXem_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLoai.SelectedIndex == 0)
                {
                    dgvData.DataSource = srv.NhanSuTheoPhongBan();
                }
                else if (cboLoai.SelectedIndex == 1)
                {
                    int thang = int.Parse(txtThang.Text);
                    int nam = int.Parse(txtNam.Text);
                    dgvData.DataSource = srv.LuongTheoThang(thang, nam);
                }
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ hoặc lỗi truy vấn.\nChi tiết: " + ex.Message);
            }
        }
    }
}