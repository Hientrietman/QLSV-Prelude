namespace GUI
{
    partial class XemHocPhi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblXemHocPhi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHienThiTrangThai = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblHienTongHocPhi = new System.Windows.Forms.Label();
            this.lblTongHocPhi = new System.Windows.Forms.Label();
            this.dtgvDanhSachHocPhanSinhVien = new System.Windows.Forms.DataGridView();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblHienThiMaSoSinhVien = new System.Windows.Forms.Label();
            this.lblMaSoSinhVien = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocPhanSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXemHocPhi
            // 
            this.lblXemHocPhi.AutoSize = true;
            this.lblXemHocPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblXemHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblXemHocPhi.Location = new System.Drawing.Point(204, 21);
            this.lblXemHocPhi.Name = "lblXemHocPhi";
            this.lblXemHocPhi.Size = new System.Drawing.Size(452, 33);
            this.lblXemHocPhi.TabIndex = 1;
            this.lblXemHocPhi.Text = "XEM HỌC PHÍ CỦA SINH VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblXemHocPhi);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 79);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHienThiTrangThai);
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.lblHienTongHocPhi);
            this.panel2.Controls.Add(this.lblTongHocPhi);
            this.panel2.Controls.Add(this.dtgvDanhSachHocPhanSinhVien);
            this.panel2.Controls.Add(this.cbNamHoc);
            this.panel2.Controls.Add(this.lblNamHoc);
            this.panel2.Controls.Add(this.cbHocKy);
            this.panel2.Controls.Add(this.lblHocKy);
            this.panel2.Controls.Add(this.lblHienThiMaSoSinhVien);
            this.panel2.Controls.Add(this.lblMaSoSinhVien);
            this.panel2.Location = new System.Drawing.Point(1, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 380);
            this.panel2.TabIndex = 5;
            // 
            // lblHienThiTrangThai
            // 
            this.lblHienThiTrangThai.AutoSize = true;
            this.lblHienThiTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHienThiTrangThai.Location = new System.Drawing.Point(486, 346);
            this.lblHienThiTrangThai.Name = "lblHienThiTrangThai";
            this.lblHienThiTrangThai.Size = new System.Drawing.Size(159, 24);
            this.lblHienThiTrangThai.TabIndex = 33;
            this.lblHienThiTrangThai.Text = "Trạng thái đóng";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblTrangThai.Location = new System.Drawing.Point(370, 346);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(110, 24);
            this.lblTrangThai.TabIndex = 32;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblHienTongHocPhi
            // 
            this.lblHienTongHocPhi.AutoSize = true;
            this.lblHienTongHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienTongHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHienTongHocPhi.Location = new System.Drawing.Point(158, 346);
            this.lblHienTongHocPhi.Name = "lblHienTongHocPhi";
            this.lblHienTongHocPhi.Size = new System.Drawing.Size(122, 24);
            this.lblHienTongHocPhi.TabIndex = 31;
            this.lblHienTongHocPhi.Text = "Hiển thị tiền";
            // 
            // lblTongHocPhi
            // 
            this.lblTongHocPhi.AutoSize = true;
            this.lblTongHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblTongHocPhi.Location = new System.Drawing.Point(11, 346);
            this.lblTongHocPhi.Name = "lblTongHocPhi";
            this.lblTongHocPhi.Size = new System.Drawing.Size(141, 24);
            this.lblTongHocPhi.TabIndex = 30;
            this.lblTongHocPhi.Text = "Tổng học phí:";
            // 
            // dtgvDanhSachHocPhanSinhVien
            // 
            this.dtgvDanhSachHocPhanSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachHocPhanSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhSachHocPhanSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHocPhanSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocPhan,
            this.TenHocPhan,
            this.HocPhi});
            this.dtgvDanhSachHocPhanSinhVien.Location = new System.Drawing.Point(3, 75);
            this.dtgvDanhSachHocPhanSinhVien.Name = "dtgvDanhSachHocPhanSinhVien";
            this.dtgvDanhSachHocPhanSinhVien.Size = new System.Drawing.Size(885, 253);
            this.dtgvDanhSachHocPhanSinhVien.TabIndex = 29;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.HeaderText = "Mã Học Phần";
            this.MaHocPhan.Name = "MaHocPhan";
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.FillWeight = 60F;
            this.TenHocPhan.HeaderText = "Tên Học Phần";
            this.TenHocPhan.Name = "TenHocPhan";
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học Phí";
            this.HocPhi.Name = "HocPhi";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(699, 13);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cbNamHoc.TabIndex = 28;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblNamHoc.Location = new System.Drawing.Point(583, 10);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(100, 24);
            this.lblNamHoc.TabIndex = 27;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(425, 13);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cbHocKy.TabIndex = 26;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHocKy.Location = new System.Drawing.Point(339, 10);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(80, 24);
            this.lblHocKy.TabIndex = 25;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblHienThiMaSoSinhVien
            // 
            this.lblHienThiMaSoSinhVien.AutoSize = true;
            this.lblHienThiMaSoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiMaSoSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblHienThiMaSoSinhVien.Location = new System.Drawing.Point(171, 10);
            this.lblHienThiMaSoSinhVien.Name = "lblHienThiMaSoSinhVien";
            this.lblHienThiMaSoSinhVien.Size = new System.Drawing.Size(138, 24);
            this.lblHienThiMaSoSinhVien.TabIndex = 24;
            this.lblHienThiMaSoSinhVien.Text = "47.01.104.116";
            // 
            // lblMaSoSinhVien
            // 
            this.lblMaSoSinhVien.AutoSize = true;
            this.lblMaSoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSoSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.lblMaSoSinhVien.Location = new System.Drawing.Point(3, 10);
            this.lblMaSoSinhVien.Name = "lblMaSoSinhVien";
            this.lblMaSoSinhVien.Size = new System.Drawing.Size(162, 24);
            this.lblMaSoSinhVien.TabIndex = 23;
            this.lblMaSoSinhVien.Text = "Mã số sinh viên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(743, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // XemHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "XemHocPhi";
            this.Text = "XemHocPhi";
            this.Load += new System.EventHandler(this.XemHocPhi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHocPhanSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblXemHocPhi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMaSoSinhVien;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.DataGridView dtgvDanhSachHocPhanSinhVien;
        private System.Windows.Forms.Label lblHienThiMaSoSinhVien;
        private System.Windows.Forms.Label lblHienThiTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblHienTongHocPhi;
        private System.Windows.Forms.Label lblTongHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
    }
}