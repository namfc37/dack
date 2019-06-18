using QuanLyThuVien.QuanLyThuVienDAO;
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
    /// Interaction logic for UserMgrPage.xaml
    /// </summary>
    public partial class UserMgrPage : Page
    {

        private CustomerDAO customerDAO = new CustomerDAO();
        public UserMgrPage()
        {
            InitializeComponent();
            var listItem = customerDAO.LoadList();
            ListUser.ItemsSource = listItem.DefaultView;
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
    }
}
