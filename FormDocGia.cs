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

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnXem_Click(sender, e);
            DataProducer.Instance.TimKiemTrenDGV(dataMain, tbxSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (DocGiaBUS.Instance.Them(dataMain))
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
            if (DocGiaBUS.Instance.XoatheoMaDG(dataMain))
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

            if (DocGiaBUS.Instance.Sua(dataMain))
            {
                MessageBox.Show("Sửa thành công!");
                btnXem_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            DocGiaBUS.Instance.Xem(dataMain);

        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            btnXem_Click(sender, e);
        }
    }
}
