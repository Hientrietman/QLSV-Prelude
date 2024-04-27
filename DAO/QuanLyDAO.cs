using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyDAO
    {
        public QuanLyDAO() { }

        private static QuanLyDAO instance;

        public static QuanLyDAO Instance
        {
            get { if (instance == null) instance = new QuanLyDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayThongTinQuanLy(string MaNQL)
        {
            string query = String.Format("SELECT * FROM QuanLy WHERE MaNQL = '{0}'", MaNQL);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ChinhSuaThongTinQuanLy(string MaQL, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh)
        {
            string query = string.Format("EXEC ChinhSuaThongTinQuanLy @MaQL = '{0}', @Email = '{1}', @SDT = '{2}', @NgaySinh = '{3}', @DiaChi = '{4}', @HoTen = N'{5}', @GioiTinh = N'{6}';", MaQL, Email, SDT, NgaySinh.ToString("yyyy-MM-dd"), DiaChi, HoTen, GioiTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
