using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class ThuThuDTO
    {
        private string maThuThu;
        public string MaThuThu
        {
            get { return maThuThu; }
            set { maThuThu = value; }
        }

        private string tenThuThu;
        public string TenThuThu
        {
            get { return tenThuThu; }
            set { tenThuThu = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
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

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
