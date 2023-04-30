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
            SachBUS.Instance.Xem(dataGridView1);
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SachBUS.Instance.TimKiemTheoTen(dataGridView1, tBxTenSach.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SachBUS.Instance.Xem(dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Xoa(dataGridView1))
            {
                MessageBox.Show("Xoa Thanh Cong");
                btnRefresh_Click(sender, e);
            } else
                MessageBox.Show("Xoa khong Thanh Cong");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Sua(dataGridView1))
            {
                MessageBox.Show("Sua Thanh Cong");
                //btnRefresh_Click(sender,e);
            }
            else
                MessageBox.Show("Sua khong Thanh Cong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SachBUS.Instance.Them(dataGridView1))
            {
                MessageBox.Show("Them Thanh Cong");
                btnRefresh_Click(sender, e);
            }
            else
                MessageBox.Show("Them khong Thanh Cong");
        }

    } 
}
