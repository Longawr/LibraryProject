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
    public partial class FormPhieuTra : Form
    {
        private const string defaultText = " Tìm Kiếm";

        public FormPhieuTra()
        {
            InitializeComponent();
        }

        private void FormPhieuTra_Load(object sender, EventArgs e)
        {
            PhieuTraBUS.Instance.XemPhieuTra(dataMain);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text != defaultText ? tbxSearch.Text : "";
            DataProducer.Instance.TimKiemTrenDGV(dataMain, searchText);
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == defaultText)
            {
                tbxSearch.Text = "";
                tbxSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                tbxSearch.Text = defaultText;
                tbxSearch.ForeColor = Color.DimGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PhieuTraBUS.Instance.XemPhieuTra(dataMain);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PhieuTraBUS.Instance.TaoPhieuTra(dataMain))
                MessageBox.Show("Tạo phiếu trả thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Tạo phiếu trả thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnRefresh_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (PhieuTraBUS.Instance.XoaPhieuTra(dataMain))
            {
                MessageBox.Show("Xóa phiếu trả thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
            else
                MessageBox.Show("Xóa phiếu trả thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (PhieuTraBUS.Instance.SuaPhieuTra(dataMain))
                MessageBox.Show("Sửa phiếu trả thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Sửa phiếu trả thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRefresh_Click(sender, e);
            }
        }
    }
}
