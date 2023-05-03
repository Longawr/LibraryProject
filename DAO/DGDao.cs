using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    internal class DGDao
    {
        private static DGDao instance;
        public static DGDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DGDao();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private DGDao() { }
        public DataTable Xem()
        {
            string query = "SELECT MaDG AS N'Mã độc giả', TenDG AS N'Tên độc giả', NgaySinh AS N'Ngày sinh', GioiTinh AS N'Giới tính', DiaChi AS N'Địa chỉ', SDT AS N'SĐT', Email AS N'Email' FROM dbo.DOCGIA";

            return Provider.Instance.ExecuteQuery(query);
        }
        public bool XoatheoMaDG(string maDG)
        {
            string query = "delete DOCGIA where MaDG = @MaDG";
            object[] para = new object[] { maDG };
            if (Provider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool Sua(string maDG, DGDTO DocGia)
        {
            string query = "update DOCGIA set TenDG = @TenDG , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , DiaChi = @DiaChi , SDT = @SDT , Email = @Email + user  WHERE MaDG = @oldMaDG ";
            object[] para = new object[] { DocGia.TenDG, DocGia.NgaySinh, DocGia.GioiTinh, DocGia.DiaChi, DocGia.SDT, DocGia.Email, maDG };
            if (Provider.Instance.ExecuteNonQuery(query, para) > 0) return true;
            return false;
        }
        public bool Them(DGDTO docGia)
        {
            string query = "Insert into DocGia values( @MaDG , @TenDG , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @Email ) ";
           // if(checkMaDGTontai(docGia.MaDG))
           // {
           //     docGia.MaDG = (TimMaxMaDG() + 1).ToString();
           // }    

            object[] para = new object[] { docGia.MaDG, docGia.TenDG, docGia.NgaySinh, docGia.GioiTinh, docGia.DiaChi, docGia.SDT, docGia.Email };
            if (Provider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        //bool checkMaDGTontai(string MaDG)
        //{
            //string query = "select * from DocGia where MaDG = @MaDG";


            //object[] para = new object[] {MaDG};
            //if (Int32.Parse((string)Provider.Instance.ExecuteScalar(query, para)) > 0)
                //return true;
            //return false;
        //}
        //public int TimMaxMaDG()
        //{
        //  string query = "SELECT Max(MaDG) from DOCGIA";
        //   return Int32.Parse((string)Provider.Instance.ExecuteScalar(query));
       // }
    }
}


