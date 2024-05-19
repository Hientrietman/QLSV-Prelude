using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoaBUS
    {


        public KhoaBUS()
        {

        }
        private static KhoaBUS instance;

        public static KhoaBUS Instance
        {
            get { if (instance == null) instance = new KhoaBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayKhoa()
        {
            return KhoaDAO.Instance.LayDanhSachKhoa();
        }
    }
}