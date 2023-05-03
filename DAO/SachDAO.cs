using LibraryProject.DTO;
using System;
using System.Data;

namespace LibraryProject.DAO
{
    class SachDAO
    {

        private static SachDAO instance;
        public static SachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachDAO();
                return instance;
            }
            //set => instance = value;
        }

        public SachDAO() { }

        public DataTable Xem()
        {
                string sql = "select * from Sach";
                return DataProvider.Instance.ExecuteQuery(sql);
            }

        /*public DataTable TheLoai()
        {
            try
            {
                string sql = "select * from TheLoai";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public DataTable TimKiemTheoTen(string TenSach)
        {
            try
            {
                object[] pmt = new object[] { "%" + TenSach + "%" };
                string sql = "select * from Sach where TenSach like @TenSach";
                    
                return DataProvider.Instance.ExecuteQuery(sql, pmt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LocSach(string MaLoai)
        {
            try
            {
                object[] pmt = new object[] { MaLoai };
                string sql = "select * from Sach where MaLoai = @MaLoai ";

                return DataProvider.Instance.ExecuteQuery(sql, pmt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public bool Xoa(string TenSach)
        {
            try
            {
                string sql = "delete from Sach where TenSach = @TenSach";
                object[] pmt = new object[] { TenSach };
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

        public bool Sua(string MaSach, SachDTO sach)
        {
            try
            {
                string sql = "update Sach set TenSach = @TenSach , " +
                "SoLuong = @SoLuong , " +
               "TonKho = @TonKho , " +
               "GiaTri = @GiaTri , " +
               "MaLoai = @MaLoai , " +
                "MaTG = @MaTG , " +
                "MaNXB = @MaNXB , " +
                "NamXB = @NamXB " +
                "where MaSach = @OldMaSach";
                object[] pmt = new object[] {sach.TenSach,
                sach.SoLuong, sach.TonKho, sach.GiaTri, sach.MaLoai, sach.MaTG,
                sach.MaNXB, sach.NamXB , MaSach};

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

        public bool Them(SachDTO sach)
        {
            try
            {
                string sql = "insert into Sach values( @MaSach , " +
                "@TenSach , " +
                "@SoLuong , " +
               "@TonKho , " +
               "@GiaTri , " +
               "@MaLoai , " +
               "@MaTG , " +
                "@MaNXB , " +
                "@NamXB )";
            object[] pmt = new object[] {sach.MaSach, sach.TenSach,
                sach.SoLuong, sach.TonKho, sach.GiaTri, sach.MaLoai, sach.MaTG,
                sach.MaNXB, sach.NamXB };

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
