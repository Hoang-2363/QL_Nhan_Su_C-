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
    public partial class Form2 : Form
    {
        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CrystalReport2 rpt = new CrystalReport2();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT PHONG_BAN.TEN_PB, SUM(KHEN_PHAT.T_THUONG) AS TONG_THUONG, SUM(KHEN_PHAT.T_PHAT) AS TONG_PHAT FROM   KHEN_PHAT INNER JOIN NHAN_VIEN ON KHEN_PHAT.MA_NV = NHAN_VIEN.MA_NV INNER JOIN PHONG_BAN ON NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB GROUP BY TEN_PB", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            cryKP_BC_PB.ReportSource = rpt;
        }
    }
}
