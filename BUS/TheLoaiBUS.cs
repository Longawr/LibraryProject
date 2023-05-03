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
    internal class TheLoaiBUS
    {
        private static TheLoaiBUS instance;
        public static TheLoaiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiBUS();
                return instance;
            }
            //set => instance = value;
        }

        public void GetTheLoai(ComboBox cbx)
        {
            cbx.DataSource = TheLoaiDAO.Instance.GetTheLoai();
        }
    }
}
