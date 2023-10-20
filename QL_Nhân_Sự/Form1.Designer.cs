
namespace QL_Nhân_Sự
{
    partial class Form1
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
            this.cryKP_BC_NV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryKP_BC_NV
            // 
            this.cryKP_BC_NV.ActiveViewIndex = -1;
            this.cryKP_BC_NV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryKP_BC_NV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryKP_BC_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryKP_BC_NV.Location = new System.Drawing.Point(0, 0);
            this.cryKP_BC_NV.Name = "cryKP_BC_NV";
            this.cryKP_BC_NV.Size = new System.Drawing.Size(819, 484);
            this.cryKP_BC_NV.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.cryKP_BC_NV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo thưởng phạt theo nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryKP_BC_NV;
    }
}