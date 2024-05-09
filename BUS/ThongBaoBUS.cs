﻿using DAO;
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
    }
}