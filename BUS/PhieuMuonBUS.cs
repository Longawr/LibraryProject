using LibraryProject.DAO;
using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class PhieuMuonBUS
    {
        private static PhieuMuonBUS instance;

        public static PhieuMuonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private PhieuMuonBUS() { }

        public void XemPhieuMuon(DataGridView data)
        {
            data.DataSource = PhieuMuonDAO.Instance.XemPhieuMuon();
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataProducer.Instance.TaoSearchCol(data);
        }

        public bool ThemPhieuMuon(DataGridView dataMain)
        {
            PhieuMuonDTO phieuMuon = new PhieuMuonDTO
            {
                MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString(),
                MaDG = dataMain.SelectedCells[0].OwningRow.Cells["Độc Giả"].Value.ToString(),
                TaiKhoan = NhanVienBUS.currentNhanVien.MaNhanVien,
                NgayMuon = DateTime.Now,
                HanTra = (DateTime)dataMain.SelectedCells[0].OwningRow.Cells["Hạn Trả"].Value,
                DaTraXong = false
            };

            return (PhieuMuonDAO.Instance.TaoPhieuMuon(phieuMuon) > 0);
        }

        public bool XoaPhieuMuon(DataGridView dataMain)
        {
            string MaPhieuMuon = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            return (PhieuMuonDAO.Instance.XoaPhieuMuon(MaPhieuMuon) > 0);
        }

        public bool SuaPhieuMuon(DataGridView dataMain)
        {
            PhieuMuonDTO phieuMuon = new PhieuMuonDTO();
            phieuMuon.MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            phieuMuon.MaDG = dataMain.SelectedCells[0].OwningRow.Cells["Độc Giả"].Value.ToString();
            phieuMuon.TaiKhoan = dataMain.SelectedCells[0].OwningRow.Cells["Thủ Thư"].Value.ToString();
            phieuMuon.NgayMuon = new DateTime(1900, 1, 1);
            try
            {
                phieuMuon.NgayMuon = (DateTime)dataMain.SelectedCells[0].OwningRow.Cells["Ngày Mượn"].Value;
            }
            catch { }
            phieuMuon.HanTra = new DateTime(1900, 1, 1);
            try
            {
                phieuMuon.HanTra = (DateTime)dataMain.SelectedCells[0].OwningRow.Cells["Hạn Trả"].Value;
            }
            catch { }
            phieuMuon.DaTraXong = false;
            try
            {
                phieuMuon.DaTraXong = (bool)dataMain.SelectedCells[0].OwningRow.Cells["Xong"].Value;
            }
            catch { }

            return (PhieuMuonDAO.Instance.SuaPhieuMuon(phieuMuon) > 0);
        }
    }
}
