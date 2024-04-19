using BUS;
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
    public partial class ThongTinCaNhan : Form
    {
        TaiKhoanDTO taiKhoanDTO = null;
        public ThongTinCaNhan(DTO.TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanDTO=taiKhoan;

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
        if(taiKhoanDTO.VaiTro == 1)
            {
                DataTable dt = GiangVienBUS.Instance.LayThongTinGiangVien(taiKhoanDTO.TenDangNhap);
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtMaKhoa.Text = dt.Rows[0]["MaKhoa"].ToString();
                txtNamSinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
            }
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
