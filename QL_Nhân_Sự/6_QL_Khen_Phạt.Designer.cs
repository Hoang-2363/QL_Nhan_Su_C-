namespace QL_Nhân_Sự
{
    partial class frmQL_KP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_KP));
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.dgvThuongPhat = new System.Windows.Forms.DataGridView();
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Seach = new System.Windows.Forms.ComboBox();
            this.kHENPHATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QL_Nhân_Sự.DataSet1();
            this.btnXoa = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.nHAN_VIENTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.NHAN_VIENTableAdapter();
            this.kHEN_PHATTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.KHEN_PHATTableAdapter();
            this.T_PHAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_THUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHENPHATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Location = new System.Drawing.Point(330, 45);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(173, 20);
            this.txtTienThuong.TabIndex = 12;
            // 
            // dgvThuongPhat
            // 
            this.dgvThuongPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuongPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NV,
            this.T_THUONG,
            this.T_PHAT});
            this.dgvThuongPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuongPhat.Location = new System.Drawing.Point(0, 87);
            this.dgvThuongPhat.Name = "dgvThuongPhat";
            this.dgvThuongPhat.Size = new System.Drawing.Size(774, 270);
            this.dgvThuongPhat.TabIndex = 14;
            this.dgvThuongPhat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvThuongPhat_CellMouseClick);
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(478, 18);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(116, 22);
            this.btnSeach.TabIndex = 41;
            this.btnSeach.Text = "Tìm kiếm";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(540, 52);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(445, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(343, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(147, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 35);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txt_Seach);
            this.panel2.Controls.Add(this.btnSeach);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 96);
            this.panel2.TabIndex = 13;
            // 
            // txt_Seach
            // 
            this.txt_Seach.DataSource = this.kHENPHATBindingSource;
            this.txt_Seach.DisplayMember = "MA_NV";
            this.txt_Seach.FormattingEnabled = true;
            this.txt_Seach.Location = new System.Drawing.Point(191, 19);
            this.txt_Seach.Name = "txt_Seach";
            this.txt_Seach.Size = new System.Drawing.Size(283, 21);
            this.txt_Seach.TabIndex = 52;
            // 
            // kHENPHATBindingSource
            // 
            this.kHENPHATBindingSource.DataMember = "KHEN_PHAT";
            this.kHENPHATBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(246, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHAN_VIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(582, 45);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(146, 20);
            this.txtTienPhat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền phạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiền thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH MỤC THƯỞNG PHẠT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtTienPhat);
            this.panel1.Controls.Add(this.txtTienThuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 87);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataSource = this.nHANVIENBindingSource;
            this.txtMaNV.DisplayMember = "MA_NV";
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(107, 44);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(133, 21);
            this.txtMaNV.TabIndex = 53;
            // 
            // nHAN_VIENTableAdapter
            // 
            this.nHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHEN_PHATTableAdapter
            // 
            this.kHEN_PHATTableAdapter.ClearBeforeFill = true;
            // 
            // T_PHAT
            // 
            this.T_PHAT.DataPropertyName = "T_PHAT";
            this.T_PHAT.HeaderText = "Tiền phạt";
            this.T_PHAT.Name = "T_PHAT";
            // 
            // T_THUONG
            // 
            this.T_THUONG.DataPropertyName = "T_THUONG";
            this.T_THUONG.HeaderText = "Tiền thưởng";
            this.T_THUONG.Name = "T_THUONG";
            // 
            // MA_NV
            // 
            this.MA_NV.DataPropertyName = "MA_NV";
            this.MA_NV.HeaderText = "Mã nhân viên";
            this.MA_NV.Name = "MA_NV";
            // 
            // frmQL_KP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 453);
            this.Controls.Add(this.dgvThuongPhat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQL_KP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khen phạt";
            this.Load += new System.EventHandler(this.frmQL_KP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHENPHATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTienThuong;
        private System.Windows.Forms.DataGridView dgvThuongPhat;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txt_Seach;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet1TableAdapters.NHAN_VIENTableAdapter nHAN_VIENTableAdapter;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.BindingSource kHENPHATBindingSource;
        private DataSet1TableAdapters.KHEN_PHATTableAdapter kHEN_PHATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_THUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_PHAT;
    }
}