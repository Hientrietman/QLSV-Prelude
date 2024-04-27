using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyHocPhan : Form
    {
        bool isError = false;
        public QuanLyHocPhan()
        {
            InitializeComponent();
            dtgv_hocphan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhan();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các text box đã được điền đầy đủ và đáp ứng các điều kiện kiểm tra
            if (txt_mahp.Text != "" && txt_mahp.Text.Length == 10 && txt_mamh.Text != ""&&  txt_magv.Text != "" && txt_nam.Text != "" && txt_ngaybatdau.Text != "" && txt_ngayketthuc.Text != "" && label4.Text == "" && label6.Text == "" && label7.Text == "" && label8.Text == "")
            {
                // Kiểm tra định dạng của ngày bắt đầu và kết thúc
                DateTime ngayBatDau, ngayKetThuc;
                if (DateTime.TryParseExact(txt_ngaybatdau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBatDau) &&
                    DateTime.TryParseExact(txt_ngayketthuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKetThuc))
                {
                    // Tạo một đối tượng hocPhan từ dữ liệu nhập vào từ các text box
                    HocPhanDTO hocPhan = new HocPhanDTO(txt_mahp.Text, txt_mamh.Text, txt_tenhp.Text, txt_magv.Text, txt_nam.Text, txt_ngaybatdau.Text, txt_ngayketthuc.Text, txt_tinchi.Text, txt_thongtin.Text);

                    // Thực hiện thêm vào CSDL thông qua lớp BUS
                    HocPhanBUS.Instance.ThemHocPhan(hocPhan);
                    MessageBox.Show("Thêm thành công");
                    dtgv_hocphan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhan();
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu định dạng ngày không hợp lệ
                    MessageBox.Show("Định dạng ngày không hợp lệ. Vui lòng nhập ngày theo định dạng dd/MM/yyyy.");
                }
            }
            else
            {
                // Nếu không đáp ứng các điều kiện, hiển thị thông báo lỗi hoặc thực hiện hành động phù hợp khác
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và kiểm tra lại các điều kiện!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_mahp.Text != "" && txt_mahp.Text.Length == 10)
            {
                HocPhanDTO hocPhan = new HocPhanDTO(txt_mahp.Text, txt_mamh.Text, txt_tenhp.Text, txt_magv.Text, txt_nam.Text, txt_ngaybatdau.Text, txt_ngayketthuc.Text, txt_tinchi.Text, txt_thongtin.Text);

                if (KiemTraMaHocPhan(txt_mahp.Text))
                {
                    //txt_mahp_Edit();

                    HocPhanBUS.Instance.SuaHocPhan(hocPhan);
                    MessageBox.Show("Sửa thành công");
                    dtgv_hocphan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhanEdit();

                }
                else
                {
                    // Hiển thị thông báo lỗi nếu định dạng ngày không hợp lệ
                    MessageBox.Show("Mã học phần không tồn tại!");

                }
            }
            else 
            {
                // Nếu không đáp ứng các điều kiện, hiển thị thông báo lỗi hoặc thực hiện hành động phù hợp khác
                MessageBox.Show("Vui lòng điền đúng mã học phần!");
            }
        }

        private bool KiemTraMaMonHoc(string mamh)
        {
            return HocPhanBUS.Instance.KiemTraMaMonHoc(mamh);
        }
        private bool KiemTraMaHocPhan(string MaHP)
        {
            return HocPhanBUS.Instance.KiemTraMaHocPhan(MaHP);
        }
        private bool KiemTraMaGiangVien(string mamh)
        {
            return HocPhanBUS.Instance.KiemTraMaGiangVien(mamh);
        }
        private string LayTinChiMonHoc(string tinchi)
        {
            return HocPhanBUS.Instance.LayTinChi(tinchi);
        }
        private string LayTinChiEdit(string tinchi)
        {
            return HocPhanBUS.Instance.LayTinChiEdit(tinchi);
        }

        private void txt_mamh_Leave(object sender, EventArgs e)
        {

        }
        private void txt_mahp_Leave(object sender, EventArgs e)
        {
            if (!KiemTraMaMonHoc(txt_mamh.Text))
            {
                lbl_Emamh.Text = "Mã môn học này không tồn tại!";
                txt_tinchi.Clear();
                txt_tenhp.Clear();
            }
            else if (KiemTraMaMonHoc(txt_mamh.Text))
            {

                txt_tinchi.Text = LayTinChiMonHoc(txt_mamh.Text);
                lbl_Emamh.Text = " ";
                txt_tenhp.Text = HocPhanBUS.Instance.LayTenMonHoc(txt_mamh.Text);
            }


        }
        
        private void txt_magv_Leave(object sender, EventArgs e)
        {
            if (!KiemTraMaGiangVien(txt_magv.Text))
            {
                lbl_Emagv.Text = "Giảng viên này không tồn tại!";
            }
            else if (txt_magv.Text == " ")
            {
                lbl_Emagv.Text = " ";
            }
            else if (KiemTraMaGiangVien(txt_magv.Text))
            {
                lbl_Emagv.Text = " ";

            }

        }

        private void txt_ngaybatdau_Leave(object sender, EventArgs e)
        {
            // Kiểm tra định dạng của ngày bắt đầu
            DateTime ngayBatDau;
            if (!DateTime.TryParseExact(txt_ngaybatdau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBatDau))
            {
                // Nếu không đúng định dạng, hiển thị thông báo lỗi trên label6
                label6.Text = "Định dạng ngày không hợp lệ. Vui lòng nhập ngày theo định dạng dd/MM/yyyy.";
            }
            else
            {
                // Nếu đúng định dạng, xóa thông báo lỗi trên label6 (nếu có)
                label6.Text = "";
            }
        }

        private void txt_ngayketthuc_Leave(object sender, EventArgs e)
        {
            // Kiểm tra định dạng của ngày kết thúc
            DateTime ngayKetThuc;
            if (!DateTime.TryParseExact(txt_ngayketthuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKetThuc))
            {
                // Nếu không đúng định dạng, hiển thị thông báo lỗi trên label7
                label7.Text = "Định dạng ngày không hợp lệ. Vui lòng nhập ngày theo định dạng dd/MM/yyyy.";
            }
            else
            {
                // Nếu đúng định dạng, kiểm tra xem ngày kết thúc có lớn hơn ngày bắt đầu không
                DateTime ngayBatDau;
                if (DateTime.TryParseExact(txt_ngaybatdau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBatDau))
                {
                    if (ngayKetThuc <= ngayBatDau)
                    {
                        // Nếu ngày kết thúc không lớn hơn ngày bắt đầu, hiển thị thông báo lỗi trên label7
                        label7.Text = "Ngày kết thúc phải lớn hơn ngày bắt đầu!";
                    }
                    else
                    {
                        // Nếu đúng định dạng và ngày kết thúc lớn hơn ngày bắt đầu, xóa thông báo lỗi trên label7 (nếu có)
                        label7.Text = "";
                    }
                }
            }
        }

        private void txt_nam_Leave(object sender, EventArgs e)
        {
            int nam;
            if (!int.TryParse(txt_nam.Text, out nam) || txt_nam.Text.Length != 4 || nam < DateTime.Now.Year)
            {
                // Nếu không phải định dạng yyyy hoặc nhỏ hơn năm hiện tại, hiển thị thông báo lỗi trên label8
                label8.Text = "Năm phải là định dạng yyyy và lớn hơn hoặc bằng năm hiện tại!";
            }
            else
            {
                // Nếu đúng định dạng và lớn hơn hoặc bằng năm hiện tại, xóa thông báo lỗi trên label8 (nếu có)
                label8.Text = "";
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            /*hocPhanStr = txt_mahp.Text;*/
            if (txt_mahp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học phần cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahp.Focus();
            }
            else
            {
                try
                {
                    // Thực hiện xóa học phần dựa trên mã học phần được nhập từ textbox
                    HocPhanDTO hocPhan = new HocPhanDTO(txt_mahp.Text, "", "", "", "", "", "", "", "");
                    bool success = HocPhanBUS.Instance.XoaHocPhan(hocPhan);

                    if (success)
                    {
                        // Load lại bảng datagridview sau khi xóa học phần
                        dtgv_hocphan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhan();
                        MessageBox.Show("Đã xóa học phần thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa học phần thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgv_hocphan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_hocphan.Rows[e.RowIndex];

                /*DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hocphan.Rows[e.RowIndex];*/
                txt_mahp.Text = Convert.ToString(row.Cells["MaHocPhan"].Value);
                txt_mamh.Text = Convert.ToString(row.Cells["MaMonHoc"].Value);
                txt_tenhp.Text = Convert.ToString(row.Cells["TenHocPhan"].Value);
                txt_magv.Text = Convert.ToString(row.Cells["MaGV"].Value);
                txt_nam.Text = Convert.ToString(row.Cells["Nam"].Value);
                txt_ngaybatdau.Text = Convert.ToString(row.Cells["NgayMoDau"].Value);
                txt_ngayketthuc.Text = Convert.ToString(row.Cells["NgayKetThuc"].Value);
                txt_tinchi.Text = Convert.ToString(row.Cells["TinChi"].Value);
                txt_thongtin.Text = Convert.ToString(row.Cells["ThongTin"].Value);
            }
        }

        private void txt_mahp_TextChanged(object sender, EventArgs e)
        {
            if (txt_mahp.Text.Length != 10)
            {
                // Hiển thị thông báo lỗi trên label4
                label4.Text = "Mã học phần phải có 10 ký tự!";
            }
            else
            {
                label4.Text = "";
            }
        }

        private void txt_mamh_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraMaMonHoc(txt_mamh.Text))
            {
                lbl_Emamh.Text = "Mã môn học này không tồn tại!";
                txt_tinchi.Clear();
                txt_tenhp.Clear();
            }
            else if (KiemTraMaMonHoc(txt_mamh.Text))
            {
                txt_tinchi.Text = LayTinChiMonHoc(txt_mamh.Text);
                lbl_Emamh.Text = " ";
                txt_tenhp.Text = HocPhanBUS.Instance.LayTenMonHoc(txt_mamh.Text);
            }
        }
    }
}
