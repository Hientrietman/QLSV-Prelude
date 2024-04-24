using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SVDangKyHocPhan : Form
    {
        string HocKy;
        string NamHoc;
        bool KTHanDKHP = true;
        string MaSinhVien = "47.01.104.003";
        public SVDangKyHocPhan()
        {
            InitializeComponent();
            //LayThongTinHocKyNamHoc(DateTime.Now);
            DateTime ngayCanKiemTra = new DateTime(2023, 08, 11);
            LayThongTinHocKyNamHoc(ngayCanKiemTra);
            dtgvDanhSachLopHocPhan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanCoDK(MaSinhVien, NamHoc);
        }

        DataTable TimKiemMaHP(string MaHP)
        {

            DataTable dataTable = new DataTable();
            dataTable = HocPhanBUS.Instance.TimKiemMaHP(MaHP);

            return dataTable;
        }

        private void btnTimMaHocPhan_Click(object sender, EventArgs e)
        {
            dtgvDanhSachLopHocPhan.DataSource = HocPhanBUS.Instance.TimKiemMaHocPhanCoDK(MaSinhVien, NamHoc, txtTimMaHocPhan.Text);
        }

        void LayThongTinHocKyNamHoc(DateTime ngay)
        {
            // Kiểm tra ngày để xác định học kỳ
            if (ngay.Month == 8 && (ngay.Day >= 1 || ngay.Day <= 31))
            {
                HocKy = "1";
            }
            else if ((ngay.Month == 12 && ngay.Day >= 11) || (ngay.Month == 1 && ngay.Day <= 30))
            {
                HocKy = "2";
            }
            else
            {
                // Trường hợp ngày không nằm trong các khoảng trên
                // Nếu cần, bạn có thể cập nhật logic ở đây
                // Ví dụ: HocKy = "3";
                KTHanDKHP = false;
                lblHocKy.Visible = false;
                lblNamHoc.Visible = false;
                lblHocKyLoad.Visible = false;
                lblNamHocLoad.Visible = false;
            }

            // Xác định năm học
            if (ngay.Month >= 8)
            {
                NamHoc = $"{ngay.Year}-{ngay.Year + 1}";
            }
            else
            {
                NamHoc = $"{ngay.Year - 1}-{ngay.Year}";
            }

            lblHocKyLoad.Text = HocKy;
            lblNamHocLoad.Text = NamHoc;
        }

        private void dtgvDanhSachLopHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvDanhSachLopHocPhan.Columns["DangKy"].Index && e.RowIndex >= 0)
            {
                if (!KTHanDKHP)
                {
                    MessageBox.Show("Chưa đến hạn đăng ký học phần.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow row = dtgvDanhSachLopHocPhan.Rows[e.RowIndex];
                string maHocPhan = row.Cells["MaHocPhan"].Value.ToString();
                string MaSinhVien = "47.01.104.003";

                if (!ThoiKhoaBieuDAO.Instance.KiemTraTKBTonTai(MaSinhVien, lblHocKyLoad.Text, lblNamHocLoad.Text))
                {
                    ThoiKhoaBieuDAO.Instance.ThemTKB(MaSinhVien, lblHocKyLoad.Text, lblNamHocLoad.Text);
                }

                string MaTKB = LayMaTKB(MaSinhVien, lblHocKyLoad.Text, lblNamHocLoad.Text);
                if (DangKyDAO.Instance.ThemDangKy(MaTKB, maHocPhan))
                {
                    MessageBox.Show("Đăng ký học phần thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký học phần thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dtgvDanhSachLopHocPhan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanCoDK(MaSinhVien, NamHoc);
        }

        private string LayMaTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            string maTKB = "";

            DataTable dt = ThoiKhoaBieuDAO.Instance.LayMaTKB(MaSinhVien, HocKy, NamHoc);

            if (dt != null && dt.Rows.Count > 0)
            {
                maTKB = dt.Rows[0]["MaTKB"].ToString();
            }

            return maTKB;
        }
    }
}
