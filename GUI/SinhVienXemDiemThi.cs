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
    public partial class SinhVienXemDiemThi : Form
    {
        public SinhVienXemDiemThi()
        {
            InitializeComponent();
            dtgvBangDiemSinhVien.DataSource = DiemDAO.Instance.LayDiemSinhVienBangMSSV(lblMaSinhVienParam.Text);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maSV = lblMaSinhVienParam.Text;

            string namHoc = cboNamHoc.SelectedItem.ToString();

            dtgvBangDiemSinhVien.DataSource = DiemDAO.Instance.LayDiemSinhVienBangMssvVaNamHoc(maSV, namHoc);
        }
    }
}
