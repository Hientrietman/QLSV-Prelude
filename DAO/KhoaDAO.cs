using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhoaDAO
    {
        public KhoaDAO()
        {

        }
        private static KhoaDAO instance;

        public static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachKhoa()
        {
            string query = String.Format("SELECT * FROM Khoa ");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayDanhSachLop()
        {
            string query = "SELECT DISTINCT Lop FROM SinhVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
