using LibraryProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return TaiKhoanDAO.Instance.XacNhanTkMk(uname, upass);
        }

        public static void DangXuat()
        {
            NhanVienBUS.currentNhanVien = new DTO.NhanVienDTO();
            TaiKhoanDAO.Instance.DangXuat();
        }

        public bool XacNhanMK(string matKhau)
        {
            string username = NhanVienBUS.currentNhanVien.MaNhanVien;
            return TaiKhoanDAO.Instance.XacNhanTkMk(username, matKhau);
        }

        public void DoiMatKhau(string mkMoi)
        {
            string username = NhanVienBUS.currentNhanVien.MaNhanVien;
            TaiKhoanDAO.Instance.DoiMatKhau(username, mkMoi);
        }
    }
}
