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
    class PhieuTraBUS
    {
        private static PhieuTraBUS instance;

        public static PhieuTraBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private PhieuTraBUS() { }

        public void XemPhieuTra(DataGridView data)
        {
            data.DataSource = PhieuTraDAO.Instance.XemPhieuTra();
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //data.Columns["Mã Trả"].ReadOnly = true;
            DataProducer.Instance.TaoSearchCol(data);
        }

        public bool TraSach(DataGridView dataMain, int soLuong)
        {
            PhieuTraDTO phieuTra = new PhieuTraDTO();
            phieuTra.MaPT = "PT" + phieuTra.MaPM.Substring(3) + phieuTra.MaSach.Substring(2) + DateTime.Now.ToString("yyyyMMdd").Substring(6) + DateTime.Now.ToString("HHmmss").Remove(2);
            phieuTra.TaiKhoan = NhanVienBUS.currentNhanVien.MaNhanVien;
            phieuTra.MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            phieuTra.MaSach = dataMain.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();
            phieuTra.SoLuong = soLuong;
            phieuTra.NgayTra = DateTime.Now;

            if (PhieuTraDAO.Instance.ThemPhieuTra(phieuTra) > 0)
            {
                if (int.TryParse(dataMain.SelectedCells[0].OwningRow.Cells["Đã Trả"].Value.ToString(), out int value))
                    dataMain.SelectedCells[0].OwningRow.Cells["Đã Trả"].Value = value + soLuong;
                return true;
            }
            return false;
        }

        public bool TaoPhieuTra(DataGridView dataMain)
        {
            PhieuTraDTO phieuTra = new PhieuTraDTO();

            string TaiKhoan = dataMain.SelectedCells[0].OwningRow.Cells["Thủ Thư"].Value.ToString();
            if (TaiKhoan != String.Empty)
                phieuTra.TaiKhoan = TaiKhoan;
            else
                phieuTra.TaiKhoan = NhanVienBUS.currentNhanVien.MaNhanVien;

            phieuTra.MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            phieuTra.MaSach = dataMain.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();

            if (int.TryParse(dataMain.SelectedCells[0].OwningRow.Cells["Số Lượng"].Value.ToString(), out int soLuong))
                phieuTra.SoLuong = soLuong;
            else
                phieuTra.SoLuong = 0;

            string MaTra = dataMain.SelectedCells[0].OwningRow.Cells["Mã Trả"].Value.ToString();
            if (MaTra != String.Empty)
                phieuTra.MaPT = MaTra;
            else
                phieuTra.MaPT = "PT" + phieuTra.MaPM.Substring(3) + phieuTra.MaSach.Substring(2) + DateTime.Now.ToString("yyyyMMdd").Substring(6) + DateTime.Now.ToString("HHmmss").Remove(2);

            phieuTra.NgayTra = DateTime.Now;
            try
            {
                phieuTra.NgayTra = (DateTime)dataMain.SelectedCells[0].OwningRow.Cells["Ngày Trả"].Value;
            }
            catch { }

            return PhieuTraDAO.Instance.ThemPhieuTra(phieuTra) > 0;
        }

        public bool XoaPhieuTra(DataGridView dataMain)
        {
            string MaTra = dataMain.SelectedCells[0].OwningRow.Cells["Mã Trả"].Value.ToString();
            return (PhieuTraDAO.Instance.XoaPhieuTra(MaTra) > 0);
        }

        public bool SuaPhieuTra(DataGridView dataMain)
        {
            PhieuTraDTO phieuTra = new PhieuTraDTO();

            phieuTra.MaPT = dataMain.SelectedCells[0].OwningRow.Cells["Mã Trả"].Value.ToString();
            phieuTra.TaiKhoan = NhanVienBUS.currentNhanVien.MaNhanVien;
            try
            {
                phieuTra.TaiKhoan = dataMain.SelectedCells[0].OwningRow.Cells["Thủ Thư"].Value.ToString();
            }
            catch { }
            phieuTra.MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            phieuTra.MaSach = dataMain.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();
            if (int.TryParse(dataMain.SelectedCells[0].OwningRow.Cells["Số Lượng"].Value.ToString(), out int soLuong))
                phieuTra.SoLuong = soLuong;
            else
                phieuTra.SoLuong = 0;
            phieuTra.NgayTra = DateTime.Now;
            try
            {
                phieuTra.NgayTra = (DateTime)dataMain.SelectedCells[0].OwningRow.Cells["Ngày Trả"].Value;
            }
            catch { }

            return PhieuTraDAO.Instance.SuaPhieuTra(phieuTra) > 0;
        }
    }
}
