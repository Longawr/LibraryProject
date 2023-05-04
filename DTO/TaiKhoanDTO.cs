using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class TaiKhoanDTO
    {
        private string taiKhoan;
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string chucVu;
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
    }
}
