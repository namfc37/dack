using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDTO
{
    public class BookMgr
    {
        public BookMgr(int id,string name,int loai,int so, Decimal gia,int nam,string nha ,string vitri)
        {
            idSach = id;
            TenSach = name;
            LoaiSach = loai;
            SoLuong = so;
            Gia = gia;
            NamSanXuat = nam;
            NhaSanXuat = nha;
            ViTri = vitri;
        }

        public int idSach { get; set; }
        public String TenSach { get; set; }
        public int LoaiSach { get; set; }
        public int SoLuong { get; set; }
        public Decimal Gia { get; set; }
        public int NamSanXuat { get; set; }
        public String NhaSanXuat { get; set; } 
        public String ViTri { get; set; }
    }
}
