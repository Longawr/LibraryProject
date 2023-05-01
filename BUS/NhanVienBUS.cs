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
                currentNhanVien.TenNhanVien = dRow[0] != null ? dRow[1].ToString() : "";
                currentNhanVien.Email = dRow[0] != null ? dRow[2].ToString() : "";
                currentNhanVien.GioiTinh = dRow[0] != null ? dRow[3].ToString() : "";
                currentNhanVien.DiaChi = dRow[0] != null ? dRow[4].ToString() : "";
            }
        }

        public bool SuaCurrentNhanVien(string maNV, string tenNV, string email, string gioiTinh, string diaChi)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNhanVien = currentNhanVien.MaNhanVien;
            nhanVien.TenNhanVien = tenNV;
            nhanVien.Email = email;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.DiaChi = diaChi;
            if (NhanVienDAO.Instance.SuaNhanVien(maNV, nhanVien))
            {
                currentNhanVien = nhanVien;
                return true;
            }
            return false;
        }
    }
}
