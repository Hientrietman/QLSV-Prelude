using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThoiKhoaBieuBUS
    {
        private ThoiKhoaBieuBUS() { }
        private static ThoiKhoaBieuBUS instance;
        public static ThoiKhoaBieuBUS Instance
        {
            get { if (instance == null) instance = new ThoiKhoaBieuBUS(); return instance; }
            private set { instance = value; }
        }

        public bool KiemTraTKBTonTai(string MaSinhVien, string HocKy, string NamHoc)
        {
            return ThoiKhoaBieuDAO.Instance.KiemTraTKBTonTai(MaSinhVien, HocKy, NamHoc);
        }

        public bool ThemTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            return ThoiKhoaBieuDAO.Instance.ThemTKB(MaSinhVien, HocKy, NamHoc);
        }

        public DataTable LayMaTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            return ThoiKhoaBieuDAO.Instance.LayMaTKB(MaSinhVien, HocKy, NamHoc);
        }

        public List<string> LayDanhSachHocKy(string mssv)
        {
            return ThoiKhoaBieuDAO.Instance.LayDanhSachHocKy(mssv);
        }

        public List<string> LayDanhSachNamHoc(string mssv)
        {
            return ThoiKhoaBieuDAO.Instance.LayDanhSachNamHoc(mssv);
        }
    }
}
