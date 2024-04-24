namespace GUI
{
    partial class DanhSachSinhVienCuaLopHP
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
            this.lblTenLopHocPhan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDanhSachSVCuaLopHocPhan = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.btnTimMaSinhVien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimMaSinhVien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtgvDanhSachSVCuaLopHocPhan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Them = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXuatExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSVCuaLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblTenLopHocPhan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDanhSachSVCuaLopHocPhan);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 79);
            this.panel1.TabIndex = 0;
            // 
            // lblTenLopHocPhan
            // 
            this.lblTenLopHocPhan.AutoSize = true;
            this.lblTenLopHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLopHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblTenLopHocPhan.Location = new System.Drawing.Point(352, 43);
            this.lblTenLopHocPhan.Name = "lblTenLopHocPhan";
            this.lblTenLopHocPhan.Size = new System.Drawing.Size(131, 25);
            this.lblTenLopHocPhan.TabIndex = 24;
            this.lblTenLopHocPhan.Text = "COMP0001";
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
            this.lblDanhSachSVCuaLopHocPhan.Location = new System.Drawing.Point(166, 9);
            this.lblDanhSachSVCuaLopHocPhan.Name = "lblDanhSachSVCuaLopHocPhan";
            this.lblDanhSachSVCuaLopHocPhan.Size = new System.Drawing.Size(494, 25);
            this.lblDanhSachSVCuaLopHocPhan.TabIndex = 1;
            this.lblDanhSachSVCuaLopHocPhan.Text = "DANH SÁCH SINH VIÊN CỦA LỚP HỌC PHẦN";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblMaSinhVien.Location = new System.Drawing.Point(10, 95);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(137, 20);
            this.lblMaSinhVien.TabIndex = 4;
            this.lblMaSinhVien.Text = "Mã số sinh viên:";
            // 
            // btnTimMaSinhVien
            // 
            this.btnTimMaSinhVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimMaSinhVien.Location = new System.Drawing.Point(329, 90);
            this.btnTimMaSinhVien.Name = "btnTimMaSinhVien";
            this.btnTimMaSinhVien.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaSinhVien.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaSinhVien.Size = new System.Drawing.Size(96, 32);
            this.btnTimMaSinhVien.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaSinhVien.StateCommon.Border.Rounding = 8;
            this.btnTimMaSinhVien.StateCommon.Border.Width = 2;
            this.btnTimMaSinhVien.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaSinhVien.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTimMaSinhVien.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimMaSinhVien.StateTracking.Border.Rounding = 8;
            this.btnTimMaSinhVien.StateTracking.Border.Width = 2;
            this.btnTimMaSinhVien.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTimMaSinhVien.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaSinhVien.TabIndex = 21;
            this.btnTimMaSinhVien.Values.Text = "Tìm kiếm";
            this.btnTimMaSinhVien.Click += new System.EventHandler(this.btnTimMaSinhVien_Click);
            // 
            // txtTimMaSinhVien
            // 
            this.txtTimMaSinhVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimMaSinhVien.Location = new System.Drawing.Point(163, 92);
            this.txtTimMaSinhVien.Name = "txtTimMaSinhVien";
            this.txtTimMaSinhVien.Size = new System.Drawing.Size(144, 28);
            this.txtTimMaSinhVien.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTimMaSinhVien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaSinhVien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txtTimMaSinhVien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimMaSinhVien.StateCommon.Border.Rounding = 10;
            this.txtTimMaSinhVien.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtTimMaSinhVien.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaSinhVien.TabIndex = 20;
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
            this.MaSV,
            this.Lop,
            this.HoTen,
            this.NgaySinh,
            this.DiemQuaTrinh,
            this.DiemGiuaKy,
            this.DiemCuoiKy,
            this.Them,
            this.Sua});
            this.dtgvDanhSachSVCuaLopHocPhan.Location = new System.Drawing.Point(1, 130);
            this.dtgvDanhSachSVCuaLopHocPhan.Name = "dtgvDanhSachSVCuaLopHocPhan";
            this.dtgvDanhSachSVCuaLopHocPhan.Size = new System.Drawing.Size(969, 321);
            this.dtgvDanhSachSVCuaLopHocPhan.TabIndex = 22;
            this.dtgvDanhSachSVCuaLopHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachSVCuaLopHocPhan_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 43.25956F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.FillWeight = 86.5191F;
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.Name = "MaSV";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.FillWeight = 86.5191F;
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 86.5191F;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 86.5191F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.DataPropertyName = "DiemQuaTrinh";
            this.DiemQuaTrinh.FillWeight = 63.54511F;
            this.DiemQuaTrinh.HeaderText = "Điểm Quá Trình";
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            // 
            // DiemGiuaKy
            // 
            this.DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            this.DiemGiuaKy.FillWeight = 60.94918F;
            this.DiemGiuaKy.HeaderText = "Điểm Giữa Kỳ";
            this.DiemGiuaKy.Name = "DiemGiuaKy";
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            this.DiemCuoiKy.FillWeight = 58.05992F;
            this.DiemCuoiKy.HeaderText = "Điểm Cuối Kỳ";
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            // 
            // Them
            // 
            this.Them.FillWeight = 53.41833F;
            this.Them.HeaderText = "Thêm";
            this.Them.Name = "Them";
            this.Them.Text = "Thêm";
            this.Them.UseColumnTextForButtonValue = true;
            // 
            // Sua
            // 
            this.Sua.FillWeight = 53.41833F;
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuatExcel.Location = new System.Drawing.Point(843, 92);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Size = new System.Drawing.Size(96, 32);
            this.btnXuatExcel.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.StateCommon.Border.Rounding = 8;
            this.btnXuatExcel.StateCommon.Border.Width = 2;
            this.btnXuatExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnXuatExcel.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.StateTracking.Border.Rounding = 8;
            this.btnXuatExcel.StateTracking.Border.Width = 2;
            this.btnXuatExcel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.TabIndex = 23;
            this.btnXuatExcel.Values.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // DanhSachSinhVienCuaLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 463);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dtgvDanhSachSVCuaLopHocPhan);
            this.Controls.Add(this.btnTimMaSinhVien);
            this.Controls.Add(this.txtTimMaSinhVien);
            this.Controls.Add(this.lblMaSinhVien);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(667, 296);
            this.Name = "DanhSachSinhVienCuaLopHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DanhSachSinhVienCuaLopHP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSVCuaLopHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDanhSachSVCuaLopHocPhan;
        private System.Windows.Forms.Label lblMaSinhVien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimMaSinhVien;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimMaSinhVien;
        private System.Windows.Forms.DataGridView dtgvDanhSachSVCuaLopHocPhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenLopHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewButtonColumn Them;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;

    }
}