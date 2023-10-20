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
    public partial class frmQL_PB : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHONG_BAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPhong_Ban.DataSource = table;

        }
        public frmQL_PB()
        {
            InitializeComponent();
        }

        private void frmQL_PB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PHONG_BAN' table. You can move, or remove it, as needed.
            this.pHONG_BANTableAdapter.Fill(this.dataSet1.PHONG_BAN);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvPhong_Ban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhong_Ban.CurrentRow.Index;
            txtMaPB.Text = dgvPhong_Ban.Rows[i].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPhong_Ban.Rows[i].Cells[1].Value.ToString();
            txtDia_Chi.Text = dgvPhong_Ban.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvPhong_Ban.Rows[i].Cells[3].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Seach.Text = "";
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtDia_Chi.Text = "";
            txtSDT.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into PHONG_BAN values ('" + txtMaPB.Text + "', N'" + txtTenPB.Text + "', N'" + txtDia_Chi.Text + "', '" + txtSDT.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from PHONG_BAN where MA_PB= '" + txtMaPB.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PHONG_BAN set TEN_PB=N'" + txtTenPB.Text + "', DIA_CHI=N'" + txtDia_Chi.Text + "', SDT='" + txtSDT.Text + "' where MA_PB='" + txtMaPB.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " select * from PHONG_BAN WHERE MA_PB='" + txt_Seach.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPhong_Ban.DataSource = table;
        }

        private void dgvPhong_Ban_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvPhong_Ban.CurrentRow.Index;
            txtMaPB.Text = dgvPhong_Ban.Rows[i].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPhong_Ban.Rows[i].Cells[1].Value.ToString();
            txtDia_Chi.Text = dgvPhong_Ban.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvPhong_Ban.Rows[i].Cells[3].Value.ToString();
        }
    }
}
