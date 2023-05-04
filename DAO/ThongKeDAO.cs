using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private ThongKeDAO() { }

        public int XemSoSach()
        {
            string query = "SELECT COUNT(*) FROM Sach";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public int TongSoSach()
        {
            string query = "SELECT SUM(SoLuong) AS TongSoLuongTon FROM Sach";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public int XemSoTheLoai()
        {
            string query = "SELECT COUNT(*) FROM TheLoai";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public int XemSoTacGia()
        {
            string query = "SELECT COUNT(*) FROM TacGia";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        
        public int XemSoNXB()
        {
            string query = "SELECT COUNT(*) FROM NXB";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public int XemSoDocGia()
        {
            string query = "SELECT COUNT(*) FROM DocGia";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public int XemSoNhanVien()
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable XemDangMuon()
        {
            string query = "SELECT DG.MaDG, DG.TenDG, DG.DiaChi, DG.SDT, PM.MaPM, PM.NgayMuon, PM.HanTra " +
                        "FROM DOCGIA DG " +
                        "JOIN PHIEUMUON PM ON DG.MaDG = PM.MaDG " +
                        "JOIN CTPM ON PM.MaPM = CTPM.MaPM " +
                        "JOIN SACH ON CTPM.MaSach = SACH.MaSach " +
                        "WHERE PM.HanTra >= GETDATE()";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int XemSoDangMuon()
        {
            string query = "SELECT COUNT(*) FROM PhieuMuon WHERE HanTra >= GETDATE() ";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable XemQuaHan()
        {
            string query = "SELECT DG.MaDG, DG.TenDG, DG.DiaChi, DG.SDT, PM.MaPM, PM.NgayMuon, PM.HanTra " +
                        "FROM DOCGIA DG " +
                        "JOIN PHIEUMUON PM ON DG.MaDG = PM.MaDG " +
                        "WHERE PM.HanTra < GETDATE()";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int XemSoQuaHan()
        {
            string query = "SELECT COUNT(*) FROM PhieuMuon WHERE HanTra < GETDATE() ";
            return DataProvider.Instance.ExecuteScalar(query);
        }
        public DataTable BieuDoMuon()
        {
            string query = "SELECT MONTH(NgayMuon) AS Thang, COUNT(*) AS SoLuotMuon FROM PHIEUMUON GROUP BY MONTH(NgayMuon)";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable BieuDoTra()
        {
            string query = "SELECT MONTH(NgayTra) AS Thang, COUNT(*) AS SoLuotTra FROM PHIEUTRA GROUP BY MONTH(NgayTra)";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TopDocGia()
        {
            string query = "SELECT TOP 5 pm.MADG, dg.TenDG, COUNT(*) as SoLuotMuon\r\n                        FROM PhieuMuon pm\r\n                        JOIN CTPM ct ON pm.MaPM = ct.MaPM\r\n                        JOIN DocGia dg ON pm.MaDG = dg.MaDG\r\n                        GROUP BY pm.MaDG, dg.TenDG\r\n                        ORDER BY SoLuotMuon DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable TopSach()
        {
            string query = "SELECT TOP 5 Sach.MaSach, Sach.TenSach, COUNT(CTPM.MaSach) AS SoLuotMuon\r\nFROM Sach\r\nINNER JOIN CTPM ON Sach.MaSach = CTPM.MaSach\r\nGROUP BY Sach.MaSach, Sach.TenSach\r\nORDER BY SoLuotMuon DESC\r\n";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
