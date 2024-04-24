using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiKhoaBieuDTO
    {
        public ThoiKhoaBieuDTO(string maTKB, string maSinhVien, string hocKy, string namHoc)
        {
            this.MaTKB = maTKB;
            this.MaSinhVien = maSinhVien;
            this.HocKy = hocKy;
            this.NamHoc = namHoc;
        }

        public ThoiKhoaBieuDTO(DataRow row)
        {
            this.MaTKB = row["MaTKB"].ToString();
            this.MaSinhVien = row["MaSinhVien"].ToString();
            this.HocKy = row["HocKy"].ToString();
            this.NamHoc = row["NamHoc"].ToString();
        }


        private string maTKB;
        public string MaTKB
        {
            get { return maTKB; }
            set { maTKB = value; }
        }

        private string maSinhVien;
        public string MaSinhVien
        {
            get { return MaSinhVien; }
            set { maSinhVien = value; }
        }

        private string hocKy;
        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }

        private string namHoc;
        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }
    }
}
