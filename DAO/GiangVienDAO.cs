using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiangVienDAO
    {
        public GiangVienDAO() { }

        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get { if (instance == null) instance = new GiangVienDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayThongTinGiangVien(string MaGV)
        {
            string query = String.Format("SELECT * FROM GiangVien WHERE MaGV = '{0}'", MaGV);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ChinhSuaThongTinGiangVien(string MaGV, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh)
        {
            string query = string.Format("EXEC ChinhSuaThongTinGiangVien @MaGV = '{0}', @Email = '{1}', @SDT = '{2}', @NgaySinh = '{3}', @DiaChi = '{4}', @HoTen = N'{5}', @GioiTinh = N'{6}';", MaGV, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

    }
}
