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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ThemLHPVaoTKB : Form
    {
        //Lấy tháng hiện tại
        int thangHienTai = DateTime.Now.Month;
        public ThemLHPVaoTKB()
        {
            InitializeComponent();
        }
        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            loadBangHocPhanSV();
            loadBangHocPhan();

        }

        private void btnTimLopHocPhan_Click(object sender, EventArgs e)
        {
            loadBangHocPhan();
        }

        private void dtgvBangHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaSV = txtMaSV.Text;
            int HocKy = int.Parse(string.Format("{0}", cboHocKy.SelectedItem));
            string NamHoc = cboNamHoc.SelectedItem.ToString();         

            //Lấy mã học phần và mã môn học tại dòng click vào
            int r = e.RowIndex;

            string MaHocPhan = dtgvBangHocPhan.Rows[r].Cells["colMaHP"].Value.ToString();
            string MaMonHoc = dtgvBangHocPhan.Rows[r].Cells["colMaMH"].Value.ToString();

            //Xử lý tách chuỗi combobox năm học
            string NamHocSV = string.Format("{0}", cboNamHoc.SelectedItem);
            string[] arrNamHocSV = NamHocSV.Split(new char[] { '-' });

            int kiemtraHocKy = 0;
            int kiemtraNamHoc = 0;

            //Học kỳ 1
            if (thangHienTai >= 7 && thangHienTai <= 8)
            {
                kiemtraHocKy = 1;
                kiemtraNamHoc = int.Parse(arrNamHocSV[0]);
                //Kiểm tra học kỳ
                if (kiemtraHocKy == HocKy)
                {
                    //Kiểm tra học phần có trong tkb của sinh viên trong học kỳ hiện tại
                    if (HocPhanBUS.Instance.KiemTraHocPhan(MaSV, HocKy, NamHoc, MaHocPhan) == false)
                    {
                        //Kiểm tra môn học có trong tkb của sinh viên trong học kỳ hiện tại
                        if (HocPhanBUS.Instance.KiemTraMonHoc(MaSV, HocKy, NamHoc, MaHocPhan, MaMonHoc) == false)
                        {
                            if (e.ColumnIndex == dtgvBangHocPhan.Columns["btnThem"].Index && e.RowIndex >= 0)
                            {
                            dtgvBangHocPhan.DataSource = HocPhanDAO.Instance.ThemHocPhan(MaSV, HocKy, NamHoc, MaHocPhan);
                            MessageBox.Show("Thêm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgvBangHocPhanSV.DataSource = HocPhanDAO.Instance.LayDanhSachHocPhanCuaSV(MaSV, HocKy, NamHoc);
                            }
                        }
                        else
                            MessageBox.Show("Môn học này tồn tại trong TKB của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Học phần này tồn tại trong TKB của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Học kỳ hiện tại không được đăng ký học phần này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Học kỳ 2
            else if (thangHienTai >= 12 || thangHienTai <= 5)
            {
                kiemtraHocKy = 2;
                kiemtraNamHoc = int.Parse(arrNamHocSV[1]);
                //Kiểm tra học kỳ
                if (kiemtraHocKy == HocKy)
                {
                    //Kiểm tra học phần có trong tkb của sinh viên trong học kỳ hiện tại
                    if (HocPhanBUS.Instance.KiemTraHocPhan(MaSV, HocKy, NamHoc, MaHocPhan) == false)
                    {
                        //Kiểm tra môn học có trong tkb của sinh viên trong học kỳ hiện tại
                        if (HocPhanBUS.Instance.KiemTraMonHoc(MaSV, HocKy, NamHoc, MaHocPhan, MaMonHoc) == false)
                        {
                            dtgvBangHocPhan.DataSource = HocPhanDAO.Instance.ThemHocPhan(MaSV, HocKy, NamHoc, MaHocPhan);
                            MessageBox.Show("Thêm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgvBangHocPhanSV.DataSource = HocPhanDAO.Instance.LayDanhSachHocPhanCuaSV(MaSV, HocKy, NamHoc);
                        }
                        else
                            MessageBox.Show("Môn học này tồn tại trong TKB của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Học phần này tồn tại trong TKB của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Học kỳ hiện tại không được đăng ký học phần này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void loadBangHocPhanSV()
        {
            string MaSV = txtMaSV.Text;
            int HocKy = int.Parse(string.Format("{0}", cboHocKy.SelectedItem));
            string NamHoc = cboNamHoc.SelectedItem.ToString();

            dtgvBangHocPhanSV.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanCuaSV(MaSV, HocKy, NamHoc);
        }
        private void loadBangHocPhan()
        {
            //Xử lý tách chuỗi combobox năm học
            string NamHocSV = string.Format("{0}", cboNamHoc.SelectedItem);
            string[] arrNamHocSV = NamHocSV.Split(new char[] { '-' });

            int HocKy = int.Parse(string.Format("{0}", cboHocKy.SelectedItem));
            int kiemtraNamHoc;
            string MaHP = txtMaHP.Text;

            if (HocKy == 1)
            {
                kiemtraNamHoc = int.Parse(arrNamHocSV[0]);
                dtgvBangHocPhan.DataSource = HocPhanBUS.Instance.TimKiemLopHP(kiemtraNamHoc, MaHP);
            }
            else if (HocKy == 2)
            {
                kiemtraNamHoc = int.Parse(arrNamHocSV[1]);
                dtgvBangHocPhan.DataSource = HocPhanBUS.Instance.TimKiemLopHP(kiemtraNamHoc, MaHP);
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btnThem";
                button.HeaderText = "";
                button.Text = "Thêm học phần";
                button.UseColumnTextForButtonValue = true;
                if (this.dtgvBangHocPhan.Columns["btnThem"] == null)
                {
                    this.dtgvBangHocPhan.Columns.Add(button);
                }
            }
        }
    }
}
