
namespace QL_Nhân_Sự
{
    partial class Form3
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
            this.cryKP_BC_PB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryKP_BC_PB
            // 
            this.cryKP_BC_PB.ActiveViewIndex = -1;
            this.cryKP_BC_PB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryKP_BC_PB.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryKP_BC_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryKP_BC_PB.Location = new System.Drawing.Point(0, 0);
            this.cryKP_BC_PB.Name = "cryKP_BC_PB";
            this.cryKP_BC_PB.Size = new System.Drawing.Size(800, 450);
            this.cryKP_BC_PB.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryKP_BC_PB);
            this.Name = "Form3";
            this.Text = "In báo cáo tổng lương nhân viên theo phòng ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryKP_BC_PB;
    }
}