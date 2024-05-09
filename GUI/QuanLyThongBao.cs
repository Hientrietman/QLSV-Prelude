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

        private void dtgvBangThongBao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            string MaThongBao = dtgvBangThongBao.Rows[r].Cells["MaThongBao"].Value.ToString();
            string TieuDe = dtgvBangThongBao.Rows[r].Cells["TieuDe"].Value.ToString();
            string NoiDung = dtgvBangThongBao.Rows[r].Cells["NoiDung"].Value.ToString();

            if (e.ColumnIndex == dtgvBangThongBao.Columns["SuaThongBao"].Index)
            {
                SuaThongBao suaThongBao = new SuaThongBao(MaThongBao, TieuDe, NoiDung);

                suaThongBao.ShowDialog();
            }
        }
    }
}
