using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDTO
    {
        public DiemDTO(string maSinhVien, string maHocPhan, float? diemQuaTrinh, float? diemGiuaKy, float? diemCuoiKy)
        {
            this.MaSinhVien = maSinhVien;
            this.MaHocPhan = maHocPhan;
            this.DiemQuaTrinh = diemQuaTrinh;
            this.DiemGiuaKy = diemGiuaKy;
            this.DiemCuoiKy = diemCuoiKy;
        }

        public DiemDTO(DataRow row)
        {
            this.MaSinhVien = row["MaSinhVien"].ToString();
            this.MaHocPhan = row["MaHocPhan"].ToString();
            this.DiemQuaTrinh = (float?)row["DiemQuaTrinh"];
            this.DiemGiuaKy = (float?)row["DiemGiuaKy"];
            this.DiemCuoiKy = (float?)row["DiemCuoiKy"];
        }

        private string maSinhVien;
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

        private string maHocPhan;
        public string MaHocPhan
        {
            get { return maHocPhan; }
            set { maHocPhan = value; }
        }

        private float? diemQuaTrinh;
        public float? DiemQuaTrinh
        {
            get { return diemQuaTrinh; }
            set { diemQuaTrinh = value; }
        }

        private float? diemGiuaKy;
        public float? DiemGiuaKy
        {
            get { return diemGiuaKy; }
            set { diemGiuaKy = value; }
        }

        private float? diemCuoiKy;
        public float? DiemCuoiKy
        {
            get { return diemCuoiKy; }
            set { diemCuoiKy = value; }
        }
    }
}
