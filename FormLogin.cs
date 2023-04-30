using LibraryProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryProject.Controllers.TaiKhoanController;

namespace LibraryProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxUser_Enter(object sender, EventArgs e)
        {
            panelUser.BackColor = Color.White;
            tbxUser.BackColor = Color.White;
            if (tbxUser.Text == " Username")
            {
                tbxUser.Text = "";
                tbxUser.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbxUser_Leave(object sender, EventArgs e)
        {
            panelUser.BackColor = SystemColors.Control;
            tbxUser.BackColor = SystemColors.Control;
            if (tbxUser.Text == "")
            {
                tbxUser.Text = " Username";
                tbxUser.ForeColor = Color.DimGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            panelPassword.BackColor = Color.White;
            tbxPassword.BackColor = Color.White;
            if (tbxPassword.Text == " Password")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            panelPassword.BackColor = SystemColors.Control;
            tbxPassword.BackColor = SystemColors.Control;
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = " Password";
                tbxPassword.ForeColor = Color.DimGray;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbxUser.Select();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = tbxUser.Text;
            password = tbxPassword.Text;
            try
            {
                if (DangNhap(username, password))
                {
                    userNhanVien = NhanVienController.GetNhanVienbyId(username);
                    FormDashBoard mainForm = new FormDashBoard();
                    mainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Thông tin đăng nhập sai! vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btbLogin_Click(sender, e);
        }

        private void tbxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxPassword.Select();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            tbxUser.Select();
        }
    }
}
