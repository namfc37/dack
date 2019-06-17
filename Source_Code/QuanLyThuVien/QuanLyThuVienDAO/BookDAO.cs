using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    class BookDAO
    {
        public BookDAO()
        {

        }

        public DataTable LoadList()
        {
            String sql = " Select * from Sach";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }

        public void Insert(BookMgr book)
        {
            String sql = "INSERT INTO Sach  VALUES(" + book.idSach + ", '" + book.TenSach + "', " + book.LoaiSach + ", " + book.SoLuong + ", " + book.Gia + ", " + book.NamSanXuat + "," + book.ViTri + ") ";
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }


        public void Update(BookMgr book)
        {
            String sql = "Update Sach  TenSach ='" + book.TenSach + "', LoaiSach=" + book.LoaiSach + ",SoLuong= " + book.SoLuong + ",Gia= " + book.Gia + ",NamSanXuat= " + book.NamSanXuat + ",ViTri =" + book.ViTri + ") ";
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }

        public void Delete(int idBook)
        {
            String sql = "Delete From Sach Where idSach = "+idBook;
            //String sql = "Update Sach  TenSach ='" + book.TenSach + "', LoaiSach=" + book.LoaiSach + ",SoLuong= " + book.SoLuong + ",Gia= " + book.Gia + ",NamSanXuat= " + book.NamSanXuat + ",ViTri =" + book.ViTri + ") ";
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }


    }

}
