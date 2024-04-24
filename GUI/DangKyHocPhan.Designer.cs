namespace GUI
{
    partial class DangKyHocPhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDanhSachSVCuaLopHocPhan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangKy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblMaHocPhan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDanhSachSVCuaLopHocPhan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblHienThiHocKy = new System.Windows.Forms.Label();
            this.txtMaHocPhan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblHienThiNamHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSVCuaLopHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDanhSachSVCuaLopHocPhan
            // 
            this.dtgvDanhSachSVCuaLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachSVCuaLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachSVCuaLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSVCuaLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHocPhan,
            this.TenHocPhan,
            this.MaGiaoVien,
            this.NamHoc,
            this.PhongHoc,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.SoTinChi,
            this.LichHoc,
            this.DangKy});
            this.dtgvDanhSachSVCuaLopHocPhan.Location = new System.Drawing.Point(1, 136);
            this.dtgvDanhSachSVCuaLopHocPhan.Name = "dtgvDanhSachSVCuaLopHocPhan";
            this.dtgvDanhSachSVCuaLopHocPhan.Size = new System.Drawing.Size(969, 321);
            this.dtgvDanhSachSVCuaLopHocPhan.TabIndex = 28;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 43.25956F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.FillWeight = 86.5191F;
            this.MaHocPhan.HeaderText = "Mã học phần";
            this.MaHocPhan.Name = "MaHocPhan";
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.FillWeight = 86.5191F;
            this.TenHocPhan.HeaderText = "Tên Học Phần";
            this.TenHocPhan.Name = "TenHocPhan";
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.FillWeight = 86.5191F;
            this.MaGiaoVien.HeaderText = "Mã Giáo viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.FillWeight = 86.5191F;
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.FillWeight = 63.54511F;
            this.PhongHoc.HeaderText = "Phòng Học";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.FillWeight = 60.94918F;
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.FillWeight = 58.05992F;
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số Tín Chỉ";
            this.SoTinChi.Name = "SoTinChi";
            // 
            // LichHoc
            // 
            this.LichHoc.DataPropertyName = "LichHoc";
            this.LichHoc.HeaderText = "Lịch Học";
            this.LichHoc.Name = "LichHoc";
            // 
            // DangKy
            // 
            this.DangKy.FillWeight = 53.41833F;
            this.DangKy.HeaderText = "Đăng Ký";
            this.DangKy.Name = "DangKy";
            this.DangKy.Text = "Đăng Ký";
            this.DangKy.UseColumnTextForButtonValue = true;
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblMaHocPhan.Location = new System.Drawing.Point(10, 101);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(117, 20);
            this.lblMaHocPhan.TabIndex = 25;
            this.lblMaHocPhan.Text = "Mã học phần:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(810, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblDanhSachSVCuaLopHocPhan
            // 
            this.lblDanhSachSVCuaLopHocPhan.AutoSize = true;
            this.lblDanhSachSVCuaLopHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachSVCuaLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSVCuaLopHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblDanhSachSVCuaLopHocPhan.Location = new System.Drawing.Point(332, 19);
            this.lblDanhSachSVCuaLopHocPhan.Name = "lblDanhSachSVCuaLopHocPhan";
            this.lblDanhSachSVCuaLopHocPhan.Size = new System.Drawing.Size(291, 25);
            this.lblDanhSachSVCuaLopHocPhan.TabIndex = 1;
            this.lblDanhSachSVCuaLopHocPhan.Text = "ĐĂNG KÝ LỚP HỌC PHẦN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDanhSachSVCuaLopHocPhan);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 79);
            this.panel1.TabIndex = 24;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblNamHoc.Location = new System.Drawing.Point(657, 101);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 20);
            this.lblNamHoc.TabIndex = 30;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHocKy.Location = new System.Drawing.Point(521, 101);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(68, 20);
            this.lblHocKy.TabIndex = 31;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblHienThiHocKy
            // 
            this.lblHienThiHocKy.AutoSize = true;
            this.lblHienThiHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHienThiHocKy.Location = new System.Drawing.Point(595, 101);
            this.lblHienThiHocKy.Name = "lblHienThiHocKy";
            this.lblHienThiHocKy.Size = new System.Drawing.Size(19, 20);
            this.lblHienThiHocKy.TabIndex = 32;
            this.lblHienThiHocKy.Text = "1";
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHocPhan.Location = new System.Drawing.Point(153, 101);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.Size = new System.Drawing.Size(153, 28);
            this.txtMaHocPhan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMaHocPhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtMaHocPhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtMaHocPhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaHocPhan.StateCommon.Border.Rounding = 10;
            this.txtMaHocPhan.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtMaHocPhan.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocPhan.TabIndex = 50;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Location = new System.Drawing.Point(338, 98);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Size = new System.Drawing.Size(96, 32);
            this.btnTimKiem.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateCommon.Border.Rounding = 8;
            this.btnTimKiem.StateCommon.Border.Width = 2;
            this.btnTimKiem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimKiem.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateTracking.Border.Rounding = 8;
            this.btnTimKiem.StateTracking.Border.Width = 2;
            this.btnTimKiem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // lblHienThiNamHoc
            // 
            this.lblHienThiNamHoc.AutoSize = true;
            this.lblHienThiNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHienThiNamHoc.Location = new System.Drawing.Point(747, 101);
            this.lblHienThiNamHoc.Name = "lblHienThiNamHoc";
            this.lblHienThiNamHoc.Size = new System.Drawing.Size(95, 20);
            this.lblHienThiNamHoc.TabIndex = 52;
            this.lblHienThiNamHoc.Text = "2022-2023";
            // 
            // DangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 463);
            this.Controls.Add(this.lblHienThiNamHoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaHocPhan);
            this.Controls.Add(this.lblHienThiHocKy);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.dtgvDanhSachSVCuaLopHocPhan);
            this.Controls.Add(this.lblMaHocPhan);
            this.Controls.Add(this.panel1);
            this.Name = "DangKyHocPhan";
            this.Text = "DangKyHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSVCuaLopHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDanhSachSVCuaLopHocPhan;
        private System.Windows.Forms.Label lblMaHocPhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDanhSachSVCuaLopHocPhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichHoc;
        private System.Windows.Forms.DataGridViewButtonColumn DangKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblHienThiHocKy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private System.Windows.Forms.Label lblHienThiNamHoc;
    }
}