using LibraryProject.BUS;
using LibraryProject.DAO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }
        
        private void FormSach_Load(object sender, EventArgs e)
        {
            SachBUS.Instance.Xem(dgvSach);
            cBxTheLoai.DataSource = TheLoaiDAO.Instance.GetTheLoai();
            cBxTheLoai.DisplayMember = "TenLoai";
            cBxTheLoai.ValueMember = "MaLoai";

            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[0].Width= 60;
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[1].Width = 160;
            dgvSach.Columns[2].HeaderText = "Số lượng";
            dgvSach.Columns[2].Width = 40;
            dgvSach.Columns[3].HeaderText = "Tồn kho";
            dgvSach.Columns[3].Width = 40;
            dgvSach.Columns[4].HeaderText = "Giá trị";
            dgvSach.Columns[4].Width = 60;
            dgvSach.Columns[5].HeaderText = "Mã loại";
            dgvSach.Columns[5].Width = 40;
            dgvSach.Columns[6].HeaderText = "Mã tác giả";
            dgvSach.Columns[6].Width = 70;
            dgvSach.Columns[7].HeaderText = "Mã nhà xuất bản";
            dgvSach.Columns[7].Width = 60;
            dgvSach.Columns[8].HeaderText = "Năm xuất bản";
            dgvSach.Columns[8].Width = 60;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SachBUS.Instance.TimKiemTheoTen(dgvSach, tBxTenSach.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SachBUS.Instance.Xem(dgvSach);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        if (SachBUS.Instance.Xoa(dgvSach))
        {
            MessageBox.Show("Xoa Thanh Cong");
            btnRefresh_Click(sender, e);
        }
        else
            MessageBox.Show("Xoa khong Thanh Cong");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Sua(dgvSach))
            {
                MessageBox.Show("Sua Thanh Cong");
                btnRefresh_Click(sender,e);
            }
            else
                MessageBox.Show("Sua khong Thanh Cong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Them(dgvSach))
            {
                MessageBox.Show("Them Thanh Cong");
                btnRefresh_Click(sender, e);
            }
            else
                MessageBox.Show("Them khong Thanh Cong");
        }

       private void btnLoc_Click(object sender, EventArgs e)
        {
            string MaLoai = cBxTheLoai.SelectedValue.ToString();
            SachBUS.Instance.LocSach(dgvSach, MaLoai);
        }

        
    }
        
}
