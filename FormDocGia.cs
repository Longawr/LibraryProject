using LibraryProject.BUS;
using LibraryProject.DAO;
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
    public partial class FormDocGia : Form
    {
        public FormDocGia()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=SHINN;Initial Catalog=DB_LIBRARY1;Integrated Security=True";
        private void btnTim_Click(object sender, EventArgs e)
        {

            string query = "SELECT MaDG AS N'Mã độc giả', TenDG AS N'Tên độc giả', NgaySinh AS N'Ngày sinh', GioiTinh AS N'Giới tính', DiaChi AS N'Địa chỉ', SDT AS N'SĐT', Email AS N'Email' FROM dbo.DOCGIA Where MaDG like @MaDG";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaDG", tbxSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataMain.DataSource = table;                     
            connection.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (DGBus.Instance.Them(dataMain))
            {
                MessageBox.Show("Thêm thành công!");
                btnXem_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DGBus.Instance.XoatheoMaDG(dataMain))
            {
                MessageBox.Show("Xóa thành công!");
                btnXem_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            } 
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (DGBus.Instance.Sua(dataMain))
            {
                MessageBox.Show("Sửa thành công!");
                btnXem_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void dataMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnXem_Click(object sender, EventArgs e)
        {
            
            DGBus.Instance.Xem(dataMain);   

        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            btnXem_Click(sender, e);
        }
    }
}
