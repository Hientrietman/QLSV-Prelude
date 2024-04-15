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

        public DataTable TimKiemMaHP(string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", MaHP);

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
