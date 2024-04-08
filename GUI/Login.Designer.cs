namespace GUI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenPhanMem = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.txt_UserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_PassWord = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnQuenMK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkshow = new System.Windows.Forms.CheckBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // lbl_TenPhanMem
            // 
            this.lbl_TenPhanMem.AutoSize = true;
            this.lbl_TenPhanMem.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhanMem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_TenPhanMem.Location = new System.Drawing.Point(122, 26);
            this.lbl_TenPhanMem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenPhanMem.Name = "lbl_TenPhanMem";
            this.lbl_TenPhanMem.Size = new System.Drawing.Size(199, 50);
            this.lbl_TenPhanMem.TabIndex = 2;
            this.lbl_TenPhanMem.Text = "PRELUDE";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(40, 116);
            this.lbl_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lbl_TenDangNhap.TabIndex = 3;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.Location = new System.Drawing.Point(39, 140);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(358, 28);
            this.txt_UserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_UserName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txt_UserName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txt_UserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_UserName.StateCommon.Border.Rounding = 10;
            this.txt_UserName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txt_UserName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.TabIndex = 9;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(40, 168);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 20);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PassWord.Location = new System.Drawing.Point(39, 189);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(358, 28);
            this.txt_PassWord.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_PassWord.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txt_PassWord.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.txt_PassWord.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_PassWord.StateCommon.Border.Rounding = 10;
            this.txt_PassWord.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txt_PassWord.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(260, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Size = new System.Drawing.Size(95, 28);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 8;
            this.btnLogin.StateCommon.Border.Width = 2;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.Rounding = 8;
            this.btnLogin.StateTracking.Border.Width = 2;
            this.btnLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 60;
            this.btnLogin.Values.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuenMK.Location = new System.Drawing.Point(70, 309);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnQuenMK.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnQuenMK.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnQuenMK.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.Size = new System.Drawing.Size(113, 28);
            this.btnQuenMK.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnQuenMK.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnQuenMK.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnQuenMK.StateCommon.Border.Rounding = 8;
            this.btnQuenMK.StateCommon.Border.Width = 2;
            this.btnQuenMK.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(150)))));
            this.btnQuenMK.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnQuenMK.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnQuenMK.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnQuenMK.StateTracking.Border.Rounding = 8;
            this.btnQuenMK.StateTracking.Border.Width = 2;
            this.btnQuenMK.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQuenMK.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnQuenMK.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.TabIndex = 61;
            this.btnQuenMK.Values.Text = "Quên mật khẩu?";
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshow.ForeColor = System.Drawing.Color.ForestGreen;
            this.chkshow.Location = new System.Drawing.Point(301, 221);
            this.chkshow.Margin = new System.Windows.Forms.Padding(2);
            this.chkshow.Name = "chkshow";
            this.chkshow.Size = new System.Drawing.Size(109, 19);
            this.chkshow.TabIndex = 62;
            this.chkshow.Text = "Show password";
            this.chkshow.UseVisualStyleBackColor = true;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged_1);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(41, 219);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(47, 13);
            this.lblCheck.TabIndex = 63;
            this.lblCheck.Text = "Warning";
            this.lblCheck.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 357);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.chkshow);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.lbl_TenPhanMem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenPhanMem;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_UserName;
        private System.Windows.Forms.Label lbl_password;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PassWord;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnQuenMK;
        private System.Windows.Forms.CheckBox chkshow;
        private System.Windows.Forms.Label lblCheck;
    }
}