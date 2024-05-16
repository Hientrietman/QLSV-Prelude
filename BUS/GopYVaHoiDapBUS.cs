using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class GopYVaHoiDapBUS
    {
        private static GopYVaHoiDapBUS instance;

        public static GopYVaHoiDapBUS Instance
        {
            get { if (instance == null) instance = new GopYVaHoiDapBUS(); return instance; }
            private set { instance = value; }
        }


        public bool ThemGopYVaHoiDap(GopYVaHoiDapDTO gopYVaHoiDap)
        {
            return GopYVaHoiDapDAO.Instance.ThemGopYVaHoiDap(gopYVaHoiDap);
        }
    }
}