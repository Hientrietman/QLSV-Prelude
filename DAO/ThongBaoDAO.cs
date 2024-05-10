using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongBaoDAO
    {
        public ThongBaoDAO() { }

        private static ThongBaoDAO instance;

        public static ThongBaoDAO Instance
        {
            get { if (instance == null) instance = new ThongBaoDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachThongBao(string TieuDe)
        {
            string query = String.Format("SELECT ROW_NUMBER() OVER (ORDER BY MaThongBao) AS STT, MaThongBao, TieuDe, NoiDung, NgayTao, NguoiTao FROM  ThongBao WHERE dbo.fuConvertToUnsign1(TieuDe) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%';", TieuDe);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
