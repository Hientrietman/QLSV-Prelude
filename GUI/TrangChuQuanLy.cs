﻿using System;
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
    public partial class TrangChuQuanLy : Form
    {
        public TrangChuQuanLy()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan taoTaiKhoan = new TaoTaiKhoan();
            taoTaiKhoan.ShowDialog();
        }
    }
}