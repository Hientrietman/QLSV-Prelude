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
        //bool isError = false;
        private TaiKhoanDAO loginAccount;
        public string mssv;
        public string tensv;
        public string namhoc;
        public string hocky;
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
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView
            LoadData();

            // Populate years and semesters
            PopulateYears();
            PopulateSemesters();
        }
        
       
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadData();
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(string maSV = null, string namHoc = null, string hocKy = null)
        {
            string MSSV = lblMSSV.Text;
            string selectedYear = cboNamHoc.SelectedItem?.ToString();
            string selectedSemester = cboHocKy.SelectedItem?.ToString();

            dataGridView.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanTheoMSSV(MSSV, selectedYear, selectedSemester);

        }
        
        private List<string> PopulateYears()
        {
            List<string> years  = HocPhanBUS.GetDistinctYears(); // Lấy danh sách các năm học từ cơ sở dữ liệu
            foreach (string year in years)
            {
                cboNamHoc.Items.Add(year);
            }

            cboNamHoc.SelectedIndex = 0;
            return years;
        }

        private List<string> PopulateSemesters()
        {
            List<string> semesters = HocPhanBUS.GetDistinctSemesters(); // Lấy danh sách các học kỳ từ cơ sở dữ liệu

            foreach (string semester in semesters)
            {
                cboNamHoc.Items.Add(semester);
            }            
            cboNamHoc.SelectedIndex = 0;
            return  semesters;
        }
        
       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã chọn giá trị cho cả hai ComboBox
            if (KiemTraGiaTriDaChon() && KiemTraTKB())
            {
                // Nếu đã đủ giá trị, mở form in thời khóa biểu
                InThoiKhoaBieu inThoiKhoaBieu = new InThoiKhoaBieu(lblMSSV.Text, cboHocKy.SelectedItem.ToString(), string.Format("{0}", cboNamHoc.SelectedItem));
                inThoiKhoaBieu.ShowDialog();
            }

            else
            {
                // Nếu chưa đủ giá trị, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn giá trị cho cả học kỳ và năm học hoặc không có thời khóa biểu cho niên học này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool KiemTraTKB()
        {

            bool dataGridViewHasNull = false;
            for (int i = 1; i < dataGridView.Rows.Count; i++)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || cell.Value == DBNull.Value)
                        {
                            dataGridViewHasNull = true;
                            // Bạn có thể dừng việc kiểm tra ở đây nếu bạn chỉ quan tâm đến việc có tồn tại giá trị null hay không
                            // break;
                        }
                    }
                }
            }
            if (dataGridViewHasNull)
            {
                // DataGridView chứa ít nhất một giá trị null
                return true;
            }
            else
            {
                // DataGridView không chứa giá trị null
                return false;
            }
        }



    }
}
