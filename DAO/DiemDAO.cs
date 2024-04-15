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

        public DataTable LayDiemSinhVienBangMssvVaNamHoc(string MaSinhVien, string NamHoc)
        {
            string query = String.Format("EXEC LoadDiemByMaSVAndNamHoc @MaSV = '{0}', @NamHoc = '{1}'", MaSinhVien, NamHoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
