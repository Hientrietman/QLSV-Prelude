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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class XemThongBao : Form
    {
        public XemThongBao()
        {
            InitializeComponent();
        }
        public XemThongBao(string mathongbao, string tieude, string ngaytao) : this()
        {
            lblTieuDe.Text =tieude;
            lblNgayTao.Text = "[Ngày đăng: " + ngaytao + "]";
            string noidung = ThongBaoBUS.Instance.LayNoiDungThongBao(mathongbao);
            string nguoitao = ThongBaoBUS.Instance.LayTenNguoiTaoThongBao(mathongbao);

            txtNoiDung.Text = noidung;
            lblNguoiTao.Text = "[Người đăng: " + nguoitao + "]";
        }

        private void lblNoiDung_TextChanged(object sender, EventArgs e)
        {
            txtNoiDung.SelectionStart = txtNoiDung.Text.Length;
            txtNoiDung.ScrollToCaret();
            txtNoiDung.Multiline = true;
            txtNoiDung.WordWrap = true;
        }
    }
}
