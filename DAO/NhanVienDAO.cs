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
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private NhanVienDAO() { }

        public DataTable GetNhanVienbyId(String id)
        {
            string query = "SELECT * FROM [ThuThu] WHERE [MaThuThu] = @id";

            object[] obj = new object[] { id };

            DataTable dTable = DataProvider.Instance.ExecuteQuery(query, obj);

            return dTable;
        }

        public bool SuaNhanVien(string maNV, NhanVienDTO nhanVien)
        {
            string query = "UPDATE [ThuThu] SET [TenThuThu] = @TenNhanVien , [Email] = @Email , [GioiTinh] = @GioiTinh ,[DiaChi] = @DiaChi , [NgaySinh] = @NgaySinh , [SDT] = @SoDT WHERE [MaThuThu] = @MaNhanVien";

            object[] obj = new object[] { nhanVien.TenNhanVien, nhanVien.Email, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.NgaySinh, nhanVien.SoDienThoai, maNV };

            return DataProvider.Instance.ExecuteNonQuery(query, obj) > 0;
        }
    }
}
