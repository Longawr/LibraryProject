using LibraryProject.DAO;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class NhanVienBUS
    {
        public static NhanVienDTO currentNhanVien = new NhanVienDTO();

        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private NhanVienBUS() { }

        internal void AddCurrentNhanVien(string id)
        {
            DataTable dtable = NhanVienDAO.Instance.GetNhanVienbyId(id);
            if (dtable.Rows.Count > 0)
            {
                DataRow dRow = dtable.Rows[0];
                currentNhanVien.MaNhanVien = dRow[0].ToString();
                currentNhanVien.TenNhanVien = dRow[1] != null ? dRow[1].ToString() : "";
                currentNhanVien.NgaySinh = (DateTime)dRow[2];
                currentNhanVien.GioiTinh = (bool)dRow[3];
                currentNhanVien.DiaChi = dRow[4] != null ? dRow[4].ToString() : "";
                currentNhanVien.SoDienThoai = dRow[5] != null ? dRow[5].ToString() : "";
                currentNhanVien.Email = dRow[6] != null ? dRow[6].ToString() : "";
            }
        }

        public bool SuaCurrentNhanVien(string maNV, string tenNV, DateTime ngaySinh, string soDienThoai, string email, bool gioiTinh, string diaChi)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNhanVien = currentNhanVien.MaNhanVien;
            nhanVien.TenNhanVien = tenNV;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.DiaChi = diaChi;
            nhanVien.SoDienThoai = soDienThoai;
            nhanVien.Email = email;
            if (NhanVienDAO.Instance.SuaNhanVien(nhanVien.MaNhanVien, nhanVien))
            {
                currentNhanVien = nhanVien;
                return true;
            }
            return false;
        }
    }
}
