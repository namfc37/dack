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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window UILogin = new UILogin();
            UILogin.ShowDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    FrameMain.Content = new TrangChu();
                    break;
                case 1:
                    FrameMain.Content = new BookView();
                    break;
                case 2:
                    //HostWindowInFrame(FrameMain, new ManagerLibrary());
                    FrameMain.Content = new ManagerMain();
                    break;
                case 3:
                    FrameMain.Content = new borrowBook();
                    break;
                case 4:                  
                    break;
            }
        }

        

        private void btnCloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }
        public void HostWindowInFrame(Frame fraContainer, Window win)
        {
            object tmp = win.Content;
            win.Content = null;
            fraContainer.Content = new ContentControl() { Content = tmp };
            fraContainer.Background = win.Background;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new MyAccount();

        }
    }
}
