using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienDAO
    {
        public SinhVienDAO() { }

        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachSVCuaLopHocPhan(string MaHocPhan)
        {
            string query = String.Format("EXEC LayDanhSachSVCuaLopHocPhan @MaHocPhan = '{0}';", MaHocPhan);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemMaSVTrongLopHocPhan(string MaHP, string MaSV)
        {

            string query = String.Format("EXEC TimKiemSVTrongLopHocPhan @MaHocPhan = '{0}', @MaSV = '{1}';", MaHP, MaSV);

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayThongTinSinhVien(string MaSV)
        {
            string query = String.Format("SELECT * FROM SinhVien WHERE MaSV = '{0}'", MaSV);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
