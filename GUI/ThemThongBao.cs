using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ThemThongBao : Form
    {
        public string maNQL;
        public ThemThongBao()
        {
            InitializeComponent();
        }
        public string nguoiTao;
        public ThemThongBao(string tieude, string noidung, string nguoitao) : this()
        {
            nguoiTao = nguoitao;
            txtTieuDe.Text = tieude;
            txtNoiDung.Text = noidung;
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
            string nguoitaoQL = nguoiTao;

            if (IsValidTieude(tieuDe) && IsValidNoidung(noiDung))
            {
                ThongBaoBUS.Instance.ThemThongBao(tieuDe, noiDung, nguoitaoQL);
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

        private void ThemThongBao_Load(object sender, EventArgs e)
        {
            TrangChuQuanLy trangChu = Application.OpenForms["TrangChuQuanLy"] as TrangChuQuanLy;
            if (trangChu != null)
            {
                nguoiTao = trangChu.LayMaQuanLy();
            }
            else
            {
                MessageBox.Show("chưa hiện tên");
            }    
        }
    }
}