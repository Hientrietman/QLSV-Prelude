using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyDTO
    {
        public DangKyDTO(string maDangKy, string maTKB, string maHocPhan)
        {
            this.MaDangKy = maDangKy;
            this.MaTKB = maTKB;
            this.MaHocPhan = maHocPhan;
        }

        public DangKyDTO(DataRow row)
        {
            this.MaDangKy = row["MaDangKy"].ToString();
            this.MaTKB = row["MaTKB"].ToString();
            this.MaHocPhan = row["MaHocPhan"].ToString();
        }

        private string maDangKy;
        public string MaDangKy
        {
            get { return maDangKy; }
            set { maDangKy = value; }
        }

        private string maTKB;
        public string MaTKB
        {
            get { return maTKB; }
            set { maTKB = value; }
        }

        private string maHocPhan;
        public string MaHocPhan
        {
            get { return maHocPhan; }
            set { maHocPhan = value; }
        }
    }
}
