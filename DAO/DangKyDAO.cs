using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangKyDAO
    {
        public DangKyDAO() { }

        private static DangKyDAO instance;

        public static DangKyDAO Instance
        {
            get { if (instance == null) instance = new DangKyDAO(); return instance; }
            private set { instance = value; }
        }

        public bool ThemDangKy(string MaTKB, string MaHocPhan)
        {
            string query = string.Format("EXEC InsertDangKy '{0}', '{1}';", MaTKB, MaHocPhan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
