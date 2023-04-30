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
    class NhanVienController
    {
        public static DataTable GetNhanVienbyId(String id)
        {
            try
            {
                String query = "SELECT * FROM [NhanVien] WHERE [MaNhanVien] = @id";

                object[] obj = new object[] { id };

                DataTable dTable = DataProvider.Instance.ExecuteQuery(query, obj);

                if (dTable.Rows.Count > 0)
                    return dTable;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
