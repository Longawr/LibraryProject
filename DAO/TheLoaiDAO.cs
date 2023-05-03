using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAO
{
    class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiDAO();
                return instance;
            }
            //set => instance = value;
        }

        public DataTable GetTheLoai()
        {
            try
            {
                string sql = "select * from TheLoai";

                return DataProvider.Instance.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
