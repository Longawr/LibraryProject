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
    public partial class FormPhieuMuon : Form
    {
        public FormPhieuMuon()
        {
            InitializeComponent();
        }

        private bool ChiTiet = false;

        private const string defaultText = " Tìm Kiếm";

        private void FormPhieuMuon_Load(object sender, EventArgs e)
        {
            PhieuMuonBUS.Instance.XemPhieuMuon(dataMain);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbxSoLuong.Text, out int value) && value > 0)
                if (PhieuTraBUS.Instance.TraSach(dataMain, value))
                    MessageBox.Show("Tạo phiếu trả thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Tạo phiếu trả thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Nhập Số Lượng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSoLuong.Select();
            }
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

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text != defaultText ? tbxSearch.Text : "";

            DataProducer.Instance.TimKiemTrenDGV(dataMain, searchText);

        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            btnTraSach.Enabled = true;
            btnTroLai.Enabled = true;
            panelCTPM.Visible = true;
            btnXemCT.Visible = false;
            label1.Text = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            ChiTietPMBUS.Instance.XemCTPM(dataMain);
            ChiTiet = true;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            panelCTPM.Visible = false;
            btnTroLai.Enabled = false;
            btnTraSach.Enabled = false;
            btnXemCT.Visible = true;
            PhieuMuonBUS.Instance.XemPhieuMuon(dataMain);
            ChiTiet = false;
            label1.Text = "Phiếu Mượn Sách";
        }

        private void tbxSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTraSach_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ChiTiet)
            {
                if (PhieuMuonBUS.Instance.ThemPhieuMuon(dataMain))
                {
                    MessageBox.Show("Thêm phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXemCT_Click(sender, e);
                }
                else
                    MessageBox.Show("Thêm phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ChiTietPMBUS.Instance.ThemChiTietPM(dataMain))
                    MessageBox.Show("Thêm sách vào phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm sách vào phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnRefresh_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!ChiTiet)
            {
                if (PhieuMuonBUS.Instance.XoaPhieuMuon(dataMain))
                {
                    MessageBox.Show("Xóa phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ChiTietPMBUS.Instance.XoaChiTietPM(dataMain))
                {
                    MessageBox.Show("Xóa sách từ phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa sách từ phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ChiTiet)
            {
                if (PhieuMuonBUS.Instance.SuaPhieuMuon(dataMain))
                    MessageBox.Show("Sửa phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Sửa phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRefresh_Click(sender, e);
                }
            }
            else
            {
                if (ChiTietPMBUS.Instance.SuaChiTietPM(dataMain))
                    MessageBox.Show("Sửa chi tiết phiếu mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Sửa chi tiết phiếu mượn thất bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRefresh_Click(sender, e);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!ChiTiet)
                PhieuMuonBUS.Instance.XemPhieuMuon(dataMain);
            else
                ChiTietPMBUS.Instance.XemCTPM(dataMain, label1.Text);
        }
    }
}
