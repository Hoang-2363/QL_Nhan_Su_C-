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
    public partial class frmQL_KP : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHEN_PHAT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThuongPhat.DataSource = table;

        }
        public frmQL_KP()
        {
            InitializeComponent();
        }

        private void frmQL_KP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.KHEN_PHAT' table. You can move, or remove it, as needed.
            this.kHEN_PHATTableAdapter.Fill(this.dataSet1.KHEN_PHAT);
            // TODO: This line of code loads data into the 'dataSet1.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.dataSet1.NHAN_VIEN);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            txtMaNV.Text = "";
        }

        private void dgvThuongPhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvThuongPhat.CurrentRow.Index;
            txtMaNV.Text = dgvThuongPhat.Rows[i].Cells[0].Value.ToString();
            txtTienThuong.Text = dgvThuongPhat.Rows[i].Cells[1].Value.ToString();
            txtTienPhat.Text = dgvThuongPhat.Rows[i].Cells[2].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KHEN_PHAT values ('" + txtMaNV.Text + "', '" + txtTienPhat.Text + "', '" + txtTienThuong.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KHEN_PHAT where MA_NV= '" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KHEN_PHAT set T_THUONG='" + txtTienThuong.Text + "', T_PHAT='" + txtTienPhat.Text + "' where MA_NV= '" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTienPhat.Text = "";
            txtTienThuong.Text = "";
            txt_Seach.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " select * from KHEN_PHAT WHERE MA_NV= '" + txt_Seach.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThuongPhat.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
