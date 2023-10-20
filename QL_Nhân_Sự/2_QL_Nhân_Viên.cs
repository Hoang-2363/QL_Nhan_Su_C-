using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_Nhân_Sự
{
    public partial class frmQL_NV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHAN_VIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNhanVien.DataSource = table;

        }
        public frmQL_NV()
        {
            InitializeComponent();
        }

        private void frmQL_NV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.dataSet1.NHAN_VIEN);
            // TODO: This line of code loads data into the 'dataSet1.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.dataSet1.LUONG);
            // TODO: This line of code loads data into the 'dataSet1.PHONG_BAN' table. You can move, or remove it, as needed.
            this.pHONG_BANTableAdapter.Fill(this.dataSet1.PHONG_BAN);
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            txtMa_Luong.Text = "";
            txtMa_PB.Text = "";
            txt_Seach.Text = "";
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMa_NV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTen_NV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtNgay_sinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtGioi_Tinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtQue_Quan.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtDan_Toc.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtGmail.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            txtTen_CV.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            txtMa_PB.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
            txtMa_Luong.Text = dgvNhanVien.Rows[i].Cells[10].Value.ToString();
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
            command.CommandText = "insert into NHAN_VIEN values ('" + txtMa_NV.Text + "', N'" + txtTen_NV.Text + "', '" + txtNgay_sinh.Text + "', N'" + txtGioi_Tinh.Text + "', N'" + txtQue_Quan.Text + "', N'" + txtDan_Toc.Text + "', '" + txtGmail.Text + "', '" + txtSDT.Text + "', N'" + txtTen_CV.Text + "', '" + txtMa_PB.Text + "', '" + txtMa_Luong.Text + "')"; 
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHAN_VIEN where MA_NV= '" + txtMa_NV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NHAN_VIEN set HO_TEN_NV=N'" + txtTen_NV.Text + "', NGAY_SINH='" + txtNgay_sinh.Text + "', GIOI_TINH=N'" + txtGioi_Tinh.Text + "', QUE_QUAN=N'" + txtQue_Quan.Text + "', DAN_TOC=N'" + txtDan_Toc.Text + "', GMAIL='" + txtGmail.Text + "', SDT='" + txtSDT.Text + "', TEN_CV=N'" + txtTen_CV.Text + "', MA_PB='" + txtMa_PB.Text + "', MA_LUONG='" + txtMa_Luong.Text + "' where MA_NV= '" + txtMa_NV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " select * from NHAN_VIEN WHERE MA_NV= '" + txt_Seach.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNhanVien.DataSource = table;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTen_NV.Text = "";
            txtMa_NV.Text = "";
            txtDan_Toc.Text = "";
            txtGioi_Tinh.Text = "";
            txtGmail.Text = "";
            txtMa_Luong.Text = "";
            txtMa_PB.Text = "";
            txtNgay_sinh.Text = "";
            txtQue_Quan.Text = "";
            txtSDT.Text = "";
            txtTen_CV.Text = "";
            txt_Seach.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
