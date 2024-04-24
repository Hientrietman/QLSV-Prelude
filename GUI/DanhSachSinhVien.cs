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

namespace GUI
{
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            dtgvDanhSachSinhVien.DataSource = SinhVienBUS.Instance.LayToanBoSinhVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSinhVien.Text;
            string Khoa = cboKhoa.SelectedItem?.ToString() ?? "";
            string Lop = cboLop.SelectedItem?.ToString() ?? "";

            dtgvDanhSachSinhVien.DataSource = SinhVienBUS.Instance.timKiemSVTrongDSSV(MaSV, Khoa, Lop);
        }
    }
}
