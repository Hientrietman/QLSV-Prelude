using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class DanhSachSinhVienCuaLopHP : Form
    {
        public DanhSachSinhVienCuaLopHP()
        {
            InitializeComponent();
            dtgvDanhSachSVCuaLopHocPhan.DataSource = SinhVienBUS.Instance.LayDanhSachSVCuaLopHocPhan(lblTenLopHocPhan.Text);
        }

        DataTable TimKiemSVTrongLopHocPhan(string MaHP, string MaSV)
        {
            DataTable dataTable = new DataTable();

            dataTable = SinhVienBUS.Instance.TimKiemMaSVTrongLopHocPhan(MaHP, MaSV);

            return dataTable;
        }

        private void btnTimMaSinhVien_Click(object sender, EventArgs e)
        {
            dtgvDanhSachSVCuaLopHocPhan.DataSource = TimKiemSVTrongLopHocPhan(lblTenLopHocPhan.Text, txtTimMaSinhVien.Text);
        }

        private void XuatExcel(DataGridView dataGridView)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();

                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                for (int i = 2; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i - 1] = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 2; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j - 1] = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.Columns.AutoFit();

                //workbook.Activate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            XuatExcel(dtgvDanhSachSVCuaLopHocPhan);
        }
    }
}
