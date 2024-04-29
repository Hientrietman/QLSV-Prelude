namespace GUI
{
    partial class QuanLyHocPhan
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
            this.dtgv_hocphan = new System.Windows.Forms.DataGridView();
            this.txt_mahp = new System.Windows.Forms.TextBox();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.txt_tenhp = new System.Windows.Forms.TextBox();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.txt_tinchi = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_mahp = new System.Windows.Forms.Label();
            this.lbl_mamh = new System.Windows.Forms.Label();
            this.lbl_tenmh = new System.Windows.Forms.Label();
            this.lbl_magv = new System.Windows.Forms.Label();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thongtin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ngaybatdau = new System.Windows.Forms.TextBox();
            this.txt_ngayketthuc = new System.Windows.Forms.TextBox();
            this.lbl_Emamh = new System.Windows.Forms.Label();
            this.lbl_Emagv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hocphan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_hocphan
            // 
            this.dtgv_hocphan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hocphan.Location = new System.Drawing.Point(3, 12);
            this.dtgv_hocphan.Name = "dtgv_hocphan";
            this.dtgv_hocphan.RowHeadersWidth = 51;
            this.dtgv_hocphan.Size = new System.Drawing.Size(458, 504);
            this.dtgv_hocphan.TabIndex = 99;
            this.dtgv_hocphan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hocphan_CellClick);
            // 
            // txt_mahp
            // 
            this.txt_mahp.Location = new System.Drawing.Point(480, 57);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.Size = new System.Drawing.Size(147, 20);
            this.txt_mahp.TabIndex = 1;
            this.txt_mahp.TextChanged += new System.EventHandler(this.txt_mahp_TextChanged);
            // 
            // txt_mamh
            // 
            this.txt_mamh.Location = new System.Drawing.Point(713, 57);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(146, 20);
            this.txt_mamh.TabIndex = 2;
            this.txt_mamh.TextChanged += new System.EventHandler(this.txt_mamh_TextChanged);
            // 
            // txt_tenhp
            // 
            this.txt_tenhp.Enabled = false;
            this.txt_tenhp.Location = new System.Drawing.Point(480, 126);
            this.txt_tenhp.Name = "txt_tenhp";
            this.txt_tenhp.Size = new System.Drawing.Size(147, 20);
            this.txt_tenhp.TabIndex = 3;
            // 
            // txt_magv
            // 
            this.txt_magv.Location = new System.Drawing.Point(712, 126);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(147, 20);
            this.txt_magv.TabIndex = 4;
            this.txt_magv.Leave += new System.EventHandler(this.txt_magv_Leave);
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(484, 188);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(147, 20);
            this.txt_nam.TabIndex = 5;
            // 
            // txt_tinchi
            // 
            this.txt_tinchi.Enabled = false;
            this.txt_tinchi.Location = new System.Drawing.Point(715, 188);
            this.txt_tinchi.Name = "txt_tinchi";
            this.txt_tinchi.Size = new System.Drawing.Size(147, 20);
            this.txt_tinchi.TabIndex = 6;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(479, 479);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(593, 479);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(712, 479);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_mahp
            // 
            this.lbl_mahp.AutoSize = true;
            this.lbl_mahp.Location = new System.Drawing.Point(480, 38);
            this.lbl_mahp.Name = "lbl_mahp";
            this.lbl_mahp.Size = new System.Drawing.Size(70, 13);
            this.lbl_mahp.TabIndex = 15;
            this.lbl_mahp.Text = "Mã học phần";
            // 
            // lbl_mamh
            // 
            this.lbl_mamh.AutoSize = true;
            this.lbl_mamh.Location = new System.Drawing.Point(709, 38);
            this.lbl_mamh.Name = "lbl_mamh";
            this.lbl_mamh.Size = new System.Drawing.Size(66, 13);
            this.lbl_mamh.TabIndex = 16;
            this.lbl_mamh.Text = "Mã môn học";
            // 
            // lbl_tenmh
            // 
            this.lbl_tenmh.AutoSize = true;
            this.lbl_tenmh.Location = new System.Drawing.Point(480, 110);
            this.lbl_tenmh.Name = "lbl_tenmh";
            this.lbl_tenmh.Size = new System.Drawing.Size(74, 13);
            this.lbl_tenmh.TabIndex = 17;
            this.lbl_tenmh.Text = "Tên học phần";
            // 
            // lbl_magv
            // 
            this.lbl_magv.AutoSize = true;
            this.lbl_magv.Location = new System.Drawing.Point(708, 110);
            this.lbl_magv.Name = "lbl_magv";
            this.lbl_magv.Size = new System.Drawing.Size(74, 13);
            this.lbl_magv.TabIndex = 18;
            this.lbl_magv.Text = "Mã giảng viên";
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Location = new System.Drawing.Point(481, 172);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(29, 13);
            this.lbl_nam.TabIndex = 19;
            this.lbl_nam.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tín chỉ";
            // 
            // txt_thongtin
            // 
            this.txt_thongtin.Location = new System.Drawing.Point(484, 255);
            this.txt_thongtin.Name = "txt_thongtin";
            this.txt_thongtin.Size = new System.Drawing.Size(305, 20);
            this.txt_thongtin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thông tin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày kết thúc";
            // 
            // txt_ngaybatdau
            // 
            this.txt_ngaybatdau.Location = new System.Drawing.Point(484, 333);
            this.txt_ngaybatdau.Name = "txt_ngaybatdau";
            this.txt_ngaybatdau.Size = new System.Drawing.Size(195, 20);
            this.txt_ngaybatdau.TabIndex = 8;
            this.txt_ngaybatdau.Leave += new System.EventHandler(this.txt_ngaybatdau_Leave);
            // 
            // txt_ngayketthuc
            // 
            this.txt_ngayketthuc.Location = new System.Drawing.Point(485, 417);
            this.txt_ngayketthuc.Name = "txt_ngayketthuc";
            this.txt_ngayketthuc.Size = new System.Drawing.Size(195, 20);
            this.txt_ngayketthuc.TabIndex = 9;
            this.txt_ngayketthuc.Leave += new System.EventHandler(this.txt_ngayketthuc_Leave);
            // 
            // lbl_Emamh
            // 
            this.lbl_Emamh.AutoSize = true;
            this.lbl_Emamh.Location = new System.Drawing.Point(715, 84);
            this.lbl_Emamh.Name = "lbl_Emamh";
            this.lbl_Emamh.Size = new System.Drawing.Size(0, 13);
            this.lbl_Emamh.TabIndex = 27;
            // 
            // lbl_Emagv
            // 
            this.lbl_Emagv.AutoSize = true;
            this.lbl_Emagv.Location = new System.Drawing.Point(711, 153);
            this.lbl_Emagv.Name = "lbl_Emagv";
            this.lbl_Emagv.Size = new System.Drawing.Size(0, 13);
            this.lbl_Emagv.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 32;
            // 
            // QuanLyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 528);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Emagv);
            this.Controls.Add(this.lbl_Emamh);
            this.Controls.Add(this.txt_ngayketthuc);
            this.Controls.Add(this.txt_ngaybatdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_thongtin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_nam);
            this.Controls.Add(this.lbl_magv);
            this.Controls.Add(this.lbl_tenmh);
            this.Controls.Add(this.lbl_mamh);
            this.Controls.Add(this.lbl_mahp);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tinchi);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.txt_tenhp);
            this.Controls.Add(this.txt_mamh);
            this.Controls.Add(this.txt_mahp);
            this.Controls.Add(this.dtgv_hocphan);
            this.Name = "QuanLyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hocphan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_hocphan;
        private System.Windows.Forms.TextBox txt_mahp;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.TextBox txt_tenhp;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_tinchi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_mahp;
        private System.Windows.Forms.Label lbl_mamh;
        private System.Windows.Forms.Label lbl_tenmh;
        private System.Windows.Forms.Label lbl_magv;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_thongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ngaybatdau;
        private System.Windows.Forms.TextBox txt_ngayketthuc;
        private System.Windows.Forms.Label lbl_Emamh;
        private System.Windows.Forms.Label lbl_Emagv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}