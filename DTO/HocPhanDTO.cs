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

        public HocPhanDTO(string maHocPhan, string maMonHoc, string tenHocPhan, string maGiaoVien, string nam, string ngayMoDau, string ngayKetThuc, string tinChi, string thongTin, string NamHoc)
        {
            this.MaHP = maHocPhan;
            this.MaMH = maMonHoc;
            this.TenHocPhan = tenHocPhan;
            this.Nam = nam;
            this.MaGV = maGiaoVien;
            this.NgayMoDau = ngayMoDau;
            this.NgayKetThuc = ngayKetThuc;
            this.TinChi = tinChi;
            this.ThongTin = thongTin;


        }

        public HocPhanDTO(DataRow row)
        {
            this.MaHP = row["maHocPhan"].ToString();
            this.MaMH = row["maMonHoc"].ToString();
            this.TenHocPhan = row["tenHocPhan"].ToString();
            this.Nam = row["nam"].ToString();
            this.MaGV = row["MaGV"].ToString();
            this.NgayMoDau = row["NgayMoDau"].ToString();
            this.NgayKetThuc = row["NgayKetThuc"].ToString();
            this.TinChi = row["TinChi"].ToString();
            this.thongTin = row["ThongTin"].ToString();
        }

        public HocPhanDTO(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
        {
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

        private string ngayMoDau;

        public string NgayMoDau
        {
            get { return ngayMoDau; }
            set { ngayMoDau = value; }
        }

        private string ngayKetThuc;

        public string NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        private string tinChi;

        public string TinChi
        {
            get { return tinChi; }
            set { tinChi = value; }
        }

        private string thongTin;
        public string ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        private string namHoc;
        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }     
        }
    }
}
