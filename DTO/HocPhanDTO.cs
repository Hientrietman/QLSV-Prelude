using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocPhanDTO
    {

        public HocPhanDTO(string maHocPhan, string maMonHoc, string tenHocPhan, string maGiaoVien, string nam, string phongHoc)
        {
            this.MaHP = maHocPhan;
            this.MaMH = maMonHoc;
            this.TenHocPhan = tenHocPhan;
            this.Nam = nam;
            this.MaGV = maGiaoVien;
            this.PhongHoc = phongHoc;
        }

        public HocPhanDTO(DataRow row)
        {
            this.MaHP = row["maHocPhan"].ToString();
            this.MaMH = row["maMonHoc"].ToString();
            this.TenHocPhan = row["tenHocPhan"].ToString();
            this.Nam = row["nam"].ToString();
            this.MaGV = row["MaGV"].ToString();
            this.PhongHoc = row["phongHoc"].ToString();
        }

        private string maHP;

        public string MaHP
        {
            get { return maHP; }
            set { maHP = value; }
        }

        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }

        private string tenHocPhan;

        public string TenHocPhan
        {
            get { return tenHocPhan; }
            set { tenHocPhan = value; }
        }

        private string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        private string nam;

        public string Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        private string phongHoc;

        public string PhongHoc
        {
            get { return phongHoc; }
            set { phongHoc = value; }
        }
    }
}
