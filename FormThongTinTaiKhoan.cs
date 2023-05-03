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

            tbxMaNV.Text = NhanVienBUS.currentNhanVien.MaNhanVien;
            tbxTenNV.Text = NhanVienBUS.currentNhanVien.TenNhanVien;
            tbxEmail.Text = NhanVienBUS.currentNhanVien.Email;
            cbxGioiTinh.Text = NhanVienBUS.currentNhanVien.GioiTinh ? "Nam" : "Nữ";
            dtpkNgaySinh.Value = NhanVienBUS.currentNhanVien.NgaySinh != null ? NhanVienBUS.currentNhanVien.NgaySinh : result;
            tbxSoDT.Text = NhanVienBUS.currentNhanVien.SoDienThoai;
            tbxDiaChi.Text = NhanVienBUS.currentNhanVien.DiaChi;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FormDoiMK formDoiMK = new FormDoiMK();
            formDoiMK.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool gioiTinh = cbxGioiTinh.Text == "Nam";
            if (NhanVienBUS.Instance.SuaCurrentNhanVien(tbxMaNV.Text, tbxTenNV.Text, dtpkNgaySinh.Value, tbxSoDT.Text, tbxEmail.Text, gioiTinh, tbxDiaChi.Text))
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
