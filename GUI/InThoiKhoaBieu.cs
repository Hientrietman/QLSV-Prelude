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

namespace GUI
{
    public partial class InThoiKhoaBieu : Form
    {
        public InThoiKhoaBieu()
        {
            InitializeComponent();
            loadThoiKhoaBieu();
        }
        private void loadThoiKhoaBieu()
        {
            string HoTenSV = lblTenSV.Text;
            string MSSV = lblMSSV.Text;
            string Lop = lblLop.Text;
            string SoDienThoai = lblSDT.Text;

            int HocKy = int.Parse(lblHocKy.Text);
            string NamHocSV = lblNamHoc.Text;

            dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);

            ////Xử lý tách chuỗi năm học
            //string[] arrNamHocSV = NamHocSV.Split(new char[] { '-' });

            //int kiemtraNamHoc;
            //if (HocKy == 1)
            //{
            //    kiemtraNamHoc = int.Parse(arrNamHocSV[0]);
            //    dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);
            //}
            //else if (HocKy == 2)
            //{
            //    kiemtraNamHoc = int.Parse(arrNamHocSV[1]);
            //    dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);
            //}
        }

    }
}
