using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyBUS
    {
        public QuanLyBUS() { }

        private static QuanLyBUS instance;

        public static QuanLyBUS Instance
        {
            get { if (instance == null) instance = new QuanLyBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayThongTinQuanLy(string MaNQL)
        {
            return QuanLyDAO.Instance.LayThongTinQuanLy(MaNQL);
        }
        public bool ChinhSuaThongTinQuanLy(string MaQL, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh)
        {
            return QuanLyDAO.Instance.ChinhSuaThongTinQuanLy(MaQL, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh);
        }
    }
}
