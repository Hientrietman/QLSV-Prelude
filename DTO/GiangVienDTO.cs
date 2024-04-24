using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienDTO
    {
        public string MaGV { get; set; }
        public string TenDangNhap { get; set; }
        public string MaKhoa { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }

        public GiangVienDTO() { }

        // Constructor with parameters
        public GiangVienDTO(string maGV, string tenDangNhap, string maKhoa, string email, string sdt, DateTime ngaySinh, string diaChi, string hoTen, string gioiTinh)
        {
            MaGV = maGV;
            TenDangNhap = tenDangNhap;
            MaKhoa = maKhoa;
            Email = email;
            SDT = sdt;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
        }
    }

}
