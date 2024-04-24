using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        public SinhVienDTO(string maSV, string maTK, string maKhoa, string hoTen, string lop, string email, string sdt, string ngaySinh, string gioiTinh)
        {
            this.MaSV = maSV;
            this.MaTK = maTK;
            this.MaKhoa = maKhoa;
            this.HoTen = hoTen;
            this.Lop = lop;
            this.Email = email;
            this.SDT = sdt;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
        }

        public SinhVienDTO(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.MaTK = row["MaTK"].ToString();
            this.MaKhoa = row["MaKhoa"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.Lop = row["Lop"].ToString();
            this.Email = row["Emai"].ToString();
            this.SDT = row["SDT"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        private string maSV;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        private string maTK;
        public string MaTK
        {
            get { return maTK; }
            set { maTK = value; }
        }

        private string maKhoa;
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private string lop;
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string ngaySinh;
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string gioiTinh;
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
    }
}
