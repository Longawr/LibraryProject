using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class DataProducer
    {
        private static DataProducer instance;

        public static DataProducer Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProducer();
                return instance;
            }
            //set => instance = value; 
        }

        private DataProducer() { }

        public void TaoSearchCol(DataGridView data)
        {
            DataTable dt = (DataTable)data.DataSource;
            DataColumn dcRowString = dt.Columns.Add("_RowString", typeof(string));
            foreach (DataRow dataRow in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append("\t");
                }
                dataRow[dcRowString] = sb.ToString();
            }
            data.Columns["_RowString"].Visible = false;
        }

        public void TimKiemTrenDGV(DataGridView data, string searchText)
        {
            DataTable dt = (DataTable)data.DataSource;

            dt.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", searchText);
        }
    }
}
