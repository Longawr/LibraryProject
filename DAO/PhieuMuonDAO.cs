using LibraryProject.BUS;
using LibraryProject.Controllers;
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
    class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;

        public static PhieuMuonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonDAO();
                return instance;
            }
            //set => instance = value;
        }

        public PhieuMuonDAO() { }

        public DataTable XemPhieuMuon()
        {
            string query = "SELECT [MaPM] N'Mã Mượn', [MaDG] N'Độc Giả', [TaiKhoan] N'Thủ Thư', [NgayMuon] N'Ngày Mượn', [HanTra] N'Hạn Trả', [DaTraXong] N'Xong' FROM [PhieuMuon]";

            DataTable dTable = DataProvider.Instance.ExecuteQuery(query);

            return dTable;
            }

        public int TaoPhieuMuon(PhieuMuonDTO phieuMuon)
            {
            object[] obj = new object[] { phieuMuon.MaPM, phieuMuon.MaDG, phieuMuon.TaiKhoan, phieuMuon.NgayMuon, phieuMuon.HanTra, phieuMuon.DaTraXong };

            string query = "INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaDG],[TaiKhoan],[NgayMuon],[HanTra],[DaTraXong])" +
                "VALUES( @MaPM , @MaDG , @TaiKhoan , @NgayMuon , @HanTra , @DaTraXong )";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
            }
        }

        public int XoaPhieuMuon(string maPhieuMuon)
        {
            object[] obj = new object[] { maPhieuMuon };

            string query = "DELETE FROM [dbo].[PhieuMuon] WHERE [MaPM] = @maPM";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
            }

        public int SuaPhieuMuon(PhieuMuonDTO phieuMuon)
            {
            object[] obj = new object[] { phieuMuon.MaDG, phieuMuon.TaiKhoan, phieuMuon.NgayMuon, phieuMuon.HanTra, phieuMuon.DaTraXong, phieuMuon.MaPM };

            string query = "UPDATE [dbo].[PhieuMuon] SET [MaDG] = @MaDG ,[TaiKhoan] = @TaiKhoan ,[NgayMuon] = @NgayMuon ,[HanTra] = @HanTra ,[DaTraXong] = @DaTraXong WHERE [MaPM] = @MaPM";

            return DataProvider.Instance.ExecuteNonQuery(query, obj);
            }
        }
}
