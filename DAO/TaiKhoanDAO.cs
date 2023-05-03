using LibraryProject.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private TaiKhoanDAO() { }

        public bool XacNhanTkMk(String uname, String upass)
        {
            String query = "SELECT * FROM [TaiKhoan] WHERE [TaiKhoan] = @username AND [MatKhau] = @password";
            object[] obj = new object[] { uname, upass };

            return DataProvider.Instance.ExecuteQuery(query, obj).Rows.Count > 0;
        }

        public int DoiMatKhau(string username, string password)
        {
            string query = "UPDATE [dbo].[TaiKhoan] SET [MatKhau] = @password WHERE [TaiKhoan] = @username";
            object[] obj = new object[] { password, username };

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public void DangXuat() { }
    }
}
