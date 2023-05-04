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
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryProject
{
    public partial class FormChartTra : Form
    {
        public FormChartTra()
        {
            InitializeComponent();
        }

        private void FormChartTra_Load(object sender, EventArgs e)
        {
            DataTable table = ThongKeBUS.Instance.BieuDoTra();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Biểu đồ lượt trả theo tháng");
            chart1.ChartAreas[0].AxisX.Title = " Tháng";
            chart1.ChartAreas[0].AxisY.Title = " Lượt trả";

            Series series = chart1.Series.Add("Lượt trả");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Int32;
            series.YValueType = ChartValueType.Int32;

            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row["Thang"], row["SoLuotTra"]);
            }
        }

       
    }
}
