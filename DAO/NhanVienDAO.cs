using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            //set => instance = value; 
        }

        private NhanVienDAO() { }

        public DataTable GetNhanVienbyId(String id)
        {
            try
            {
                String query = "SELECT * FROM [NhanVien] WHERE [MaNhanVien] = @id";

                object[] obj = new object[] { id };

                DataTable dTable = DataProvider.Instance.ExecuteQuery(query, obj);

                if (dTable.Rows.Count > 0)
                    return dTable;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
