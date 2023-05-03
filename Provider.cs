using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace LibraryProject
{
    internal class Provider
    {
        private static Provider instance;
        public static Provider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Provider();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private Provider() { }
        string connectionString = @"Data Source=SHINN;Initial Catalog=DB_LIBRARY1;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);


            if (parameter != null)
            {
                string[] temp = query.Split(' ');
                List<string> listpara = new List<string>();
                foreach (string item in temp)
                {
                    if (item[0] == '@')
                        listpara.Add(item);
                }
                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int accpectedRows = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);


            if (parameter != null)
            {
                string[] temp = query.Split(' ');
                List<string> listpara = new List<string>();
                foreach (string item in temp)
                {
                    if (item != string.Empty && item[0] == '@')
                        listpara.Add(item);
                }
                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
            }
            accpectedRows = command.ExecuteNonQuery();
            connection.Close();

            return accpectedRows;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object accpectedRows = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);


            if (parameter != null)
            {
                string[] temp = query.Split(' ');
                List<string> listpara = new List<string>();
                foreach (string item in temp)
                {
                    if (item != string.Empty && item[0] == '@')
                        listpara.Add(item);
                }
                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
            }
            accpectedRows = command.ExecuteScalar();
            connection.Close();

            return accpectedRows;
        }
    }
}

