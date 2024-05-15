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
        public DataTable LayDanhSachThongBaoV2(string TieuDe)
        {
            string query = String.Format("SELECT ROW_NUMBER() OVER (ORDER BY NgayTao DESC) AS STT, MaThongBao, TieuDe, NgayTao FROM  ThongBao WHERE dbo.fuConvertToUnsign1(TieuDe) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' ORDER BY NgayTao DESC;", TieuDe);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string LayNoiDungThongBao(string MaThongBao)
        {
            string query = String.Format("select NoiDung from ThongBao where MaThongBao = '{0}'", MaThongBao);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NoiDung"].ToString();
        }
        public string LayTenNguoiTaoThongBao(string MaThongBao)
        {
            string query = String.Format("select HoTen from QuanLy where QuanLy.MaNQL = (select NguoiTao from  ThongBao where MaThongBao = '{0}')", MaThongBao);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["HoTen"].ToString();
        }

        public bool XoaThongBao(string MaThongBao)
        {
            string query = "DELETE FROM ThongBao WHERE MaThongBao = @MaThongBao";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaThongBao });
            return result > 0;
        }
    }
}
