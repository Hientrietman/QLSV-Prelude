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
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLInfo_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien f = new DanhSachSinhVien();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyHocPhan f = new QuanLyHocPhan();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XoaHocPhanSinhVien f = new XoaHocPhanSinhVien();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemLHPVaoTKB f = new ThemLHPVaoTKB();
            f.ShowDialog();
        }

        private void btnUpdateMes_Click(object sender, EventArgs e)
        {
            QuanLyThongBao f = new QuanLyThongBao();
            f.ShowDialog();
        }
    }
}
