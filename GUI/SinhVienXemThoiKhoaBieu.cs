using BUS;
using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace GUI
{
    public partial class SinhVienXemThoiKhoaBieu : Form
    {

        private TaiKhoanDAO loginAccount;
        public string tensv;
        string mssv = "";
        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public SinhVienXemThoiKhoaBieu()
        {
            InitializeComponent();

        }
        public SinhVienXemThoiKhoaBieu(string masosv, string hotensv) : this()
        {
            mssv = masosv;
            tensv = hotensv;
            lblMSSV.Text = mssv;
            lblName.Text = tensv;
            LoadComboBoxes();
            LoadData();
        }
        private void LoadComboBoxes()
        {
            // Gọi DAO để lấy danh sách HocKy và NamHoc
            List<string> hocKyList = ThoiKhoaBieuBUS.Instance.LayDanhSachHocKy(mssv);
            List<string> namHocList = ThoiKhoaBieuBUS.Instance.LayDanhSachNamHoc(mssv);

            // Gán danh sách HocKy và NamHoc cho DataSource của ComboBox tương ứng
            cboHocKy.DataSource = hocKyList;
            cboNamHoc.DataSource = namHocList;
        }
        private void LoadData(string maSV = null, string namHoc = null, string hocKy = null)
        {
            string MSSV = lblMSSV.Text;
            string selectedYear = cboNamHoc.SelectedItem?.ToString();
            string selectedSemester = cboHocKy.SelectedItem?.ToString();

            dataGridView.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanTheoMSSV(MSSV, selectedYear, selectedSemester);

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã chọn giá trị cho cả hai ComboBox
            if (KiemTraGiaTriDaChon())
            {
                // Nếu đã đủ giá trị, mở form in thời khóa biểu
                InThoiKhoaBieu inThoiKhoaBieu = new InThoiKhoaBieu(lblMSSV.Text, cboHocKy.SelectedItem.ToString(), string.Format("{0}", cboNamHoc.SelectedItem));
                inThoiKhoaBieu.ShowDialog();
            }

            else
            {
                // Nếu chưa đủ giá trị, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn giá trị cho cả học kỳ và năm học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KiemTraGiaTriDaChon()
        {

            // Kiểm tra xem ComboBox Học kỳ và Năm học đã chọn giá trị nào chưa
            if (cboHocKy.SelectedItem != null && cboNamHoc.SelectedItem != null)
            {
                return true; // Trả về true nếu đã chọn đủ giá trị cho cả hai ComboBox
            }
            else
            {
                return false; // Trả về false nếu có ít nhất một ComboBox chưa được chọn giá trị
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
