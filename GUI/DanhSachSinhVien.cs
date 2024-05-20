using BUS;
using DAO;
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
    public partial class DanhSachSinhVien : Form
    {
        public event EventHandler DataUpdated;

        private static DanhSachSinhVien instance;

        public static DanhSachSinhVien Instance
        {
            get { if (instance == null) instance = new DanhSachSinhVien(); return instance; }
            private set { instance = value; }
        }
        public DanhSachSinhVien()
        {
            InitializeComponent();
            ThongTinSV thongTinSV = new ThongTinSV();


        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
           /* LoadLaiDuLieu();*/
            DataTable dtKhoa = KhoaBUS.Instance.LayKhoa();
            if (dtKhoa != null && dtKhoa.Rows.Count > 0)
            {
                cboKhoa.DataSource = dtKhoa;
                cboKhoa.ValueMember = "MaKhoa";
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.SelectedIndex = -1;


            }
            // Thêm sự kiện SelectedIndexChanged cho cboKhoa
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            

        }
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue != null)
            {
                string maKhoa = cboKhoa.SelectedValue.ToString();
                LoadLopTheoKhoa(maKhoa);
            }
        }
        private void LoadLopTheoKhoa(string maKhoa)
        {
            DataTable dtLop = SinhVienBUS.Instance.LayLopTheoKhoa(maKhoa);
            if (dtLop != null && dtLop.Rows.Count > 0)
            {
                cboLop.DataSource = dtLop;
                cboLop.ValueMember = "Lop";
                cboLop.DisplayMember = "Lop";
                cboLop.SelectedIndex = -1;
            }
            else
            {
                cboLop.DataSource = null;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSinhVien.Text;
            string Khoa = cboKhoa.SelectedValue?.ToString() ?? "";
            string Lop = cboLop.SelectedValue?.ToString() ?? "";
            if (string.IsNullOrEmpty(MaSV) && string.IsNullOrEmpty(Khoa) && string.IsNullOrEmpty(Lop))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên hoặc chọn một khoa hoặc lớp để tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtgvDanhSachSinhVien.DataSource = SinhVienBUS.Instance.timKiemSVTrongDSSV(MaSV, Khoa, Lop);
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            //new ThongTinSV(null, null, null, null, null, null, null, null, null).ShowDialog();
            ThongTinSV thongTinSVForm = new ThongTinSV(null, null, null, null, null, null, null, null, null);
            thongTinSVForm.DataUpdated += F_DataUpdated;
            thongTinSVForm.ShowDialog();
        }

        private void dtgvDanhSachSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                /*string MaSV = dtgvDanhSachSinhVien.CurrentCell.Value.ToString(); // Get value of current cell
                new ThongTinSV(MaSV).ShowDialog();*/
                DataGridView dtgv = (DataGridView)sender;
                if (dtgvDanhSachSinhVien.CurrentCell != null)
                {

                    string MaSV = dtgvDanhSachSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
                    string HoTen = dtgvDanhSachSinhVien.CurrentRow.Cells["HoTen"].Value.ToString();
                    string GioiTinh = dtgvDanhSachSinhVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
                    string NgaySinh = dtgvDanhSachSinhVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
                    //string NgaySinh = DateTime.ParseExact(dtgvDanhSachSinhVien.CurrentRow.Cells["NgaySinh"].Value.ToString(),"dd/MM/yyyy",null).ToString();
                    string DiaChi = dtgvDanhSachSinhVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                    string SoDienThoai = dtgvDanhSachSinhVien.CurrentRow.Cells["SDT"].Value.ToString();
                    string Lop = dtgvDanhSachSinhVien.CurrentRow.Cells["Lop"].Value.ToString();
                    string Khoa = dtgvDanhSachSinhVien.CurrentRow.Cells["TenKhoa"].Value.ToString();
                    string Email = dtgvDanhSachSinhVien.CurrentRow.Cells["Email"].Value.ToString();


                    ThongTinSV thongTinSVForm = new ThongTinSV(MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Lop, Khoa, Email);
                    thongTinSVForm.DataUpdated += F_DataUpdated;
                    thongTinSVForm.ShowDialog();


                }
            }
        }
        private void dtgvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvDanhSachSinhVien.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                string MaSV = dtgvDanhSachSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                bool result = SinhVienBUS.Instance.XoaSinhVien(MaSV);

                // Kiểm tra kết quả và cập nhật DataGridView nếu cần thiết
                if (result)
                {
                    // Xóa hàng tương ứng trong DataGridView
                    dtgvDanhSachSinhVien.Rows.RemoveAt(e.RowIndex);

                }
                MessageBox.Show("Xóa thành công ");
                LoadLaiDuLieu();
                //OnDataUpdated();
                //this.Close();

            }
        }
        public void LoadLaiDuLieu()
        {
            dtgvDanhSachSinhVien.DataSource = SinhVienDAO.Instance.LayToanBoSinhVien();

        }

        private void F_DataUpdated(object sender, EventArgs e)
        {
            LoadLaiDuLieu();
        }
        protected virtual void OnDataUpdated()
        {
            EventHandler handler = DataUpdated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

      
        public bool IsStudentIdExists(string maSV)
        {
            foreach (DataGridViewRow row in dtgvDanhSachSinhVien.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadLaiDuLieu();
        }
    }
}
