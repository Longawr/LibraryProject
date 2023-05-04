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
            ThuThuBUS.Instance.XemThuThu(dgvThuThu);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ThuThuBUS.Instance.TimKiemTheoMaThuThu(dgvThuThu, tbxSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.TaoTaiKhoan(dgvThuThu))
                if (ThuThuBUS.Instance.ThemThuThu(dgvThuThu))
                {
                    MessageBox.Show("Them Thanh Cong");
                    ThuThuBUS.Instance.XemThuThu(dgvThuThu);
                    return;
                }
                else
                    TaiKhoanBUS.Instance.XoaTaiKhoan(dgvThuThu);
            MessageBox.Show("Them khong Thanh Cong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThuThuBUS.Instance.XoaThuThu(dgvThuThu))
                if (TaiKhoanBUS.Instance.XoaTaiKhoan(dgvThuThu))
                {
                    MessageBox.Show("Xoa Thanh Cong");
                    ThuThuBUS.Instance.XemThuThu(dgvThuThu);
                    return;
                }
                else
                    ThuThuBUS.Instance.ThemThuThu(dgvThuThu);
            MessageBox.Show("Xoa khong Thanh Cong");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool thuThu = ThuThuBUS.Instance.SuaThuThu(dgvThuThu);
            bool taiKhoan = TaiKhoanBUS.Instance.SuaTaiKhoan(dgvThuThu);
            if (thuThu && taiKhoan)
                MessageBox.Show("Sua Thanh Cong");
            else if (!thuThu && !taiKhoan)
                MessageBox.Show("Sua Khong Thanh Cong");
            else if (!thuThu)
                MessageBox.Show("Sua Thu Thu Khong Thanh Cong");
            else
                MessageBox.Show("Sua Tai Khoan Khong Thanh Cong");
            ThuThuBUS.Instance.XemThuThu(dgvThuThu);
        }
    }
}
