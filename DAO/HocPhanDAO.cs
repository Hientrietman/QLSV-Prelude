using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DAO
{
    public class HocPhanDAO
    {
        public HocPhanDAO() { }

        private static HocPhanDAO instance;

        public static HocPhanDAO Instance
        {
            get { if (instance == null) instance = new HocPhanDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachHocPhan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER (ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, ThongTin FROM  HocPhan;");
        }

        public DataTable LayDanhSachHocPhanCuaGV(string TenDangNhap)
        {
            string query = String.Format("SELECT ROW_NUMBER() OVER (ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM  HocPhan WHERE HocPhan.MaGV = '{0}';", TenDangNhap);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHocPhanCuaSV(string MSSV, int HocKy, string NamHoc)
        {
            string query = String.Format("EXEC GetHocPhanTheoSinhVien @MaSinhVien = '{0}', @HocKy = '{1}', @NamHoc = '{2}'", MSSV, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHocPhanEdit()
        {
            
            return DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan;");
        }

        public DataTable TimKiemMaHP(string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", MaHP);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemMaHPCuaGV(string MaGV, string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan WHERE HocPhan.MaGV = '{0}' AND dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%'", MaGV, MaHP);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHocPhanCoDK(string MaSinhVien, string Nam)
        {
            string query = String.Format("EXEC LayDanhSachHocPhanCoDK '{0}', '{1}';", MaSinhVien, Nam);
            return DataProvider.Instance.ExecuteQuery(query);

        }

        public DataTable TimKiemMaHocPhanCoDK(string MaSinhVien, string Nam, string MaHocPhan)
        {
            string query = String.Format("EXEC TimKiemMaHocPhanCoDK '{0}', '{1}', '{2}';", MaSinhVien, Nam, MaHocPhan);
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable TimKiemLopHP(int NamHoc, string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER (ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, TinChi, ThongTin, MaGV, Nam, NgayMoDau, NgayKetThuc FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND Nam = '{1}'", MaHP, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool KiemTraNamHoc(int kiemtraNamHoc, string MaHocPhan)
        {
            string query1 = String.Format("SELECT CASE WHEN EXISTS (SELECT 1 FROM HocPhan hp WHERE hp.Nam = '{0}' AND hp.MaHocPhan = '')THEN 1 ELSE 0 END", kiemtraNamHoc, MaHocPhan);
            int exists = (int)DataProvider.Instance.ExecuteScalar(query1);
            return exists == 1;
        }
        public bool KiemTraHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {

            string query2 = String.Format("SELECT CASE WHEN EXISTS (SELECT 1 FROM DangKy dk JOIN ThoiKhoaBieu tkb ON dk.MaTKB = tkb.MaTKB WHERE tkb.MaSinhVien = '{0}' AND tkb.HocKy = '{1}' AND tkb.NamHoc = '{2}' AND dk.MaHocPhan = '{3}')THEN 1 ELSE 0 END", MSSV, HocKy, NamHoc, MaHP);
            int exists = (int)DataProvider.Instance.ExecuteScalar(query2);
            return exists == 1;
        }
        public bool KiemTraMonHoc(string MSSV, int HocKy, string NamHoc, string MaHP, string MaMH)
        {
            string query3 = String.Format("SELECT CASE WHEN EXISTS " +
                "(SELECT 1 FROM HocPhan hp WHERE hp.MaHocPhan = " +
                "(SELECT dk.MaHocPhan FROM DangKy dk JOIN ThoiKhoaBieu tkb ON dk.MaTKB = tkb.MaTKB " +
                "WHERE tkb.MaSinhVien = '{0}' AND tkb.HocKy = '{1}' AND tkb.NamHoc = '{2}' AND dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{4}') + '%')" +
                "AND hp.MaMonHoc = '{4}') THEN 1 ELSE 0 END", MSSV, HocKy, NamHoc, MaHP, MaMH);
            int exists = (int)DataProvider.Instance.ExecuteScalar(query3);
            return exists == 1;
        }

        public DataTable ThemHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {
            string query = String.Format("EXEC ThemHocPhanChoSinhVien @MaSinhVien = '{0}', @HocKy = '{1}', @NamHoc = '{2}', @MaHocPhan = '{3}'", MSSV, HocKy, NamHoc, MaHP);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimThoiKhoaBieu(string MSSV, int HocKy, string NamHoc)
        {
            string query = String.Format("EXEC LayThoiKhoaBieuSinhVien @MaSinhVien = '{0}',@HocKy = '{1}', @NamHoc = '{2}'", MSSV, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool KiemTraTKB(string MSSV, int HocKy, string NamHoc)
        {
            string query = String.Format("SELECT CASE WHEN EXISTS " +
                "(SELECT * FROM ThoiKhoaBieu WHERE MaSinhVien = '{0}' AND HocKy = '{1}' AND NamHoc = '{2}') " +
                "THEN 1 ELSE 0 END", MSSV, HocKy, NamHoc);
            int exists = (int)DataProvider.Instance.ExecuteScalar(query);
            return exists == 1;
        }
        public bool KiemTraMaMH(string mamh)
        {
            string query = String.Format("Select count(*) from MonHoc where MaMH = '{0}'", mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }
        public bool KiemTraMaHP(string mahp)
        {
            string query = String.Format("Select count(*) from HocPhan where MaHocPhan = '{0}'", mahp);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }
        
        public string LayTinChi(string tinchi)
        {
            string query = String.Format("select TinChi from MonHoc where MaMH = '{0}'", tinchi);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TinChi"].ToString();
        }
        public string LayTinChiEdit(string tinchi)
        {
            string query = String.Format("select TinChi from HocPhan where MaHocPhan = '{0}'", tinchi);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TinChi"].ToString();
        }
        public bool KiemTraMaGV(string mamh)
        {
            string query = String.Format("select count(*) from GiangVien where MaGV = '{0}'", mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }
        public string LayTenMonHoc(string text)
        {
            string query = String.Format("select TenMH from MonHoc where MaMH = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TenMH"].ToString();

        }


        public string LayTenMonHocEdit(string text)
        {
            string query = String.Format("select TenHocPhan from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TenHocPhan"].ToString();

        }
        // lay thoi khoa bieu sinh vien
        public DataTable LayThoiKhoaBieuSinhVien(string maSV, string HocKy, string NamHoc)
        {
            string query = String.Format("EXEC LayThoiKhoaBieuSinhVien @MaSV = '{0}', @HocKy = '{1}', @NamHoc = '{2}';", maSV, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool XoaHocPhanTrongThoiKhoaBieuSinhVien(string maHocPhan)
        {
            try
            {

                string query = String.Format("EXEC XoaHocPhanTrongThoiKhoaBieuSinhVien @MaHocPhan = '{0}'", maHocPhan);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public string LayMaMonHocEdit(string text)
        {
            string query = String.Format("select MaMonHoc from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["MaMonHoc"].ToString();

        }
        public string LayMaGiangVienEdit(string text)
        {
            string query = String.Format("select MaGV from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["MaGV"].ToString();

        }
        public string LayNamEdit(string text)
        {
            string query = String.Format("select Nam from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["Nam"].ToString();

        }
        public string LayNgayMoDauEdit(string text)
        {
            string query = String.Format("select NgayMoDau from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NgayMoDau"].ToString();

        }
        public string LayNgayKetThucEdit(string text)
        {
            string query = String.Format("select NgayKetThuc from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NgayKetThuc"].ToString();

        }
        public string LayThongTinEdit(string text)
        {
            string query = String.Format("select ThongTin from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["ThongTin"].ToString();

        }
    }

}
