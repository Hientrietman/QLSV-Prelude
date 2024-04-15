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
    }
}
