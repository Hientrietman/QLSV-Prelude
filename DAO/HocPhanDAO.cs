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
        public DataTable LayDanhSachHocPhanEdit()
        {
            
            return DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan;");
        }
        public DataTable TimKiemMaHP(string MaHP)
        {

            string query = String.Format("SELECT ROW_NUMBER() OVER(ORDER BY MaHocPhan) AS STT, MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam, NgayMoDau, NgayKetThuc, TinChi, ThongTin FROM HocPhan WHERE dbo.fuConvertToUnsign1(MaHocPhan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", MaHP);

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool KiemTraMaMH(string mamh)
        {
            string query = String.Format("Select count(*) from MonHoc where MaMH = '{0}'",mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count>0;
        }
        public bool KiemTraMaHP(string mahp)
        {
            string query = String.Format("Select count(*) from HocPhan where MaHocPhan = '{0}'", mahp);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }
        
        public string LayTinChi(string tinchi)
        {
            string query = String.Format("select TinChi from MonHoc where MaMH = '{0}'",tinchi);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TinChi"].ToString();
        }
        public string LayTinChiEdit(string tinchi)
        {
            string query = String.Format("select TinChi from HocPhan where MaHocPhan = '{0}'", tinchi);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TinChi"].ToString();
        }
        public bool KiemTraMaGV(string mamh)
        {
            string query = String.Format("select count(*) from GiangVien where MaGV = '{0}'",mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count> 0;
        }
        public string LayTenMonHoc(string text)
        {
            string query = String.Format("select TenMH from MonHoc where MaMH = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TenMH"].ToString();

        }

        public string LayTenMonHocEdit(string text)
        {
            string query = String.Format("select TenHocPhan from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TenHocPhan"].ToString();
             
        }
        public string LayMaMonHocEdit(string text)
        {
            string query = String.Format("select MaMonHoc from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["MaMonHoc"].ToString();

        }
        public string LayMaGiangVienEdit(string text)
        {
            string query = String.Format("select MaGV from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["MaGV"].ToString();

        }
        public string LayNamEdit(string text)
        {
            string query = String.Format("select Nam from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["Nam"].ToString();

        }
        public string LayNgayMoDauEdit(string text)
        {
            string query = String.Format("select NgayMoDau from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NgayMoDau"].ToString();

        }
        public string LayNgayKetThucEdit(string text)
        {
            string query = String.Format("select NgayKetThuc from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["NgayKetThuc"].ToString();

        }
        public string LayThongTinEdit(string text)
        {
            string query = String.Format("select ThongTin from HocPhan where MaHocPhan = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["ThongTin"].ToString();

        }
    }

}
