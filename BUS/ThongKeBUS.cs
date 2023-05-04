using LibraryProject.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class ThongKeBUS
    {
        private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private ThongKeBUS() { }

        public void XemThongKe(TextBox sach, TextBox tongsach,TextBox theLoai, TextBox tacGia, TextBox NXB, TextBox docGia, TextBox nhanVien)
        {
            sach.Text = ThongKeDAO.Instance.XemSoSach().ToString();
            tongsach.Text = ThongKeDAO.Instance.TongSoSach().ToString();
            theLoai.Text = ThongKeDAO.Instance.XemSoTheLoai().ToString();
            tacGia.Text = ThongKeDAO.Instance.XemSoTacGia().ToString();
            NXB.Text = ThongKeDAO.Instance.XemSoNXB().ToString();
            docGia.Text = ThongKeDAO.Instance.XemSoDocGia().ToString();
            nhanVien.Text = ThongKeDAO.Instance.XemSoNhanVien().ToString();
        }

        public void XemDangMuon(DataGridView data, TextBox tongSo)
        {
            data.DataSource = ThongKeDAO.Instance.XemDangMuon();
            tongSo.Text = ThongKeDAO.Instance.XemSoDangMuon().ToString();
        }

        public void XemQuaHan(DataGridView data, TextBox tongSo)
        {
            data.DataSource = ThongKeDAO.Instance.XemQuaHan();
            tongSo.Text = ThongKeDAO.Instance.XemSoQuaHan().ToString();
        }

        public DataTable BieuDoMuon()
        {
            DataTable dt = ThongKeDAO.Instance.BieuDoMuon();
           return dt;
        }

        public DataTable BieuDoTra()
        {
            DataTable dt = ThongKeDAO.Instance.BieuDoTra();
            return dt;
        }

        public void TopDocGia(DataGridView data)
        {
            data.DataSource = ThongKeDAO.Instance.TopDocGia();
        }
        public void TopSach(DataGridView data)
        {
            data.DataSource = ThongKeDAO.Instance.TopSach();
        }
    }
}
