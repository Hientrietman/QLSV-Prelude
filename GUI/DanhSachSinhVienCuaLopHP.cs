using BUS;
using DAO;
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
        public DanhSachSinhVienCuaLopHP(string maHocPhan)
        {
            InitializeComponent();
            lblTenLopHocPhan.Text = maHocPhan;
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


                excelApp.DisplayAlerts = false;
                workbook.Saved = true;

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

        private void dtgvDanhSachSVCuaLopHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvDanhSachSVCuaLopHocPhan.Columns["Them"].Index)
            {
                // Lấy dữ liệu từ dòng được nhấn
                string maSinhVien = dtgvDanhSachSVCuaLopHocPhan.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                string maHocPhan = lblTenLopHocPhan.Text;
                string tenSinhVien = dtgvDanhSachSVCuaLopHocPhan.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();

                // Mở form ThemDiemSinhVien và truyền dữ liệu
                ThemDiemChoSinhVien formThemDiem = new ThemDiemChoSinhVien(maSinhVien, maHocPhan, tenSinhVien, dtgvDanhSachSVCuaLopHocPhan);
                //this.Hide();
                formThemDiem.Show();
                //this.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dtgvDanhSachSVCuaLopHocPhan.Columns["Sua"].Index)
            {
                // Lấy dữ liệu từ dòng được nhấn
                string maSinhVien = dtgvDanhSachSVCuaLopHocPhan.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                string maHocPhan = lblTenLopHocPhan.Text;
                string tenSinhVien = dtgvDanhSachSVCuaLopHocPhan.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();

                // Mở form SuaDiemSinhVien và truyền dữ liệu
                SuaDiemChoSinhVien formSuaDiem = new SuaDiemChoSinhVien(maSinhVien, maHocPhan, tenSinhVien, dtgvDanhSachSVCuaLopHocPhan);
                //this.Hide();
                formSuaDiem.Show();
                //this.Show();
            }
        }
    }
}
