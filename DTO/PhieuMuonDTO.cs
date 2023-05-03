using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class PhieuMuonDTO
    {
        public string MaPM { get; set; }
        public string MaDG { get; set; }
        public string TaiKhoan { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public bool DaTraXong { get; set; }
        
        public PhieuMuonDTO() { }

        public PhieuMuonDTO(string maPM, string maDG, string taiKhoan, DateTime ngayMuon, DateTime hanTra, bool daTraXong)
            {
            MaPM = maPM;
            MaDG = maDG;
            TaiKhoan = taiKhoan;
            NgayMuon = ngayMuon;
            HanTra = hanTra;
            DaTraXong = daTraXong;
            }

        public override bool Equals(object obj)
        {
            return obj is PhieuMuonDTO dTO &&
                   MaPM == dTO.MaPM &&
                   MaDG == dTO.MaDG &&
                   TaiKhoan == dTO.TaiKhoan &&
                   NgayMuon == dTO.NgayMuon &&
                   HanTra == dTO.HanTra &&
                   DaTraXong == dTO.DaTraXong;
        }
           
        public override int GetHashCode()
        {
            int hashCode = -173499981;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaPM);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MaDG);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TaiKhoan);
            hashCode = hashCode * -1521134295 + NgayMuon.GetHashCode();
            hashCode = hashCode * -1521134295 + HanTra.GetHashCode();
            hashCode = hashCode * -1521134295 + DaTraXong.GetHashCode();
            return hashCode;
        }
    }
}