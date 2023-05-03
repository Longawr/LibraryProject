using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class ChiTietPMDTO
    {
        public string MaCTPM { get; set; }
        public string MaPM { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }
        public int DaTra { get; set; }

        public ChiTietPMDTO() { }

        public ChiTietPMDTO(string maCTPM, string maPM, string maSach, int soLuong, int daTra)
        {
            MaCTPM = maCTPM;
            MaPM = maPM;
            MaSach = maSach;
            SoLuong = soLuong;
            DaTra = daTra;
        }

        public override bool Equals(object obj)
        {
            return obj is ChiTietPMDTO pMDTO &&
                   MaCTPM == pMDTO.MaCTPM &&
                   MaPM == pMDTO.MaPM &&
                   MaSach == pMDTO.MaSach &&
                   SoLuong == pMDTO.SoLuong &&
                   DaTra == pMDTO.DaTra;
        }

        public override int GetHashCode()
        {
            int hashCode = -393521308;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaCTPM);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaPM);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaSach);
            hashCode = hashCode * -1521134295 + SoLuong.GetHashCode();
            hashCode = hashCode * -1521134295 + DaTra.GetHashCode();
            return hashCode;
        }
    }
}
