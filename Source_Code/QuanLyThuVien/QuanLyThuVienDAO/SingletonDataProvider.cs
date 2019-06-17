using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDAO
{
    class SingletonDataProvider
    {
        private static SingletonDataProvider _ins;
        public static SingletonDataProvider Ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new SingletonDataProvider();
                }
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }
        public DataProcess DataBase { get; set; }

        private SingletonDataProvider()
        {
            DataBase = new DataProcess();
        }
    }
}
