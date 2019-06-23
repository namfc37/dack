using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    public class RegulationsDAO
    {
        public DataTable LoadList()
        {
            String sql = " Select * from QuyDinh";
            return SingletonDataProvider.Ins.DataBase.truyvan(sql);
        }
    }
}
