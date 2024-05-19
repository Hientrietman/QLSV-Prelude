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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tieuDe = txtTieuDe.Text;
            string noiDung = txtNoiDung.Text;
            string nguoiTao = maNQL;

            if (IsValidTieude(tieuDe) && IsValidNoidung(noiDung))
            {
                ThongBaoBUS.Instance.ThemThongBao(tieuDe, noiDung, nguoiTao);
                MessageBox.Show("Thông báo đã được thêm thành công!");
                this.Close();
            }
        }

        private bool IsValidTieude(string tieude)
        {
            if (string.IsNullOrWhiteSpace(tieude))
            {
                MessageBox.Show("Tiêu đề không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidNoidung(string noidung)
        {
            if (string.IsNullOrWhiteSpace(noidung))
            {
                MessageBox.Show("Nội dung không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
