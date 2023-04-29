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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            checkBtnAn.CheckedChanged += new EventHandler(checkBtnAn_CheckedChanged);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTen.Text;
            string password =txtMatKhau.Text;

            if (username == "admin" && password == "123")
            {
                // Chuyển sang giao diện dashboard
                FormDashBoard dashboard = new FormDashBoard();
                dashboard.Show();

                // Ẩn giao diện đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBtnAn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBtnAn.Checked)
            {
               txtMatKhau.UseSystemPasswordChar = false;
            }
            // Ngược lại, ẩn mật khẩu
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
    }

