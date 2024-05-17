using BUS;
using DAO;
using DTO;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongBao : Form
    {
        private DataTable duLieuBang; 
        private int trangHienTai = 1;   // Trang hiện tại
        private int soDong = 20;        // Số dòng hiển thị trên mỗi trang

        TaiKhoanDTO taiKhoanDTO = null;
        public ThongBao(DTO.TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanDTO = taiKhoan;

            loadBangThongBao();
            //loadTrangThongBao(trangHienTai);
        }
        private void loadTrangThongBao(int page)
        {
            // Tính toán chỉ số bắt đầu và kết thúc của danh sách thông báo
            int trangDau = (page - 1) * soDong;
            int trangCuoi = Math.Min(trangDau + soDong - 1, duLieuBang.Rows.Count - 1);

            // Hiển thị dữ liệu trên DataGridView

            if (duLieuBang.AsEnumerable().Any())
            {
                dtgvBangThongBao.DataSource = duLieuBang.AsEnumerable()
                .Skip(trangDau)
                .Take(trangCuoi - trangDau + 1).CopyToDataTable();
                // Cập nhật label số trang
                lblSoTrang.Text = $"{trangHienTai}/{tongTrang()}";
                lblCanhBao.Text = "";
            }
            else
            { 
                duLieuBang.Clone();
                lblCanhBao.Text = "Không thấy thông tin tìm kiếm!";
            }

        }
        private int tongTrang()
        {
            return (int)Math.Ceiling((double)duLieuBang.Rows.Count / soDong);
        }
        private void loadBangThongBao()
        {
            string TieuDe = txtTimKiem.Text;

            duLieuBang = new DataTable();
            duLieuBang = ThongBaoBUS.Instance.LayDanhSachThongBaoV2(TieuDe);

            this.dtgvBangThongBao.AutoGenerateColumns = false;
            //Ẩn cột mathongbao
            this.dtgvBangThongBao.Columns["MaThongBao"].Visible = false;
            dtgvBangThongBao.ScrollBars = ScrollBars.None;

            loadTrangThongBao(trangHienTai);

        }
        private void btnTimKiemTB_Click(object sender, EventArgs e)
        {
            loadBangThongBao();
        }

        private void dtgvBangThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            string MaThongBao = dtgvBangThongBao.Rows[r].Cells["MaThongBao"].Value.ToString();
            string TieuDe = dtgvBangThongBao.Rows[r].Cells["TieuDe"].Value.ToString();
            string NgayTao = dtgvBangThongBao.Rows[r].Cells["NgayTao"].Value.ToString();

            DataGridViewRow row = dtgvBangThongBao.Rows[e.RowIndex];

            if (row == dtgvBangThongBao.Rows[e.RowIndex])
            {
                XemThongBao xemThongBao = new XemThongBao(MaThongBao, TieuDe, NgayTao);
                xemThongBao.ShowDialog();
            }
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                loadTrangThongBao(trangHienTai);
            }
        }

        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongTrang())
            {
                trangHienTai++;
                loadTrangThongBao(trangHienTai);
            }
        }

        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            trangHienTai = 1;
            loadTrangThongBao(trangHienTai);
        }

        private void btnCuoiTrang_Click(object sender, EventArgs e)
        {
            trangHienTai = tongTrang();
            loadTrangThongBao(trangHienTai);
        }

    }
}
