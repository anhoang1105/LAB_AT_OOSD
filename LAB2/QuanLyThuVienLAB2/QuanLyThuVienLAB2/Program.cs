using System;
using System.Windows.Forms;
using QuanLyThuVienLab2.Forms; // Khai báo namespace chứa Forms

namespace QuanLyThuVienLab2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}