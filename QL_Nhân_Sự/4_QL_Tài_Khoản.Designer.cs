namespace QL_Nhân_Sự
{
    partial class frmQL_TK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_TK));
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Seach = new System.Windows.Forms.ComboBox();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QL_Nhân_Sự.DataSet1();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTai_Khoan = new System.Windows.Forms.DataGridView();
            this.TAI_KHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_KHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nGUOI_DUNGTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.NGUOI_DUNGTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTai_Khoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(439, 25);
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
            this.btnDong.Location = new System.Drawing.Point(509, 69);
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
            this.btnReset.Location = new System.Drawing.Point(414, 69);
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
            this.btnSua.Location = new System.Drawing.Point(312, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa TK";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(215, 69);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa TK";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(116, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 35);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm TK";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(121, 42);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(194, 20);
            this.txtTK.TabIndex = 11;
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
            this.panel2.Location = new System.Drawing.Point(0, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 116);
            this.panel2.TabIndex = 13;
            // 
            // txt_Seach
            // 
            this.txt_Seach.DataSource = this.nGUOIDUNGBindingSource;
            this.txt_Seach.DisplayMember = "TAI_KHOAN";
            this.txt_Seach.FormattingEnabled = true;
            this.txt_Seach.Location = new System.Drawing.Point(150, 26);
            this.txt_Seach.Name = "txt_Seach";
            this.txt_Seach.Size = new System.Drawing.Size(283, 21);
            this.txt_Seach.TabIndex = 52;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOI_DUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(423, 39);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(193, 20);
            this.txtMK.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH MỤC TÀI KHOẢN";
            // 
            // dgvTai_Khoan
            // 
            this.dgvTai_Khoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTai_Khoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTai_Khoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAI_KHOAN,
            this.MAT_KHAU});
            this.dgvTai_Khoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTai_Khoan.Location = new System.Drawing.Point(0, 96);
            this.dgvTai_Khoan.Name = "dgvTai_Khoan";
            this.dgvTai_Khoan.Size = new System.Drawing.Size(668, 262);
            this.dgvTai_Khoan.TabIndex = 14;
            this.dgvTai_Khoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTai_Khoan_CellContentClick);
            this.dgvTai_Khoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTai_Khoan_CellMouseClick);
            // 
            // TAI_KHOAN
            // 
            this.TAI_KHOAN.DataPropertyName = "TAI_KHOAN";
            this.TAI_KHOAN.HeaderText = "Tên tài khoản";
            this.TAI_KHOAN.Name = "TAI_KHOAN";
            // 
            // MAT_KHAU
            // 
            this.MAT_KHAU.DataPropertyName = "MAT_KHAU";
            this.MAT_KHAU.HeaderText = "Mật khẩu";
            this.MAT_KHAU.Name = "MAT_KHAU";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 96);
            this.panel1.TabIndex = 12;
            // 
            // nGUOI_DUNGTableAdapter
            // 
            this.nGUOI_DUNGTableAdapter.ClearBeforeFill = true;
            // 
            // frmQL_TK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTai_Khoan);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmQL_TK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQL_TK_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTai_Khoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTai_Khoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAI_KHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_KHAU;
        private System.Windows.Forms.ComboBox txt_Seach;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private DataSet1TableAdapters.NGUOI_DUNGTableAdapter nGUOI_DUNGTableAdapter;
    }
}