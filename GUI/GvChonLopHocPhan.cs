using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GvChonLopHocPhan : Form
    {
        private TaiKhoanDTO taiKhoan;
        public GvChonLopHocPhan(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            taiKhoan = TaiKhoan;
            dtgvDanhSachLopHocPhan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanCuaGV(taiKhoan.TenDangNhap);
        }

        DataTable TimKiemMaHPCuaGV(string MaGV, string MaHP)
        {

            DataTable dataTable = new DataTable();
            dataTable = HocPhanBUS.Instance.TimKiemMaHPCuaGV(MaGV, MaHP);

            return dataTable;
        }

        private void btnTimMaHocPhan_Click(object sender, EventArgs e)
        {
            dtgvDanhSachLopHocPhan.DataSource = TimKiemMaHPCuaGV(taiKhoan.TenDangNhap, txtTimMaHocPhan.Text);
        }

        private void dtgvDanhSachLopHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvDanhSachLopHocPhan.Columns["DanhSachSV"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDanhSachLopHocPhan.Rows[e.RowIndex];
                string maHocPhan = row.Cells["MaHocPhan"].Value.ToString();

                DanhSachSinhVienCuaLopHP form = new DanhSachSinhVienCuaLopHP(maHocPhan);
                //this.Hide();
                form.Show();
                //this.Show();
            }
        }
    }
}
