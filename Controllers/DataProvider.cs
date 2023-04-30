using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryProject.Controllers
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            //set => instance = value;
        }

        public DataProvider() { }

        private string connString = @"Data Source=NGOCTRINH;Initial Catalog=QuanLyThuVienDB;Integrated Security=True";


        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dtable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listPara = new List<string>();

                    foreach (string item in temp)
                    {
                        if (item != string.Empty && item[0] == '@')
                            listPara.Add(item);
                    }

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(listPara[i], parameters[i]);
                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dtable);

                conn.Close();
            }
            return dtable;
        }
    }
}
