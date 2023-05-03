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
        public bool TaoTaiKhoanMoi(TaiKhoanDTO taiKhoan)
        {
            try
            {
                string sql = "insert into TaiKhoan values ( @TaiKhoan , @MatKhau , @Chucvu )";
                object[] pmt = new object[] { taiKhoan.TaiKhoan, taiKhoan.MatKhau, taiKhoan.ChucVu };
                if (DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool Xoa(string MaThuThu)
        {
            try
            {
                string sql = "delete from TaiKhoan where TaiKhoan = @MaThuThu";
                object[] pmt = new object[] { MaThuThu };
                if (DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DangXuat() { }
    }
}
