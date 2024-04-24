using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChinhSuaThongTinCaNhan : Form
    {
        public event EventHandler DataUpdated;
        TaiKhoanDTO taiKhoanDTO = null;
        public ChinhSuaThongTinCaNhan(DTO.TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanDTO = taiKhoan;
        }

        

        private void ChinhSuaThongTinCaNhan_Load(object sender, EventArgs e)
        {
            if (taiKhoanDTO.VaiTro == 0)
            {
                System.Data.DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(taiKhoanDTO.TenDangNhap);
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtLop.Text = dt.Rows[0]["Lop"].ToString();
                txtMaKhoa.Text = dt.Rows[0]["MaKhoa"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[0]["NgaySinh"];
                string ngaySinhFormatted = ngaySinh.ToString("yyyy-MM-dd");
                txtNamSinh.Text = ngaySinhFormatted;
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
                txtMaKhoa.ReadOnly = true;
                txtLop.ReadOnly = true;
            }
            else if (taiKhoanDTO.VaiTro == 1)
            {
                lblLop.Visible = false;
                txtLop.Visible = false;
                lblGioiTinh.Location = lblLop.Location;
                txtGioiTinh.Location = txtLop.Location;
                System.Data.DataTable dt = GiangVienBUS.Instance.LayThongTinGiangVien(taiKhoanDTO.TenDangNhap);
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtMaKhoa.Text = dt.Rows[0]["MaKhoa"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[0]["NgaySinh"];
                string ngaySinhFormatted = ngaySinh.ToString("yyyy-MM-dd");
                txtNamSinh.Text = ngaySinhFormatted;
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
            }
            else if (taiKhoanDTO.VaiTro == 2)
            {
                lblLop.Visible = false;
                txtLop.Visible = false;
                lblMaKhoa.Visible = false;
                txtMaKhoa.Visible = false;
                lblGioiTinh.Location = lblLop.Location;
                txtGioiTinh.Location = txtLop.Location;
                System.Data.DataTable dt = QuanLyBUS.Instance.LayThongTinQuanLy(taiKhoanDTO.TenDangNhap);
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[0]["NgaySinh"];
                string ngaySinhFormatted = ngaySinh.ToString("yyyy-MM-dd");
                txtNamSinh.Text = ngaySinhFormatted;
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO != null)
            {
                string ma = taiKhoanDTO.TenDangNhap;
                string hoTen = txtHoTen.Text;
                string diaChi = txtDiaChi.Text;
                string namSinhString = txtNamSinh.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string email = txtEmail.Text;
                string lop = txtLop.Text;
                string gioiTinh = txtGioiTinh.Text;

                if (!IsValidPhoneNumber(soDienThoai) || !IsValidEmail(email) || !IsValidName(hoTen) || !IsValidAddress(diaChi))
                    return;

                if (!IsValidGender(gioiTinh))
                    return;

                if (!IsValidBirthDate(namSinhString, out DateTime ngaySinh))
                    return;

                bool result;
                if (taiKhoanDTO.VaiTro == 0)
                {
                    result = SinhVienBUS.Instance.ChinhSuaThongTinSinhVien(ma, lop, email, soDienThoai, ngaySinh, diaChi, hoTen, gioiTinh);
                }
                else if (taiKhoanDTO.VaiTro == 1)
                {
                    result = GiangVienBUS.Instance.ChinhSuaThongTinGiangVien(ma, email, soDienThoai, ngaySinh, diaChi, hoTen, gioiTinh);
                }
                else
                {
                    result = QuanLyBUS.Instance.ChinhSuaThongTinQuanLy(ma, email, soDienThoai, ngaySinh, diaChi, hoTen, gioiTinh);
                }

                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnDataUpdated();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected virtual void OnDataUpdated()
        {
            EventHandler handler = DataUpdated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private bool IsValidGender(string gender)
        {
            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Giới tính không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (gender != "Nam" && gender != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ. Chỉ được ghi 'Nam' hoặc 'Nữ'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidBirthDate(string birthDateString, out DateTime birthDate)
        {
            birthDate = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(birthDateString))
            {
                MessageBox.Show("Ngày sinh không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DateTime.TryParseExact(birthDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ. Định dạng yêu cầu là 'YYYY-MM-DD'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidAddress(string diaChi)
        {
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phoneNumber.Length < 10 || phoneNumber.Length >= 11)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsValidName(string name)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
