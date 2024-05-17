using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS
{
    public class HocPhiBUS
    {
        private HocPhiBUS() { }
        private static HocPhiBUS instance;
        public static HocPhiBUS Instance
        {
            get { if (instance == null) instance = new HocPhiBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiHocKyVaNamHoc(string Masv)
        {
            return HocPhiDAO.Instance.HienThiHocKyVaNamHoc(Masv);
        }
        public DataTable HienThiHocPhiSinhVien(string maSinhVien, string hocKy, string namHoc)
        {
            return HocPhiDAO.Instance.HienThiHocPhiSinhVien(maSinhVien, hocKy, namHoc);
        }
    }
}
