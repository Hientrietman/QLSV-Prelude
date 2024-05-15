using System;
using DAO;
using BUS;
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
    public partial class SuaThongBao : Form
    {
        public SuaThongBao()
        {
            InitializeComponent();
        }
        public string maThongBao;
        public SuaThongBao(string matb, string tieude, string noidung) : this()
        {
            maThongBao = matb;
            txtTieuDe.Text = tieude;
            txtNoiDung.Text = noidung;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            txtNoiDung.SelectionStart = txtNoiDung.Text.Length;
            txtNoiDung.ScrollToCaret();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaThongBao = maThongBao; // Lấy mã thông báo từ biến lớp
            string tieuDe = txtTieuDe.Text;
            string noiDung = txtNoiDung.Text;

            // Kiểm tra nếu nội dung và tiêu đề mới giống với nội dung và tiêu đề cũ
            if (!IsContentModified(tieuDe, noiDung))
            {
                MessageBox.Show("Nội dung và tiêu đề mới không có sự thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra dữ liệu hợp lệ
            if (!IsValidTieude(tieuDe) || !IsValidNoidung(noiDung))
                return;

            // Cập nhật thông báo
            ThongBaoBUS.Instance.CapNhatThongBao(MaThongBao, tieuDe, noiDung);

            // Hiển thị thông báo hoặc thực hiện các hành động phù hợp
            MessageBox.Show("Thông báo đã được sửa thành công!");

            // Đóng form sau khi sửa thành công (tùy theo yêu cầu của bạn)
            this.Close();
        }
        private bool IsValidTieude(string tieude)
        {

            if (string.IsNullOrWhiteSpace(tieude))
            {
                MessageBox.Show("Tiêu đề không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsValidNoidung(string noidung)
        {

            if (string.IsNullOrWhiteSpace(noidung))
            {
                MessageBox.Show("Nội dung không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsContentModified(string newTieuDe, string newNoiDung)
        {
            string maThongBao = this.maThongBao; // Lấy mã thông báo từ biến lớp
            // Lấy thông tin của thông báo từ cơ sở dữ liệu
            DataTable dt = ThongBaoDAO.Instance.LayThongBaoTheoMa(maThongBao);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string oldTieuDe = row["TieuDe"].ToString();
                string oldNoiDung = row["NoiDung"].ToString();

                // So sánh nội dung và tiêu đề mới với nội dung và tiêu đề cũ
                if (newTieuDe == oldTieuDe && newNoiDung == oldNoiDung)
                    return false; // Trả về false nếu không có sự thay đổi
                else
                    return true; // Trả về true nếu có sự thay đổi
            }
            else
            {

                return false;
            }
        }

        
    }
}
