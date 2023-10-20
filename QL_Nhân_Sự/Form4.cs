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
    public partial class Form4 : Form
    {
        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CrystalReport4 rpt = new CrystalReport4();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT PHONG_BAN.TEN_PB, SUM(LUONG.LUONG_CB) AS TONG_LUONG FROM   LUONG INNER JOIN NHAN_VIEN ON LUONG.MA_LUONG = NHAN_VIEN.MA_LUONG INNER JOIN PHONG_BAN ON NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB GROUP BY PHONG_BAN.TEN_PB", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            cryKP_BC_PB.ReportSource = rpt;
        }
    }
}
