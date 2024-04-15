using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    using System;
    using System.Data;

    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int VaiTro { get; set; }
        public int? TrangThai { get; set; }

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(DataRow row)
        {
            TenDangNhap = row["TenDangNhap"].ToString();
            MatKhau = row["MatKhau"].ToString();
            VaiTro = Convert.ToInt32(row["VaiTro"]);
            TrangThai = row["TrangThai"] != DBNull.Value ? Convert.ToInt32(row["TrangThai"]) : (int?)null;
        }

        public TaiKhoanDTO(string tenDangNhap, string matKhau, int vaiTro, int trangthai)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            VaiTro = vaiTro;
            TrangThai = trangthai;
            // Khởi tạo các thuộc tính khác nếu cần
        }
    }
}


