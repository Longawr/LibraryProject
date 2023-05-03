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

namespace LibraryProject
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            ThongKeBUS.Instance.XemThongKe(txtSach, txtLoaiSach, txtTacGia, txtNXB, txtDocGia, txtNhanVien);
        }

        private void btnDangMuon_Click(object sender, EventArgs e)
        {
            ThongKeBUS.Instance.XemDangMuon(dtgvDanhSach, txtSoLuong);

        }

        private void btnQuaHan_Click(object sender, EventArgs e)
        {
            ThongKeBUS.Instance.XemQuaHan(dtgvDanhSach, txtSoLuong);
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            //FormChartMuon formChart = new FormChartMuon();

            //formChart.ShowDialog();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            //   FormChartTra formChart= new FormChartTra();

            // formChart.ShowDialog();
        }
    }
}
