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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.XacNhanMK(tbxMkCu.Text))
            {
                if (tbxMkMoi.Text == tbxMkCu.Text)
                {
                    MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    tbxMkMoi.Text = "";
                    tbxXnMk.Text = "";
                    tbxMkMoi.Select();
                }
                else if (tbxMkMoi.Text == tbxXnMk.Text)
                {
                    TaiKhoanBUS.Instance.DoiMatKhau(tbxMkMoi.Text);
                    DialogResult checkOK = MessageBox.Show("Đổi mật khẩu thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkOK == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu mới", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    tbxMkMoi.Text = "";
                    tbxXnMk.Text = "";
                    tbxMkMoi.Select();
                }
            }
            else
            {
                DialogResult checkOK = MessageBox.Show("Mật khẩu cũ không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tbxMkCu.Text = "";
                tbxMkMoi.Text = "";
                tbxXnMk.Text = "";
                tbxMkMoi.Select();
            }
        }
    }
}
