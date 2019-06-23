using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDTO
{
    public static class User
    {
        private static int userId=0;
        private static int loaiUser=0;
        private static decimal moneyUser=0;
        private static string userName;

        public static void setUserID( int id)
        {
            userId = id;
        }
        public static void setLoai (int loaiuser)
        {
            loaiUser = loaiuser;
        }
        public static void setUserName(string name)
        {
            userName = name;
        }
        public static string getUserName()
        {
            return userName;
        }
        public static int getUserID()
        {
            return userId;
        }

        public static int getLoai()
        {
            return loaiUser;
        }

        public static void setMoney(decimal money)
        {
            moneyUser = money;
        }

        public static decimal getMoney()
        {
            return moneyUser;
        }

        public static int calculateAge(DateTime time)
        {
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - time.Year;
            // Go back to the year the person was born in case of a leap year
            if (time.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
