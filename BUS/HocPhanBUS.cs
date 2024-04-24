using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocPhanBUS
    {
        private HocPhanBUS() { }
        private static HocPhanBUS instance;
        public static HocPhanBUS Instance
        {
            get { if (instance == null) instance = new HocPhanBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable TimKiemMaHP(string MaHP)
        {
            return HocPhanDAO.Instance.TimKiemMaHP(MaHP);
        }

        public DataTable TimKiemMaHPCuaGV(string MaGV, string MaHP)
        {
            return HocPhanDAO.Instance.TimKiemMaHPCuaGV(MaGV, MaHP);
        }
        public DataTable TimKiemLopHP(int NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.TimKiemLopHP(NamHoc,MaHP);
        }
        public bool KiemTraNamHoc(int kiemtraNamHoc, string MaHocPhan)
        {
            return HocPhanDAO.Instance.KiemTraNamHoc(kiemtraNamHoc, MaHocPhan);
        }
        public bool KiemTraHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.KiemTraHocPhan(MSSV, HocKy, NamHoc, MaHP);
        }
        public bool KiemTraMonHoc(string MSSV, int HocKy, string NamHoc, string MaHP, string MaMH)
        {
            return HocPhanDAO.Instance.KiemTraMonHoc(MSSV, HocKy, NamHoc, MaHP, MaMH);
        }

        public DataTable LayDanhSachHocPhan()
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhan();
        }
        public DataTable LayDanhSachHocPhanTheoMSSV(string MaSinhVien, string NamHoc, string HocKy)
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhanTheoMSSV(MaSinhVien, NamHoc, HocKy);
        }

        public DataTable LayDanhSachHocPhanEdit()
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhanEdit();
        }

        public DataTable LayDanhSachHocPhanCuaGV(string TenDangNhap)
        {          
            return HocPhanDAO.Instance.LayDanhSachHocPhanCuaGV(TenDangNhap);
        }

        public DataTable LayDanhSachHocPhanCuaSV(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhanCuaSV(MSSV,HocKy,NamHoc);
        }
        public DataTable ThemHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.ThemHocPhan(MSSV, HocKy, NamHoc,MaHP);
        }
        public DataTable TimThoiKhoaBieu(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHoc);
        }
        public bool KiemTraTKB(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.KiemTraTKB(MSSV, HocKy, NamHoc);
        }


        public DataTable ThemHocPhan(HocPhanDTO hocPhan)
        {
            string query = String.Format("INSERT INTO HocPhan (MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam,NgayMoDau,NgayKetThuc,TinChi,ThongTin ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}')",
                hocPhan.MaHP, hocPhan.MaMH, hocPhan.TenHocPhan, hocPhan.MaGV, hocPhan.Nam, hocPhan.NgayMoDau, hocPhan.NgayKetThuc, hocPhan.TinChi, hocPhan.ThongTin);

            return DataProvider.Instance.ExecuteQuery(query);
        }


        public DataTable SuaHocPhan(HocPhanDTO hocPhan)
        {

            string query = String.Format("UPDATE HocPhan SET MaMonHoc = '{1}', TenHocPhan = '{2}', MaGV = '{3}', Nam = '{4}', NgayMoDau = '{5}', NgayKetThuc = '{6}', TinChi = '{7}', ThongTin = '{8}' WHERE MaHocPhan = '{0}'",
                hocPhan.MaHP, hocPhan.MaMH, hocPhan.TenHocPhan, hocPhan.MaGV, hocPhan.Nam, hocPhan.NgayMoDau, hocPhan.NgayKetThuc, hocPhan.TinChi, hocPhan.ThongTin);

            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public static List<string> GetDistinctYears()
        {
            throw new NotImplementedException();
        }

        public static List<string> GetDistinctSemesters()
        {
            throw new NotImplementedException();
        }

        public bool KiemTraMaMonHoc(string mamh)
        {
            return HocPhanDAO.Instance.KiemTraMaMH(mamh);
        }
        public bool KiemTraMaHocPhan(string MaHP)
        {
            return HocPhanDAO.Instance.KiemTraMaHP(MaHP);
        }

        public string LayTinChi(string tinchi)
        {
            return HocPhanDAO.Instance.LayTinChi(tinchi);

        }
        public string LayTinChiEdit(string tinchi)
        {
            return HocPhanDAO.Instance.LayTinChiEdit(tinchi);

        }
        public bool KiemTraMaGiangVien(string mamh)
        {
            return HocPhanDAO.Instance.KiemTraMaGV(mamh);
        }

        public string LayTenMonHoc(string text)
        {
            return HocPhanDAO.Instance.LayTenMonHoc(text);
        }

        public List<string> GetDistinctYears(string NamHoc)
        {
            return HocPhanDAO.Instance.GetDistinctYears(NamHoc);
        }

        public List<string> GetDistinctSemesters(string HocKy)
        {
            return HocPhanDAO.Instance.GetDistinctSemesters(HocKy);
        }

        public string LayTenMonHocEdit(string text)
        {
            return HocPhanDAO.Instance.LayTenMonHocEdit(text);
        }
        public string LayMaMonHocEdit(string text)
        {
            return HocPhanDAO.Instance.LayMaMonHocEdit(text);
        }
        public string LayMaGiangVienEdit(string text)
        {
            return HocPhanDAO.Instance.LayMaGiangVienEdit(text);
        }
        public string LayNgayMoDauEdit(string text)
        {
            return HocPhanDAO.Instance.LayNgayMoDauEdit(text);
        }
        public string LayNgayKetThucEdit(string text)
        {
            return HocPhanDAO.Instance.LayNgayKetThucEdit(text);
        }
        public string LayNamEdit(string text)
        {
            return HocPhanDAO.Instance.LayNamEdit(text);
        }
        public string LayThongTinEdit(string text)
        {
            return HocPhanDAO.Instance.LayThongTinEdit(text);
        }

        }
        // lay danh sach thoi khoa bieu
        public DataTable LayThoiKhoaBieuSinhVien(string maSV, string HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.LayThoiKhoaBieuSinhVien(maSV, HocKy, NamHoc);
        }

        public bool XoaHocPhanTrongThoiKhoaBieuSinhVien(string maHocPhan)
        {
            try
            {

                return HocPhanDAO.Instance.XoaHocPhanTrongThoiKhoaBieuSinhVien(maHocPhan);
            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public bool XoaHocPhan(HocPhanDTO hocPhan)
        {

            /*string query = String.Format("DELETE FROM HocPhan WHERE MaHocPhan = '{0}'",hocPhan.MaHP);*/
            string query = String.Format("DELETE FROM Diem WHERE MaHocPhan = '{0}'; DELETE FROM DangKy WHERE MaHocPhan = '{0}'; DELETE FROM HocPhan WHERE MaHocPhan = '{0}';", hocPhan.MaHP);
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hocPhan.MaMH });
            return rowsAffected > 0;

            /*string query = "DELETE FROM HocPhan WHERE MaHocPhan = @MaHocPhan";

            // Create a list of SqlParameter objects
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add the parameter for MaHocPhan
            parameters.Add(new SqlParameter("@MaHocPhan", SqlDbType.VarChar) { Value = hocPhanStr });

            // Convert the list to an array
            SqlParameter[] parametersArray = parameters.ToArray();

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parametersArray);
            return rowsAffected > 0;*/

        }


        public DataTable LayDanhSachHocPhanCoDK(string MaSinhVien, string Nam)
        {

            return HocPhanDAO.Instance.LayDanhSachHocPhanCoDK(MaSinhVien, Nam);

        }

        public DataTable TimKiemMaHocPhanCoDK(string MaSinhVien, string Nam, string MaHocPhan)
        {
            return HocPhanDAO.Instance.TimKiemMaHocPhanCoDK(MaSinhVien, Nam, MaHocPhan);


        }

    }
}
