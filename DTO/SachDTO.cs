using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DTO
{
    class SachDTO
    {
        private string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private string tenSach;

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }

        private string maTacGia;

        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

        private string maXB;

        public string MaXB
        {
            get { return maXB; }
            set { maXB = value; }
        }

        private string maLoai;

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }

        private int giaBan;

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
