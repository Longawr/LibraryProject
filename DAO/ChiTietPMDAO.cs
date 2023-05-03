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
    class ChiTietPMDAO
    {
        private static ChiTietPMDAO instance;

        public static ChiTietPMDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPMDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private ChiTietPMDAO() { }

        public DataTable XemChiTietPM(string MaMuon)
        {
            object[] obj = new object[] { MaMuon };
            string query = "SELECT [MaCTPM] N'Mã CTPM' ,[MaPM] N'Mã Mượn' ,[MaSach] N'Mã Sách' ,[SoLuong] N'Số Lượng' ,[DaTra] N'Đã Trả' FROM [CTPM] WHERE [MaPM] = @MaMuon";

            DataTable dTable = DataProvider.Instance.ExecuteQuery(query, obj);

            return dTable;
        }

        public int ThemCTPM(ChiTietPMDTO CTPM)
        {
            if (CTPM.MaCTPM == null)
                CTPM.MaCTPM = CTPM.MaSach + CTPM.MaPM;
            object[] obj = new object[] { CTPM.MaCTPM, CTPM.MaPM, CTPM.MaSach, CTPM.SoLuong };

            string query = "INSERT INTO [dbo].[CTPM] ([MaCTPM],[MaPM],[MaSach],[SoLuong])" +
                "VALUES( @MaCTPM , @MaPM , @MaSach , @SoLuong )";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public int XoaCTPM(string maCTPM)
        {
            object[] obj = new object[] { maCTPM };

            string query = "DELETE FROM [dbo].[CTPM] WHERE MaCTPM = @MaCTPM";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public int SuaCTPM(ChiTietPMDTO CTPM)
        {
            object[] obj = new object[] { CTPM.MaPM, CTPM.MaSach, CTPM.SoLuong, CTPM.DaTra, CTPM.MaCTPM };

            string query = "UPDATE [dbo].[CTPM] SET [MaPM] = @MaPM ,[MaSach] = @MaSach ,[SoLuong] = @SoLuong,[DaTra] = @DaTra WHERE [MaCTPM] = @MaCTPM";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
