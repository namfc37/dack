using QuanLyThuVien.QuanLyThuVienDAO;
using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for UILogin.xaml
    /// </summary>
    public partial class UILogin : Window
    {
        private CustomerDAO customerDAO;
        private RegulationsDAO regulationsDAO;
        public UILogin()
        {
            InitializeComponent();
            customerDAO = new CustomerDAO();
            regulationsDAO = new RegulationsDAO();

            var regulation = regulationsDAO.LoadList();

            Regulations.TuoiToiThieu = int.Parse(regulation.Rows[0]["TuoiToiThieu"].ToString());
            Regulations.TuoiToiDa = int.Parse(regulation.Rows[0]["TuoiToiDa"].ToString());
            Regulations.ThoiHanThe = int.Parse(regulation.Rows[0]["ThoiHanThe"].ToString());
            Regulations.SoLuongSachToiDa = int.Parse(regulation.Rows[0]["SoLuongSachToiDa"].ToString());
            Regulations.SoLuongLoai = int.Parse(regulation.Rows[0]["SoLuongLoai"].ToString());
            Regulations.SoNgayMuonToiDa = int.Parse(regulation.Rows[0]["SoNgayMuonToiDa"].ToString());

        }


        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = textUserName.Text;
            string password = passboxPassWord.Password;

            if (username == "")
            {
                MessageBox.Show("Bạn chưa nhập UserName !!!");
            }
            else if (password == "")
            {
                MessageBox.Show("Bạn chưa nhập PassWord !!!");
            }

            else
            {
                if (username == "admin" && password == "123456")
                {
                    // IsLoginLoaded = true;

                    this.Close();
                }
                else
                {
                    if (!customerDAO.CheckUserExist(username))
                    {
                        MessageBox.Show("Tài Khoản Không Tồn Tại !!!");
                    }
                    else
                    {
                        if (customerDAO.CheckPassword(username, password))
                        {
                           
                            var data = customerDAO.loadInfoUser(username);
                            var age = User.calculateAge(DateTime.Parse(data.Rows[0]["ngaysinh"].ToString()));
                            if (age>Regulations.TuoiToiDa || age<Regulations.TuoiToiThieu)
                            {
                                MessageBox.Show("Tuổi Tài Khoản Không Hợp Lệ !!");
                                return;
                            }

                            User.setUserID(int.Parse(data.Rows[0]["idUser"].ToString()));
                            User.setLoai(int.Parse(data.Rows[0]["LoaiNguoiDung"].ToString()));
                            User.setMoney(decimal.Parse(data.Rows[0]["TaiKhoan"].ToString()));
                            User.setUserName(data.Rows[0]["TenNguoiDung"].ToString());
                            //MessageBox.Show(data.Rows[0]["idUser"].ToString());
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        }
                    }

                }

                //string codePass = MD5Hash(password);
                //var accCount = DataProvider.Ins.DB.Nguoidungs.Where(x => x.Username == username && x.Passuser == codePass).Count();

                //if (accCount > 0)
                //{
                //    IsLoginLoaded = true;

                //    this.Close();
                //}
                //else
                //{
                //    IsLoginLoaded = false;
                //    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                //}
            }
        }


        

        private void btnFacebook_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");

        }

        private void btnTwitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com");
        }

        private void btnGooglePlus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}

