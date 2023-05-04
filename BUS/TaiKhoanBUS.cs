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

        public void DangXuat()
        {
            ThuThuBUS.currentNhanVien = new DTO.ThuThuDTO();
            TaiKhoanDAO.Instance.DangXuat();
        }

        public bool XacNhanMK(string matKhau)
        {
            string username = ThuThuBUS.currentNhanVien.MaThuThu;
            return TaiKhoanDAO.Instance.XacNhanTkMk(username, matKhau);
        }

        public void DoiMatKhau(string mkMoi)
        {
            string username = ThuThuBUS.currentNhanVien.MaThuThu;
            TaiKhoanDAO.Instance.DoiMatKhau(username, mkMoi);
        }

        public bool TaoTaiKhoan(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaThuThu = row.Cells["Mã"].Value.ToString();
            string MatKhau = row.Cells["Mật Khẩu"].Value.ToString();
            string ChucVu = row.Cells["Chức vụ"].Value.ToString();

            TaiKhoanDTO taiKhoan = new TaiKhoanDTO()
            {
                TaiKhoan = MaThuThu,
                MatKhau = MatKhau,
                ChucVu = ChucVu
            };
            return TaiKhoanDAO.Instance.TaoTaiKhoan(taiKhoan);
        }

        public bool XoaTaiKhoan(DataGridView data)
        {
            string MaThuThu = data.SelectedCells[0].OwningRow.Cells["MaThuThu"].Value.ToString();
            return TaiKhoanDAO.Instance.XoaTaiKhoan(MaThuThu);
        }

        public bool SuaTaiKhoan(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaThuThu = row.Cells["Mã"].Value.ToString();
            string MatKhau = row.Cells["Mật Khẩu"].Value.ToString();
            string ChucVu = row.Cells["Chức vụ"].Value.ToString();

            TaiKhoanDTO taiKhoan = new TaiKhoanDTO()
            {
                TaiKhoan = MaThuThu,
                MatKhau = MatKhau,
                ChucVu = ChucVu
            };
            return TaiKhoanDAO.Instance.SuaTaiKhoan(taiKhoan);
        }
    }
}
