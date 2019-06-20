using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.QuanLyThuVienDTO
{
    class CartBook
    {
        private static CartBook _ins;
        public static CartBook Ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new CartBook();
                }
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }
    }
}
