using BUS;
using DAO;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongTinSV : Form
    {
        private string MaSV;
        private string HoTen;
        private string NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SoDienThoai;
        private string Lop;
        private string Khoa;
        private string Email;

        // Constructor
        public ThongTinSV(string MaSV, string HoTen, string NgaySinh, string GioiTinh, string DiaChi, string SoDienThoai, string Lop, string Khoa, string Email)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.Lop = Lop;
            this.Khoa = Khoa;
            this.Email = Email;

            InitializeComponent();
        }

        // Load form
        private void ThongTinSV_Load(object sender, EventArgs e)
        {
            cb_Khoa_Load();

            if (string.IsNullOrEmpty(MaSV))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";

                this.txt_MSV.Text = MaSV;
                this.txt_HoTen.Text = HoTen;
                this.dtP_NgaySinh.Value = DateTime.Parse(NgaySinh);
                this.txt_Email.Text = Email;
                this.txt_DiaChi.Text = DiaChi;
                this.cb_Khoa.SelectedValue = Khoa;
                this.txt_SDT.Text = SoDienThoai;
                this.txt_Lop.Text = Lop;
                this.txt_GioiTinh.Text = GioiTinh;
            }
        }

        // Load data for combobox Khoa
        private void cb_Khoa_Load()
        {
            cb_Khoa.DisplayMember = "MaKhoa";
            cb_Khoa.ValueMember = "MaKhoa";
            DataTable data = KhoaDAO.Instance.LayDanhSachKhoa();
            cb_Khoa.DataSource = data;
        }

        // Button Enter Click Event
      

        // Button Exit Click Event
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string MaSV = this.txt_MSV.Text;
            string HoTen = this.txt_HoTen.Text;
            DateTime NgaySinh = this.dtP_NgaySinh.Value;
            string GioiTinh = this.txt_GioiTinh.Text;
            string DiaChi = this.txt_DiaChi.Text;
            string SoDienThoai = this.txt_SDT.Text;
            string Lop = this.txt_Lop.Text;
            string Khoa = cb_Khoa.SelectedValue.ToString();
            string Email = this.txt_Email.Text;

            if (this.Text == "Thêm mới sinh viên")
            {
                /*SinhVienDTO sinhVien = new SinhVienDTO(MaSV, null, Khoa, HoTen, Lop, Email, SoDienThoai, NgaySinh, GioiTinh);
                SinhVienBUS.Instance.ThemSV(sinhVien);
                this.Close();*/
                SinhVienDTO sinhVien = new SinhVienDTO(MaSV, null, Khoa, HoTen, Lop, Email, SoDienThoai, NgaySinh, GioiTinh);
                SinhVienBUS.Instance.ThemSV(MaSV, Lop, Email, SoDienThoai, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
                MessageBox.Show("Thêm mới thành công");
                this.Close();

            }
            else if (this.Text == "Cập nhật thông tin sinh viên")
            {
                SinhVienDTO sinhVien = new SinhVienDTO(MaSV, null, Khoa, HoTen, Lop, Email, SoDienThoai, NgaySinh, GioiTinh);
                SinhVienBUS.Instance.CapNhatSV(MaSV, Lop, Email, SoDienThoai, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }
    }
}
