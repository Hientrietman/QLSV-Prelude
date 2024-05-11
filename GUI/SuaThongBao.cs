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
    public partial class SuaThongBao : Form
    {
        public SuaThongBao()
        {
            InitializeComponent();
        }
        public string maThongBao;
        public SuaThongBao(string matb, string tieude, string noidung) : this()
        {
            maThongBao = matb;
            txtTieuDe.Text = tieude;
            txtNoiDung.Text = noidung;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            txtNoiDung.SelectionStart = txtNoiDung.Text.Length;
            txtNoiDung.ScrollToCaret();
        }
    }
}
