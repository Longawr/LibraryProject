using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private ThuThuDAO() { }

        public DataTable XemThuThuQuaId(String id)
        {
            string query = "SELECT * FROM [ThuThu] WHERE [MaThuThu] = @id";

            object[] obj = new object[] { id };

            DataTable dTable = DataProvider.Instance.ExecuteQuery(query, obj);

            return dTable;
        }

        public DataTable Xem()
        {
            string sql = "select * from ThuThu";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public object XemTTnTK()
        {
            string sql = " SELECT tt.[MaThuThu] N'Mã'" +
                ", tt.[TenThuThu] N'Tên'" +
                ",tt.[NgaySinh] N'Ngày Sinh'" +
                ",tt.[GioiTinh] N'Giới Tính'" +
                ",tt.[DiaChi] N'Địa Chỉ'" +
                ",tt.[SDT] N'SDT'" +
                ",tt.[Email] N'Email'" +
                ",tk.[MatKhau] N'Mật Khẩu'" +
                ",tk.[ChucVu] N'Chức vụ'" +
                "FROM[dbo].[ThuThu] tt INNER JOIN[dbo].[TaiKhoan] tk " +
                "ON tt.[MaThuThu] = tk.[TaiKhoan]";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public DataTable TimKiemMaThuThu(string MaThuThu)
        {
            object[] pmt = new object[] { "%" + MaThuThu + "%" };
            string sql = "select * from ThuThu where MaThuThu like @MaThuThu";

            return DataProvider.Instance.ExecuteQuery(sql, pmt);
        }

        public bool ThemThuThu(ThuThuDTO thuThu)
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

            return DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0;
        }

        public bool XoaThuThu(string MaThuThu)
        {
            string sql = "DELETE FROM [dbo].[ThuThu] WHERE MaThuThu = @MaThuThu";
            object[] pmt = new object[] { MaThuThu };
            return DataProvider.Instance.ExecuteNonQuery(sql, pmt) > 0;
        }

        public bool SuaThuThu(string maNV, ThuThuDTO nhanVien)
        {
            string query = "UPDATE [ThuThu] SET [TenThuThu] = @TenNhanVien , [Email] = @Email , [GioiTinh] = @GioiTinh ,[DiaChi] = @DiaChi , [NgaySinh] = @NgaySinh , [SDT] = @SoDT WHERE [MaThuThu] = @MaNhanVien";

            object[] obj = new object[] { nhanVien.TenThuThu, nhanVien.Email, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.NgaySinh, nhanVien.SDT, maNV };

            return DataProvider.Instance.ExecuteNonQuery(query, obj) > 0;
        }
    }
}
