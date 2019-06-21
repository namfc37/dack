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
    /// Interaction logic for BookMgrPage.xaml
    /// </summary>
    public partial class BookMgrPage : Page
    {
        private BookDAO bookDAO= new BookDAO();
        public BookMgrPage()
        {
            InitializeComponent();
            var listItem = bookDAO.LoadList();
            ListBook.ItemsSource = listItem.DefaultView;
        }
        
        private void Button_AnswerClick(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            
            switch (index)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var book = ListBook.SelectedItem;

            DataRowView book = ListBook.SelectedItem as DataRowView;
           

            if (book != null)
            {
                txtIDBook.Text = book.Row[0].ToString();
                txtNameBook.Text = book.Row[1] as string;
                txtTacGia.Text = book.Row[2] as string;
                txtCount.Text = book.Row[3].ToString();
                txtTypeBook.Text = book.Row[4].ToString();
                txtPosition.Text = book.Row[7] as string;
                
            }

            //MessageBox.Show(sValue);
            //txtIDBook.Text = book.idSach.ToString();
            //txtNameBook.Text = book.TenSach;
            //txtTacGia.Text = book.NhaSanXuat;
            //txtNamSX.Text = book.NamSanXuat.ToString();
            //txtTypeBook.Text = book.LoaiSach.ToString();
            //txtPosition.Text = book.ViTri;

        }
    }
}
