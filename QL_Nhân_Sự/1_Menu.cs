using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nhân_Sự
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuTG_DX_Click(object sender, EventArgs e)
        {
            frm_Dang_Nhap dangnhap = new frm_Dang_Nhap();
            this.Hide();
            dangnhap.ShowDialog();
        }

        private void mnuBC_TLNV_Click(object sender, EventArgs e)
        {
            frmBC_TL QL_NV = new frmBC_TL();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuBC_TLKT_Click(object sender, EventArgs e)
        {
            frmBC_TP QL_NV = new frmBC_TP();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuCL_QL_NV_Click(object sender, EventArgs e)
        {
            frmQL_NV QL_NV = new frmQL_NV();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuCL_QL_PB_Click(object sender, EventArgs e)
        {
            frmQL_PB QL_NV = new frmQL_PB();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuCL_QL_TL_Click(object sender, EventArgs e)
        {
            frmQL_TL QL_NV = new frmQL_TL();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuCL_QL_TK_Click(object sender, EventArgs e)
        {
            frmQL_TK QL_NV = new frmQL_TK();
            this.Hide();
            QL_NV.ShowDialog();
        }

        private void mnuCL_QL_KP_Click(object sender, EventArgs e)
        {
            frmQL_KP QL_NV = new frmQL_KP();
            this.Hide();
            QL_NV.ShowDialog();
        }
    }
}
