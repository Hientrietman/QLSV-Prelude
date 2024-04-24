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
    public partial class ThemDiemChoSinhVien : Form
    {
        private DataGridView _dataGridView;
        public ThemDiemChoSinhVien(string maSinhVien, string maHocPhan, string tenSinhVien, DataGridView dataGridView)
        {
            InitializeComponent();
            lblMaLopHPParam.Text = maHocPhan;
            lblMSSVParam.Text = maSinhVien;
            lblHoTenSVParam.Text = tenSinhVien;
            _dataGridView = dataGridView; // Lưu tham chiếu của DataGridView
            LoadDiem();
        }

        private void LoadDiem()
        {

            // Gọi procedure để lấy dữ liệu điểm từ cơ sở dữ liệu

            System.Data.DataTable dataTable = new System.Data.DataTable();

            dataTable = DiemBUS.Instance.LayDiemSinhVien(lblMaLopHPParam.Text, lblMSSVParam.Text);


            if (dataTable.Rows.Count > 0)
            {
                // Lấy dữ liệu từ DataTable và hiển thị lên các ô textbox
                txtDiemQuaTrinh.Text = dataTable.Rows[0]["DiemQuaTrinh"].ToString();
                txtDiemGiuaKy.Text = dataTable.Rows[0]["DiemGiuaKy"].ToString();
                txtDiemCuoiKy.Text = dataTable.Rows[0]["DiemCuoiKy"].ToString();

                // Chỉnh thuộc tính Enable của các ô textbox tùy thuộc vào giá trị của điểm
                txtDiemQuaTrinh.Enabled = string.IsNullOrEmpty(txtDiemQuaTrinh.Text);
                txtDiemGiuaKy.Enabled = string.IsNullOrEmpty(txtDiemGiuaKy.Text);
                txtDiemCuoiKy.Enabled = string.IsNullOrEmpty(txtDiemCuoiKy.Text);
            }
            else
            {
                // Nếu không có dữ liệu tức là chưa có 1 con điểm nào cả thì sẽ enable
                txtDiemQuaTrinh.Enabled = true;
                txtDiemGiuaKy.Enabled = true;
                txtDiemCuoiKy.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maHocPhan = lblMaLopHPParam.Text;
            string maSV = lblMSSVParam.Text;

            if (IsValidDiem(txtDiemQuaTrinh.Text) && IsValidDiem(txtDiemGiuaKy.Text) && IsValidDiem(txtDiemCuoiKy.Text))
            {
                float? diemQuaTrinh = string.IsNullOrEmpty(txtDiemQuaTrinh.Text) ? null : (float?)Convert.ToDouble(txtDiemQuaTrinh.Text);
                float? diemGiuaKy = string.IsNullOrEmpty(txtDiemGiuaKy.Text) ? null : (float?)Convert.ToDouble(txtDiemGiuaKy.Text);
                float? diemCuoiKy = string.IsNullOrEmpty(txtDiemCuoiKy.Text) ? null : (float?)Convert.ToDouble(txtDiemCuoiKy.Text);

                if (!DiemDAO.Instance.CheckKhoaChinh(maHocPhan, maSV))
                {
                    DiemDAO.Instance.SetKhoaChinh(maHocPhan, maSV);
                }

                if (DiemBUS.Instance.UpdateDiemSinhVien(maHocPhan, maSV, diemQuaTrinh, diemGiuaKy, diemCuoiKy))
                {
                    MessageBox.Show("Thêm điểm thành công");
                    LoadDiem();
                    _dataGridView.DataSource = SinhVienBUS.Instance.LayDanhSachSVCuaLopHocPhan(lblMaLopHPParam.Text);
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm điểm");
                }
            }
            else
            {
                MessageBox.Show("Sai quy định nhập điểm, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidDiem(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return true; // Cho phép rỗng, vì có thể điểm chưa được nhập

            float value;
            if (!float.TryParse(text, out value))
                return false; // Không phải số hợp lệ

            if (value < 0 || value > 10)
                return false; // Số không nằm trong khoảng từ 0 đến 10

            return true; // Số hợp lệ
        }
    }
}
