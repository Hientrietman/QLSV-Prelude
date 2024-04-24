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
    public partial class SinhVienXemDiemThi : Form
    {
        private TaiKhoanDTO taiKhoan;
        public SinhVienXemDiemThi(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            taiKhoan = TaiKhoan;
            lblMaSinhVienParam.Text = taiKhoan.TenDangNhap;
            lblHoTenSVParam.Text = LayTenSinhVien(taiKhoan.TenDangNhap);
            dtgvBangDiemSinhVien.DataSource = DiemDAO.Instance.LayDiemSinhVienBangMSSV(lblMaSinhVienParam.Text);
        }

        private string LayTenSinhVien(string tenDangNhap)
        {
            string TenSV = "";

            DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                TenSV = dt.Rows[0]["HoTen"].ToString();
            }

            return TenSV;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maSV = lblMaSinhVienParam.Text;

            string namHoc = cboNamHoc.SelectedItem.ToString();

            dtgvBangDiemSinhVien.DataSource = DiemDAO.Instance.LayDiemSinhVienBangMssvVaNamHoc(maSV, namHoc);
        }
    }
}
