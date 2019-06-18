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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : Page
    {
        private BookDAO bookDAO;
        private KindOfBookDAO kindOfBookDao;
        private List<BookMgr> BookMgrs = new List<BookMgr>();
        private List<String> KindOfBooks = new List<String>();
        public BookView()
        {
            InitializeComponent();
            bookDAO = new BookDAO();
            kindOfBookDao = new KindOfBookDAO();

            var listItem = bookDAO.LoadList();
            ListBook.ItemsSource = listItem.DefaultView;

            var listType = kindOfBookDao.LoadList();

            foreach (DataRow row in listType.Rows)
            {
                String name = row["TenLoaiSach"].ToString();
                KindOfBooks.Add(name);
            }

            listloai.ItemsSource = KindOfBooks;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
