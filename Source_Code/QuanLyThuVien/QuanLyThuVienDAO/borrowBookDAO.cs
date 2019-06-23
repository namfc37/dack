using QuanLyThuVien.QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    public class borrowBookDAO
    {
        public void addListBook(string date)
        {
            string sql = "Select * from PhieuMuonSach";
            int idPhieuMuon = SingletonDataProvider.Ins.DataBase.truyvan(sql).Rows.Count+1;
            string sql2 = "Select * from PhieuMuon_Sach";
            int id = SingletonDataProvider.Ins.DataBase.truyvan(sql2).Rows.Count + 1;

            var listBook = CartBook.GetList();

            decimal totalMoney = 0;
            for (int i = 0; i < listBook.Count(); i++)
            {
                totalMoney += listBook[i].Gia;
            }



            string sql3 = "Insert Into PhieuMuonSach Values (" + idPhieuMuon + "," + User.getUserID() + ",null,'" + DateTime.UtcNow.Date.ToString().Split()[0] + "'," + "'binh thuong','"+date+"'," + totalMoney +" )";
            SingletonDataProvider.Ins.DataBase.truyvan(sql3);

            for(int i=0;i <listBook.Count();i++)
            {
                string sql4 = "Insert Into PhieuMuon_Sach Values ("+id+"," +idPhieuMuon+ ","+listBook[i].idSach+" )";
                id++;
                SingletonDataProvider.Ins.DataBase.truyvan(sql4);
            }

            

        }
       
        public DataTable loadList()
        {
            string sql = "Select * from PhieuMuonSach";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
    }
}
