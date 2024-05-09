using BUS;
using DAO;
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
    public partial class QuanLyThongBao : Form
    {
        private TaiKhoanDAO loginAccount;
        public string maNQL;
        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public QuanLyThongBao(string manql) : this()
        {
            maNQL = manql;
        }
        public QuanLyThongBao()
        {
            InitializeComponent();
            loadBangThongBao();
        }
        private void loadBangThongBao()
        {
            string TieuDe = txtTimKiem.Text;

            dtgvBangThongBao.DataSource = ThongBaoBUS.Instance.LayDanhSachThongBao(TieuDe);

            this.dtgvBangThongBao.AutoGenerateColumns = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadBangThongBao();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThongBao themThongBao = new ThemThongBao(maNQL);

            themThongBao.ShowDialog();
        }
    }
}
