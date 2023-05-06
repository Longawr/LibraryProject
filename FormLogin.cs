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
    public partial class FormLogin : Form
    {
        private const string defaultUsernameText = " Username";
        private const string defaultPasswordText = " Password";
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
            if (tbxUser.Text == defaultUsernameText)
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
                tbxUser.Text = defaultUsernameText;
                tbxUser.ForeColor = Color.DimGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            panelPassword.BackColor = Color.White;
            tbxPassword.BackColor = Color.White;
            if (tbxPassword.Text == defaultPasswordText)
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
                tbxPassword.Text = defaultPasswordText;
                tbxPassword.ForeColor = Color.DimGray;
            }
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text == defaultUsernameText || tbxPassword.Text == defaultPasswordText)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxUser.Text[0] == ' ' || tbxPassword.Text[0] == ' ')
            {
                MessageBox.Show("Thông tin đăng nhập không thể bắt đầu bằng phím cách (space key)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (TaiKhoanBUS.Instance.DangNhap(tbxUser.Text, tbxPassword.Text))
                {
                    ThuThuBUS.Instance.AddCurrentNhanVien(tbxUser.Text);
                    FormDashBoard mainForm = new FormDashBoard();
                    mainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
