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
    public partial class frmBC_TP : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        SqlConnection connection1;
        SqlCommand command1;
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_NHAN_SU;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT HO_TEN_NV, TEN_CV, T_THUONG, T_PHAT FROM NHAN_VIEN, KHEN_PHAT, PHONG_BAN WHERE KHEN_PHAT.MA_NV = NHAN_VIEN.MA_NV AND NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB AND TEN_PB = N'" + txtTenPB.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_Tien_Luong.DataSource = table;
        }

        void loadData1()
        {
            command1 = connection1.CreateCommand();
            command1.CommandText = "SELECT TEN_PB, SUM(T_THUONG) AS TONG_THUONG, SUM(T_PHAT) AS TONG_PHAT FROM NHAN_VIEN, KHEN_PHAT, PHONG_BAN WHERE KHEN_PHAT.MA_NV = NHAN_VIEN.MA_NV AND NHAN_VIEN.MA_PB = PHONG_BAN.MA_PB GROUP BY TEN_PB";
            adapter1.SelectCommand = command1;
            table1.Clear();
            adapter1.Fill(table1);
            dvgTong_Luong.DataSource = table1;
        }
        public frmBC_TP()
        {
            InitializeComponent();
        }

        private void frmBC_TP_Load(object sender, EventArgs e)
        {
            connection1 = new SqlConnection(str);
            connection1.Open();
            loadData1();
        }

        private void dvgTong_Luong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dvgTong_Luong.CurrentRow.Index;
            txtTenPB.Text = dvgTong_Luong.Rows[i].Cells[0].Value.ToString();
            txtTong_Tien_Thuong.Text = dvgTong_Luong.Rows[i].Cells[1].Value.ToString();
            txtTong_Tien_Phat.Text = dvgTong_Luong.Rows[i].Cells[2].Value.ToString();

            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnXuat_BC_NV_Click(object sender, EventArgs e)
        {
            Form1 bc = new Form1(); 
            bc.Message = txtTenPB.Text;
            bc.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btn_BC_PB_Click(object sender, EventArgs e)
        {
            Form2 bc = new Form2();
            bc.Show();
        }

        private void dvgTong_Luong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Export(DataTable dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //Tạo logo
            Microsoft.Office.Interop.Excel.Range lg1 = oSheet.get_Range("A1", "A1");
            lg1.Value2 = "Kế toán Huy Hoàng";
            Microsoft.Office.Interop.Excel.Range lg2 = oSheet.get_Range("C1", "C1");
            lg2.Value2 = "Mẫu số 01a - LDTL";
            Microsoft.Office.Interop.Excel.Range logo1 = oSheet.get_Range("A1", "C1");
            logo1.Font.Bold = true;
            logo1.Font.Color = Color.Blue;
            logo1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range lg11 = oSheet.get_Range("A2", "A2");
            lg11.Value2 = "ketoanhuyhoang.vn";
            Microsoft.Office.Interop.Excel.Range lg22 = oSheet.get_Range("C2", "C2");
            lg22.Value2 = "Thông tư số 198/2023/TLD";
            Microsoft.Office.Interop.Excel.Range logo11 = oSheet.get_Range("A2", "C2");
            logo11.Font.Bold = true;
            logo11.Font.Italic = true;
            logo11.Font.Color = Color.Blue;
            logo11.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A3", "C3");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Color = Color.Red;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Tạo ngày tháng trả lương
            Microsoft.Office.Interop.Excel.Range ngay = oSheet.get_Range("B4", "B4");
            ngay.Value2 = "Tháng 05 Năm 2023";
            ngay.Font.Bold = true;
            ngay.Font.Italic = true;
            ngay.Font.Color = Color.Violet;
            ngay.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Đơn vị
            Microsoft.Office.Interop.Excel.Range donvi = oSheet.get_Range("C5", "C5");
            donvi.Value2 = "Đơn vị: Đồng";
            donvi.Font.Bold = true;
            donvi.Font.Italic = true;
            donvi.Font.Color = Color.Black;
            donvi.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A6", "A6");
            cl1.Value2 = "Tên phòng ban";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B6", "B6");
            cl2.Value2 = "Tổng tiền thưởng";
            cl2.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C6", "C6");
            cl3.Value2 = "Tổng tiền phạt";
            cl3.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A6", "C6");
            rowHead.Font.Bold = true;
            rowHead.Font.Color = Color.Yellow;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 4;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 7;
            int columnStart1 = 1;
            int columnStart2 = 2;
            int columnStart3 = 3;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart1];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart1];
            Microsoft.Office.Interop.Excel.Range c5 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart2];
            Microsoft.Office.Interop.Excel.Range c6 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart3];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            Microsoft.Office.Interop.Excel.Range c7 = oSheet.get_Range(c1, c5);
            Microsoft.Office.Interop.Excel.Range c8 = oSheet.get_Range(c1, c6);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c5, c7).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c6, c8).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //In số thành dấu ','
            Microsoft.Office.Interop.Excel.Range phay1 = oSheet.get_Range(c5, c7);
            phay1.NumberFormat = "#,##0";
            Microsoft.Office.Interop.Excel.Range phay2 = oSheet.get_Range(c6, c8);
            phay2.NumberFormat = "#,##0";

            //Border
            Microsoft.Office.Interop.Excel.Range border = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 2, columnEnd];
            border.Value2 = "Hà Nội, tháng 05 năm 2023";
            border.Font.Bold = true;
            border.Font.Italic = true;
            border.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Ký tên
            Microsoft.Office.Interop.Excel.Range border1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd - 2];
            border1.Value2 = "Người lập phiếu";
            border1.Font.Bold = true;
            border1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd - 1];
            border2.Value2 = "Kế toán trưởng";
            border2.Font.Bold = true;
            border2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd];
            border3.Value2 = "Giám đốc công ty";
            border3.Font.Bold = true;
            border3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border11 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd - 2];
            border11.Value2 = "(Ký, họ tên)";
            border11.Font.Italic = true;
            border11.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border22 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd - 1];
            border22.Value2 = "(Ký, họ tên)";
            border22.Font.Italic = true;
            border22.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border33 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd];
            border33.Value2 = "(Ký, họ tên)";
            border33.Font.Italic = true;
            border33.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Chữ ký
            Microsoft.Office.Interop.Excel.Range border111 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd - 2];
            border111.Value2 = "Lê";
            border111.Font.Bold = true;
            border111.Font.Name = "Script MT Bold";
            border111.Font.Italic = true;
            border111.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border222 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd - 1];
            border222.Value2 = "Huy";
            border222.Font.Bold = true;
            border222.Font.Name = "Script MT Bold";
            border222.Font.Italic = true;
            border222.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border333 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd];
            border333.Value2 = "Hoàng";
            border333.Font.Bold = true;
            border333.Font.Name = "Script MT Bold";
            border333.Font.Italic = true;
            border333.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border444 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd - 2];
            border444.Value2 = "Huy Hoàng Lê";
            border444.Font.Bold = true;
            border444.Font.Name = "Script MT Bold";
            border444.Font.Italic = true;
            border444.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border555 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd - 1];
            border555.Value2 = "Hoàng Lê Huy";
            border555.Font.Bold = true;
            border555.Font.Name = "Script MT Bold";
            border555.Font.Italic = true;
            border555.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border666 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd];
            border666.Value2 = "Lê Huy Hoàng";
            border666.Font.Bold = true;
            border666.Font.Name = "Script MT Bold";
            border666.Font.Italic = true;
            border666.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        public void Export1(DataTable dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //Tạo logo
            Microsoft.Office.Interop.Excel.Range lg1 = oSheet.get_Range("A1", "A1");
            lg1.Value2 = "Kế toán Huy Hoàng";
            Microsoft.Office.Interop.Excel.Range lg2 = oSheet.get_Range("D1", "D1");
            lg2.Value2 = "Mẫu số 01a - LDTL";
            Microsoft.Office.Interop.Excel.Range logo1 = oSheet.get_Range("A1", "D1");
            logo1.Font.Bold = true;
            logo1.Font.Color = Color.Blue;
            logo1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range lg11 = oSheet.get_Range("A2", "A2");
            lg11.Value2 = "ketoanhuyhoang.vn";
            Microsoft.Office.Interop.Excel.Range lg22 = oSheet.get_Range("D2", "D2");
            lg22.Value2 = "Thông tư số 198/2023/TLD";
            Microsoft.Office.Interop.Excel.Range logo11 = oSheet.get_Range("A2", "D2");
            logo11.Font.Bold = true;
            logo11.Font.Italic = true;
            logo11.Font.Color = Color.Blue;
            logo11.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A3", "D3");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Color = Color.Red;
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Tạo ngày tháng trả lương
            Microsoft.Office.Interop.Excel.Range ngay = oSheet.get_Range("B4", "C4");
            ngay.Value2 = "Tháng 05 Năm 2023";
            ngay.MergeCells = true;
            ngay.Font.Bold = true;
            ngay.Font.Italic = true;
            ngay.Font.Color = Color.Violet;
            ngay.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Đơn vị
            Microsoft.Office.Interop.Excel.Range donvi = oSheet.get_Range("D5", "D5");
            donvi.Value2 = "Đơn vị: Đồng";
            donvi.Font.Bold = true;
            donvi.Font.Italic = true;
            donvi.Font.Color = Color.Black;
            donvi.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A6", "A6");
            cl1.Value2 = "Họ tên nhân viên";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B6", "B6");
            cl2.Value2 = "Tên chức vụ";
            cl2.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C6", "C6");
            cl3.Value2 = "Tiền thưởng";
            cl3.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D6", "D6");
            cl4.Value2 = "Tiền phạt";
            cl4.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A6", "D6");
            rowHead.Font.Bold = true;
            rowHead.Font.Color = Color.Yellow;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 4;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 7;
            int columnStart1 = 1;
            int columnStart2 = 2;
            int columnStart3 = 3;
            int columnStart4 = 4;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart1];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart1];
            Microsoft.Office.Interop.Excel.Range c5 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart2];
            Microsoft.Office.Interop.Excel.Range c6 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart3];
            Microsoft.Office.Interop.Excel.Range c9 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart4];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            Microsoft.Office.Interop.Excel.Range c7 = oSheet.get_Range(c1, c5);
            Microsoft.Office.Interop.Excel.Range c8 = oSheet.get_Range(c1, c6);
            Microsoft.Office.Interop.Excel.Range c10 = oSheet.get_Range(c1, c9);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c5, c7).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c6, c8).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c9, c10).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //In số thành dấu ','
            Microsoft.Office.Interop.Excel.Range phay1 = oSheet.get_Range(c5, c7);
            phay1.NumberFormat = "#,##0";
            Microsoft.Office.Interop.Excel.Range phay2 = oSheet.get_Range(c6, c8);
            phay2.NumberFormat = "#,##0";
            Microsoft.Office.Interop.Excel.Range phay3 = oSheet.get_Range(c9, c10);
            phay3.NumberFormat = "#,##0";

            //Border
            Microsoft.Office.Interop.Excel.Range border = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 2, columnEnd];
            border.Value2 = "Hà Nội, tháng 05 năm 2023";
            border.Font.Bold = true;
            border.Font.Italic = true;
            border.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Ký tên
            Microsoft.Office.Interop.Excel.Range border1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd - 2];
            border1.Value2 = "Người lập phiếu";
            border1.Font.Bold = true;
            border1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd - 1];
            border2.Value2 = "Kế toán trưởng";
            border2.Font.Bold = true;
            border2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 3, columnEnd];
            border3.Value2 = "Giám đốc công ty";
            border3.Font.Bold = true;
            border3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border11 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd - 2];
            border11.Value2 = "(Ký, họ tên)";
            border11.Font.Italic = true;
            border11.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border22 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd - 1];
            border22.Value2 = "(Ký, họ tên)";
            border22.Font.Italic = true;
            border22.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border33 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 4, columnEnd];
            border33.Value2 = "(Ký, họ tên)";
            border33.Font.Italic = true;
            border33.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Chữ ký
            Microsoft.Office.Interop.Excel.Range border111 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd - 2];
            border111.Value2 = "Lê";
            border111.Font.Bold = true;
            border111.Font.Name = "Script MT Bold";
            border111.Font.Italic = true;
            border111.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border222 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd - 1];
            border222.Value2 = "Huy";
            border222.Font.Bold = true;
            border222.Font.Name = "Script MT Bold";
            border222.Font.Italic = true;
            border222.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border333 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 5, columnEnd];
            border333.Value2 = "Hoàng";
            border333.Font.Bold = true;
            border333.Font.Name = "Script MT Bold";
            border333.Font.Italic = true;
            border333.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border444 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd - 2];
            border444.Value2 = "Huy Hoàng Lê";
            border444.Font.Bold = true;
            border444.Font.Name = "Script MT Bold";
            border444.Font.Italic = true;
            border444.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border555 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd - 1];
            border555.Value2 = "Hoàng Lê Huy";
            border555.Font.Bold = true;
            border555.Font.Name = "Script MT Bold";
            border555.Font.Italic = true;
            border555.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border666 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 6, columnEnd];
            border666.Value2 = "Lê Huy Hoàng";
            border666.Font.Bold = true;
            border666.Font.Name = "Script MT Bold";
            border666.Font.Italic = true;
            border666.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dvgTong_Luong.DataSource;
            Export(dt, "Tong_TP", "DANH SÁCH TỔNG TIỀN THƯỞNG PHẠT");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgv_Tien_Luong.DataSource;
            Export1(dt, "Tong_TP_NV", "DANH SÁCH TIỀN THƯỞNG PHẠT NV " + txtTenPB.Text.ToUpper());
        }
    }
}
