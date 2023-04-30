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
                String query = "SELECT * FROM [TaiKhoan] WHERE [username] = @username AND [password] = @password";

                object[] obj = new object[] { uname, upass };

                return DataProvider.Instance.ExecuteQuery(query, obj).Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DangXuat()
        {
            userNhanVien = null;
            return true;
        }
    }
}
