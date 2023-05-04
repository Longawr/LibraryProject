using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class ThuThuDTO
    {
        public string MaThuThu { get; set; }
        public string TenThuThu { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public ThuThuDTO(string maNhanVien, string tenNhanVien, DateTime ngaySinh, bool gioiTinh, string diaChi, string soDienThoai, string email)
        {
            MaThuThu = maNhanVien;
            TenThuThu = tenNhanVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = soDienThoai;
            Email = email;
        }

        public ThuThuDTO() { }

        public override bool Equals(object obj)
        {
            return obj is ThuThuDTO dTO &&
                   MaThuThu == dTO.MaThuThu &&
                   TenThuThu == dTO.TenThuThu &&
                   NgaySinh == dTO.NgaySinh &&
                   GioiTinh == dTO.GioiTinh &&
                   DiaChi == dTO.DiaChi &&
                   SDT == dTO.SDT &&
                   Email == dTO.Email;
        }

        public override int GetHashCode()
        {
            int hashCode = 1329759879;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaThuThu);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TenThuThu);
            hashCode = hashCode * -1521134295 + NgaySinh.GetHashCode();
            hashCode = hashCode * -1521134295 + GioiTinh.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiaChi);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SDT);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
