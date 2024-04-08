using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public TaiKhoanDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Quan_li_SV;Integrated Security=True";

        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }



        public bool Login(string TenDangNhap, string MatKhau)
        {

            string query = "AccountLogin @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenDangNhap, MatKhau });

            return result.Rows.Count > 0;
        }

        public TaiKhoanDTO GetAccountByUserName(string TenDangNhap)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from TaiKhoan where TenDangNhap = '" + TenDangNhap + "'");

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }

            return null;
        }

        public bool UpdateAccount(string TenDangNhap, string MatKhau, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @TenDangNhap , @MatKhau , @newPassword", new object[] { TenDangNhap, MatKhau, newPass });

            return result > 0;

        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TenDangNhap, VaiTro FROM Taikhoan");
        }

        public bool InsertAccount(string TenDangNhap, string HoTen, int VaiTro)
        {
            string query = string.Format("INSERT TAIKHOAN  (TenDangNhap, HoTen, Loaitaikhoan) VALUES  ( N'{0}', N'{1}', {2})", TenDangNhap, HoTen, VaiTro);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string TenDangNhap, string HoTen, int VaiTro, int MaTK)
        {
            string query = string.Format("UPDATE TAIKHOAN SET TenDangNhap = N'{0}', HoTen = N'{1}', VaiTro = {2} WHERE MaTK = {3}", TenDangNhap, HoTen, VaiTro, MaTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(int ID)
        {
            string query = string.Format("Delete TAIKHOAN where ID = {0}", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(int ID)
        {
            string query = string.Format("update TAIKHOAN set Matkhau = N'12345678' where ID = {0}", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
