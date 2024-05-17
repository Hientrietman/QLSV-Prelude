using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemBUS
    {
        public DiemBUS() { }

        private static DiemBUS instance;

        public static DiemBUS Instance
        {
            get { if (instance == null) instance = new DiemBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDiemSinhVien(string MaHocPhan, string MaSinhVien)
        {
            return DiemDAO.Instance.LayDiemSinhVien(MaHocPhan, MaSinhVien);
        }

        public bool UpdateDiemSinhVien(string maHocPhan, string maSV, float? diemQuaTrinh, float? diemGiuaKy, float? diemCuoiKy)
        {

            return DiemDAO.Instance.UpdateDiemSinhVien(maHocPhan, maSV, diemQuaTrinh, diemGiuaKy, diemCuoiKy);
        }
    }
}
