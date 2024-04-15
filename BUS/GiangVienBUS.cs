using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVienBUS
    {
        public GiangVienBUS() { }

        private static GiangVienBUS instance;

        public static GiangVienBUS Instance
        {
            get { if (instance == null) instance = new GiangVienBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayThongTinGiangVien(string MaGV)
        {
            return GiangVienDAO.Instance.LayThongTinGiangVien(MaGV);
        }
    }
}
