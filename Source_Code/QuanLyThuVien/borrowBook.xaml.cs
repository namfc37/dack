using QuanLyThuVien.QuanLyThuVienDAO;
using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for borrowBook.xaml
    /// </summary>
    public partial class borrowBook : Page
    {
        private List<BookMgr> listBook = new List<BookMgr>();
        private borrowBookDAO borrowBookDao = new borrowBookDAO();
        private BookDAO bookDAO = new BookDAO();
        public borrowBook()
        {
            InitializeComponent();

            dateTimePicker1.Text = DateTime.Today.ToString();
            listBook = CartBook.GetList();

            ListBook.ItemsSource = listBook;
            //for(int i=0;i<CartBook.GetList().Count();i++)
            //{
            //    //bookDAO.FindBookbyId(CartBook.getList()[i]);
            //}

            //MessageBox.Show(listId.ToString());

            decimal totalMoney = 0;
            for(int i=0;i<listBook.Count();i++)
            {
                totalMoney += listBook[i].Gia;
            }

            txtTotalMoney.Content = totalMoney.ToString() +" đ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var test= DateTime.Parse(dateTimePicker2.Text).ToString().Split()[0];
            //MessageBox.Show(test.ToString());

            if(listBook.Count>0 && test!=null)
            {
                borrowBookDao.addListBook(test);
            }
            
        }
    }
}
