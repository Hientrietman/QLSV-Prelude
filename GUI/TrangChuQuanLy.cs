using DAO;
using DTO;
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

namespace GUI
{
    public partial class TrangChuQuanLy : Form
    {
        private TaiKhoanDAO loginAccount;

        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        private TaiKhoanDTO taiKhoanHienTai;
        public TrangChuQuanLy(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            lblName.Text = LayTenQuanLy(TaiKhoan.TenDangNhap); ;
            lblMSSV.Text = TaiKhoan.TenDangNhap;
            taiKhoanHienTai = TaiKhoan;
        }

        private string LayTenQuanLy(string tenDangNhap)
        {
            string maNQL = "";

            DataTable dt = QuanLyBUS.Instance.LayThongTinQuanLy(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                maNQL = dt.Rows[0]["HoTen"].ToString();
            }

            return maNQL;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan taoTaiKhoan = new TaoTaiKhoan();
            taoTaiKhoan.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(taiKhoanHienTai);
            f.ShowDialog();
            this.Close();
        }
    }
}
