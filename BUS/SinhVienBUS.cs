﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBUS
    {
        private SinhVienBUS() { }
        private static SinhVienBUS instance;
        public static SinhVienBUS Instance
        {
            get { if (instance == null) instance = new SinhVienBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayDanhSachSVCuaLopHocPhan(string MaHocPhan)
        {
            return SinhVienDAO.Instance.LayDanhSachSVCuaLopHocPhan(MaHocPhan);
        }

        public DataTable TimKiemMaSVTrongLopHocPhan(string MaHP, string MaSV)
        {

            return SinhVienDAO.Instance.TimKiemMaSVTrongLopHocPhan(MaHP, MaSV);
        }

        public DataTable LayThongTinSinhVien(string MaSV)
        {
            return SinhVienDAO.Instance.LayThongTinSinhVien(MaSV);
        }
        public bool ChinhSuaThongTinSinhVien(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh)
        {
            return SinhVienDAO.Instance.ChinhSuaThongTinSinhVien(MaSV, Lop, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh);
        }

        public DataTable LayToanBoSinhVien()
        {
            return SinhVienDAO.Instance.LayToanBoSinhVien();
        }
        public DataTable LayLop()
        {
            return SinhVienDAO.Instance.LayLop();
        }
        public DataTable LayLopTheoKhoa(string maKhoa)
        {
            return SinhVienDAO.Instance.LayLopTheoKhoa(maKhoa);
        }
        public DataTable timKiemSVTrongDSSV(string maSV, string khoa, string lop)
        {
            return SinhVienDAO.Instance.timKiemSVTrongDSSV(maSV, khoa, lop);    
        }
        public bool CapNhatSV(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh, string Khoa)
        {
            return SinhVienDAO.Instance.CapNhatSV(MaSV, Lop, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
        }
        public bool ThemSV(string MaSV, string Lop, string Email, string SDT, DateTime NgaySinh, string DiaChi, string HoTen, string GioiTinh, string Khoa)
        {
            return SinhVienDAO.Instance.ThemSV(MaSV, Lop, Email, SDT, NgaySinh, DiaChi, HoTen, GioiTinh, Khoa);
        }

       
        public bool XoaSinhVien(string MaSV)
        {
            return SinhVienDAO.Instance.XoaSinhVien(MaSV);
        }
        public bool IsStudentIdExists(string maSV)
        {
            return SinhVienDAO.Instance.IsStudentIdExists(maSV);
        }
        public bool IsStudentEmailExists(string email)
        {
            return SinhVienDAO.Instance.IsStudentEmailExists(email);
        }
    }
}
