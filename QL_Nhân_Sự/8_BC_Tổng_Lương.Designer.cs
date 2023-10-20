namespace QL_Nhân_Sự
{
    partial class frmBC_TL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBC_TL));
            this.txtTong_Tien = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_BC_PB = new System.Windows.Forms.Button();
            this.btnXuat_BC_NV = new System.Windows.Forms.Button();
            this.dgv_Tien_Luong = new System.Windows.Forms.DataGridView();
            this.HO_TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG_CB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgTong_Luong = new System.Windows.Forms.DataGridView();
            this.TEN_PB_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_lUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tien_Luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTong_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTong_Tien
            // 
            this.txtTong_Tien.Enabled = false;
            this.txtTong_Tien.Location = new System.Drawing.Point(481, 331);
            this.txtTong_Tien.Name = "txtTong_Tien";
            this.txtTong_Tien.Size = new System.Drawing.Size(193, 20);
            this.txtTong_Tien.TabIndex = 17;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Location = new System.Drawing.Point(181, 331);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(194, 20);
            this.txtTenPB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên phòng ban";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(667, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_BC_PB
            // 
            this.btn_BC_PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_BC_PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BC_PB.Location = new System.Drawing.Point(93, 388);
            this.btn_BC_PB.Name = "btn_BC_PB";
            this.btn_BC_PB.Size = new System.Drawing.Size(236, 31);
            this.btn_BC_PB.TabIndex = 32;
            this.btn_BC_PB.Text = "Xuất báo cáo phòng ban";
            this.btn_BC_PB.UseVisualStyleBackColor = false;
            this.btn_BC_PB.Click += new System.EventHandler(this.btn_BC_PB_Click);
            // 
            // btnXuat_BC_NV
            // 
            this.btnXuat_BC_NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuat_BC_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat_BC_NV.Location = new System.Drawing.Point(349, 388);
            this.btnXuat_BC_NV.Name = "btnXuat_BC_NV";
            this.btnXuat_BC_NV.Size = new System.Drawing.Size(312, 31);
            this.btnXuat_BC_NV.TabIndex = 31;
            this.btnXuat_BC_NV.Text = "Xuất báo cáo nhân viên";
            this.btnXuat_BC_NV.UseVisualStyleBackColor = false;
            this.btnXuat_BC_NV.Click += new System.EventHandler(this.btnXuat_BC_NV_Click);
            // 
            // dgv_Tien_Luong
            // 
            this.dgv_Tien_Luong.AllowUserToAddRows = false;
            this.dgv_Tien_Luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tien_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tien_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HO_TEN_NV,
            this.TEN_CV,
            this.LUONG_CB});
            this.dgv_Tien_Luong.Location = new System.Drawing.Point(411, 61);
            this.dgv_Tien_Luong.Name = "dgv_Tien_Luong";
            this.dgv_Tien_Luong.Size = new System.Drawing.Size(394, 228);
            this.dgv_Tien_Luong.TabIndex = 34;
            this.dgv_Tien_Luong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tien_Luong_CellContentClick);
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
            this.TEN_CV.HeaderText = "Tên phòng ban";
            this.TEN_CV.Name = "TEN_CV";
            // 
            // LUONG_CB
            // 
            this.LUONG_CB.DataPropertyName = "LUONG_CB";
            this.LUONG_CB.HeaderText = "Tiền lương";
            this.LUONG_CB.Name = "LUONG_CB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "TÊN NHÂN VIÊN";
            // 
            // dvgTong_Luong
            // 
            this.dvgTong_Luong.AllowUserToAddRows = false;
            this.dvgTong_Luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTong_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTong_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_PB_1,
            this.TONG_lUONG});
            this.dvgTong_Luong.Location = new System.Drawing.Point(12, 60);
            this.dvgTong_Luong.Name = "dvgTong_Luong";
            this.dvgTong_Luong.Size = new System.Drawing.Size(394, 229);
            this.dvgTong_Luong.TabIndex = 36;
            this.dvgTong_Luong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTong_Luong_CellContentClick);
            this.dvgTong_Luong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgTong_Luong_CellMouseClick);
            // 
            // TEN_PB_1
            // 
            this.TEN_PB_1.DataPropertyName = "TEN_PB";
            this.TEN_PB_1.HeaderText = "Tên phòng ban";
            this.TEN_PB_1.Name = "TEN_PB_1";
            // 
            // TONG_lUONG
            // 
            this.TONG_lUONG.DataPropertyName = "TONG_LUONG";
            this.TONG_lUONG.HeaderText = "Tổng lương";
            this.TONG_lUONG.Name = "TONG_lUONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "TỔNG LƯƠNG THEO PHÒNG BAN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(349, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "Xuất file Excel nhân viên phòng ban";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(93, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Xuất file Excel phòng ban";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBC_TL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvgTong_Luong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Tien_Luong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BC_PB);
            this.Controls.Add(this.btnXuat_BC_NV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTong_Tien);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "frmBC_TL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng lương";
            this.Load += new System.EventHandler(this.frmBC_TL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tien_Luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTong_Luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTong_Tien;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_BC_PB;
        private System.Windows.Forms.Button btnXuat_BC_NV;
        private System.Windows.Forms.DataGridView dgv_Tien_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO_TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgTong_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_PB_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_lUONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}