using LibraryProject.Controllers;
using LibraryProject.DAO;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryProject.DAO.SachDAO;

namespace LibraryProject.BUS
{
    class SachBUS
    {
        
        private static SachBUS instance;
        public static SachBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachBUS();
                return instance;
            }
            //set => instance = value;
        }

        public SachBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = SachDAO.Instance.Xem();
        }

        public void TheLoai(DataGridView data)
        {
            data.DataSource = SachDAO.Instance.TheLoai();
        }

        public void TimKiemTheoTen(DataGridView data, string TenSach)
        {
            data.DataSource = SachDAO.Instance.TimKiemTheoTen(TenSach);
        }

        public void LocSach(DataGridView data, string MaLoai)
        {
            data.DataSource = SachDAO.Instance.LocSach(MaLoai);
        }

        public bool Xoa(DataGridView data)
        {
            string TenSach = data.SelectedCells[0].OwningRow.Cells["TenSach"].Value.ToString();
            return SachDAO.Instance.Xoa(TenSach);
        }

        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string OldMaSach = data.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
            

            string id = row.Cells["MaSach"].Value.ToString();
            string Ten = row.Cells["TenSach"].Value.ToString();
            string TacGia = row.Cells["MaTacGia"].Value.ToString();
            string XB = row.Cells["MaXB"].Value.ToString();
            string maLoai = row.Cells["MaLoai"].Value.ToString();
            int soTrang = (int)row.Cells["SoTrang"].Value;
            int giaBan = (int)row.Cells["GiaBan"].Value;
            int soLuong = (int)row.Cells["SoLuong"].Value;

            SachDTO sach = new SachDTO()
            {
                MaSach = id,
                TenSach = Ten,
                MaTacGia = TacGia,
                MaXB = XB,
                MaLoai = maLoai,
                SoTrang = soTrang,
                GiaBan = giaBan,
                SoLuong = soLuong
            };

            return SachDAO.Instance.Sua(OldMaSach, sach);
        }

        public bool Them(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            //string OldMaSach = data.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();


            string id = row.Cells["MaSach"].Value.ToString();
            string Ten = row.Cells["TenSach"].Value.ToString();
            string TacGia = row.Cells["MaTacGia"].Value.ToString();
            string XB = row.Cells["MaXB"].Value.ToString();
            string maLoai = row.Cells["MaLoai"].Value.ToString();
            int soTrang = (int)row.Cells["SoTrang"].Value;
            int giaBan = (int)row.Cells["GiaBan"].Value;
            int soLuong = (int)row.Cells["SoLuong"].Value;

            SachDTO sach = new SachDTO()
            {
                MaSach = id,
                TenSach = Ten,
                MaTacGia = TacGia,
                MaXB = XB,
                MaLoai = maLoai,
                SoTrang = soTrang,
                GiaBan = giaBan,
                SoLuong = soLuong
            };

            return SachDAO.Instance.Them(sach);
        }

    }
}
