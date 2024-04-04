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

        public DataTable LayDanhSachHocPhan()
        {
            return HocPhanDAO.Instance.LayDanhSachHocPhan();
        }
    }
}
