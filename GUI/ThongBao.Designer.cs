namespace GUI
{
    partial class ThongBao
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.dtgvBangThongBao = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThongBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDauTrang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCuoiTrang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTrangTruoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTrangSau = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSoTrang = new System.Windows.Forms.Label();
            this.btnTimKiemTB = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblThongBao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 45);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(637, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblThongBao.Location = new System.Drawing.Point(265, 9);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(364, 31);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "DANH SÁCH THÔNG BÁO";
            // 
            // dtgvBangThongBao
            // 
            this.dtgvBangThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBangThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBangThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaThongBao,
            this.TieuDe,
            this.NgayTao});
            this.dtgvBangThongBao.Location = new System.Drawing.Point(0, 117);
            this.dtgvBangThongBao.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvBangThongBao.Name = "dtgvBangThongBao";
            this.dtgvBangThongBao.RowHeadersWidth = 51;
            this.dtgvBangThongBao.Size = new System.Drawing.Size(983, 573);
            this.dtgvBangThongBao.TabIndex = 43;
            this.dtgvBangThongBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBangThongBao_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 38.48485F;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 59;
            // 
            // MaThongBao
            // 
            this.MaThongBao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaThongBao.DataPropertyName = "MaThongBao";
            this.MaThongBao.Frozen = true;
            this.MaThongBao.HeaderText = "Mã Thông Báo";
            this.MaThongBao.MinimumWidth = 6;
            this.MaThongBao.Name = "MaThongBao";
            this.MaThongBao.Visible = false;
            this.MaThongBao.Width = 125;
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.FillWeight = 272.7273F;
            this.TieuDe.HeaderText = "Tiêu Đề Thông Báo";
            this.TieuDe.MinimumWidth = 6;
            this.TieuDe.Name = "TieuDe";
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày Tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nhập tiêu đề:";
            // 
            // btnDauTrang
            // 
            this.btnDauTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDauTrang.Location = new System.Drawing.Point(345, 698);
            this.btnDauTrang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDauTrang.Name = "btnDauTrang";
            this.btnDauTrang.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnDauTrang.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnDauTrang.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDauTrang.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.Size = new System.Drawing.Size(43, 32);
            this.btnDauTrang.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDauTrang.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnDauTrang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDauTrang.StateCommon.Border.Rounding = 8;
            this.btnDauTrang.StateCommon.Border.Width = 2;
            this.btnDauTrang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnDauTrang.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDauTrang.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDauTrang.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDauTrang.StateTracking.Border.Rounding = 8;
            this.btnDauTrang.StateTracking.Border.Width = 2;
            this.btnDauTrang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDauTrang.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDauTrang.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.TabIndex = 48;
            this.btnDauTrang.Values.Text = "<<";
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);
            // 
            // btnCuoiTrang
            // 
            this.btnCuoiTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuoiTrang.Location = new System.Drawing.Point(571, 698);
            this.btnCuoiTrang.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuoiTrang.Name = "btnCuoiTrang";
            this.btnCuoiTrang.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCuoiTrang.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCuoiTrang.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCuoiTrang.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoiTrang.Size = new System.Drawing.Size(43, 32);
            this.btnCuoiTrang.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCuoiTrang.StateCommon.Border.Rounding = 8;
            this.btnCuoiTrang.StateCommon.Border.Width = 2;
            this.btnCuoiTrang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoiTrang.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnCuoiTrang.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCuoiTrang.StateTracking.Border.Rounding = 8;
            this.btnCuoiTrang.StateTracking.Border.Width = 2;
            this.btnCuoiTrang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCuoiTrang.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoiTrang.TabIndex = 49;
            this.btnCuoiTrang.Values.Text = ">>";
            this.btnCuoiTrang.Click += new System.EventHandler(this.btnCuoiTrang_Click);
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrangTruoc.Location = new System.Drawing.Point(396, 698);
            this.btnTrangTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTrangTruoc.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTrangTruoc.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangTruoc.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangTruoc.Size = new System.Drawing.Size(37, 32);
            this.btnTrangTruoc.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangTruoc.StateCommon.Border.Rounding = 8;
            this.btnTrangTruoc.StateCommon.Border.Width = 2;
            this.btnTrangTruoc.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangTruoc.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangTruoc.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangTruoc.StateTracking.Border.Rounding = 8;
            this.btnTrangTruoc.StateTracking.Border.Width = 2;
            this.btnTrangTruoc.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTrangTruoc.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangTruoc.TabIndex = 50;
            this.btnTrangTruoc.Values.Text = "<";
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTrangTruoc_Click);
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrangSau.Location = new System.Drawing.Point(526, 698);
            this.btnTrangSau.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTrangSau.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTrangSau.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangSau.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangSau.Size = new System.Drawing.Size(37, 32);
            this.btnTrangSau.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTrangSau.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTrangSau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangSau.StateCommon.Border.Rounding = 8;
            this.btnTrangSau.StateCommon.Border.Width = 2;
            this.btnTrangSau.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangSau.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnTrangSau.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnTrangSau.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnTrangSau.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangSau.StateTracking.Border.Rounding = 8;
            this.btnTrangSau.StateTracking.Border.Width = 2;
            this.btnTrangSau.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTrangSau.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTrangSau.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangSau.TabIndex = 51;
            this.btnTrangSau.Values.Text = ">";
            this.btnTrangSau.Click += new System.EventHandler(this.btnTrangSau_Click);
            // 
            // lblSoTrang
            // 
            this.lblSoTrang.AutoSize = true;
            this.lblSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblSoTrang.Location = new System.Drawing.Point(456, 698);
            this.lblSoTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTrang.Name = "lblSoTrang";
            this.lblSoTrang.Size = new System.Drawing.Size(43, 25);
            this.lblSoTrang.TabIndex = 52;
            this.lblSoTrang.Text = "1/n";
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.Location = new System.Drawing.Point(554, 54);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(98, 32);
            this.btnTimKiemTB.TabIndex = 53;
            this.btnTimKiemTB.Text = "Tìm Kiếm";
            this.btnTimKiemTB.UseVisualStyleBackColor = true;
            this.btnTimKiemTB.Click += new System.EventHandler(this.btnTimKiemTB_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(178, 54);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(370, 31);
            this.txtTimKiem.TabIndex = 54;
            // 
            // lblCanhBao
            // 
            this.lblCanhBao.AutoSize = true;
            this.lblCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhBao.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBao.Location = new System.Drawing.Point(175, 97);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Size = new System.Drawing.Size(0, 16);
            this.lblCanhBao.TabIndex = 55;
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 739);
            this.Controls.Add(this.lblCanhBao);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiemTB);
            this.Controls.Add(this.lblSoTrang);
            this.Controls.Add(this.btnTrangSau);
            this.Controls.Add(this.btnTrangTruoc);
            this.Controls.Add(this.btnCuoiTrang);
            this.Controls.Add(this.btnDauTrang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvBangThongBao);
            this.Controls.Add(this.panel1);
            this.Name = "ThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvBangThongBao;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDauTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCuoiTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrangTruoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrangSau;
        private System.Windows.Forms.Label lblSoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.Button btnTimKiemTB;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblCanhBao;
    }
}