using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class DiemDAO
    {
        public DiemDAO() { }

        private static DiemDAO instance;

        public static DiemDAO Instance
        {
            get { if (instance == null) instance = new DiemDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDiemSinhVien(string MaHocPhan, string MaSinhVien)
        {
            string query = String.Format("EXEC LayDiemSinhVien @MaHocPhan = '{0}', @MaSV = '{1}';", MaHocPhan, MaSinhVien);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateDiemSinhVien(string maHocPhan, string maSV, float? diemQuaTrinh, float? diemGiuaKy, float? diemCuoiKy)
        {
            string formatDiemQuaTrinh = diemQuaTrinh.HasValue ? diemQuaTrinh.ToString() : "NULL";
            string formatDiemGiuaKy = diemGiuaKy.HasValue ? diemGiuaKy.ToString() : "NULL";
            string formatDiemCuoiKy = diemCuoiKy.HasValue ? diemCuoiKy.ToString() : "NULL";

            string query = string.Format("EXEC UpdateDiemSinhVien @MaHocPhan = '{0}', @MaSV = '{1}', @DiemQuaTrinh = {2}, @DiemGiuaKy = {3}, @DiemCuoiKy = {4}", maHocPhan, maSV, formatDiemQuaTrinh, formatDiemGiuaKy, formatDiemCuoiKy);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CheckKhoaChinh(string maHocPhan, string maSV)
        {
            string query = String.Format("SELECT * FROM Diem WHERE MaSinhVien = '{0}' AND MaHocPhan = '{1}'", maSV, maHocPhan);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool SetKhoaChinh(string maHocPhan, string maSV)
        {
            string query = String.Format("EXEC InsertDiemNull @MaSinhVien = '{0}' , @MaHocPhan = '{1}'", maSV, maHocPhan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable LayDiemSinhVienBangMSSV(string MaSinhVien)
        {
            string query = String.Format("EXEC GetDiemByMaSV @MaSV = '{0}'", MaSinhVien);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDiemSinhVienTheoTKB(string MaSinhVien, string HocKy, string NamHoc)
        {
            string query = String.Format("EXEC LayDiemSinhVienTheoThoiKhoaBieu '{0}', '{1}', '{2}'", MaSinhVien, HocKy, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
