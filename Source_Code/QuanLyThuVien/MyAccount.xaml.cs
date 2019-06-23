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
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Page
    {
        private CustomerDAO customerDAO = new CustomerDAO();
        public MyAccount()
        {
            InitializeComponent();

            var info = customerDAO.loadInfoUserbyId(User.getUserID());

            
            txtName.Content = info.Rows[0]["idUser"].ToString();
            txtDateofBirth.Content = info.Rows[0]["ngaysinh"].ToString().Split()[0];
            txtCMND.Content = info.Rows[0]["CMND"].ToString();
            txtPhone.Content =  info.Rows[0]["idUser"].ToString();
            txtPass.Content = info.Rows[0]["MatKhau"].ToString(); 
            txtMoney.Content = info.Rows[0]["idUser"].ToString(); 

        }
    }
}
