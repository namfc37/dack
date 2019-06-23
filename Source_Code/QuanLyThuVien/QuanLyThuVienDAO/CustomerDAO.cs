using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    class  CustomerDAO
    {
        
        public CustomerDAO()
        {
            
        }

        public DataTable LoadList()
        {
            String sql = " Select * from nguoidung";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
         public bool CheckUserExist(String username)
        {
            String sql = " Select * from nguoidung where CMND = '"+ username+"'";
            var data = SingletonDataProvider.Ins.DataBase.truyvan(sql);
            if (data.Rows.Count > 0) return true;
            else return false;
        }
        public bool CheckPassword(String username, String pass)
        {
            String sql = " Select * from nguoidung where MatKhau = '" + pass +"' AND CMND = '"+username+"'" ;
            var data = SingletonDataProvider.Ins.DataBase.truyvan(sql);
            if (data.Rows.Count > 0) return true;
            else return false;
        }

        public DataTable loadInfoUser(String username)
        {
            String sql = "Select * from nguoidung where CMND = '" + username + "'";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
        public DataTable loadInfoUserbyId(int id)
        { 
            String sql = "Select * from nguoidung where idUser = " + id ;
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
    }
}
