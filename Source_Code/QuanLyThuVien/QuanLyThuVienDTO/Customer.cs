using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDTO
{
    class Customer
    {
        public int ID { get; set; }
        public String DiaChi { get; set; }
        public String CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LoaiNguoiDung { get; set; }
        public String UserName { get; set; }
        public String MatKhau { get; set; }
    }
}
