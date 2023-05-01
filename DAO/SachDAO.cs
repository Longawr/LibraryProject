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
            try
            {
                string sql = "select * from Sach";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TheLoai()
        {
            try
            {
                string sql = "select * from LoaiSach";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TimKiemTheoTen(string TenSach)
        {
            try
            {
                object[] pmt = new object[] { TenSach};
                string sql = "select * from Sach where TenSach like @TenSach";
                    
                return DataProvider.Instance.ExecuteQuery(sql, pmt);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        public DataTable LocSach(string MaLoai)
        {
            try
            {
                object[] pmt = new object[] { MaLoai };
                string sql = "select Sach.* from Sach, LoaiSach where Sach.MaLoai like LoaiSach.MaLoai and LoaiSach.MaLoai = @MaLoai";

                return DataProvider.Instance.ExecuteQuery(sql,pmt);
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
            } catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public bool Sua(string MaSach, SachDTO sach)
        {
            try
            {
                string sql = "update Sach set TenSach = @TenSach , " +
                "MaTacGia = @MaTacGia , " +
               "MaXB = @MaXB , " +
               "MaLoai = @MaLoai , " +
               "SoTrang = @SoTrang , " +
                "GiaBan = @GiaBan , " +
                "SoLuong = @SoLuong " +
                "where MaSach = @OldMaSach";
                object[] pmt = new object[] {sach.TenSach,
                sach.MaTacGia, sach.MaXB, sach.MaLoai, sach.SoTrang,
                sach.GiaBan, sach.SoLuong , MaSach};

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
                "@MaTacGia , " +
               "@MaXB , " +
               "@MaLoai , " +
               "@SoTrang , " +
                "@GiaBan , " +
                "@SoLuong )";
            object[] pmt = new object[] {sach.MaSach, sach.TenSach,
                sach.MaTacGia, sach.MaXB, sach.MaLoai, sach.SoTrang,
                sach.GiaBan, sach.SoLuong};

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
