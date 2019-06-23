using QuanLyThuVien.QuanLyThuVienDAO;
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
    /// Interaction logic for BillMgrPage.xaml
    /// </summary>
    public partial class BillMgrPage : Page
    {
        private borrowBookDAO dao = new borrowBookDAO();
        public BillMgrPage()
        {
            InitializeComponent();

            var list = dao.loadList();

            ListBook.ItemsSource = list.DefaultView;
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

            DataRowView bill = ListBook.SelectedItem as DataRowView;


            if (bill != null)
            {
                txtIDBill.Text = bill.Row[0].ToString();
                txtIDUser.Text = bill.Row[1] as string;
                txtCost.Text = bill.Row[2] as string;
                txtStatic.Text = bill.Row[3].ToString();
                txtDateBorrow.Text = bill.Row[4].ToString();
                txtDate.Text = bill.Row[5] as string;

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
