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

namespace GUI
{
    public partial class DanhSachSinhVien : Form
    {
    
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

            dtgvDanhSachSinhVien.DataSource = SinhVienBUS.Instance.LayToanBoSinhVien();
            // Load danh sách khoa vào ComboBox
            DataTable dtKhoa = KhoaBUS.Instance.LayKhoa();
            if (dtKhoa != null && dtKhoa.Rows.Count > 0)
            {
                // Thiết lập DataSource cho ComboBox Khoa
                cboKhoa.DataSource = dtKhoa;
                cboKhoa.ValueMember = "MaKhoa";
                // Thiết lập trường cần hiển thị lên ComboBox (ở đây là trường "MaKhoa")
                cboKhoa.DisplayMember = "TenKhoa";
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu hoặc lỗi khi truy vấn
                // Ví dụ: MessageBox.Show("Không có dữ liệu khoa.");
            }

            DataTable dtLop = SinhVienBUS.Instance.LayLop();
            if (dtLop != null && dtLop.Rows.Count > 0)
            {
                // Thiết lập DataSource cho ComboBox Khoa
                cboLop.DataSource = dtLop;
                cboLop.ValueMember = "Lop";
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu hoặc lỗi khi truy vấn
                // Ví dụ: MessageBox.Show("Không có dữ liệu khoa.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSinhVien.Text;
            string Khoa = cboKhoa.SelectedValue?.ToString() ?? "";
            string Lop = cboLop.SelectedValue?.ToString() ?? "";

            dtgvDanhSachSinhVien.DataSource = SinhVienBUS.Instance.timKiemSVTrongDSSV(MaSV, Khoa, Lop);
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new ThongTinSV(null, null, null, null, null, null, null, null, null).ShowDialog();

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
                    thongTinSVForm.ShowDialog();

                }
            }
        }
        private void dtgvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvDanhSachSinhVien.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                string MaSV = dtgvDanhSachSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                bool result = SinhVienBUS.Instance.XoaSV(MaSV);

                // Kiểm tra kết quả và cập nhật DataGridView nếu cần thiết
                if (result)
                {
                    // Xóa hàng tương ứng trong DataGridView
                    dtgvDanhSachSinhVien.Rows.RemoveAt(e.RowIndex);

                }
                MessageBox.Show("Xóa thành công ");

            }
        }
        public void LoadLaiDuLieu()
        {
            dtgvDanhSachSinhVien.DataSource = SinhVienDAO.Instance.LayToanBoSinhVien();

        }
        private void txt_Load_Click(object sender, EventArgs e)
        {
            dtgvDanhSachSinhVien.DataSource = SinhVienDAO.Instance.LayToanBoSinhVien();
        }
        
    }
}
