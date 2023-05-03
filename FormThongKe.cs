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

namespace LibraryProject
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            // Hiển thị số đầu sách
            string queryDauSach = "SELECT COUNT(*) FROM SACH";
            txtSach.Text= executeQuerytoTextbox(queryDauSach);
            // Hiển thị số lượng sách
            string querySoLuongSach = " ";
            
            //Hiển thị số loại sách
            string queryLoaiSach = " SELECT COUNT(*) FROM TheLoai";
            txtLoaiSach.Text = executeQuerytoTextbox(queryLoaiSach);

            //Hiển thị số tác giả
            string queryTacGia = " SELECT COUNT(*) FROM TacGia";
            txtTacGia.Text = executeQuerytoTextbox(queryTacGia);

            //Hiển thị số NXB
            string queryNXB = " SELECT COUNT(*) FROM NXB";
            txtNXB.Text = executeQuerytoTextbox(queryNXB);

            //Hiển thị số Độc giả
            string queryDocGia = " SELECT COUNT(*) FROM DOCGIA ";
            txtDocGia.Text = executeQuerytoTextbox(queryDocGia);

            //Hiển thị số Nhân viên
            string queryNhanVien = " SELECT COUNT(*) FROM TaiKhoan";
            txtNhanVien.Text = executeQuerytoTextbox(queryNhanVien);
            


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangMuon_Click(object sender, EventArgs e)
        {
            string query = "SELECT DG.MaDG, DG.TenDG, DG.DiaChi, DG.SDT, PM.MaPM, PM.NgayMuon, PM.HanTra " +
                        "FROM DOCGIA DG " +
                        "JOIN PHIEUMUON PM ON DG.MaDG = PM.MaDG " +
                        "JOIN CTPM ON PM.MaPM = CTPM.MaPM " +
                        "JOIN SACH ON CTPM.MaSach = SACH.MaSach " +
                        "WHERE PM.HanTra >= GETDATE()";

            string query1 = "SELECT COUNT(*) FROM PhieuMuon WHERE HanTra >= GETDATE() ";
            txtSoLuong.Text = executeQuerytoTextbox(query1);
            dtgvDanhSach.DataSource = executeQuery(query);

        }


        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            string query = "SELECT DG.MaDG, DG.TenDG, DG.DiaChi, DG.SDT, PM.MaPM, PM.NgayMuon, PM.HanTra " +
                        "FROM DOCGIA DG " +
                        "JOIN PHIEUMUON PM ON DG.MaDG = PM.MaDG " +
                        "WHERE PM.HanTra < GETDATE()";

            string query1 = "SELECT COUNT(*) FROM PhieuMuon WHERE HanTra < GETDATE() ";
            txtSoLuong.Text=executeQuerytoTextbox(query1);
            dtgvDanhSach.DataSource = executeQuery(query);
            
        }
        public DataTable executeQuery(string query)
        {
            DataTable dataTable = new DataTable();
            string connectionString = @"Data Source=DESKTOP-DUY2010\SQLEXPRESS;Initial Catalog=DB_LIBRARY;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
            return dataTable;
        }
        public string executeQuerytoTextbox(string query)
        {
            // Kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=DESKTOP-DUY2010\SQLEXPRESS;Initial Catalog=DB_LIBRARY;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Câu truy vấn SQL để đếm số lượng độc giả đang mượn sách
            //string query1 = "SELECT COUNT(*) FROM PhieuMuon WHERE HanTra >= GETDATE() ";

            // Thực thi câu truy vấn và lưu kết quả vào biến
            SqlCommand command = new SqlCommand(query, connection);
            int count = (int)command.ExecuteScalar();

            // Ép kiểu kết quả thành chuỗi và hiển thị lên txtSoLuong
            string soluong = count.ToString();

            
            return soluong;
            // Đóng kết nối
            connection.Close();
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            //FormChartMuon formChart = new FormChartMuon();

            //formChart.ShowDialog();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
         //   FormChartTra formChart= new FormChartTra();

           // formChart.ShowDialog();
        }
    }
}
