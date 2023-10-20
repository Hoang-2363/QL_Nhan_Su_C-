namespace QL_Nhân_Sự
{
    partial class frmBC_TP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_TP));
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Tien_Luong = new System.Windows.Forms.DataGridView();
            this.HO_TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_THUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_PHAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgTong_Luong = new System.Windows.Forms.DataGridView();
            this.TEN_PB_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_THUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_PHAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTong_Tien_Thuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTong_Tien_Phat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXuat_BC_NV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_BC_PB = new System.Windows.Forms.Button();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tien_Luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTong_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TỔNG THƯỞNG PHẠT THEO PHÒNG BAN";
            // 
            // dgv_Tien_Luong
            // 
            this.dgv_Tien_Luong.AllowUserToAddRows = false;
            this.dgv_Tien_Luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tien_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tien_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HO_TEN_NV,
            this.TEN_CV,
            this.T_THUONG,
            this.T_PHAT});
            this.dgv_Tien_Luong.Location = new System.Drawing.Point(476, 60);
            this.dgv_Tien_Luong.Name = "dgv_Tien_Luong";
            this.dgv_Tien_Luong.Size = new System.Drawing.Size(408, 132);
            this.dgv_Tien_Luong.TabIndex = 5;
            // 
            // HO_TEN_NV
            // 
            this.HO_TEN_NV.DataPropertyName = "HO_TEN_NV";
            this.HO_TEN_NV.HeaderText = "Họ tên NV";
            this.HO_TEN_NV.Name = "HO_TEN_NV";
            // 
            // TEN_CV
            // 
            this.TEN_CV.DataPropertyName = "TEN_CV";
            this.TEN_CV.HeaderText = "Tên chức vụ";
            this.TEN_CV.Name = "TEN_CV";
            // 
            // T_THUONG
            // 
            this.T_THUONG.DataPropertyName = "T_THUONG";
            this.T_THUONG.HeaderText = "Tiền thưởng";
            this.T_THUONG.Name = "T_THUONG";
            // 
            // T_PHAT
            // 
            this.T_PHAT.DataPropertyName = "T_PHAT";
            this.T_PHAT.HeaderText = "Tiền phạt";
            this.T_PHAT.Name = "T_PHAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÊN NHÂN VIÊN";
            // 
            // dvgTong_Luong
            // 
            this.dvgTong_Luong.AllowUserToAddRows = false;
            this.dvgTong_Luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTong_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTong_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_PB_1,
            this.TONG_THUONG,
            this.TONG_PHAT});
            this.dvgTong_Luong.Location = new System.Drawing.Point(5, 60);
            this.dvgTong_Luong.Name = "dvgTong_Luong";
            this.dvgTong_Luong.Size = new System.Drawing.Size(465, 132);
            this.dvgTong_Luong.TabIndex = 6;
            this.dvgTong_Luong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTong_Luong_CellContentClick);
            this.dvgTong_Luong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgTong_Luong_CellMouseClick);
            // 
            // TEN_PB_1
            // 
            this.TEN_PB_1.DataPropertyName = "TEN_PB";
            this.TEN_PB_1.HeaderText = "Tên phòng ban";
            this.TEN_PB_1.Name = "TEN_PB_1";
            // 
            // TONG_THUONG
            // 
            this.TONG_THUONG.DataPropertyName = "TONG_THUONG";
            this.TONG_THUONG.HeaderText = "Tổng tiền thưởng";
            this.TONG_THUONG.Name = "TONG_THUONG";
            // 
            // TONG_PHAT
            // 
            this.TONG_PHAT.DataPropertyName = "TONG_PHAT";
            this.TONG_PHAT.HeaderText = "Tổng tiền phạt";
            this.TONG_PHAT.Name = "TONG_PHAT";
            // 
            // txtTong_Tien_Thuong
            // 
            this.txtTong_Tien_Thuong.Enabled = false;
            this.txtTong_Tien_Thuong.Location = new System.Drawing.Point(680, 220);
            this.txtTong_Tien_Thuong.Name = "txtTong_Tien_Thuong";
            this.txtTong_Tien_Thuong.Size = new System.Drawing.Size(166, 20);
            this.txtTong_Tien_Thuong.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tổng tiền thưởng";
            // 
            // txtTong_Tien_Phat
            // 
            this.txtTong_Tien_Phat.Enabled = false;
            this.txtTong_Tien_Phat.Location = new System.Drawing.Point(389, 220);
            this.txtTong_Tien_Phat.Name = "txtTong_Tien_Phat";
            this.txtTong_Tien_Phat.Size = new System.Drawing.Size(157, 20);
            this.txtTong_Tien_Phat.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng tiền phạt";
            // 
            // btnXuat_BC_NV
            // 
            this.btnXuat_BC_NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuat_BC_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat_BC_NV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXuat_BC_NV.Location = new System.Drawing.Point(367, 302);
            this.btnXuat_BC_NV.Name = "btnXuat_BC_NV";
            this.btnXuat_BC_NV.Size = new System.Drawing.Size(312, 30);
            this.btnXuat_BC_NV.TabIndex = 27;
            this.btnXuat_BC_NV.Text = "Xuất báo cáo nhân viên";
            this.btnXuat_BC_NV.UseVisualStyleBackColor = false;
            this.btnXuat_BC_NV.Click += new System.EventHandler(this.btnXuat_BC_NV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Thoat.Location = new System.Drawing.Point(695, 302);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 30);
            this.btn_Thoat.TabIndex = 29;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_BC_PB
            // 
            this.btn_BC_PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_BC_PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BC_PB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BC_PB.Location = new System.Drawing.Point(111, 302);
            this.btn_BC_PB.Name = "btn_BC_PB";
            this.btn_BC_PB.Size = new System.Drawing.Size(236, 30);
            this.btn_BC_PB.TabIndex = 30;
            this.btn_BC_PB.Text = "Xuất báo cáo phòng ban";
            this.btn_BC_PB.UseVisualStyleBackColor = false;
            this.btn_BC_PB.Click += new System.EventHandler(this.btn_BC_PB_Click);
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Location = new System.Drawing.Point(111, 221);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(170, 20);
            this.txtTenPB.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(367, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 30);
            this.button2.TabIndex = 35;
            this.button2.Text = "Xuất file Excel nhân viên phòng ban";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(111, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Xuất file Excel phòng ban";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBC_TP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.btn_BC_PB);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btnXuat_BC_NV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTong_Tien_Phat);
            this.Controls.Add(this.dgv_Tien_Luong);
            this.Controls.Add(this.dvgTong_Luong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTong_Tien_Thuong);
            this.Name = "frmBC_TP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thưởng phạt";
            this.Load += new System.EventHandler(this.frmBC_TP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tien_Luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTong_Luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Tien_Luong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgTong_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_PB_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_THUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_PHAT;
        private System.Windows.Forms.TextBox txtTong_Tien_Thuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTong_Tien_Phat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXuat_BC_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO_TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_THUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_PHAT;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_BC_PB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}