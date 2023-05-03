using LibraryProject.BUS;
using LibraryProject.DAO;
using LibraryProject.DTO;
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
    public partial class FormTaoTaiKhoan : Form
    {
        bool sex;
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO
                {
                    TaiKhoan = tbxUsername.Text,
                    MatKhau = tbxMatKhau.Text,
                    ChucVu = "thuthu"
                };

                TaiKhoanBUS.Instance.TaoTaiKhoanMoi(taikhoan);

                if (ckbNam.Checked)
                {
                    sex = true;
                    ckbNu.Checked = false;
                }
                if (ckbNu.Checked)
                {
                    sex = false;
                    ckbNam.Checked = false;
                }

            } catch(SqlException ex) when (ex.Number == 2627)
            {
                try
                {
                    ThuThuDTO thuthu = new ThuThuDTO
                    {
                        MaThuThu = tbxUsername.Text,
                        TenThuThu = tbxTenThuThu.Text,
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = sex,
                        DiaChi = tbxAddr.Text,
                        SDT = tbxSDT.Text,
                        Email = tbxEmail.Text,
                    };
                    ThuThuBUS.Instance.ThemThuThu(thuthu);
                     } catch(SqlException a) when (a.Number == 2627)
                {
                    this.Close();
                }
                
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
