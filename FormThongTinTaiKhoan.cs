using LibraryProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormThongTinTaiKhoan : Form
    {
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        public string Data
        {
            get => tbxTenNV.Text;
            set => tbxTenNV.Text = value;
        }

        public event EventHandler DataAvailable;

        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void FormThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.ParseExact("19000101", "yyyyMMdd",
                CultureInfo.InvariantCulture);

            tbxMaNV.Text = ThuThuBUS.currentNhanVien.MaThuThu;
            tbxTenNV.Text = ThuThuBUS.currentNhanVien.TenThuThu;
            tbxEmail.Text = ThuThuBUS.currentNhanVien.Email;
            cbxGioiTinh.Text = ThuThuBUS.currentNhanVien.GioiTinh ? "Nam" : "Nữ";
            dtpkNgaySinh.Value = ThuThuBUS.currentNhanVien.NgaySinh != null ? ThuThuBUS.currentNhanVien.NgaySinh : result;
            tbxSoDT.Text = ThuThuBUS.currentNhanVien.SDT;
            tbxDiaChi.Text = ThuThuBUS.currentNhanVien.DiaChi;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FormDoiMK formDoiMK = new FormDoiMK();
            formDoiMK.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool gioiTinh = cbxGioiTinh.Text == "Nam";
            if (ThuThuBUS.Instance.SuaCurrentNhanVien(tbxMaNV.Text, tbxTenNV.Text, dtpkNgaySinh.Value, tbxSoDT.Text, tbxEmail.Text, gioiTinh, tbxDiaChi.Text))
            {
                MessageBox.Show("Lưu thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnDataAvailable(null);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
