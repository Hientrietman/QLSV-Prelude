using DAO;
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
        public DataTable TimKiemLopHP(int NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.TimKiemLopHP(NamHoc,MaHP);
        }
        public bool KiemTraNamHoc(int kiemtraNamHoc, string MaHocPhan)
        {
            return HocPhanDAO.Instance.KiemTraNamHoc(kiemtraNamHoc, MaHocPhan);
        }
        public bool KiemTraHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.KiemTraHocPhan(MSSV, HocKy, NamHoc, MaHP);
        }
        public bool KiemTraMonHoc(string MSSV, int HocKy, string NamHoc, string MaHP, string MaMH)
        {
            return HocPhanDAO.Instance.KiemTraMonHoc(MSSV, HocKy, NamHoc, MaHP, MaMH);
        }

        public DataTable LayDanhSachHocPhan()
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhan();
        }
        public DataTable LayDanhSachHocPhanCuaSV(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhanCuaSV(MSSV,HocKy,NamHoc);
        }
        public DataTable ThemHocPhan(string MSSV, int HocKy, string NamHoc, string MaHP)
        {
            return HocPhanDAO.Instance.ThemHocPhan(MSSV, HocKy, NamHoc,MaHP);
        }
        public DataTable TimThoiKhoaBieu(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHoc);
        }
        public bool KiemTraTKB(string MSSV, int HocKy, string NamHoc)
        {
            return HocPhanDAO.Instance.KiemTraTKB(MSSV, HocKy, NamHoc);
        }
    }
}
