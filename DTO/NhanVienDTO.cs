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
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public NhanVienDTO(string maNhanVien, string tenNhanVien, DateTime ngaySinh, bool gioiTinh, string diaChi, string soDienThoai, string email)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }

        public NhanVienDTO() { }

        public override bool Equals(object obj)
        {
            return obj is NhanVienDTO dTO &&
                   MaNhanVien == dTO.MaNhanVien &&
                   TenNhanVien == dTO.TenNhanVien &&
                   NgaySinh == dTO.NgaySinh &&
                   GioiTinh == dTO.GioiTinh &&
                   DiaChi == dTO.DiaChi &&
                   SoDienThoai == dTO.SoDienThoai &&
                   Email == dTO.Email;
        }

        public override int GetHashCode()
        {
            int hashCode = 1329759879;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaNhanVien);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TenNhanVien);
            hashCode = hashCode * -1521134295 + NgaySinh.GetHashCode();
            hashCode = hashCode * -1521134295 + GioiTinh.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiaChi);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SoDienThoai);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
