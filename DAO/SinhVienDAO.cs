using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienDAO
    {
        public SinhVienDAO() { }

        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachSVCuaLopHocPhan(string MaHocPhan)
        {
            string query = String.Format("EXEC LayDanhSachSVCuaLopHocPhan @MaHocPhan = '{0}'", MaHocPhan);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemMaSVTrongLopHocPhan(string MaHP, string MaSV)
        {

            string query = String.Format("EXEC TimKiemSVTrongLopHocPhan @MaHocPhan = '{0}', @MaSV = '{1}';", MaHP, MaSV);

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayThongTinSinhVien(string MaSV)
        {
            string query = String.Format("SELECT * FROM SinhVien WHERE MaSV = '{0}'", MaSV);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ChinhSuaThongTinSinhVien(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh)
        {
            string query = string.Format("EXEC ChinhSuaThongTinSinhVien @MaSV = '{0}', @Lop = '{1}', @Email = '{2}', @SDT = '{3}', @NgaySinh = '{4}', @DiaChi = '{5}', @HoTen = N'{6}', @GioiTinh = N'{7}';", MaSV, Lop, Email, SDT, NgaySinh.ToString("yyyy-MM-dd"), DiaChi, HoTen, GioiTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public DataTable LayToanBoSinhVien()
        {
            string query = String.Format("EXEC LayDSSV");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timKiemSVTrongDSSV(string maSV, string maKhoa, string lop)
        {
            // Sử dụng String.Format để tạo câu lệnh SQL với các tham số được thay thế
            string query = "EXEC TimKiemSVTrongDSSV ";
            query += (maSV != null) ? $"@MaSV = '{maSV}', " : "@MaSV = NULL, "; // Kiểm tra và thêm tham số maSV
            query += (maKhoa != null) ? $"@MaKhoa = '{maKhoa}', " : "@MaKhoa = NULL, "; // Kiểm tra và thêm tham số maKhoa
            query += (lop != null) ? $"@Lop = '{lop}'" : "@Lop = NULL"; // Kiểm tra và thêm tham số lop

            // Gọi phương thức ExecuteQuery để thực hiện câu lệnh SQL
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool CapNhatSV(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh, string Khoa)
        {
            string query = string.Format("EXEC CapNhatSV @MaSV = '{0}', @Lop = '{1}', @Email = '{2}', @SDT = '{3}', @NgaySinh = '{4}', @DiaChi = '{5}', @HoTen = N'{6}', @GioiTinh = N'{7}',@MaKhoa=N'{8}';", MaSV, Lop, Email, SDT, NgaySinh.ToString("yyyy-MM-dd"), DiaChi, HoTen, GioiTinh, Khoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool ThemSV(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh, string Khoa)
        {
            string query = string.Format("EXEC ThemSV @MaSV = '{0}', @Lop = '{1}', @Email = '{2}', @SDT = '{3}', @NgaySinh = '{4}', @DiaChi = '{5}', @HoTen = N'{6}', @GioiTinh = N'{7}',@MaKhoa=N'{8}';", MaSV, Lop, Email, SDT, NgaySinh.ToString("yyyy-MM-dd"), DiaChi, HoTen, GioiTinh, Khoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
        public bool XoaSV(string MaSV)
        {
            string query = string.Format("EXEC XoaSV @MaSV = '{0}';", MaSV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable LayLop()
        {
            string query = string.Format("Select Lop from SinhVien");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayLopTheoKhoa(string maKhoa)
        {
            string query = string.Format("EXEC LayLopTheoKhoa @MaKhoa = '{0}';", maKhoa);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool XoaSinhVien(string MaSV)
        {
            string query = string.Format("EXEC XoaSinhVien @MaSV = '{0}';", MaSV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool IsStudentIdExists(string maSV)
        {
            string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
            object[] parameter = { maSV };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameter);
            return count > 0;
        }

        public bool IsStudentEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM SinhVien WHERE Email = @Email";
            object[] parameter = { email };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameter);
            return count > 0;
        }
    }
}
