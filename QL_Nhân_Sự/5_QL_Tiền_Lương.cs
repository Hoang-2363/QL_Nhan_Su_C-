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
    public partial class frmQL_TL : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from LUONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvLuong.DataSource = table;
        }
        public frmQL_TL()
        {
            InitializeComponent();
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLuong.CurrentRow.Index;
            txtMaLuong.Text = dgvLuong.Rows[i].Cells[0].Value.ToString();
            txtLuong_CB.Text = dgvLuong.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvLuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvLuong.CurrentRow.Index;
            txtMaLuong.Text = dgvLuong.Rows[i].Cells[0].Value.ToString();
            txtLuong_CB.Text = dgvLuong.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into LUONG values ('" + txtMaLuong.Text + "', '" + txtLuong_CB.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void _5_QL_Tiền_Lương_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.dataSet1.LUONG);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " select * from LUONG WHERE MA_LUONG='" + txt_Seach.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvLuong.DataSource = table;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from LUONG where MA_LUONG= '" + txtMaLuong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update LUONG set LUONG_CB='" + txtLuong_CB.Text + "'where MA_LUONG='" + txtMaLuong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Seach.Text = "";
            txtMaLuong.Text = "";
            txtLuong_CB.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
