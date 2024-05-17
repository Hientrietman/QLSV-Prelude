namespace GUI
{
    partial class XemThongBao
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNguoiTao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(13, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(85, 25);
            this.lblTieuDe.TabIndex = 48;
            this.lblTieuDe.Text = "Tiêu đề";
            // 
            // lblNguoiTao
            // 
            this.lblNguoiTao.AutoSize = true;
            this.lblNguoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiTao.ForeColor = System.Drawing.Color.Gray;
            this.lblNguoiTao.Location = new System.Drawing.Point(392, 47);
            this.lblNguoiTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNguoiTao.Name = "lblNguoiTao";
            this.lblNguoiTao.Size = new System.Drawing.Size(89, 20);
            this.lblNguoiTao.TabIndex = 50;
            this.lblNguoiTao.Text = "Người tạo";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.ForeColor = System.Drawing.Color.Gray;
            this.lblNgayTao.Location = new System.Drawing.Point(13, 47);
            this.lblNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(83, 20);
            this.lblNgayTao.TabIndex = 51;
            this.lblNgayTao.Text = "Ngày tạo";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Enabled = false;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(17, 84);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.Size = new System.Drawing.Size(954, 621);
            this.txtNoiDung.TabIndex = 52;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.lblNoiDung_TextChanged);
            // 
            // XemThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 717);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblNguoiTao);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "XemThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Thông Báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNguoiTao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}