using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.DAO
{
    class PhieuTraDAO
    {
        private static PhieuTraDAO instance;

        public static PhieuTraDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private PhieuTraDAO() { }

        public DataTable XemPhieuTra()
        {
            string query = "SELECT [MaPT] N'Mã Trả', [TaiKhoan] N'Thủ Thư', [MaPM] N'Mã Mượn', [MaSach] N'Mã Sách', [SoLuong] N'Số Lượng', [NgayTra] N'Ngày Trả' FROM [dbo].[PhieuTra]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int ThemPhieuTra(PhieuTraDTO phieuTra)
        {
            object[] obj = new object[] { phieuTra.MaPT, phieuTra.TaiKhoan, phieuTra.MaPM, phieuTra.MaSach, phieuTra.SoLuong, phieuTra.NgayTra };

            string query = "INSERT INTO [PhieuTra] ([MaPT],[TaiKhoan],[MaPM],[MaSach],[SoLuong],[NgayTra])" +
                "VALUES( @MaPT , @TaiKhoan , @MaPM , @MaSach , @SoLuong , @NgayTra )";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public int XoaPhieuTra(string maTra)
        {
            object[] obj = new object[] { maTra };

            string query = "DELETE FROM [dbo].[PhieuTra] WHERE [MaPT] = @maPT";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public int SuaPhieuTra(PhieuTraDTO phieuTra)
        {
            object[] obj = new object[] { phieuTra.MaPT, phieuTra.TaiKhoan, phieuTra.MaPM, phieuTra.MaSach, phieuTra.SoLuong, phieuTra.NgayTra };

            string query = "UPDATE [dbo].[PhieuTra] SET [TaiKhoan] = @TaiKhoan ,[MaPM] = @MaPM ,[MaSach] = @MaSach ,[SoLuong] = @SoLuong ,[NgayTra] = @NgayTra WHERE [MaPT] = @MaPT";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
