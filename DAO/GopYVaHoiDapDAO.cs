using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class GopYVaHoiDapDAO
    {
        private static GopYVaHoiDapDAO instance;

        public static GopYVaHoiDapDAO Instance
        {
            get { if (instance == null) instance = new GopYVaHoiDapDAO(); return instance; }
            private set { instance = value; }
        }



        public bool ThemGopYVaHoiDap(GopYVaHoiDapDTO gopYVaHoiDap)
        {
            string query = string.Format("EXEC ThemGopYVaHoiDap @MaSinhVien = '{0}', @HoTen = N'{1}', @Email = N'{2}', @NoiDung = N'{3}';", gopYVaHoiDap.MaSinhVien, gopYVaHoiDap.HoTen, gopYVaHoiDap.Email, gopYVaHoiDap.NoiDung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
