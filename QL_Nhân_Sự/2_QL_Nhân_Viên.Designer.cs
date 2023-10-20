namespace QL_Nhân_Sự
{
    partial class frmQL_NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_NV));
            this.txtTen_NV = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO_TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_SINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOI_TINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUE_QUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAN_TOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_PB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMa_NV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Seach = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QL_Nhân_Sự.DataSet1();
            this.txtMa_Luong = new System.Windows.Forms.ComboBox();
            this.lUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMa_PB = new System.Windows.Forms.ComboBox();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGioi_Tinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTen_CV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDan_Toc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQue_Quan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgay_sinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pHONG_BANTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.PHONG_BANTableAdapter();
            this.lUONGTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.LUONGTableAdapter();
            this.nHAN_VIENTableAdapter = new QL_Nhân_Sự.DataSet1TableAdapters.NHAN_VIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen_NV
            // 
            this.txtTen_NV.Location = new System.Drawing.Point(163, 68);
            this.txtTen_NV.Name = "txtTen_NV";
            this.txtTen_NV.Size = new System.Drawing.Size(194, 20);
            this.txtTen_NV.TabIndex = 12;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NV,
            this.HO_TEN_NV,
            this.NGAY_SINH,
            this.GIOI_TINH,
            this.QUE_QUAN,
            this.DAN_TOC,
            this.GMAIL,
            this.SDT,
            this.TEN_CV,
            this.MA_PB,
            this.MA_LUONG});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 252);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(806, 194);
            this.dgvNhanVien.TabIndex = 8;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // MA_NV
            // 
            this.MA_NV.DataPropertyName = "MA_NV";
            this.MA_NV.HeaderText = "Mã nhân viên";
            this.MA_NV.Name = "MA_NV";
            // 
            // HO_TEN_NV
            // 
            this.HO_TEN_NV.DataPropertyName = "HO_TEN_NV";
            this.HO_TEN_NV.HeaderText = "Họ tên nhân viên";
            this.HO_TEN_NV.Name = "HO_TEN_NV";
            // 
            // NGAY_SINH
            // 
            this.NGAY_SINH.DataPropertyName = "NGAY_SINH";
            this.NGAY_SINH.HeaderText = "Ngày sinh";
            this.NGAY_SINH.Name = "NGAY_SINH";
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.DataPropertyName = "GIOI_TINH";
            this.GIOI_TINH.HeaderText = "Giới tính";
            this.GIOI_TINH.Name = "GIOI_TINH";
            // 
            // QUE_QUAN
            // 
            this.QUE_QUAN.DataPropertyName = "QUE_QUAN";
            this.QUE_QUAN.HeaderText = "Quê quán";
            this.QUE_QUAN.Name = "QUE_QUAN";
            // 
            // DAN_TOC
            // 
            this.DAN_TOC.DataPropertyName = "DAN_TOC";
            this.DAN_TOC.HeaderText = "Dân tộc";
            this.DAN_TOC.Name = "DAN_TOC";
            // 
            // GMAIL
            // 
            this.GMAIL.DataPropertyName = "GMAIL";
            this.GMAIL.HeaderText = "Gmail";
            this.GMAIL.Name = "GMAIL";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // TEN_CV
            // 
            this.TEN_CV.DataPropertyName = "TEN_CV";
            this.TEN_CV.HeaderText = "Tên công việc";
            this.TEN_CV.Name = "TEN_CV";
            // 
            // MA_PB
            // 
            this.MA_PB.DataPropertyName = "MA_PB";
            this.MA_PB.HeaderText = "Mã phòng ban";
            this.MA_PB.Name = "MA_PB";
            // 
            // MA_LUONG
            // 
            this.MA_LUONG.DataPropertyName = "MA_LUONG";
            this.MA_LUONG.HeaderText = "Mã lương";
            this.MA_LUONG.Name = "MA_LUONG";
            // 
            // txtMa_NV
            // 
            this.txtMa_NV.Location = new System.Drawing.Point(163, 42);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(194, 20);
            this.txtMa_NV.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 54);
            this.panel2.TabIndex = 7;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(537, 16);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(442, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(346, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa NV";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(254, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa NV";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(151, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm NV";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(513, 46);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(193, 20);
            this.txtGmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 46);
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
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_Seach);
            this.panel1.Controls.Add(this.txtMa_Luong);
            this.panel1.Controls.Add(this.txtMa_PB);
            this.panel1.Controls.Add(this.txtGioi_Tinh);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSeach);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtTen_CV);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDan_Toc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQue_Quan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNgay_sinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtGmail);
            this.panel1.Controls.Add(this.txtTen_NV);
            this.panel1.Controls.Add(this.txtMa_NV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 252);
            this.panel1.TabIndex = 6;
            // 
            // txt_Seach
            // 
            this.txt_Seach.DataSource = this.nHANVIENBindingSource;
            this.txt_Seach.DisplayMember = "MA_NV";
            this.txt_Seach.FormattingEnabled = true;
            this.txt_Seach.Location = new System.Drawing.Point(200, 214);
            this.txt_Seach.Name = "txt_Seach";
            this.txt_Seach.Size = new System.Drawing.Size(270, 21);
            this.txt_Seach.TabIndex = 50;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHAN_VIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMa_Luong
            // 
            this.txtMa_Luong.DataSource = this.lUONGBindingSource;
            this.txtMa_Luong.DisplayMember = "MA_LUONG";
            this.txtMa_Luong.FormattingEnabled = true;
            this.txtMa_Luong.Location = new System.Drawing.Point(517, 177);
            this.txtMa_Luong.Name = "txtMa_Luong";
            this.txtMa_Luong.Size = new System.Drawing.Size(193, 21);
            this.txtMa_Luong.TabIndex = 49;
            // 
            // lUONGBindingSource
            // 
            this.lUONGBindingSource.DataMember = "LUONG";
            this.lUONGBindingSource.DataSource = this.dataSet1;
            // 
            // txtMa_PB
            // 
            this.txtMa_PB.DataSource = this.pHONGBANBindingSource;
            this.txtMa_PB.DisplayMember = "MA_PB";
            this.txtMa_PB.FormattingEnabled = true;
            this.txtMa_PB.Location = new System.Drawing.Point(516, 146);
            this.txtMa_PB.Name = "txtMa_PB";
            this.txtMa_PB.Size = new System.Drawing.Size(193, 21);
            this.txtMa_PB.TabIndex = 48;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONG_BAN";
            this.pHONGBANBindingSource.DataSource = this.dataSet1;
            // 
            // txtGioi_Tinh
            // 
            this.txtGioi_Tinh.Location = new System.Drawing.Point(164, 120);
            this.txtGioi_Tinh.Name = "txtGioi_Tinh";
            this.txtGioi_Tinh.Size = new System.Drawing.Size(194, 20);
            this.txtGioi_Tinh.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(446, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Mã lương";
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(476, 214);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(116, 22);
            this.btnSeach.TabIndex = 18;
            this.btnSeach.Text = "Tìm kiếm";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(417, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Mã phòng ban";
            // 
            // txtTen_CV
            // 
            this.txtTen_CV.Location = new System.Drawing.Point(515, 116);
            this.txtTen_CV.Name = "txtTen_CV";
            this.txtTen_CV.Size = new System.Drawing.Size(194, 20);
            this.txtTen_CV.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Tên chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dân tộc";
            // 
            // txtDan_Toc
            // 
            this.txtDan_Toc.Location = new System.Drawing.Point(164, 177);
            this.txtDan_Toc.Name = "txtDan_Toc";
            this.txtDan_Toc.Size = new System.Drawing.Size(193, 20);
            this.txtDan_Toc.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(515, 81);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 20);
            this.txtSDT.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gmail";
            // 
            // txtQue_Quan
            // 
            this.txtQue_Quan.Location = new System.Drawing.Point(163, 149);
            this.txtQue_Quan.Name = "txtQue_Quan";
            this.txtQue_Quan.Size = new System.Drawing.Size(194, 20);
            this.txtQue_Quan.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quê quán";
            // 
            // txtNgay_sinh
            // 
            this.txtNgay_sinh.Location = new System.Drawing.Point(164, 93);
            this.txtNgay_sinh.Name = "txtNgay_sinh";
            this.txtNgay_sinh.Size = new System.Drawing.Size(194, 20);
            this.txtNgay_sinh.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày sinh";
            // 
            // pHONG_BANTableAdapter
            // 
            this.pHONG_BANTableAdapter.ClearBeforeFill = true;
            // 
            // lUONGTableAdapter
            // 
            this.lUONGTableAdapter.ClearBeforeFill = true;
            // 
            // nHAN_VIENTableAdapter
            // 
            this.nHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmQL_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQL_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQL_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen_NV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMa_NV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQue_Quan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNgay_sinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTen_CV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDan_Toc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO_TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_SINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOI_TINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUE_QUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAN_TOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_LUONG;
        private System.Windows.Forms.ComboBox txtMa_PB;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private DataSet1TableAdapters.PHONG_BANTableAdapter pHONG_BANTableAdapter;
        private System.Windows.Forms.ComboBox txtMa_Luong;
        private System.Windows.Forms.BindingSource lUONGBindingSource;
        private DataSet1TableAdapters.LUONGTableAdapter lUONGTableAdapter;
        private System.Windows.Forms.ComboBox txt_Seach;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet1TableAdapters.NHAN_VIENTableAdapter nHAN_VIENTableAdapter;
    }
}