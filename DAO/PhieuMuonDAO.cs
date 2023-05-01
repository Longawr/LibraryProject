using LibraryProject.BUS;
using LibraryProject.Controllers;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            try
            {
                string sql = "select * from MuonTraSach";
                return DataProvider.Instance.ExecuteQuery(sql);
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
