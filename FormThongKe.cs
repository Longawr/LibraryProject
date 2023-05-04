using LibraryProject.BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            ThongKeBUS.Instance.XemThongKe(txtSach,txtTongSach, txtLoaiSach, txtTacGia, txtNXB, txtDocGia, txtNhanVien);
            ThongKeBUS.Instance.XemDangMuon(dtgvDanhSach, txtSoLuong);
        }

        private void btnDangMuon_Click(object sender, EventArgs e)
        {
            ThongKeBUS.Instance.XemDangMuon(dtgvDanhSach, txtSoLuong);
            lableChange.Text = "Danh sách đang mượn";
        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            
            ThongKeBUS.Instance.XemQuaHan(dtgvDanhSach, txtSoLuong);
            lableChange.Text = "Danh sách quá hạn";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbBieuDo.SelectedItem != null)
            {
                string selectedValue = cbbBieuDo.SelectedItem.ToString();
                if (selectedValue == "Lượt mượn")
                {
                    // Thực hiện tìm kiếm cho Lượt Mượn
                    cbbBieuDo.Text = "";
                    FormChartMuon formChart = new FormChartMuon();
                    formChart.ShowDialog();
                }
                else if (selectedValue == "Lượt trả")
                {
                    // Thực hiện tìm kiếm cho Lượt Trả
                    cbbBieuDo.Text = "";
                    FormChartTra formChart = new FormChartTra();
                    formChart.ShowDialog();
                }
            }
            else if (cbbTop.SelectedItem != null)
            {
                string selectedValue = cbbTop.SelectedItem.ToString();
                if (selectedValue == "Độc giả tích cực")
                {
                    // Thực hiện tìm kiếm cho Lượt Mượn
                    cbbTop.Text = "";
                    FormTopDocGia formChart = new FormTopDocGia();
                    formChart.ShowDialog();
                }
                else if (selectedValue == "Sách hay nhất")
                {
                    // Thực hiện tìm kiếm cho Lượt Trả
                    cbbTop.Text = "";
                    FormTopSach formChart = new FormTopSach();
                    formChart.ShowDialog();
                }
            }
            else MessageBox.Show("Chọn giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
