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
    public partial class FormDashBoard : Form
    {
        bool sidebarExpand = false;
        public FormDashBoard()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            loadForm(new FormSach());
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            loadForm(new FormPhieuMuon());
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            loadForm(new FormPhieuTra());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            loadForm(new FormDocGia());
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            loadForm(new FormThuThu());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadForm(new FormThongKe());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            loadForm(new FormCaiDat());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelTaiKhoan.Height -= 10;
                if (panelTaiKhoan.Height == panelTaiKhoan.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelTaiKhoan.Height += 10;
                if (panelTaiKhoan.Height == panelTaiKhoan.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnTKInfo_Click(object sender, EventArgs e)
        {
            loadForm(new FormThongTinTaiKhoan());
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            btnTaiKhoan.Text = Controllers.TaiKhoanController.userNhanVien.Rows[0][0].ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không?",
                                        "Cảnh Báo Đăng Xuất",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                Controllers.TaiKhoanController.DangXuat();
            }
            else
            {
                // If 'No', do something here.
            }
        }
    }
}
