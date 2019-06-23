using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDTO
{
    public static class CartBook
    {
        private static List<BookMgr> ListBook = new List<BookMgr>();

        public static void AddBook(BookMgr book) => ListBook.Add(book);
        public static List<BookMgr> GetList() => ListBook;
    }
}
