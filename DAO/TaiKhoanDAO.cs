using LibraryProject.BUS;
using LibraryProject.DTO;
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

        public bool TaoTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            string sql = "INSERT INTO [dbo].[TaiKhoan]([TaiKhoan],[MatKhau],[ChucVu])" +
                "VALUES( @TaiKhoan , @MatKhau , @Chucvu )";
            object[] pmt = new object[] { taiKhoan.TaiKhoan, taiKhoan.MatKhau, taiKhoan.ChucVu };
            return DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0;
        }

        public bool XoaTaiKhoan(string MaThuThu)
        {
            string sql = "delete from TaiKhoan where TaiKhoan = @MaThuThu";
            object[] pmt = new object[] { MaThuThu };
            return DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0;
        }



        public void DangXuat() { }
    }
}
