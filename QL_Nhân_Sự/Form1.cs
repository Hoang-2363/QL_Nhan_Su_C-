using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nhân_Sự
{
    public partial class Form1 : Form
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT NHAN_VIEN.HO_TEN_NV, NHAN_VIEN.TEN_CV, KHEN_PHAT.T_THUONG, KHEN_PHAT.T_PHAT FROM   KHEN_PHAT INNER JOIN NHAN_VIEN ON KHEN_PHAT.MA_NV = NHAN_VIEN.MA_NV INNER JOIN PHONG_BAN ON NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB WHERE TEN_PB = N'"+ _message+ "'", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            cryKP_BC_NV.ReportSource = rpt;
        }

    }
}
