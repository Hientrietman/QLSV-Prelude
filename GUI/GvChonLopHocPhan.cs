﻿using BUS;
using DAO;
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
    public partial class GvChonLopHocPhan : Form
    {
        public GvChonLopHocPhan()
        {
            InitializeComponent();
            dtgvDanhSachLopHocPhan.DataSource = HocPhanBUS.Instance.LayDanhSachHocPhan();
        }

        DataTable TimKiemMaHP(string MaHP)
        {

            DataTable dataTable = new DataTable();
            dataTable = HocPhanBUS.Instance.TimKiemMaHP(MaHP);

            return dataTable;
        }

        private void btnTimMaHocPhan_Click(object sender, EventArgs e)
        {
            dtgvDanhSachLopHocPhan.DataSource = TimKiemMaHP(txtTimMaHocPhan.Text);
        }

    }
}