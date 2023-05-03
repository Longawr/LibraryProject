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
    class ChiTietPMBUS
    {
        private static ChiTietPMBUS instance;

        public static ChiTietPMBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPMBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private ChiTietPMBUS() { }

        public void XemCTPM(DataGridView data, string MaMuon = null)
        {
            if (MaMuon == null || MaMuon.Equals("Phiếu Mượn Sách"))
                MaMuon = data.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString();
            data.DataSource = ChiTietPMDAO.Instance.XemChiTietPM(MaMuon);
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataProducer.Instance.TaoSearchCol(data);
        }

        public bool ThemChiTietPM(DataGridView dataMain)
        {
            ChiTietPMDTO CTPM = new ChiTietPMDTO
            {
                MaCTPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã CTPM"].Value.ToString(),
                MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString(),
                MaSach = dataMain.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString(),
                SoLuong = int.Parse(dataMain.SelectedCells[0].OwningRow.Cells["Số Lượng"].Value.ToString())
            };

            return (ChiTietPMDAO.Instance.ThemCTPM(CTPM) > 0);
        }

        internal bool XoaChiTietPM(DataGridView dataMain)
        {
            string MaCTPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã CTPM"].Value.ToString();

            return (ChiTietPMDAO.Instance.XoaCTPM(MaCTPM) > 0);
        }

        internal bool SuaChiTietPM(DataGridView dataMain)
        {
            ChiTietPMDTO CTPM = new ChiTietPMDTO
            {
                MaCTPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã CTPM"].Value.ToString(),
                MaPM = dataMain.SelectedCells[0].OwningRow.Cells["Mã Mượn"].Value.ToString(),
                MaSach = dataMain.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString(),
                SoLuong = int.Parse(dataMain.SelectedCells[0].OwningRow.Cells["Số Lượng"].Value.ToString()),
                DaTra = int.Parse(dataMain.SelectedCells[0].OwningRow.Cells["Đã Trả"].Value.ToString())
            };

            return (ChiTietPMDAO.Instance.SuaCTPM(CTPM) > 0);
        }
    }
}
