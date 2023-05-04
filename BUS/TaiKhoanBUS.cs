using LibraryProject.DAO;
using LibraryProject.DTO;
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

        public bool TaoTaiKhoanMoi(TaiKhoanDTO taiKhoan)
        {
            TaiKhoanDAO.Instance.TaoTaiKhoanMoi(taiKhoan);
            return TaiKhoanDAO.Instance.TaoTaiKhoanMoi(taiKhoan);
        }

        public bool Xoa(DataGridView data)
        {
            string MaThuThu = data.SelectedCells[0].OwningRow.Cells["MaThuThu"].Value.ToString();
            return TaiKhoanDAO.Instance.Xoa(MaThuThu);
        }
    }
}
