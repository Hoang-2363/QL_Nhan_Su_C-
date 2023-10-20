namespace QL_Nhân_Sự
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.mnuTro_Giup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTG_DX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_TLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_TLKT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCL_QL_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuc_Nang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCL_QL_PB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCL_QL_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCL_QL_TK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCL_QL_KP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTro_Giup
            // 
            this.mnuTro_Giup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTG_DX});
            this.mnuTro_Giup.Name = "mnuTro_Giup";
            this.mnuTro_Giup.Size = new System.Drawing.Size(85, 25);
            this.mnuTro_Giup.Text = "Trợ giúp";
            // 
            // mnuTG_DX
            // 
            this.mnuTG_DX.Name = "mnuTG_DX";
            this.mnuTG_DX.Size = new System.Drawing.Size(180, 26);
            this.mnuTG_DX.Text = "Đăng xuất";
            this.mnuTG_DX.Click += new System.EventHandler(this.mnuTG_DX_Click);
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBC_TLNV,
            this.mnuBC_TLKT});
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(82, 25);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuBC_TLNV
            // 
            this.mnuBC_TLNV.Name = "mnuBC_TLNV";
            this.mnuBC_TLNV.Size = new System.Drawing.Size(273, 26);
            this.mnuBC_TLNV.Text = "Tổng lương nhân viên";
            this.mnuBC_TLNV.Click += new System.EventHandler(this.mnuBC_TLNV_Click);
            // 
            // mnuBC_TLKT
            // 
            this.mnuBC_TLKT.Name = "mnuBC_TLKT";
            this.mnuBC_TLKT.Size = new System.Drawing.Size(273, 26);
            this.mnuBC_TLKT.Text = "Tổng lương thưởng, phạt";
            this.mnuBC_TLKT.Click += new System.EventHandler(this.mnuBC_TLKT_Click);
            // 
            // mnuCL_QL_NV
            // 
            this.mnuCL_QL_NV.Name = "mnuCL_QL_NV";
            this.mnuCL_QL_NV.Size = new System.Drawing.Size(243, 26);
            this.mnuCL_QL_NV.Text = "Quản lý nhân viên";
            this.mnuCL_QL_NV.Click += new System.EventHandler(this.mnuCL_QL_NV_Click);
            // 
            // mnuChuc_Nang
            // 
            this.mnuChuc_Nang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCL_QL_NV,
            this.mnuCL_QL_PB,
            this.mnuCL_QL_TL,
            this.mnuCL_QL_TK,
            this.mnuCL_QL_KP});
            this.mnuChuc_Nang.Name = "mnuChuc_Nang";
            this.mnuChuc_Nang.Size = new System.Drawing.Size(104, 25);
            this.mnuChuc_Nang.Text = "Chức năng";
            // 
            // mnuCL_QL_PB
            // 
            this.mnuCL_QL_PB.Name = "mnuCL_QL_PB";
            this.mnuCL_QL_PB.Size = new System.Drawing.Size(243, 26);
            this.mnuCL_QL_PB.Text = "Quản lý phòng ban";
            this.mnuCL_QL_PB.Click += new System.EventHandler(this.mnuCL_QL_PB_Click);
            // 
            // mnuCL_QL_TL
            // 
            this.mnuCL_QL_TL.Name = "mnuCL_QL_TL";
            this.mnuCL_QL_TL.Size = new System.Drawing.Size(243, 26);
            this.mnuCL_QL_TL.Text = "Quản lý tiền lương";
            this.mnuCL_QL_TL.Click += new System.EventHandler(this.mnuCL_QL_TL_Click);
            // 
            // mnuCL_QL_TK
            // 
            this.mnuCL_QL_TK.Name = "mnuCL_QL_TK";
            this.mnuCL_QL_TK.Size = new System.Drawing.Size(243, 26);
            this.mnuCL_QL_TK.Text = "Quản lý tài khoản";
            this.mnuCL_QL_TK.Click += new System.EventHandler(this.mnuCL_QL_TK_Click);
            // 
            // mnuCL_QL_KP
            // 
            this.mnuCL_QL_KP.Name = "mnuCL_QL_KP";
            this.mnuCL_QL_KP.Size = new System.Drawing.Size(243, 26);
            this.mnuCL_QL_KP.Text = "Quản lý thưởng, phạt";
            this.mnuCL_QL_KP.Click += new System.EventHandler(this.mnuCL_QL_KP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChuc_Nang,
            this.mnuBC,
            this.mnuTro_Giup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 398);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuTro_Giup;
        private System.Windows.Forms.ToolStripMenuItem mnuBC;
        private System.Windows.Forms.ToolStripMenuItem mnuCL_QL_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuChuc_Nang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_TLNV;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_TLKT;
        private System.Windows.Forms.ToolStripMenuItem mnuCL_QL_PB;
        private System.Windows.Forms.ToolStripMenuItem mnuTG_DX;
        private System.Windows.Forms.ToolStripMenuItem mnuCL_QL_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuCL_QL_TK;
        private System.Windows.Forms.ToolStripMenuItem mnuCL_QL_KP;
    }
}

