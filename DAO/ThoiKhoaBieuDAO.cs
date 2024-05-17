using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class ThoiKhoaBieuDAO
    {
        public ThoiKhoaBieuDAO() { }

        private static ThoiKhoaBieuDAO instance;

        public static ThoiKhoaBieuDAO Instance
        {
            get { if (instance == null) instance = new ThoiKhoaBieuDAO(); return instance; }
            private set { instance = value; }
        }

        public bool KiemTraTKBTonTai(string MaSinhVien, string HocKy, string NamHoc)
        {
            string query = string.Format("SELECT * FROM ThoiKhoaBieu WHERE MaSinhVien = '{0}' AND HocKy = '{1}' AND NamHoc = '{2}';", MaSinhVien, HocKy, NamHoc);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool ThemTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            string query = string.Format("EXEC InsertThoiKhoaBieu '{0}', '{1}', '{2}';", MaSinhVien, HocKy, NamHoc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable LayMaTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            string query = String.Format("SELECT MaTKB FROM ThoiKhoaBieu WHERE MaSinhVien = '{0}' AND HocKy = '{1}' AND NamHoc = '{2}';", MaSinhVien, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> LayDanhSachHocKy(string mssv)
        {
            string query = String.Format("SELECT DISTINCT HocKy FROM ThoiKhoaBieu WHERE MaSinhVien = '{0}'", mssv);
            return DataProvider.Instance.GetDistinctSemesters(query);
        }

        public List<string> LayDanhSachNamHoc(string mssv)
        {
            string query = String.Format("SELECT DISTINCT NamHoc FROM ThoiKhoaBieu WHERE MaSinhVien = '{0}'", mssv);
            return DataProvider.Instance.GetDistinctYear(query);
        }

    }
}
