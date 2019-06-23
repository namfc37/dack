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
    /// 
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Button button = sender as Button;

            var book = (DataRowView)button.DataContext;

            //MessageBox.Show(int.Parse(book.Row[0].ToString()) + book.Row[1].ToString() + int.Parse(book.Row[2].ToString()) + int.Parse(book.Row[3].ToString()) +decimal.Parse(book.Row[4].ToString())+ int.Parse(book.Row[5].ToString()) + book.Row[6].ToString() + book.Row[7].ToString());
            BookMgr bookmgr = new BookMgr(int.Parse(book.Row[0].ToString()),book.Row[1].ToString(), int.Parse(book.Row[2].ToString()), int.Parse(book.Row[3].ToString()), decimal.Parse(book.Row[4].ToString()), int.Parse(book.Row[5].ToString()),book.Row[6].ToString(),book.Row[7].ToString());

            if(CartBook.GetList().Count() == Regulations.SoLuongSachToiDa )
            {
                MessageBox.Show("Số Sách Mượn Đã Tối Đa");
                return;
            }
            CartBook.AddBook(bookmgr);

            //DataRowView librarian = ListBook.SelectedItem as DataRowView;
            //DataRowView librarian = ListBook.SelectedItem as DataRowView;
            // MessageBox.Show(book.Row[0].ToString());
            //Game game = button.DataContext as Game;
            //int id = game.ID;
        }
    }
}
