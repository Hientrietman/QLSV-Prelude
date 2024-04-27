using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class InThoiKhoaBieu : Form
    {
        //public string MSSV;
        //public string HocKy;
        //public string NamHoc;
        public InThoiKhoaBieu()
        {
            InitializeComponent();
        }
        public InThoiKhoaBieu(string mssv, string hocky, string namhoc) : this() 
        {
            //MSSV = mssv;
            //HocKy = hocky;
            //NamHoc = namhoc;

            lblMSSV.Text = mssv;
            lblHocKy.Text = hocky;
            lblNamHoc.Text = namhoc;

            System.Data.DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(mssv);
            lblTenSV.Text = dt.Rows[0]["HoTen"].ToString();
            lblSDT.Text = dt.Rows[0]["SDT"].ToString();
            lblLop.Text = dt.Rows[0]["Lop"].ToString();

            loadThoiKhoaBieu();
        }

        private void loadThoiKhoaBieu()
        {
            string HoTenSV = lblTenSV.Text;
            string MSSV = lblMSSV.Text;
            string Lop = lblLop.Text;
            string SoDienThoai = lblSDT.Text;

            string HocKy =lblHocKy.Text;
            string NamHocSV = lblNamHoc.Text;

            dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);

            ////Xử lý tách chuỗi năm học
            //string[] arrNamHocSV = NamHocSV.Split(new char[] { '-' });

            //int kiemtraNamHoc;
            //if (HocKy == 1)
            //{
            //    kiemtraNamHoc = int.Parse(arrNamHocSV[0]);
            //    dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);
            //}
            //else if (HocKy == 2)
            //{
            //    kiemtraNamHoc = int.Parse(arrNamHocSV[1]);
            //    dtgvBangTKB.DataSource = HocPhanBUS.Instance.TimThoiKhoaBieu(MSSV, HocKy, NamHocSV);
            //}
        }

        public void ExportDataToPDF(DataGridView dataGridView)
        {
            string HoTenSV = lblTenSV.Text;
            string MSSV = lblMSSV.Text;
            string Lop = lblLop.Text;
            string SoDienThoai = lblSDT.Text;

            int HocKy = int.Parse(lblHocKy.Text);
            string NamHocSV = lblNamHoc.Text;

            string TT1 = String.Format("Họ tên SV: {0}, MSSV: {1}", HoTenSV, MSSV);
            string TT2 = String.Format("Lớp: {0}, SĐT: {1}",Lop, SoDienThoai);
            string TKB = String.Format("Học Kỳ: {0}, Năm Học: {1}",HocKy,NamHocSV);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Lưu thời khóa biểu dưới dạng PDF";
            saveFileDialog.ShowDialog();

            BaseFont bf = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

            // Nếu người dùng đã chọn một tên file
            if (saveFileDialog.FileName != "")
            {
                // Tạo một đối tượng PDF mới
                Document document = new Document();
                // Tạo một writer PDF mới, ghi vào file được chọn
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                // Mở tài liệu để ghi vào
                document.Open();

                // Thêm dòng chữ tiêu đề
                Paragraph tieude = new Paragraph("Thời Khóa Biểu Sinh Viên", font);
                //Paragraph tieude = new Paragraph("Thoi Khoa Bieu", FontFactory.GetFont(font.ToString(), 14, iTextSharp.text.Font.BOLD));

                tieude.Alignment = Element.TITLE;
                document.Add(tieude);

                Paragraph ttsv1 = new Paragraph(TT1, font);
                ttsv1.Alignment = Element.ALIGN_LEFT;
                document.Add(ttsv1);

                Paragraph ttsv2 = new Paragraph(TT2, font);
                ttsv2.Alignment = Element.ALIGN_LEFT;
                document.Add(ttsv2);

                Paragraph tkb = new Paragraph(TKB, font);
                tkb.Alignment = Element.ALIGN_CENTER;
                document.Add(tkb);

                // Tạo một bảng PDF mới với số cột tương ứng với DataGridView
                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);               
                //Thiết lập độ rộng các cột trong bảng
                table.SetWidths(new float[] { 1f, 2f, 2f, 1f, 2.5f ,2f, 2f, 2f });

                // Thêm tiêu đề cột vào bảng PDF
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dataGridView.Columns[i].HeaderText,font));
                }

                // Thêm các hàng dữ liệu vào bảng PDF
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView[j, i].Value.ToString(), font));
                        }
                        else
                        {
                            table.AddCell(new Phrase(""));
                        }
                    }
                }

                // Thêm bảng vào tài liệu
                document.Add(table);
                // Đóng tài liệu
                document.Close();
                MessageBox.Show("In thời khóa biểu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string MSSV = lblMSSV.Text;
            int HocKy = int.Parse(lblHocKy.Text);
            string NamHocSV = lblNamHoc.Text;
            //Kiểm tra dữ liệu trong tkb
            if (HocPhanBUS.Instance.KiemTraTKB(MSSV, HocKy, NamHocSV) == true)
            {
                ExportDataToPDF(dtgvBangTKB);
            }
            else
            {
                MessageBox.Show("In thời khóa biểu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
