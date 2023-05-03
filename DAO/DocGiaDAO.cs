using LibraryProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.DAO
{
    internal class DocGiaDAO
    {
        private static DocGiaDAO instance;
        public static DocGiaDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DocGiaDAO();
                }
                return instance;
            }
            //set { instance = value; }
        }
        private DocGiaDAO() { }
        public DataTable Xem()
        {
            string query = "SELECT MaDG AS N'Mã độc giả', TenDG AS N'Tên độc giả', NgaySinh AS N'Ngày sinh', GioiTinh AS N'Giới tính', DiaChi AS N'Địa chỉ', SDT AS N'SĐT', Email AS N'Email' FROM dbo.DOCGIA";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool XoatheoMaDG(string maDG)
        {
            string query = "delete DOCGIA where MaDG = @MaDG";
            object[] para = new object[] { maDG };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool Sua(string maDG, DocGiaDTO DocGia)
        {
            string query = "update DOCGIA set TenDG = @TenDG , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , DiaChi = @DiaChi , SDT = @SDT , Email = @Email + user  WHERE MaDG = @oldMaDG ";
            object[] para = new object[] { DocGia.TenDG, DocGia.NgaySinh, DocGia.GioiTinh, DocGia.DiaChi, DocGia.SDT, DocGia.Email, maDG };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0) return true;
            return false;
        }
        public bool Them(DocGiaDTO docGia)
        {
            string query = "Insert into DocGia values( @MaDG , @TenDG , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @Email ) ";
            // if(checkMaDGTontai(docGia.MaDG))
            // {
            //     docGia.MaDG = (TimMaxMaDG() + 1).ToString();
            // }    

            object[] para = new object[] { docGia.MaDG, docGia.TenDG, docGia.NgaySinh, docGia.GioiTinh, docGia.DiaChi, docGia.SDT, docGia.Email };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}


