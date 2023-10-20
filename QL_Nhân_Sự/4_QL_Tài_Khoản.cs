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
    public partial class frmQL_TK : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NGUOI_DUNG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTai_Khoan.DataSource = table;
        }
        public frmQL_TK()
        {
            InitializeComponent();
        }

        private void dgvTai_Khoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTai_Khoan.CurrentRow.Index;
            txtTK.Text = dgvTai_Khoan.Rows[i].Cells[0].Value.ToString();
            txtMK.Text = dgvTai_Khoan.Rows[i].Cells[1].Value.ToString();
        }

        private void frmQL_TK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.nGUOI_DUNGTableAdapter.Fill(this.dataSet1.NGUOI_DUNG);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " select * from NGUOI_DUNG WHERE TAI_KHOAN='" + txt_Seach.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTai_Khoan.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" && txtMK.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTK.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMK.Text =="")
            {
                MessageBox.Show("Hãy nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into NGUOI_DUNG values ('" + txtTK.Text + "', '" + txtMK.Text + "')";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NGUOI_DUNG where TAI_KHOAN= '" + txtTK.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NGUOI_DUNG set MAT_KHAU='" + txtMK.Text + "'where TAI_KHOAN='" + txtTK.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Seach.Text = "";
            txtTK.Text = "";
            txtMK.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvTai_Khoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvTai_Khoan.CurrentRow.Index;
            txtTK.Text = dgvTai_Khoan.Rows[i].Cells[0].Value.ToString();
            txtMK.Text = dgvTai_Khoan.Rows[i].Cells[1].Value.ToString();
        }
    }
}
