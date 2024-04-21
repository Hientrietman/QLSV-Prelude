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

namespace GUI
{
    public partial class InThoiKhoaBieu : Form
    {
        public InThoiKhoaBieu()
        {
            InitializeComponent();
            loadThoiKhoaBieu();
        }
        private void loadThoiKhoaBieu()
        {
            string HoTenSV = lblTenSV.Text;
            string MSSV = lblMSSV.Text;
            string Lop = lblLop.Text;
            string SoDienThoai = lblSDT.Text;

            int HocKy = int.Parse(lblHocKy.Text);
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
            int HocKy = int.Parse(lblHocKy.Text);
            string NamHocSV = lblNamHoc.Text;

            string TKB = String.Format("HK: {0}, NH: {1}",HocKy,NamHocSV);

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
                Paragraph tieude = new Paragraph("Thoi Khoa Bieu", FontFactory.GetFont(font.ToString(), 14, iTextSharp.text.Font.BOLD));
                tieude.Alignment = Element.TITLE;
                document.Add(tieude);

                Paragraph tkb = new Paragraph(TKB, FontFactory.GetFont(font.ToString(), 12, iTextSharp.text.Font.ITALIC));
                tkb.Alignment = Element.ALIGN_CENTER;
                document.Add(tkb);

                // Tạo một bảng PDF mới với số cột tương ứng với DataGridView
                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);               
                //Thiết lập độ rộng các cột trong bảng
                table.SetWidths(new float[] { 1f, 2f, 2f, 1f, 2.5f ,2f, 2f, 2f });

                // Thêm tiêu đề cột vào bảng PDF
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dataGridView.Columns[i].HeaderText));
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
