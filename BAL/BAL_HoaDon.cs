using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BEL;
using DAL;
namespace BAL
{
    public class BAL_HoaDon
    {
        DAL_HoaDon xulihoadon = new DAL_HoaDon();

        public DataTable loadDSHoaDon()
        {
            return xulihoadon.loadDSHoaDon();
        }
        public bool luuHD(HoaDon HD)
        {
            return xulihoadon.luuHD(HD);
        }
        public bool luuCTHD(String maHD, SanPham sanPham)
        {
            return xulihoadon.luuCTHD(maHD, sanPham);
        }
        public DataTable TimKiemTheoMa(string ma)
        {
            return xulihoadon.TimKiemTheoMa(ma);
        }
        public DataTable TimKiemTheoTenNV(string ten)
        {
            return xulihoadon.TimKiemTheoTenNV(ten);
        }
        public DataTable TimKiemTheoTenKH(string ten)
        {
            return xulihoadon.TimKiemTheoTenKH(ten);
        }
        public DataTable layChiTietHoaDon(string maHD)
        {
            return xulihoadon.layChiTietHoaDon(maHD);
        }
    }
}
