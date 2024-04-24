using DTO;
using DAO;
using System;
using GUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient; // Thêm thư viện để kết nối đến SQL Server
//using Main;

namespace GUI
{
    public partial class Login : Form
    {
        //private TaiKhoanDAO loginAccount;
        private int loginAttempts = 0;
        private const string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Quan_li_SV;Integrated Security=True";
        //private TaiKhoanDTO loginAccount;

        public Login()
        {
            InitializeComponent();
            txt_PassWord.UseSystemPasswordChar = true;
        }

        bool LoginAccount(string tenDangNHap, string matKhau)
        {
            return TaiKhoanDAO.Instance.Login(tenDangNHap, matKhau);
        }
        //void check_TK(string )
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNHap = txt_UserName.Text;
            string matKhau = txt_PassWord.Text;
            //string vaitro;

            if (string.IsNullOrEmpty(tenDangNHap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            if (LoginAccount(tenDangNHap, matKhau))
            {
                TaiKhoanDTO loginAccount = TaiKhoanDAO.Instance.GetAccountByUserName(tenDangNHap);
                if (loginAccount.VaiTro == 0)
                {
                    TrangChuSinhVien f = new TrangChuSinhVien(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (loginAccount.VaiTro == 1)
                {
                    TrangChuGiaoVien f = new TrangChuGiaoVien(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

                else
                {
                    TrangChuQuanLy f = new TrangChuQuanLy(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

            }
            else
            {
                loginAttempts++;

                if (loginAttempts >= 5)
                {
                    // Khóa tài khoản
                    LockAccount();
                    MessageBox.Show("Tài khoản của bạn đã bị khóa do đăng nhập quá 5 lần không thành công.");

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private bool KiemTraMatKhauHopLe(string matKhau)
        {
            // Kiểm tra độ dài của mật khẩu
            if (matKhau.Length < 8)
                return false;

            //Kiểm tra xem mật khẩu có ít nhất một chữ cái viết hoa
            if (!matKhau.Any(char.IsUpper))
                return false;

            //Kiểm tra xem mật khẩu có ít nhất một chữ cái viết thường
            if (!matKhau.Any(char.IsLower))
                return false;

            // Kiểm tra xem mật khẩu có ít nhất một số
            if (!matKhau.Any(char.IsDigit))
                return false;

            //Kiểm tra xem mật khẩu có ít nhất một ký tự đặc biệt
            if (!matKhau.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            // Nếu tất cả các điều kiện đều được thỏa mãn, trả về true
            return true;
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            // Khởi tạo và hiển thị form quên mật khẩu khi nút button được nhấn
            QuenMatKhau forgotPasswordForm = new QuenMatKhau();
            forgotPasswordForm.Show();
        }

        private void LockAccount()
        {
            // Ở đây, bạn có thể thực hiện các hành động cần thiết để khóa tài khoản, 
            // ví dụ: vô hiệu hóa các Control đăng nhập hoặc đặt một cờ để chỉ định rằng tài khoản đã bị khóa.
            // Trong ví dụ này, chúng ta chỉ làm sạch các ô nhập liệu.
            txt_UserName.Text = "";
            txt_PassWord.Text = "";
            txt_UserName.Enabled = false;
            txt_PassWord.Enabled = false;
            btnLogin.Enabled = false;

        }

        private void chkshow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txt_PassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txt_PassWord.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}