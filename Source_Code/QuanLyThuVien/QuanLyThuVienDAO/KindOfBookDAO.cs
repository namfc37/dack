using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    class KindOfBookDAO
    {
        public KindOfBookDAO()
        {

        }
        public DataTable LoadList()
        {
            String sql = " Select * from LoaiSach";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }

        public void Insert(KindOfBook kindOfBook)
        {
            String sql = "INSERT INTO LoaiSach  VALUES(" + kindOfBook.IDLoai + ", '" + kindOfBook.TenLoai + ") ";
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }


        public void Update(KindOfBook kindOfBook)
        {
            String sql = "Update Sach  TenSach ='" + kindOfBook.TenLoai +" Where idLoaiSach =" + kindOfBook.IDLoai ;
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }

        public void Delete(int idLoai)
        {
            String sql = "Delete From LoaiSach Where idLoaiSach = " + idLoai;
            //String sql = "Update Sach  TenSach ='" + book.TenSach + "', LoaiSach=" + book.LoaiSach + ",SoLuong= " + book.SoLuong + ",Gia= " + book.Gia + ",NamSanXuat= " + book.NamSanXuat + ",ViTri =" + book.ViTri + ") ";
            SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
    }
}
