using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryProject.Controllers
{
    class ConnectToDB
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=NGOCTRINH;Initial Catalog=QuanLyThuVienDB;Integrated Security=True");
    }
}
