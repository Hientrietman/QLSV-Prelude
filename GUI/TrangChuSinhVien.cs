using DAO;
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
    public partial class TrangChuSinhVien : Form
    {
        private TaiKhoanDAO loginAccount;

        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public TrangChuSinhVien(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SinhVienXemDiemThi sinhVienXemDiemThi=new SinhVienXemDiemThi();
            sinhVienXemDiemThi.ShowDialog();
        }
    }
}
