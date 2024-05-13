using BUS;
using DTO;
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
    public partial class XemHocPhi : Form
    {
        TaiKhoanDTO taiKhoanDTO = null;
        public XemHocPhi(DTO.TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanDTO = taiKhoan;
        }

        private void XemHocPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(taiKhoanDTO.TenDangNhap);
            if (dt.Rows.Count > 0)
            {
                string maSinhVien = dt.Rows[0]["MaSV"].ToString();
                lblHienThiMaSoSinhVien.Text = maSinhVien;
                DataTable dtHocKyNamHoc = HocPhiBUS.Instance.HienThiHocKyVaNamHoc(maSinhVien);
                if (dtHocKyNamHoc.Rows.Count > 0)
                {
                    cbHocKy.DataSource = dtHocKyNamHoc.DefaultView.ToTable(true, "HocKy");
                    cbHocKy.DisplayMember = "HocKy";
                    cbHocKy.ValueMember = "HocKy";

                    cbNamHoc.DataSource = dtHocKyNamHoc.DefaultView.ToTable(true, "NamHoc");
                    cbNamHoc.DisplayMember = "NamHoc";
                    cbNamHoc.ValueMember = "NamHoc";

                    cbHocKy.SelectedIndex = -1;
                    cbNamHoc.SelectedIndex = -1;
                }

            }

        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataBasedOnSelection();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataBasedOnSelection();
        }
        private void LoadDataBasedOnSelection()
        {
            if (cbHocKy.SelectedIndex != -1 && cbNamHoc.SelectedIndex != -1)
            {
                string hocKy = cbHocKy.SelectedValue.ToString();
                string namHoc = cbNamHoc.SelectedValue.ToString();
                string maSinhVien = lblHienThiMaSoSinhVien.Text; 
                DisplayData(maSinhVien, hocKy, namHoc);
            }
        }
        private void DisplayData(string maSinhVien, string hocKy, string namHoc)
        {


            /*DataTable dt = HocPhiBUS.Instance.HienThiHocPhiSinhVien(maSinhVien, hocKy, namHoc);
            dtgvDanhSachHocPhanSinhVien.DataSource = dt;
            TinhTongHocPhi();*/
            DataTable dt = HocPhiBUS.Instance.HienThiHocPhiSinhVien(maSinhVien, hocKy, namHoc);
            dtgvDanhSachHocPhanSinhVien.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                lblHienThiTrangThai.Text = dt.Rows[0]["TrangThaiText"].ToString();
            }
            else
            {
                lblHienThiTrangThai.Text = "N/A";
            }
            TinhTongHocPhi();
            dtgvDanhSachHocPhanSinhVien.Columns["TrangThaiText"].Visible = false;




        }
        private void TinhTongHocPhi()
        {
            decimal tongHocPhi = 0m; 
            if (dtgvDanhSachHocPhanSinhVien.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvDanhSachHocPhanSinhVien.Rows)
                {
                    if (row.Cells["HocPhi"].Value != DBNull.Value && row.Cells["HocPhi"].Value != null)
                    {
                        tongHocPhi += Convert.ToDecimal(row.Cells["HocPhi"].Value);
                    }
                }
                lblHienTongHocPhi.Text = $"{tongHocPhi:N0} VND";  
            }
            else
            {
                lblHienTongHocPhi.Text = "0 VND";
            }
        }
    }
}
