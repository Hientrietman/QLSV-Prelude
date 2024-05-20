using System.Collections.Generic;

namespace GUI
{
    partial class ThongTinSV
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txt_MSV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_MSV = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_HoTen = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_HoTen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_NgaySinh = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_GioiTinh = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_DiaChi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DiaChi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDanhSachSVCuaLopHocPhan = new System.Windows.Forms.Label();
            this.btn_Enter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnKhoa = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Lop = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_SDT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_SDT = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_GioiTinh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.dtP_NgaySinh = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(48, 55);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(0, 13);
            this.lblMSSV.TabIndex = 0;
            // 
            // txt_MSV
            // 
            this.txt_MSV.Location = new System.Drawing.Point(200, 96);
            this.txt_MSV.Name = "txt_MSV";
            this.txt_MSV.Size = new System.Drawing.Size(200, 23);
            this.txt_MSV.TabIndex = 1;
            // 
            // lbl_MSV
            // 
            this.lbl_MSV.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_MSV.Location = new System.Drawing.Point(91, 96);
            this.lbl_MSV.Name = "lbl_MSV";
            this.lbl_MSV.Size = new System.Drawing.Size(84, 20);
            this.lbl_MSV.TabIndex = 2;
            this.lbl_MSV.Values.Text = "Mã sinh viên";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_HoTen.Location = new System.Drawing.Point(475, 96);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(50, 20);
            this.lbl_HoTen.TabIndex = 4;
            this.lbl_HoTen.Values.Text = "Họ tên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(584, 93);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(200, 23);
            this.txt_HoTen.TabIndex = 3;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(87, 201);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(68, 20);
            this.lbl_NgaySinh.TabIndex = 6;
            this.lbl_NgaySinh.Values.Text = "Ngày sinh";
            // 
            // lbl_Email
            // 
            this.lbl_Email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_Email.Location = new System.Drawing.Point(90, 261);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 20);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Values.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(200, 261);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 23);
            this.txt_Email.TabIndex = 7;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(475, 201);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(61, 20);
            this.lbl_GioiTinh.TabIndex = 11;
            this.lbl_GioiTinh.Values.Text = "Giới tính";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_DiaChi.Location = new System.Drawing.Point(91, 324);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 20);
            this.lbl_DiaChi.TabIndex = 13;
            this.lbl_DiaChi.Values.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(200, 324);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(591, 75);
            this.txt_DiaChi.TabIndex = 12;
            this.txt_DiaChi.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblDanhSachSVCuaLopHocPhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 68);
            this.panel1.TabIndex = 17;
            // 
            // lblDanhSachSVCuaLopHocPhan
            // 
            this.lblDanhSachSVCuaLopHocPhan.AutoSize = true;
            this.lblDanhSachSVCuaLopHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachSVCuaLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSVCuaLopHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblDanhSachSVCuaLopHocPhan.Location = new System.Drawing.Point(348, 26);
            this.lblDanhSachSVCuaLopHocPhan.Name = "lblDanhSachSVCuaLopHocPhan";
            this.lblDanhSachSVCuaLopHocPhan.Size = new System.Drawing.Size(254, 25);
            this.lblDanhSachSVCuaLopHocPhan.TabIndex = 1;
            this.lblDanhSachSVCuaLopHocPhan.Text = "THÔNG TIN SINH VIÊN";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Enter.Location = new System.Drawing.Point(347, 447);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_Enter.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_Enter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Enter.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Size = new System.Drawing.Size(96, 32);
            this.btn_Enter.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_Enter.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_Enter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Enter.StateCommon.Border.Rounding = 8;
            this.btn_Enter.StateCommon.Border.Width = 2;
            this.btn_Enter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Enter.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btn_Enter.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btn_Enter.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Enter.StateTracking.Border.Rounding = 8;
            this.btn_Enter.StateTracking.Border.Width = 2;
            this.btn_Enter.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Enter.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Enter.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.TabIndex = 23;
            this.btn_Enter.Values.Text = "Hoàn thành";
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.Location = new System.Drawing.Point(520, 447);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_Exit.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_Exit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Size = new System.Drawing.Size(96, 32);
            this.btn_Exit.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_Exit.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_Exit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateCommon.Border.Rounding = 8;
            this.btn_Exit.StateCommon.Border.Width = 2;
            this.btn_Exit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btn_Exit.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btn_Exit.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btn_Exit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateTracking.Border.Rounding = 8;
            this.btn_Exit.StateTracking.Border.Width = 2;
            this.btn_Exit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Exit.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Exit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.TabIndex = 24;
            this.btn_Exit.Values.Text = "Hủy";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.btnKhoa.Location = new System.Drawing.Point(101, 145);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(40, 20);
            this.btnKhoa.TabIndex = 28;
            this.btnKhoa.Values.Text = "Khoa";
            // 
            // btn_Lop
            // 
            this.btn_Lop.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.btn_Lop.Location = new System.Drawing.Point(475, 145);
            this.btn_Lop.Name = "btn_Lop";
            this.btn_Lop.Size = new System.Drawing.Size(32, 20);
            this.btn_Lop.TabIndex = 26;
            this.btn_Lop.Values.Text = "Lớp";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(584, 261);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 23);
            this.txt_SDT.TabIndex = 29;
            // 
            // btn_SDT
            // 
            this.btn_SDT.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.btn_SDT.Location = new System.Drawing.Point(475, 261);
            this.btn_SDT.Name = "btn_SDT";
            this.btn_SDT.Size = new System.Drawing.Size(87, 20);
            this.btn_SDT.TabIndex = 30;
            this.btn_SDT.Values.Text = "Số điện thoại";
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Location = new System.Drawing.Point(584, 201);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(200, 23);
            this.txt_GioiTinh.TabIndex = 31;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(200, 145);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(200, 21);
            this.cb_Khoa.TabIndex = 34;
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.CustomFormat = "yyyy-mm-dd";
            this.dtP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_NgaySinh.Location = new System.Drawing.Point(200, 202);
            this.dtP_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtP_NgaySinh.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtP_NgaySinh.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtP_NgaySinh.Name = "dtP_NgaySinh";
            this.dtP_NgaySinh.Size = new System.Drawing.Size(200, 21);
            this.dtP_NgaySinh.TabIndex = 35;
            this.dtP_NgaySinh.ValueNullable = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(584, 144);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(200, 21);
            this.cb_Lop.TabIndex = 36;
            // 
            // ThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 527);
            this.Controls.Add(this.cb_Lop);
            this.Controls.Add(this.dtP_NgaySinh);
            this.Controls.Add(this.cb_Khoa);
            this.Controls.Add(this.txt_GioiTinh);
            this.Controls.Add(this.btn_SDT);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btn_Lop);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_MSV);
            this.Controls.Add(this.txt_MSV);
            this.Controls.Add(this.lblMSSV);
            this.Name = "ThongTinSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.ThongTinSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_MSV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_MSV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_HoTen;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_HoTen;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_NgaySinh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_GioiTinh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_DiaChi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDanhSachSVCuaLopHocPhan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Enter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Exit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btnKhoa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btn_Lop;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SDT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel btn_SDT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_GioiTinh;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtP_NgaySinh;
        private System.Windows.Forms.ComboBox cb_Lop;
    }
}
