using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class XoaHocPhanSinhVien : Form
    {
        string hocKy;
        string namHoc;
        public XoaHocPhanSinhVien()
        {
            InitializeComponent();
            DateTime hocKy_namHoc = DateTime.Now;
  
            LayThongTinhocKyNamHoc(hocKy_namHoc);
        }

        void LayThongTinhocKyNamHoc(DateTime time)
        {
            int year = time.Year;
            if (time >= new DateTime(year, 8, 7) && time <= new DateTime(year, 8, 31))
            {
                hocKy = "1";
                namHoc = $"{year}-{year + 1}";
            }
            else if ((time >= new DateTime(year - 1, 12, 1) && time <= new DateTime(year - 1, 12, 31)) ||
                     (time >= new DateTime(year, 1, 1) && time <= new DateTime(year, 1, 30)))
            {
                hocKy = "2";
                namHoc = $"{year - 1}-{year}";
            }

            lblHienHocKy.Text = hocKy;
            lblHienNamHoc.Text = namHoc;
        }




        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSinhVien.Text;


            DataTable dt = HocPhanBUS.Instance.LayThoiKhoaBieuSinhVien(maSV, hocKy, namHoc);
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgvDanHSachThoiKhoaBieuSinhVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin thời khóa biểu cho sinh viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvDanHSachThoiKhoaBieuSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dtgvDanHSachThoiKhoaBieuSinhVien.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                string maHocPhan = dtgvDanHSachThoiKhoaBieuSinhVien.Rows[e.RowIndex].Cells["MaHocPhan"].Value.ToString();

               
                bool result = HocPhanBUS.Instance.XoaHocPhanTrongThoiKhoaBieuSinhVien(maHocPhan);

                if (result)
                {
                   
                    dtgvDanHSachThoiKhoaBieuSinhVien.Rows.RemoveAt(e.RowIndex); 
                    
                    if (dtgvDanHSachThoiKhoaBieuSinhVien.Rows.Count == 0)
                    {
                        MessageBox.Show("Không còn học phần nào trong thời khóa biểu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Xóa học phần thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa học phần không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
