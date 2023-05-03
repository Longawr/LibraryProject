//using LibraryProject.Controller;
using LibraryProject.DAO;
using LibraryProject.DTO;
using System.Windows.Forms;

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

        /*public void TheLoai(DataGridView data)
        {
            data.DataSource = SachDAO.Instance.TheLoai();
        }*/

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


            string MaSach = row.Cells["MaSach"].Value.ToString();
            string TenSach = row.Cells["TenSach"].Value.ToString();
            int SoLuong = (int)row.Cells["SoLuong"].Value;
            int TonKho = (int)row.Cells["TonKho"].Value;
            int GiaTri = (int)row.Cells["GiaTri"].Value;
            string MaLoai = row.Cells["MaLoai"].Value.ToString();
            string MaTG = row.Cells["MaTG"].Value.ToString();
            string MaNXB = row.Cells["MaNXB"].Value.ToString();
            int NamXB = (int)row.Cells["NamXB"].Value;



            SachDTO sach = new SachDTO()
            {
                MaSach = MaSach,
                TenSach = TenSach,
                SoLuong = SoLuong,
                TonKho = TonKho,
                GiaTri = GiaTri,
                MaLoai = MaLoai,
                MaTG = MaTG,
                MaNXB = MaNXB,
                NamXB = NamXB
            };

            return SachDAO.Instance.Sua(OldMaSach, sach);
        }

        public bool Them(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            //string OldMaSach = data.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();


            string MaSach = row.Cells["MaSach"].Value.ToString();
            string TenSach = row.Cells["TenSach"].Value.ToString();
            int SoLuong = (int)row.Cells["SoLuong"].Value;
            int TonKho = (int)row.Cells["TonKho"].Value;
            int GiaTri = (int)row.Cells["GiaTri"].Value;
            string MaLoai = row.Cells["MaLoai"].Value.ToString();
            string MaTG = row.Cells["MaTG"].Value.ToString();
            string MaNXB = row.Cells["MaNXB"].Value.ToString();
            int NamXB = (int)row.Cells["NamXB"].Value;

            SachDTO sach = new SachDTO()
            {
                MaSach = MaSach,
                TenSach = TenSach,
                SoLuong = SoLuong,
                TonKho = TonKho,
                GiaTri = GiaTri,
                MaLoai = MaLoai,
                MaTG = MaTG,
                MaNXB = MaNXB,
                NamXB = NamXB
            };

            return SachDAO.Instance.Them(sach);
        }

    }
}
