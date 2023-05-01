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
    public partial class FormDashBoard : Form
    {
        bool sidebarExpand = false;

        private string helloText { set => btnTaiKhoan.Text = "Hello, " + value; }

        public FormDashBoard()
        {
            InitializeComponent();
        }

        void child_DataAvailable(object sender, EventArgs e)
        {
            FormThongTinTaiKhoan child = sender as FormThongTinTaiKhoan;
            if (child != null)
            {
                helloText = child.Data;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormSach());
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormPhieuMuon());
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormPhieuTra());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormDocGia());
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormThuThu());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormThongKe());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            FormBUS.Instance.loadForm(this.panelMain, new FormCaiDat());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS.DangXuat();
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
            FormThongTinTaiKhoan formThongTinTaiKhoan = new FormThongTinTaiKhoan();
            formThongTinTaiKhoan.DataAvailable += new EventHandler(child_DataAvailable);
            FormBUS.Instance.loadForm(this.panelMain, formThongTinTaiKhoan);
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            helloText = NhanVienBUS.currentNhanVien.TenNhanVien;
            FormBUS.Instance.loadForm(this.panelMain, new FormSach());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không?",
                                        "Cảnh Báo Đăng Xuất",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                TaiKhoanBUS.DangXuat();
                FormLogin loginform = new FormLogin();
                loginform.Show();
                this.Hide();
            }
        }
    }
}
