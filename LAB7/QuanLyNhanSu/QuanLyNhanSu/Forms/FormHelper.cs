using System.Windows.Forms;
using System.Drawing;

namespace QuanLyNhanSu.Forms
{
    public static class FormHelper
    {
        public static void FormatGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
        }
    }
}