using QuanLyThuVien.QuanLyThuVienDAO;
using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for Book.xaml
    /// </summary>
    public partial class Book : Window
    {
        public List<BookMgr> items = new List<BookMgr>();
        public BookDAO bookDAO = new BookDAO();
        public Book()
        {
            InitializeComponent();
            var dt = bookDAO.LoadList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                BookMgr book = new BookMgr();
                book.idSach = (int)dr["idSach"];
                book.TenSach = dr["TenSach"].ToString();
                book.Gia = (int)dr["Gia"];
                items.Add(book);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
       
    }
}
