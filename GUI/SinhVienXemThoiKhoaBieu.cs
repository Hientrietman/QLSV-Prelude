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

            MessageBox.Show("Phần này bạn Huy xử lý ");
        }

       

    }
}
