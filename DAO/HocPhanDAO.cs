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

        public bool KiemTraMaMH(string mamh)
        {
            string query = String.Format("Select count(*) from MonHoc where MaMH = '{0}'", mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }

        public string LayTinChi(string tinchi)
        {
            string query = String.Format("select TinChi from MonHoc where MaMH = '{0}'", tinchi);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TinChi"].ToString();
        }

        public bool KiemTraMaGV(string mamh)
        {
            string query = String.Format("select count(*) from GiangVien where MaGV = '{0}'", mamh);
            int count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count > 0;
        }

        public string LayTenMonHoc(string text)
        {
            string query = String.Format("select TenMH from MonHoc where MaMH = '{0}'", text);
            return DataProvider.Instance.ExecuteQuery(query).Rows[0]["TenMH"].ToString();

        }

        // lay thoi khoa bieu sinh vien
        public DataTable LayThoiKhoaBieuSinhVien(string maSV, string HocKy, string NamHoc)
        {
            string query = String.Format("EXEC LayThoiKhoaBieuSinhVien @MaSV = '{0}', @HocKy = '{1}', @NamHoc = '{2}';", maSV, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool XoaHocPhanTrongThoiKhoaBieuSinhVien(string maHocPhan)
        {
            try
            {

                string query = String.Format("EXEC XoaHocPhanTrongThoiKhoaBieuSinhVien @MaHocPhan = '{0}'", maHocPhan);
                DataProvider.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
