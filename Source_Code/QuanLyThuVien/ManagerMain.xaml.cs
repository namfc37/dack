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
    /// Interaction logic for ManagerMain.xaml
    /// </summary>
    public partial class ManagerMain : Page
    {
        public ManagerMain()
        {
            InitializeComponent();
        }
        private void Button_AnswerClick(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            switch (index)
            {
                case 0:
                    FrameManager.Content = new BookMgrPage();
                    break;
                case 1:
                    FrameManager.Content = new UserMgrPage();
                    break;
                case 2:
                    FrameManager.Content = new LibrarianMgrPage();
                    break;
                case 3:
                    FrameManager.Content = new BillMgrPage();
                    break;
                
            }
        }
        public void HostWindowInFrame(Frame fraContainer, Window win)
        {
            object tmp = win.Content;
            win.Content = null;
            fraContainer.Content = new ContentControl() { Content = tmp };
            fraContainer.Background = win.Background;
        }
    }
}
