using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocPhanBUS
    {
        private HocPhanBUS() { }
        private static HocPhanBUS instance;
        public static HocPhanBUS Instance
        {
            get { if (instance == null) instance = new HocPhanBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable TimKiemMaHP(string MaHP)
        {
            return HocPhanDAO.Instance.TimKiemMaHP(MaHP);
        }

        public DataTable LayDanhSachHocPhan()
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhan();
        }
        public DataTable LayDanhSachHocPhanTheoMSSV(string MaSinhVien, string NamHoc, string HocKy)
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhanTheoMSSV(MaSinhVien, NamHoc, HocKy);
        }
        public DataTable ThemHocPhan(HocPhanDTO hocPhan)
        {
            string query = String.Format("INSERT INTO HocPhan (MaHocPhan, MaMonHoc, TenHocPhan, MaGV, Nam,NgayMoDau,NgayKetThuc,TinChi,ThongTin ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}')",
                hocPhan.MaHP, hocPhan.MaMH, hocPhan.TenHocPhan, hocPhan.MaGV, hocPhan.Nam, hocPhan.NgayMoDau, hocPhan.NgayKetThuc, hocPhan.TinChi, hocPhan.ThongTin);
          
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public static List<string> GetDistinctYears()
        {
            throw new NotImplementedException();
        }

        public static List<string> GetDistinctSemesters()
        {
            throw new NotImplementedException();
        }

        public bool KiemTraMaMonHoc(string mamh)
        {
            return HocPhanDAO.Instance.KiemTraMaMH(mamh);
        }

        public string LayTinChi(string tinchi)
        {
            return HocPhanDAO.Instance.LayTinChi(tinchi);

        }

        public bool KiemTraMaGiangVien(string mamh)
        {
            return HocPhanDAO.Instance.KiemTraMaGV(mamh);
        }

        public string LayTenMonHoc(string text)
        {
            return HocPhanDAO.Instance.LayTenMonHoc(text);
        }
        public List<string> GetDistinctYears(string NamHoc)
        {
            return HocPhanDAO.Instance.GetDistinctYears(NamHoc);
        }

        public List<string> GetDistinctSemesters(string HocKy)
        {
            return HocPhanDAO.Instance.GetDistinctSemesters(HocKy);
        }

    }
}
