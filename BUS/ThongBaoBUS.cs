using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongBaoBUS
    {
        private ThongBaoBUS() { }
        private static ThongBaoBUS instance;
        public static ThongBaoBUS Instance
        {
            get { if (instance == null) instance = new ThongBaoBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable LayDanhSachThongBao(string TieuDe)
        {
            return ThongBaoDAO.Instance.LayDanhSachThongBao(TieuDe);
        }
        public DataTable LayDanhSachThongBaoV2(string TieuDe)
        {
            return ThongBaoDAO.Instance.LayDanhSachThongBaoV2(TieuDe);
        }
        public string LayNoiDungThongBao(string MaThongBao)
        {
            return ThongBaoDAO.Instance.LayNoiDungThongBao(MaThongBao);

        }
        public string LayTenNguoiTaoThongBao(string MaThongBao)
        {
            return ThongBaoDAO.Instance.LayTenNguoiTaoThongBao(MaThongBao);

        }
        public DataTable LayThongBaoTheoMa(string maThongBao)
        {
            return ThongBaoDAO.Instance.LayThongBaoTheoMa(maThongBao);
        }
        public void CapNhatThongBao(string maThongBao, string tieuDe, string noiDung)
        {
            ThongBaoDAO.Instance.CapNhatThongBao(maThongBao, tieuDe, noiDung);
        }
    }
}
