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
    public partial class ThemThongBao : Form
    {
        public string maNQL;
        public ThemThongBao()
        {
            InitializeComponent();
        }
        public ThemThongBao(string manql) : this()
        {

            maNQL = manql;
        }
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            txtNoiDung.SelectionStart = txtNoiDung.Text.Length;
            txtNoiDung.ScrollToCaret();
        }
    }
}
