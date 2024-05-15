using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class GopYVaHoiDapDTO
    {
        public GopYVaHoiDapDTO(string maSinhVien, string hoTen, string email, string noiDung, int trangThai)
        {

            this.MaSinhVien = maSinhVien;
            this.HoTen = hoTen;
            this.Email = email;
            this.NoiDung = noiDung;
            this.TrangThai = trangThai;
        }

        public GopYVaHoiDapDTO(DataRow row)
        {

            this.MaSinhVien = row["MaSinhVien"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.Email = row["Email"].ToString();
            this.NoiDung = row["NoiDung"].ToString();
            this.TrangThai = Convert.ToInt32(row["TrangThai"]);
        }



        private string maSinhVien;
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string noiDung;
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }

        private int trangThai;
        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}


