using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuSinhVien : Form
    {
        private TaiKhoanDAO loginAccount;

        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        private TaiKhoanDTO taiKhoan;
        public TrangChuSinhVien(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            lblName.Text = LayTenSinhVien(TaiKhoan.TenDangNhap); ;
            lblMSSV.Text = TaiKhoan.TenDangNhap;
            taiKhoan = TaiKhoan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SinhVienXemDiemThi sinhVienXemDiemThi = new SinhVienXemDiemThi();
            sinhVienXemDiemThi.ShowDialog();
        }

        private string LayTenSinhVien(string tenDangNhap)
        {
            string maSV = "";

            DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                maSV = dt.Rows[0]["HoTen"].ToString();
            }

            return maSV;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(taiKhoan);
            f.ShowDialog();
            this.Close();
        }
    }
}
