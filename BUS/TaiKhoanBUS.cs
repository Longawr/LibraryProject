using LibraryProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private TaiKhoanBUS() { }

        public bool DangNhap(String uname, String upass)
        {
            return TaiKhoanDAO.Instance.DangNhap(uname, upass);
        }

        public static void DangXuat()
        {
            NhanVienBUS.currentNhanVien = null;
            TaiKhoanDAO.Instance.DangXuat();
        }
    }
}
