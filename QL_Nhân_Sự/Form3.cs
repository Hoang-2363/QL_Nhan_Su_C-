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
    public partial class Form3 : Form
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CrystalReport3 rpt = new CrystalReport3();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT NHAN_VIEN.HO_TEN_NV, NHAN_VIEN.TEN_CV, LUONG.LUONG_CB FROM LUONG INNER JOIN NHAN_VIEN ON LUONG.MA_LUONG = NHAN_VIEN.MA_LUONG INNER JOIN PHONG_BAN ON NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB WHERE TEN_PB = N'"+_message+"'", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            cryKP_BC_PB.ReportSource = rpt;
        }
    }
}
