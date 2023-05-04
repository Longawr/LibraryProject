using LibraryProject.BUS;
using System;
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
    public partial class FormThuThu : Form
    {
        public FormThuThu()
        {
            InitializeComponent();
        }

        private void FormThuThu_Load(object sender, EventArgs e)
        {
            ThuThuBUS.Instance.Xem(dgvThuThu);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ThuThuBUS.Instance.TimKiemTheoMaThuThu(dgvThuThu, tbxSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            FormTaoTaiKhoan addAcc = new FormTaoTaiKhoan();
            addAcc.ShowDialog();
            ThuThuBUS.Instance.Xem(dgvThuThu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThuThuBUS.Instance.Xoa(dgvThuThu) && TaiKhoanBUS.Instance.Xoa(dgvThuThu))
            {
                MessageBox.Show("Xoa Thanh Cong");
                ThuThuBUS.Instance.Xem(dgvThuThu);
            }
            else
                MessageBox.Show("Xoa khong Thanh Cong");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ThuThuBUS.Instance.Sua(dgvThuThu))
            {
                MessageBox.Show("Sua Thanh Cong");
                ThuThuBUS.Instance.Xem(dgvThuThu);
            }
            else
                MessageBox.Show("Sua khong Thanh Cong");
        }
    }
}
