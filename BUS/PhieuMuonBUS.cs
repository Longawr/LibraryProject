using LibraryProject.DAO;
using System;
using System.Collections.Generic;
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

        public PhieuMuonBUS() { }
        public void XemPhieuMuon(DataGridView data)
        {
            data.DataSource = PhieuMuonDAO.Instance.XemPhieuMuon();
        }
    }
}
