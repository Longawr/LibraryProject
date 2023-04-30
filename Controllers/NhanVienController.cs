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
    class NhanVienController
    {
        public static DataTable GetNhanVienbyId(String id)
        {
            try
            {
                conn.Open();
                String querry = "SELECT * FROM [NhanVien] WHERE [MaNhanVien] = '" + id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                    return dTable;
                return null;
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
    }
}
