using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable LayDanhSachHocPhanCuaSV(string MSSV, int HocKy, string NamHoc)
        {
            string query = String.Format("EXEC GetHocPhanTheoSinhVien @MaSinhVien = '{0}', @HocKy = '{1}', @NamHoc = '{2}'", MSSV, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemMaHP(string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER (ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, PhongHoc FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", MaHP);

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
    }
}
