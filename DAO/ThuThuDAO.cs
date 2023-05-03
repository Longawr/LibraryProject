using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAO
{
    class ThuThuDAO
    {
        private static ThuThuDAO instance;
        public static ThuThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThuThuDAO();
                return instance;
            }
            //set => instance = value;
        }

        public ThuThuDAO() { }

        public DataTable Xem()
        {
            try
            {
                string sql = "select * from ThuThu";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimKiemMaThuThu(string MaThuThu)
        {
            try
            {
                object[] pmt = new object[] { "%" + MaThuThu + "%" };
                string sql = "select * from ThuThu where MaThuThu like @MaThuThu";

                return DataProvider.Instance.ExecuteQuery(sql, pmt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      

        public bool ThemThuThu(ThuThuDTO thuThu)
        {
            try
            {
                string sql = "insert into ThuThu values ( @MaThuThu , " +
                "@TenThuThu , " +
                "@NgaySinh , " +
               "@GioiTinh , " +
               "@DiaChi , " +
               "@SDT , " +
               "@Email )";

                object[] pmt = new object[] { thuThu.MaThuThu , thuThu.TenThuThu ,
                thuThu.NgaySinh , thuThu.GioiTinh , thuThu.DiaChi , thuThu.SDT , thuThu.Email };

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

        public bool Sua(string MaThuThu, ThuThuDTO thuThu)
        {
            try
            {
                string sql = "update ThuThu set TenThuThu = @TenThuThu , " +
                "NgaySinh = @NgaySinh , " +
               "GioiTinh = @GioiTinh , " +
               "DiaChi = @DiaChi , " +
               "SDT = @SDT , " +
                "Email = @Email " +
                "where MaThuThu = @OldMaThuThu";
                object[] pmt = new object[] {thuThu.TenThuThu, thuThu.NgaySinh, thuThu.GioiTinh,
                thuThu.DiaChi,thuThu.SDT,thuThu.Email, MaThuThu};

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

        public bool Xoa(string MaThuThu)
        {
            try
            {
                string sql = "delete from ThuThu where MaThuThu = @MaThuThu";
                    
                    //"delete from TaiKhoan where TaiKhoan = @MaThuThu";


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
    }
}
