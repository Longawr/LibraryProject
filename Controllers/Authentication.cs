using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryProject.Controllers.ConnectToDB;

namespace LibraryProject.Controllers
{
    class Authentication
    {
        public static bool authenticate(String uname, String upass)
        {
            try
            {
                String querry = "SELECT * FROM [account] WHERE username = '" + uname + "' AND password = '" + upass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                return dTable.Rows.Count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
