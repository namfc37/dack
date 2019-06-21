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
    /// Interaction logic for LibrarianMgrPage.xaml
    /// </summary>
    public partial class LibrarianMgrPage : Page
    {
        public LibrarianMgrPage()
        {
            InitializeComponent();
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

        private void ListItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView librarian = ListItem.SelectedItem as DataRowView;


            if (librarian != null)
            {
                //txtID.Text = librarian.Row[0].ToString();
                //txtName.Text = librarian.Row[1] as string;
                //txtCMND.Text = librarian.Row[2] as string;
                //txtDate.Text = librarian.Row[3].ToString();
                //txtLevel.Text = librarian.Row[4].ToString();
               

            }
        }
    }
}
