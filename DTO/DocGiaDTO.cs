using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
     class DocGiaDTO
    {
        private string maDG;
        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }
        private string tenDG;
        public string TenDG
        { 
            get { return tenDG; }
            set { tenDG = value; }
        }
        private DateTime ngaySinh;
        public DateTime NgaySinh
        { 
            get { return ngaySinh; } 
            set {  ngaySinh = value; } 
        }
        private bool gioiTinh;
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }  
            set { diaChi = value; }
        }
        private string sDT;
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }  
            set { email = value; }
        }
            
        
    }
}
