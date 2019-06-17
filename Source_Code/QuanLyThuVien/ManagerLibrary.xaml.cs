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
using System.Windows.Shapes;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for ManagerLibrary.xaml
    /// </summary>
    public partial class ManagerLibrary : Window
    {
        public ManagerLibrary()
        {
            InitializeComponent();
        }
        private void Button_AnswerClick(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

         

            switch (index)
            {
                case 0:
                    HostWindowInFrame(FrameManager, new ManagerBook());
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
        public void HostWindowInFrame(Frame fraContainer, Window win)
        {
            object tmp = win.Content;
            win.Content = null;
            fraContainer.Content = new ContentControl() { Content = tmp };
            fraContainer.Background = win.Background;
        }
    }
}
