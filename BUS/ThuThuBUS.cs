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
    class ThuThuBUS
    {
        public static ThuThuDTO currentNhanVien = new ThuThuDTO();

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

        private ThuThuBUS() { }

        public void AddCurrentNhanVien(string id)
        {
            DataTable dtable = ThuThuDAO.Instance.XemThuThuQuaId(id);
            if (dtable.Rows.Count > 0)
            {
                DataRow dRow = dtable.Rows[0];
                currentNhanVien.MaThuThu = dRow[0].ToString();
                currentNhanVien.TenThuThu = dRow[1] != null ? dRow[1].ToString() : "";
                currentNhanVien.NgaySinh = (DateTime)dRow[2];
                currentNhanVien.GioiTinh = (bool)dRow[3];
                currentNhanVien.DiaChi = dRow[4] != null ? dRow[4].ToString() : "";
                currentNhanVien.SDT = dRow[5] != null ? dRow[5].ToString() : "";
                currentNhanVien.Email = dRow[6] != null ? dRow[6].ToString() : "";
            }
        }

        public bool SuaCurrentNhanVien(string maNV, string tenNV, DateTime ngaySinh, string soDienThoai, string email, bool gioiTinh, string diaChi)
        {
            ThuThuDTO nhanVien = new ThuThuDTO();
            nhanVien.MaThuThu = currentNhanVien.MaThuThu;
            nhanVien.TenThuThu = tenNV;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.DiaChi = diaChi;
            nhanVien.SDT = soDienThoai;
            nhanVien.Email = email;
            if (ThuThuDAO.Instance.SuaThuThu(nhanVien.MaThuThu, nhanVien))
            {
                currentNhanVien = nhanVien;
                return true;
            }
            return false;
        }

        public void XemThuThu(DataGridView data)
        {
            data.DataSource = ThuThuDAO.Instance.XemTTnTK();
            DataProducer.Instance.TaoSearchCol(data);
        }

        public void TimKiemTheoMaThuThu(DataGridView data, string MaThuThu)
        {
            data.DataSource = ThuThuDAO.Instance.TimKiemMaThuThu(MaThuThu);
        }

        public bool ThemThuThu(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string MaThuThu = row.Cells["Mã"].Value.ToString();
            string TenThuThu = row.Cells["Tên"].Value.ToString();

            DateTime NgaySinh = new DateTime(1900, 1, 1);
            try { NgaySinh = (DateTime)row.Cells["Ngày Sinh"].Value; } catch { }

            bool GioiTinh = false;
            try { GioiTinh = (bool)row.Cells["Giới Tính"].Value; } catch { }

            string DiaChi = row.Cells["Địa Chỉ"].Value.ToString();
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

            return ThuThuDAO.Instance.ThemThuThu(thuThu);
        }
        public bool SuaThuThu(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string OldMaThuThu = data.SelectedCells[0].OwningRow.Cells["Mã"].Value.ToString();

            string MaThuThu = row.Cells["Mã"].Value.ToString();
            string TenThuThu = row.Cells["Tên"].Value.ToString();

            DateTime NgaySinh = new DateTime(1900, 1, 1);
            try { NgaySinh = (DateTime)row.Cells["Ngày Sinh"].Value; } catch { }

            bool GioiTinh = false;
            try { GioiTinh = (bool)row.Cells["Giới Tính"].Value; } catch { }

            string DiaChi = row.Cells["Địa Chỉ"].Value.ToString();
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

            return ThuThuDAO.Instance.SuaThuThu(OldMaThuThu, thuThu);
        }

        public bool XoaThuThu(DataGridView data)
        {
            string MaThuThu = data.SelectedCells[0].OwningRow.Cells["MaThuThu"].Value.ToString();
            return ThuThuDAO.Instance.XoaThuThu(MaThuThu);
        }
    }
}
