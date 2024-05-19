using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Drawing.Text;
using DAO;
using System.Data;


namespace GUI
{
    public partial class GopYVaHoiDap : Form
    {
        TaiKhoanDTO taiKhoanDTO = null; // Khai báo biến taiKhoanDTO ở cấp độ lớp

        // Thêm hàm khởi tạo mới với tham số taiKhoan
        public GopYVaHoiDap(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanDTO = taiKhoan; // Khởi tạo biến taiKhoanDTO trong hàm khởi tạo
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrEmpty(txtNhapMaSinhVien.Text) ||
                string.IsNullOrEmpty(txtNhapHoVaTen.Text) ||
                string.IsNullOrEmpty(txtNhapEmail.Text) ||
                string.IsNullOrEmpty(txt_NoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin góp ý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng DTO từ dữ liệu nhập vào
            GopYVaHoiDapDTO gopYVaHoiDap = new GopYVaHoiDapDTO(txtNhapMaSinhVien.Text, txtNhapHoVaTen.Text, txtNhapEmail.Text, txt_NoiDung.Text, 1);

            // Gọi phương thức thêm góp ý từ BUS
            bool result = GopYVaHoiDapBUS.Instance.ThemGopYVaHoiDap(gopYVaHoiDap);

            if (result)
            {
                // Gửi email
                try
                {
                    string fromEmail = "doquochuy19102019@gmail.com";
                    string password = "gyxc ddzj awee cgfo";

                    // Tạo và cấu hình đối tượng SmtpClient
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587; // Port của SMTP server
                    client.EnableSsl = true; // Sử dụng SSL để bảo mật kết nối
                    client.Credentials = new NetworkCredential(fromEmail, password); // Cung cấp thông tin xác thực cho SMTP server
                    // Tạo đối tượng MailMessage
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("minhhoang0121@gmail.com"); // Email của bạn
                    mail.To.Add("minhhoang0121@gmail.com"); // Email nhận
                    mail.Subject = "Góp ý từ sinh viên"; // Tiêu đề email
                    mail.Body = $"Mã sinh viên: {gopYVaHoiDap.MaSinhVien}\nHọ tên: {gopYVaHoiDap.HoTen}\nEmail: {gopYVaHoiDap.Email}\nNội dung: {gopYVaHoiDap.NoiDung}"; // Nội dung email




                    // Gửi email
                    client.Send(mail);

                    MessageBox.Show("Góp ý của bạn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi gửi góp ý: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi gửi góp ý. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GopYVaHoiDap_Load(object sender, EventArgs e)
        {
            TrangChuSinhVien trangChu = Application.OpenForms["TrangChuSinhVien"] as TrangChuSinhVien;
            if (trangChu != null)
            {
                txtNhapMaSinhVien.Text = trangChu.LayMaSinhVien();
                txtNhapHoVaTen.Text = trangChu.LayTenSinhVien();

            }
            // Kiểm tra nếu taiKhoanDTO là null thì thoát khỏi phương thức
            if (taiKhoanDTO == null)
            {
                MessageBox.Show("Không có thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo một đối tượng ThongTinCaNhan để truy cập vào thuộc tính EmailSinhVien
            ThongTinCaNhan formThongTinCaNhan = new ThongTinCaNhan(taiKhoanDTO);

            // Gọi phương thức LoadData để cập nhật dữ liệu trước khi truy cập vào thuộc tính EmailSinhVien
            formThongTinCaNhan.LoadData();

            // Gán giá trị email của sinh viên vào textbox txtNhapEmail
            txtNhapEmail.Text = formThongTinCaNhan.EmailSinhVien;


        }



    }
}
