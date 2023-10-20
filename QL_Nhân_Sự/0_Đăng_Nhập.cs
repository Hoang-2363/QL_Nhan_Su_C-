using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_Nhân_Sự
{
    public partial class frm_Dang_Nhap : Form
    {
        public frm_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnDang_Nhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTai_Khoan.Text;
                string mk = txtPass.Text;
                string sql = "SELECT * FROM NGUOI_DUNG WHERE TAI_KHOAN = '"+tk+"' AND MAT_KHAU = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    MessageBox.Show("Chào mừng bạn đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_Menu menu = new frm_Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Text = "";
                    txtTai_Khoan.Text = "";
                    txtTai_Khoan.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkHien_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHien_Pass.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(chon == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_Dang_Nhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDang_Nhap_Click(sender, e);
            }
        }
    }
}
