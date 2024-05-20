using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class HocPhiDAO
    {
        public HocPhiDAO() { }

        private static HocPhiDAO instance;
        public static HocPhiDAO Instance
        {
            get { if (instance == null) instance = new HocPhiDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiHocKyVaNamHoc(string maSV)
        {
            string query = $@"
                SELECT DISTINCT HocKy, NamHoc
                FROM ThoiKhoaBieu
                WHERE MaSinhVien = '{maSV}'
                ORDER BY NamHoc, HocKy";

            return DataProvider.Instance.ExecuteQuery(query);
        }
       /* public DataTable HienThiHocPhiSinhVien(string maSinhVien, string hocKy, string namHoc)
        {
            string query = $@"
        SELECT hp.MaHocPhan, hp.TenHocPhan, ISNULL(hocphi.HocPhi, 0) AS HocPhi,
               CASE WHEN ISNULL(hocphi.TrangThai, 0) = 1 THEN N'Đã đóng' ELSE N'Chưa đóng' END AS TrangThaiText
        FROM ThoiKhoaBieu tkb
        JOIN DangKy dk ON tkb.MaTKB = dk.MaTKB
        JOIN HocPhan hp ON dk.MaHocPhan = hp.MaHocPhan
        LEFT JOIN HocPhi hocphi ON tkb.MaTKB = hocphi.MaTKB
        WHERE tkb.MaSinhVien = '{maSinhVien}' AND tkb.HocKy = '{hocKy}' AND tkb.NamHoc = '{namHoc}'
        ORDER BY hp.MaHocPhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }*/

        public DataTable HienThiHocPhiSinhVien(string maSinhVien, string hocKy, string namHoc)
        {
            string query = $@"
        SELECT hp.MaHocPhan, hp.TenHocPhan, 365000 * hp.TinChi AS HocPhi,
               CASE WHEN ISNULL(hocphi.TrangThai, 0) = 1 THEN N'Đã đóng' ELSE N'Chưa đóng' END AS TrangThaiText
        FROM ThoiKhoaBieu tkb
        JOIN DangKy dk ON tkb.MaTKB = dk.MaTKB
        JOIN HocPhan hp ON dk.MaHocPhan = hp.MaHocPhan
        LEFT JOIN HocPhi hocphi ON tkb.MaTKB = hocphi.MaTKB
        WHERE tkb.MaSinhVien = '{maSinhVien}' AND tkb.HocKy = '{hocKy}' AND tkb.NamHoc = '{namHoc}'
        ORDER BY hp.MaHocPhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }





    }
}
