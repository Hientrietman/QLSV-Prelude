using BUS;
using DAO;
using DTO;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongTinSV : Form
    {
        public event EventHandler DataUpdated;

        private string MaSV;
        private string HoTen;
        private string NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SoDienThoai;
        private string Lop;
        private string Khoa;
        private string Email;

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

        public ThongTinSV()
        {
            InitializeComponent();
        }

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
                this.txt_SDT.Text = SoDienThoai;
                this.txt_GioiTinh.Text = GioiTinh;

                foreach (DataRowView item in cb_Lop.Items)
                {
                    if (item.Row["Lop"].ToString() == Lop)
                    {
                        cb_Lop.SelectedItem = item;
                        break;
                    }
                }

                foreach (DataRowView item in cb_Khoa.Items)
                {
                    if (item.Row["TenKhoa"].ToString() == Khoa)
                    {
                        cb_Khoa.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void cb_Khoa_Load()
        {
            /*cb_Khoa.DisplayMember = "TenKhoa";
            cb_Khoa.ValueMember = "MaKhoa";
            DataTable data = KhoaDAO.Instance.LayDanhSachKhoa();
            cb_Khoa.DataSource = data;

            if (!string.IsNullOrEmpty(Khoa))
            {
                foreach (DataRowView item in cb_Khoa.Items)
                {
                    if (item.Row["TenKhoa"].ToString() == Khoa)
                    {
                        cb_Khoa.SelectedItem = item;
                        break;
                    }
                }
            }*/

            DataTable dtKhoa = KhoaBUS.Instance.LayKhoa();
            if (dtKhoa != null && dtKhoa.Rows.Count > 0)
            {
                cb_Khoa.DataSource = dtKhoa;
                cb_Khoa.ValueMember = "MaKhoa";
                cb_Khoa.DisplayMember = "TenKhoa";
                cb_Khoa.SelectedIndex = -1;
            }
            // Thêm sự kiện SelectedIndexChanged cho cboKhoa
            cb_Khoa.SelectedIndexChanged += cb_Khoa_SelectedIndexChanged;
        }
        private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Khoa.SelectedValue != null)
            {
                string maKhoa = cb_Khoa.SelectedValue.ToString();
                LoadLopTheoKhoa(maKhoa);
            }
        }
        private void LoadLopTheoKhoa(string maKhoa)
        {
            DataTable dtLop = SinhVienBUS.Instance.LayLopTheoKhoa(maKhoa);
            if (dtLop != null && dtLop.Rows.Count > 0)
            {
                cb_Lop.DataSource = dtLop;
                cb_Lop.ValueMember = "Lop";
                cb_Lop.DisplayMember = "Lop";
                cb_Lop.SelectedIndex = -1;
            }
            else
            {
                cb_Lop.DataSource = null;
            }
        }

        



        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (AreDetailsFilled())
            {
                string MaSV = this.txt_MSV.Text;
                string HoTen = this.txt_HoTen.Text;
                DateTime NgaySinh = this.dtP_NgaySinh.Value;
                string GioiTinh = this.txt_GioiTinh.Text;
                string DiaChi = this.txt_DiaChi.Text;
                string SoDienThoai = this.txt_SDT.Text;
                string Lop = cb_Lop.SelectedValue.ToString();
                string Khoa = cb_Khoa.SelectedValue.ToString();
                string Email = this.txt_Email.Text;
                if (!IsValidStudentId(MaSV))
                {
                    return;
                }

                if (!IsValidGender(GioiTinh))
                    return;
                if (!IsValidPhoneNumber(SoDienThoai))
                    return;
                if (!IsValidEmail(Email))
                    return;

                if (this.Text == "Thêm mới sinh viên")
                {
                    if (SinhVienBUS.Instance.IsStudentIdExists(MaSV))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại xin mời bạn nhập mã sinh viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (SinhVienBUS.Instance.IsStudentEmailExists(Email))
                    {
                        MessageBox.Show("Email đã tồn tại xin mời bạn nhập email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool isSuccess = SinhVienBUS.Instance.ThemSV(MaSV, Lop, Email, SoDienThoai, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        DanhSachSinhVien.Instance.LoadLaiDuLieu();
                        OnDataUpdated();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.Text == "Cập nhật thông tin sinh viên")
                {
                    SinhVienDTO sinhVien = new SinhVienDTO(MaSV, null, Khoa, HoTen, Lop, Email, SoDienThoai, NgaySinh, GioiTinh);
                    SinhVienBUS.Instance.CapNhatSV(MaSV, Lop, Email, SoDienThoai, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
                    MessageBox.Show("Cập nhật thành công");
                    DanhSachSinhVien.Instance.LoadLaiDuLieu();
                    OnDataUpdated();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private bool IsValidGender(string gender)
        {
            if (gender != "Nam" && gender != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ. Chỉ được ghi 'Nam' hoặc 'Nữ'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
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
            // Biểu thức chính quy cho email kết thúc bằng @gmail.com
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private bool AreDetailsFilled()
        {
            return !string.IsNullOrEmpty(txt_MSV.Text) &&
                   !string.IsNullOrEmpty(txt_HoTen.Text) &&
                   !string.IsNullOrEmpty(txt_GioiTinh.Text) &&
                   !string.IsNullOrEmpty(txt_DiaChi.Text) &&
                   !string.IsNullOrEmpty(txt_SDT.Text) &&
                   cb_Lop.SelectedIndex != -1 &&
                   cb_Khoa.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(txt_Email.Text);
        }
        protected virtual void OnDataUpdated()
        {
            EventHandler handler = DataUpdated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        private bool IsValidStudentId(string studentId)
        {
            string pattern = @"^\d{2}\.\d{2}\.\d{3}\.\d{3}$";
            if (!Regex.IsMatch(studentId, pattern))
            {
                MessageBox.Show("Định dạng không hợp lệ mời bạn nhập lại!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



