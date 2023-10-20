namespace QL_Nhân_Sự
{
    partial class frm_Dang_Nhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dang_Nhap));
            this.btnDang_Nhap = new System.Windows.Forms.Button();
            this.chkHien_Pass = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTai_Khoan = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Khau = new System.Windows.Forms.Label();
            this.lblTen_Dang_Nhap = new System.Windows.Forms.Label();
            this.lblTieu_De = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDang_Nhap
            // 
            this.btnDang_Nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDang_Nhap.ForeColor = System.Drawing.Color.Black;
            this.btnDang_Nhap.Location = new System.Drawing.Point(58, 250);
            this.btnDang_Nhap.Name = "btnDang_Nhap";
            this.btnDang_Nhap.Size = new System.Drawing.Size(157, 40);
            this.btnDang_Nhap.TabIndex = 3;
            this.btnDang_Nhap.Text = "Đăng nhập";
            this.btnDang_Nhap.UseVisualStyleBackColor = false;
            this.btnDang_Nhap.Click += new System.EventHandler(this.btnDang_Nhap_Click);
            // 
            // chkHien_Pass
            // 
            this.chkHien_Pass.AutoSize = true;
            this.chkHien_Pass.BackColor = System.Drawing.Color.Transparent;
            this.chkHien_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHien_Pass.Location = new System.Drawing.Point(150, 204);
            this.chkHien_Pass.Name = "chkHien_Pass";
            this.chkHien_Pass.Size = new System.Drawing.Size(139, 19);
            this.chkHien_Pass.TabIndex = 12;
            this.chkHien_Pass.Text = "Hiển thị mật khẩu";
            this.chkHien_Pass.UseVisualStyleBackColor = false;
            this.chkHien_Pass.CheckedChanged += new System.EventHandler(this.chkHien_Pass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(162, 150);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(204, 26);
            this.txtPass.TabIndex = 2;
            // 
            // txtTai_Khoan
            // 
            this.txtTai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTai_Khoan.Location = new System.Drawing.Point(162, 100);
            this.txtTai_Khoan.Name = "txtTai_Khoan";
            this.txtTai_Khoan.Size = new System.Drawing.Size(204, 26);
            this.txtTai_Khoan.TabIndex = 1;
            // 
            // lbl_Mat_Khau
            // 
            this.lbl_Mat_Khau.AutoSize = true;
            this.lbl_Mat_Khau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Khau.Location = new System.Drawing.Point(74, 153);
            this.lbl_Mat_Khau.Name = "lbl_Mat_Khau";
            this.lbl_Mat_Khau.Size = new System.Drawing.Size(83, 20);
            this.lbl_Mat_Khau.TabIndex = 9;
            this.lbl_Mat_Khau.Text = "Mật khẩu";
            // 
            // lblTen_Dang_Nhap
            // 
            this.lblTen_Dang_Nhap.AutoSize = true;
            this.lblTen_Dang_Nhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Dang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Dang_Nhap.Location = new System.Drawing.Point(31, 103);
            this.lblTen_Dang_Nhap.Name = "lblTen_Dang_Nhap";
            this.lblTen_Dang_Nhap.Size = new System.Drawing.Size(129, 20);
            this.lblTen_Dang_Nhap.TabIndex = 8;
            this.lblTen_Dang_Nhap.Text = "Tên đăng nhập";
            // 
            // lblTieu_De
            // 
            this.lblTieu_De.AutoSize = true;
            this.lblTieu_De.BackColor = System.Drawing.Color.Transparent;
            this.lblTieu_De.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieu_De.ForeColor = System.Drawing.Color.Black;
            this.lblTieu_De.Location = new System.Drawing.Point(146, 9);
            this.lblTieu_De.Name = "lblTieu_De";
            this.lblTieu_De.Size = new System.Drawing.Size(129, 49);
            this.lblTieu_De.TabIndex = 7;
            this.lblTieu_De.Text = "Log In";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(256, 250);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 40);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 312);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btnDang_Nhap);
            this.Controls.Add(this.chkHien_Pass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTai_Khoan);
            this.Controls.Add(this.lbl_Mat_Khau);
            this.Controls.Add(this.lblTen_Dang_Nhap);
            this.Controls.Add(this.lblTieu_De);
            this.Name = "frm_Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Dang_Nhap_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDang_Nhap;
        private System.Windows.Forms.CheckBox chkHien_Pass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTai_Khoan;
        private System.Windows.Forms.Label lbl_Mat_Khau;
        private System.Windows.Forms.Label lblTen_Dang_Nhap;
        private System.Windows.Forms.Label lblTieu_De;
        private System.Windows.Forms.Button btn_Thoat;
    }
}