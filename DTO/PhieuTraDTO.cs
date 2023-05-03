using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class PhieuTraDTO
    {
        public string MaPT { get; set; }
        public string TaiKhoan { get; set; }
        public string MaPM { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTra { get; set; }

        public PhieuTraDTO() { }

        public PhieuTraDTO(string maPT, string taiKhoan, string maPM, string maSach, int soLuong, DateTime ngayTra)
        {
            MaPT = maPT;
            TaiKhoan = taiKhoan;
            MaPM = maPM;
            MaSach = maSach;
            SoLuong = soLuong;
            NgayTra = ngayTra;
        }

        public override bool Equals(object obj)
        {
            return obj is PhieuTraDTO dTO &&
                   MaPT == dTO.MaPT &&
                   TaiKhoan == dTO.TaiKhoan &&
                   MaPM == dTO.MaPM &&
                   MaSach == dTO.MaSach &&
                   SoLuong == dTO.SoLuong &&
                   NgayTra == dTO.NgayTra;
        }

        public override int GetHashCode()
        {
            int hashCode = -1794126166;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaPT);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TaiKhoan);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaPM);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaSach);
            hashCode = hashCode * -1521134295 + SoLuong.GetHashCode();
            hashCode = hashCode * -1521134295 + NgayTra.GetHashCode();
            return hashCode;
        }
    }
}
