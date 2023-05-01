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

        public bool DangNhap(String uname, String upass)
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

        public void DangXuat() { }
    }
}
