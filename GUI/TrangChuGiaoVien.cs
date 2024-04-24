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
    public partial class TrangChuGiaoVien : Form
    {
        private TaiKhoanDAO loginAccount;

        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        private TaiKhoanDTO taiKhoan;
        public TrangChuGiaoVien(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            lblName.Text = LayTenGiangVien(TaiKhoan.TenDangNhap); ;
            lblMSSV.Text = TaiKhoan.TenDangNhap;
            taiKhoan = TaiKhoan;
        }

        private string LayTenGiangVien(string tenDangNhap)
        {
            string maGV = "";

            DataTable dt = GiangVienBUS.Instance.LayThongTinGiangVien(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                maGV = dt.Rows[0]["HoTen"].ToString();
            }

            return maGV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GvChonLopHocPhan gvChonLopHocPhan = new GvChonLopHocPhan();
            gvChonLopHocPhan.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(taiKhoan);
            f.ShowDialog();
            this.Close();
            
        }
    }
}
