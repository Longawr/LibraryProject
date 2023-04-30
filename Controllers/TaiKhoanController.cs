using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryProject.Controllers.DataProvider;

namespace LibraryProject.Controllers
{
    class TaiKhoanController
    {
        public static DataTable userNhanVien;
        public static bool DangNhap(String uname, String upass)
        {
            try
            {
                //return uname == "username" && upass == "password";
                conn.Open();
                String querry = "SELECT * FROM [TaiKhoan] WHERE [username] = '" + uname + "' AND [password] = '" + upass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                return dTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool DangXuat()
        {
            userNhanVien = null;
            return true;
        }
    }
}
