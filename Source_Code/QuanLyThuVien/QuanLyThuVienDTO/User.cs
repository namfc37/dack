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

        public static void setUserID( int id)
        {
            userId = id;
        }
        public static void setLoai (int loaiuser)
        {
            loaiUser = loaiuser;
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
    }
}
