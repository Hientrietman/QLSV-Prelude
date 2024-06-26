﻿using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuSinhVien : Form
    {
        private TaiKhoanDAO loginAccount;

        public TaiKhoanDAO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        private TaiKhoanDTO taiKhoan;
        public TrangChuSinhVien(TaiKhoanDTO TaiKhoan)
        {
            InitializeComponent();
            lblName.Text = LayTenSinhVien(TaiKhoan.TenDangNhap); ;
            lblMSSV.Text = TaiKhoan.TenDangNhap;
            taiKhoan = TaiKhoan;
        }

        public TrangChuSinhVien()
        {
        }
        public string LayMaSinhVien()
        {
            return lblMSSV.Text;
        }
        public string LayTenSinhVien()
        {
            return lblName.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SinhVienXemDiemThi sinhVienXemDiemThi = new SinhVienXemDiemThi(taiKhoan);
            sinhVienXemDiemThi.ShowDialog();
        }

        private string LayTenSinhVien(string tenDangNhap)
        {
            string maSV = "";

            DataTable dt = SinhVienBUS.Instance.LayThongTinSinhVien(tenDangNhap);

            if (dt != null && dt.Rows.Count > 0)
            {
                maSV = dt.Rows[0]["HoTen"].ToString();
            }

            return maSV;
        }


        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //string MSSV = lblMSSV.Text;
            //string HoTenSV = lblName.Text;
            SinhVienXemThoiKhoaBieu sinhVienXemThoiKhoaBieu = new SinhVienXemThoiKhoaBieu(lblMSSV.Text, lblName.Text);
            sinhVienXemThoiKhoaBieu.ShowDialog();
         }


        private void btnInfo_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(taiKhoan);
            f.ShowDialog();
            lblName.Text = LayTenSinhVien(taiKhoan.TenDangNhap);


        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            SVDangKyHocPhan f = new SVDangKyHocPhan(taiKhoan);
            f.ShowDialog();
        }

        private void btnThongbaochung_Click(object sender, EventArgs e)
        {
            ThongBao f = new ThongBao(taiKhoan);
            f.ShowDialog();
        }
        
        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            XemHocPhi f = new XemHocPhi(taiKhoan);
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GopYVaHoiDap f = new GopYVaHoiDap(taiKhoan);
            f.ShowDialog();
        }

        private void btnTimeSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}
