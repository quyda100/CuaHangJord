using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_TaiKhoan
    {
        DAL_TaiKhoan xulitaikhoan = new DAL_TaiKhoan();
        public TaiKhoan KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            return xulitaikhoan.KiemTraDangNhap(tendangnhap, matkhau);
        }
    }
}
