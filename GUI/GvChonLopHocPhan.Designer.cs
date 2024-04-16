namespace GUI
{
    partial class GvChonLopHocPhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDanhSachHocPhan = new System.Windows.Forms.Label();
            this.lblMaHocPhan = new System.Windows.Forms.Label();
            this.btnTimMaHocPhan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimMaHocPhan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.DanhSachSV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDanhSachHocPhan);
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
            // lblDanhSachHocPhan
            // 
            this.lblDanhSachHocPhan.AutoSize = true;
            this.lblDanhSachHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblDanhSachHocPhan.Location = new System.Drawing.Point(140, 22);
            this.lblDanhSachHocPhan.Name = "lblDanhSachHocPhan";
            this.lblDanhSachHocPhan.Size = new System.Drawing.Size(582, 29);
            this.lblDanhSachHocPhan.TabIndex = 1;
            this.lblDanhSachHocPhan.Text = "DANH SÁCH LỚP HỌC PHẦN ĐANG GIẢNG DẠY";
            // 
            // lblMaHocPhan
            // 
            this.lblMaHocPhan.AutoSize = true;
            this.lblMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblMaHocPhan.Location = new System.Drawing.Point(10, 95);
            this.lblMaHocPhan.Name = "lblMaHocPhan";
            this.lblMaHocPhan.Size = new System.Drawing.Size(121, 20);
            this.lblMaHocPhan.TabIndex = 4;
            this.lblMaHocPhan.Text = "Mã Học Phần:";
            // 
            // btnTimMaHocPhan
            // 
            this.btnTimMaHocPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimMaHocPhan.Location = new System.Drawing.Point(330, 90);
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
            this.btnTimMaHocPhan.TabIndex = 21;
            this.btnTimMaHocPhan.Values.Text = "Tìm kiếm";
            this.btnTimMaHocPhan.Click += new System.EventHandler(this.btnTimMaHocPhan_Click);
            // 
            // txtTimMaHocPhan
            // 
            this.txtTimMaHocPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimMaHocPhan.Location = new System.Drawing.Point(171, 92);
            this.txtTimMaHocPhan.Name = "txtTimMaHocPhan";
            this.txtTimMaHocPhan.Size = new System.Drawing.Size(144, 28);
            this.txtTimMaHocPhan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTimMaHocPhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaHocPhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaHocPhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimMaHocPhan.StateCommon.Border.Rounding = 10;
            this.txtTimMaHocPhan.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtTimMaHocPhan.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaHocPhan.TabIndex = 20;
            // 
            // dtgvDanhSachLopHocPhan
            // 
            this.dtgvDanhSachLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.DanhSachSV});
            this.dtgvDanhSachLopHocPhan.Location = new System.Drawing.Point(1, 130);
            this.dtgvDanhSachLopHocPhan.Name = "dtgvDanhSachLopHocPhan";
            this.dtgvDanhSachLopHocPhan.Size = new System.Drawing.Size(955, 321);
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
            this.TinChi.FillWeight = 78.07944F;
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
            // DanhSachSV
            // 
            this.DanhSachSV.FillWeight = 107.0886F;
            this.DanhSachSV.HeaderText = "Danh Sách SV";
            this.DanhSachSV.Name = "DanhSachSV";
            this.DanhSachSV.Text = "Danh Sách SV";
            this.DanhSachSV.UseColumnTextForButtonValue = true;
            // 
            // GvChonLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 463);
            this.Controls.Add(this.dtgvDanhSachLopHocPhan);
            this.Controls.Add(this.btnTimMaHocPhan);
            this.Controls.Add(this.txtTimMaHocPhan);
            this.Controls.Add(this.lblMaHocPhan);
            this.Controls.Add(this.panel1);
            this.Name = "GvChonLopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GvChonLopHocPhan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLopHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDanhSachHocPhan;
        private System.Windows.Forms.Label lblMaHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimMaHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimMaHocPhan;
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
        private System.Windows.Forms.DataGridViewButtonColumn DanhSachSV;
    }
}