using LibraryProject.DAO;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class ThuThuBUS
    {
        private static ThuThuBUS instance;
        public static ThuThuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThuThuBUS();
                return instance;
            }
            //set => instance = value;
        }

        public ThuThuBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = ThuThuDAO.Instance.Xem();
        }

        public void TimKiemTheoMaThuThu(DataGridView data, string MaThuThu)
        {
            data.DataSource = ThuThuDAO.Instance.TimKiemMaThuThu(MaThuThu);
        }

        public void ThemThuThu(ThuThuDTO thuThu)
        {
            /*DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string MaThuThu = row.Cells["MaThuThu"].Value.ToString();
            string TenThuThu = row.Cells["TenThuThu"].Value.ToString();
            DateTime NgaySinh = (DateTime)row.Cells["NgaySinh"].Value;
            bool GioiTinh = (bool)row.Cells["GioiTinh"].Value;
            string DiaChi = row.Cells["DiaChi"].Value.ToString();
            string SDT = row.Cells["SDT"].Value.ToString();
            string Email = row.Cells["Email"].Value.ToString();

            ThuThuDTO thuThu = new ThuThuDTO()
            {
                MaThuThu = MaThuThu,
                TenThuThu = TenThuThu,
                NgaySinh = NgaySinh,
                GioiTinh = GioiTinh,
                DiaChi = DiaChi,
                SDT = SDT,
                Email = Email
            };

            return ThuThuDAO.Instance.ThemThuThu(thuThu);*/

            ThuThuDAO.Instance.ThemThuThu(thuThu);
            //return ThuThuDAO.Instance.ThemThuThu(thuThu);
        }

        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string OldMaThuThu = data.SelectedCells[0].OwningRow.Cells["MaThuThu"].Value.ToString();


            string MaThuThu = row.Cells["MaThuThu"].Value.ToString();
            string TenThuThu = row.Cells["TenThuThu"].Value.ToString();
            DateTime NgaySinh = (DateTime)row.Cells["NgaySinh"].Value;
            bool GioiTinh = (bool)row.Cells["GioiTinh"].Value;
            string DiaChi = row.Cells["DiaChi"].Value.ToString();
            string SDT = row.Cells["SDT"].Value.ToString();
            string Email = row.Cells["Email"].Value.ToString();



            ThuThuDTO thuthu = new ThuThuDTO
            {
                MaThuThu = MaThuThu,
                TenThuThu = TenThuThu,
                NgaySinh = NgaySinh,
                GioiTinh = GioiTinh,
                DiaChi = DiaChi,
                SDT = SDT,
                Email = Email,
            };

            return ThuThuDAO.Instance.Sua(OldMaThuThu, thuthu);
        }

        public bool Xoa(DataGridView data)
        {
            string MaThuThu = data.SelectedCells[0].OwningRow.Cells["MaThuThu"].Value.ToString();
            return ThuThuDAO.Instance.Xoa(MaThuThu);
        }
    }

}
