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
    public partial class SinhVienXemDiemThi : Form
    {
        private TaiKhoanDTO taiKhoan;
        string maSV = "";
        string hocKy = "";
        string namHoc = "";
        public SinhVienXemDiemThi(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            taiKhoan = TaiKhoan;
            lblMaSinhVienParam.Text = taiKhoan.TenDangNhap;
            lblHoTenSVParam.Text = LayTenSinhVien(taiKhoan.TenDangNhap);
            maSV = lblMaSinhVienParam.Text;
            LoadComboBoxes();
            hocKy = cboHocKy.SelectedItem.ToString();
            namHoc = cboNamHoc.SelectedItem.ToString();
            dtgvBangDiemSinhVien.DataSource = DiemBUS.Instance.LayDiemSinhVienTheoTKB(maSV, hocKy, namHoc);
            if (KiemTraDiemTrungBinhDayDu())
            {
                TinhDiemTrungBinhChung();
            }
        }

        private string LayTenSinhVien(string tenDangNhap)
        {
            string TenSV = "";

            DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                TenSV = dt.Rows[0]["HoTen"].ToString();
            }

            return TenSV;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            maSV = lblMaSinhVienParam.Text;
            hocKy = cboHocKy.SelectedItem.ToString();
            namHoc = cboNamHoc.SelectedItem.ToString();
            dtgvBangDiemSinhVien.DataSource = DiemBUS.Instance.LayDiemSinhVienTheoTKB(maSV, hocKy, namHoc);
            if (KiemTraDiemTrungBinhDayDu())
            {
                TinhDiemTrungBinhChung();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            dtgvBangDiemSinhVien.DataSource = DiemBUS.Instance.LayDiemSinhVienBangMSSV(maSV);
            if (KiemTraDiemTrungBinhDayDu())
            {
                TinhDiemTrungBinhChung();
            }
        }

        private void LoadComboBoxes()
        {
            // Gọi DAO để lấy danh sách HocKy và NamHoc
            List<string> hocKyList = ThoiKhoaBieuBUS.Instance.LayDanhSachHocKy(maSV);
            List<string> namHocList = ThoiKhoaBieuBUS.Instance.LayDanhSachNamHoc(maSV);

            // Gán danh sách HocKy và NamHoc cho DataSource của ComboBox tương ứng
            cboHocKy.DataSource = hocKyList;
            cboNamHoc.DataSource = namHocList;
        }

        public double ConvertToFourPointScale(double score)
        {
            if (score >= 8.5 && score <= 10)
                return 4.0;
            else if (score >= 7.8 && score <= 8.4)
                return 3.5;
            else if (score >= 7.0 && score <= 7.7)
                return 3.0;
            else if (score >= 6.3 && score <= 6.9)
                return 2.5;
            else if (score >= 5.5 && score <= 6.2)
                return 2.0;
            else if (score >= 4.8 && score <= 5.4)
                return 1.5;
            else if (score >= 4.0 && score <= 4.7)
                return 1.0;
            else if (score >= 3.0 && score <= 3.9)
                return 0.5;
            else if (score >= 0.0 && score <= 2.9)
                return 0.0;
            else
                throw new ArgumentException("Invalid score. Score must be between 0 and 10.");
        }

        private void TinhDiemTrungBinhChung()
        {
            double tongDiemTichLuy = 0;
            int tongSoTinChi = 0;
            string xepLoai = "";

            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dtgvBangDiemSinhVien.Rows)
            {
                // Kiểm tra nếu dòng đó không phải là dòng cuối cùng và không phải dòng header
                if (!row.IsNewRow && row.Cells.Count > 0)
                {
                    // Lấy điểm từ cột điểm trung bình (cột có index là 7)
                    double diem = Convert.ToDouble(row.Cells[7].Value);

                    // Quy đổi điểm từ thang điểm 10 sang thang điểm 4
                    double diemQuyDoi = ConvertToFourPointScale(diem);

                    // Lấy số tín chỉ từ cột tín chỉ (cột có index là 3)
                    int soTinChi = Convert.ToInt32(row.Cells[3].Value);

                    // Tính điểm tích lũy
                    tongDiemTichLuy += diemQuyDoi * soTinChi;

                    // Tổng số tín chỉ
                    tongSoTinChi += soTinChi;
                }
            }

            // Kiểm tra tổng số tín chỉ có lớn hơn 0 hay không để tránh chia cho 0
            if (tongSoTinChi > 0)
            {
                // Tính điểm trung bình chung
                double diemTBChung = tongDiemTichLuy / tongSoTinChi;
                xepLoai = XepLoai(diemTBChung);
                // Gán kết quả cho Label
                lblDiemTBDaTinh.Text = diemTBChung.ToString("0.00");
                lblXepLoaiDaTinh.Text = xepLoai;
            }
            else
            {
                // Nếu không có dữ liệu hoặc tổng số tín chỉ bằng 0, hiển thị thông báo
                lblDiemTBDaTinh.Text = "Không có dữ liệu";
            }
        }

        private bool KiemTraDiemTrungBinhDayDu()
        {
            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dtgvBangDiemSinhVien.Rows)
            {
                // Kiểm tra nếu dòng đó không phải là dòng cuối cùng và không phải dòng header
                if (!row.IsNewRow && row.Cells.Count > 0)
                {
                    // Kiểm tra giá trị của ô trong cột Điểm Trung bình
                    if (row.Cells["DiemTrungBinh"].Value == null || string.IsNullOrEmpty(row.Cells["DiemTrungBinh"].Value.ToString()))
                    {
                        // Nếu ô không có giá trị, trả về false
                        lblDiemTBDaTinh.Text = "Chưa đủ điểm";
                        lblXepLoaiDaTinh.Text = "Chưa xếp loại";
                        return false;
                    }
                }
            }

            // Nếu tất cả các ô trong cột Điểm Trung bình đều có giá trị, trả về true
            return true;
        }

        private string XepLoai(double diemTrungBinhChung)
        {
            if (diemTrungBinhChung >= 3.6)
            {
                return "Xuất sắc";
            }
            else if (diemTrungBinhChung >= 3.2)
            {
                return "Giỏi";
            }
            else if (diemTrungBinhChung >= 2.5)
            {
                return "Khá";
            }
            else if (diemTrungBinhChung >= 2.0)
            {
                return "Trung bình";
            }
            else if (diemTrungBinhChung >= 1.0)
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

    }

}
