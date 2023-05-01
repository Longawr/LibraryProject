using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public NhanVienDTO(string maNhanVien, string tenNhanVien = null, string email = null, string gioiTinh = null, string diaChi = null)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            Email = email;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public NhanVienDTO() { }

        public override bool Equals(object obj)
        {
            return obj is NhanVienDTO dTO &&
                   MaNhanVien == dTO.MaNhanVien &&
                   TenNhanVien == dTO.TenNhanVien &&
                   Email == dTO.Email &&
                   GioiTinh == dTO.GioiTinh &&
                   DiaChi == dTO.DiaChi;
        }

        public override int GetHashCode()
        {
            int hashCode = 739105931;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaNhanVien);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TenNhanVien);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GioiTinh);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiaChi);
            return hashCode;
        }
    }
}
