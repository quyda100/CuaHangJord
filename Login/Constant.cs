using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
namespace Login
{
    public class Constant
    {
        public static TaiKhoan taiKhoan;
        public static List<SanPham> listSP;
        static Constant()
        {
            listSP = new List<SanPham>();
        }

    }
}
