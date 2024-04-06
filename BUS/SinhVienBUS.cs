using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBUS
    {
        private SinhVienBUS() { }
        private static SinhVienBUS instance;
        public static SinhVienBUS Instance
        {
            get { if (instance == null) instance = new SinhVienBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable LayDanhSachSVCuaLopHocPhan(string MaHocPhan)
        {
            return SinhVienDAO.Instance.LayDanhSachSVCuaLopHocPhan(MaHocPhan);
        }

        public DataTable TimKiemMaSVTrongLopHocPhan(string MaHP, string MaSV)
        {

            return SinhVienDAO.Instance.TimKiemMaSVTrongLopHocPhan(MaHP, MaSV);
        }
    }
}
