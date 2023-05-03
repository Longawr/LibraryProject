using LibraryProject.DAO;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class DocGiaBUS
    {
        private static DocGiaBUS instance;
        public static DocGiaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DocGiaBUS();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private DocGiaBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = DocGiaDAO.Instance.Xem();
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataProducer.Instance.TaoSearchCol(data);
        }
        public bool XoatheoMaDG(DataGridView data)
        {
            string MaDG = data.SelectedCells[0].OwningRow.Cells["Mã độc giả"].Value.ToString();

            return DocGiaDAO.Instance.XoatheoMaDG(MaDG);

        }
        public bool Sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string oldMaDG = row.Cells["Mã độc giả"].Value.ToString();

            string maDG = row.Cells["Mã độc giả"].Value.ToString();
            string tenDG = row.Cells["Tên độc giả"].Value.ToString();
            DateTime ngaySinh = (DateTime)row.Cells["Ngày sinh"].Value;
            string diaChi = row.Cells["Địa chỉ"].Value.ToString();
            bool gioiTinh = (bool)row.Cells["Giới tính"].Value;
            string sDT = row.Cells["SĐT"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();


            DocGiaDTO Docgia = new DocGiaDTO() { MaDG = maDG, TenDG = tenDG, NgaySinh = ngaySinh, DiaChi = diaChi, GioiTinh = gioiTinh, SDT = sDT, Email = email };


            return DocGiaDAO.Instance.Sua(oldMaDG, Docgia);
        }
        public bool Them(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;


            string maDG = row.Cells["Mã độc giả"].Value.ToString();
            string tenDG = row.Cells["Tên độc giả"].Value.ToString();
            DateTime ngaySinh = new DateTime(1900, 1, 1);
            try
            {
                ngaySinh = ((DateTime)row.Cells["Ngày sinh"].Value);
            }
            catch { }

            string diaChi = row.Cells["Địa chỉ"].Value.ToString();
            bool gioiTinh = false;
            try
            {

                gioiTinh = (bool)row.Cells["Giới tính"].Value;
            }
            catch { }

            string sDT = row.Cells["SĐT"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();

            DocGiaDTO docGia = new DocGiaDTO() { MaDG = maDG, TenDG = tenDG, NgaySinh = ngaySinh, DiaChi = diaChi, GioiTinh = gioiTinh, SDT = sDT, Email = email };


            return DocGiaDAO.Instance.Them(docGia);
        }
    }
}
