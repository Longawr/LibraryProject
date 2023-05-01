using LibraryProject.BUS;
using LibraryProject.Controllers;
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
            SachBUS.Instance.Xem(dgvSach);
            cBxTheLoai.DataSource = SachDAO.Instance.TheLoai();
            cBxTheLoai.DisplayMember = "MaLoai";
           
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
            SachBUS.Instance.LocSach(dgvSach,cBxTheLoai.Text);
            dgvSach.DataSource = SachDAO.Instance.LocSach(cBxTheLoai.Text);
        }

    }
        
}
