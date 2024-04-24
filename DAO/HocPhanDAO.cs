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
            return DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan;");
        }
        public DataTable LayDanhSachHocPhanTheoMSSV(string MaSinhVien, string NamHoc, string HocKy)
        {
            string query = String.Format("EXEC GetHocPhanTheoSinhVien @MaSinhVien = '{0}', @NamHoc = '{1}', @HocKy = '{2}'", MaSinhVien, NamHoc, HocKy);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TimKiemMaHP(string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", MaHP);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool KiemTraMaMH(string mamh)
        {
            string query = String.Format("Select count(*) from MonHoc where MaMH = '{0}'", mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }

        public string LayTinChi(string tinchi)
        {
            string query = String.Format("select TinChi from MonHoc where MaMH = '{0}'", tinchi);
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

        public List<string> GetDistinctSemesters(string HocKy)
        {
            List<string> semesters = new List<string>();

            string query = String.Format("SELECT DISTINCT HocKy FROM ThoiKhoaBieu");

            return DataProvider.Instance.GetDistinctSemesters(query)   ;
        }
        public List<string> GetDistinctYears(string NamHoc)
        {
            List<string> semesters = new List<string>();

            string query = String.Format("SELECT DISTINCT NamHoc FROM ThoiKhoaBieu");

            return DataProvider.Instance.GetDistinctYear(query);
        }

    }
}
