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

    }
}
