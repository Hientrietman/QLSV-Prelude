namespace GUI
{
    partial class SVDangKyHocPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDangKyHocPhan = new System.Windows.Forms.Label();
            this.dtgvDanhSachLopHocPhan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangKy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTimMaHocPhan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimMaHocPhan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblMaHocPhan = new System.Windows.Forms.Label();
            this.lblHocKyLoad = new System.Windows.Forms.Label();
            this.lblNamHocLoad = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDangKyHocPhan);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 79);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(792, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblDangKyHocPhan
            // 
            this.lblDangKyHocPhan.AutoSize = true;
            this.lblDangKyHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblDangKyHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblDangKyHocPhan.Location = new System.Drawing.Point(262, 21);
            this.lblDangKyHocPhan.Name = "lblDangKyHocPhan";
            this.lblDangKyHocPhan.Size = new System.Drawing.Size(393, 33);
            this.lblDangKyHocPhan.TabIndex = 1;
            this.lblDangKyHocPhan.Text = "ĐĂNG KÝ LỚP HỌC PHẦN";
            // 
            // dtgvDanhSachLopHocPhan
            // 
            this.dtgvDanhSachLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHocPhan,
            this.MaMonHoc,
            this.TenHocPhan,
            this.MaGV,
            this.Nam,
            this.NgayMoDau,
            this.NgayKetThuc,
            this.TinChi,
            this.ThongTin,
            this.DangKy});
            this.dtgvDanhSachLopHocPhan.Location = new System.Drawing.Point(1, 135);
            this.dtgvDanhSachLopHocPhan.Name = "dtgvDanhSachLopHocPhan";
            this.dtgvDanhSachLopHocPhan.Size = new System.Drawing.Size(955, 316);
            this.dtgvDanhSachLopHocPhan.TabIndex = 22;
            this.dtgvDanhSachLopHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachLopHocPhan_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 52.9023F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.FillWeight = 105.8046F;
            this.MaHocPhan.HeaderText = "Mã Học Phần";
            this.MaHocPhan.Name = "MaHocPhan";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.FillWeight = 105.8046F;
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.FillWeight = 105.8046F;
            this.TenHocPhan.HeaderText = "Tên Học Phần";
            this.TenHocPhan.Name = "TenHocPhan";
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.FillWeight = 105.8046F;
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.FillWeight = 95.87715F;
            this.Nam.HeaderText = "Năm Học";
            this.Nam.Name = "Nam";
            // 
            // NgayMoDau
            // 
            this.NgayMoDau.DataPropertyName = "NgayMoDau";
            this.NgayMoDau.FillWeight = 99.21888F;
            this.NgayMoDau.HeaderText = "Ngày mở đầu";
            this.NgayMoDau.Name = "NgayMoDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.FillWeight = 99.21888F;
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // TinChi
            // 
            this.TinChi.DataPropertyName = "TinChi";
            this.TinChi.FillWeight = 60F;
            this.TinChi.HeaderText = "Tín chỉ";
            this.TinChi.Name = "TinChi";
            // 
            // ThongTin
            // 
            this.ThongTin.DataPropertyName = "ThongTin";
            this.ThongTin.FillWeight = 99.21888F;
            this.ThongTin.HeaderText = "Thông tin";
            this.ThongTin.Name = "ThongTin";
            // 
            // DangKy
            // 
            this.DangKy.FillWeight = 107.0886F;
            this.DangKy.HeaderText = "Đăng ký";
            this.DangKy.Name = "DangKy";
            this.DangKy.Text = "Đăng ký";
            this.DangKy.UseColumnTextForButtonValue = true;
            // 
            // btnTimMaHocPhan
            // 
            this.btnTimMaHocPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimMaHocPhan.Location = new System.Drawing.Point(336, 93);
            this.btnTimMaHocPhan.Name = "btnTimMaHocPhan";
            this.btnTimMaHocPhan.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaHocPhan.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaHocPhan.Size = new System.Drawing.Size(96, 32);
            this.btnTimMaHocPhan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaHocPhan.StateCommon.Border.Rounding = 8;
            this.btnTimMaHocPhan.StateCommon.Border.Width = 2;
            this.btnTimMaHocPhan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaHocPhan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaHocPhan.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaHocPhan.StateTracking.Border.Rounding = 8;
            this.btnTimMaHocPhan.StateTracking.Border.Width = 2;
            this.btnTimMaHocPhan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTimMaHocPhan.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaHocPhan.TabIndex = 25;
            this.btnTimMaHocPhan.Values.Text = "Tìm kiếm";
            this.btnTimMaHocPhan.Click += new System.EventHandler(this.btnTimMaHocPhan_Click);
            // 
            // txtTimMaHocPhan
            // 
            this.txtTimMaHocPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimMaHocPhan.Location = new System.Drawing.Point(150, 95);
            this.txtTimMaHocPhan.Name = "txtTimMaHocPhan";
            this.txtTimMaHocPhan.Size = new System.Drawing.Size(161, 28);
            this.txtTimMaHocPhan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTimMaHocPhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaHocPhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaHocPhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimMaHocPhan.StateCommon.Border.Rounding = 10;
            this.txtTimMaHocPhan.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtTimMaHocPhan.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaHocPhan.TabIndex = 24;
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblMaHocPhan.Location = new System.Drawing.Point(16, 98);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(121, 20);
            this.lblMaHocPhan.TabIndex = 23;
            this.lblMaHocPhan.Text = "Mã Học Phần:";
            // 
            // lblHocKyLoad
            // 
            this.lblHocKyLoad.AutoSize = true;
            this.lblHocKyLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKyLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHocKyLoad.Location = new System.Drawing.Point(575, 100);
            this.lblHocKyLoad.Name = "lblHocKyLoad";
            this.lblHocKyLoad.Size = new System.Drawing.Size(21, 20);
            this.lblHocKyLoad.TabIndex = 26;
            this.lblHocKyLoad.Text = "A";
            // 
            // lblNamHocLoad
            // 
            this.lblNamHocLoad.AutoSize = true;
            this.lblNamHocLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHocLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblNamHocLoad.Location = new System.Drawing.Point(768, 100);
            this.lblNamHocLoad.Name = "lblNamHocLoad";
            this.lblNamHocLoad.Size = new System.Drawing.Size(21, 20);
            this.lblNamHocLoad.TabIndex = 27;
            this.lblNamHocLoad.Text = "A";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHocKy.Location = new System.Drawing.Point(500, 100);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(70, 20);
            this.lblHocKy.TabIndex = 28;
            this.lblHocKy.Text = "Học Kỳ:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblNamHoc.Location = new System.Drawing.Point(684, 100);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 20);
            this.lblNamHoc.TabIndex = 29;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // SVDangKyHocPhan
            // 
            this.AcceptButton = this.btnTimMaHocPhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 463);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblNamHocLoad);
            this.Controls.Add(this.lblHocKyLoad);
            this.Controls.Add(this.btnTimMaHocPhan);
            this.Controls.Add(this.txtTimMaHocPhan);
            this.Controls.Add(this.lblMaHocPhan);
            this.Controls.Add(this.dtgvDanhSachLopHocPhan);
            this.Controls.Add(this.panel1);
            this.Name = "SVDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVDangKyHocPhan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLopHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDangKyHocPhan;
        private System.Windows.Forms.DataGridView dtgvDanhSachLopHocPhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.DataGridViewButtonColumn DangKy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimMaHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimMaHocPhan;
        private System.Windows.Forms.Label lblMaHocPhan;
        private System.Windows.Forms.Label lblHocKyLoad;
        private System.Windows.Forms.Label lblNamHocLoad;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
    }
}