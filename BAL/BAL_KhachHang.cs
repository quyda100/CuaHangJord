using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BEL;
namespace BAL
{
   public class BAL_KhachHang
    {
        DAL_KhachHang xulikhachhang = new DAL_KhachHang();
        public DataTable loadDSKhachHang()
        {
            return xulikhachhang.loadDSKhachHang();
        }
        public bool themKhachHang(KhachHang kh)
        {
            return xulikhachhang.themKhachHang(kh);
        }
        public bool capnhatKhachHang(KhachHang kh)
        {
            return xulikhachhang.capnhatKhachHang(kh);
        }
        public bool xoaKhachHang(KhachHang kh)
        {
            return xulikhachhang.xoaKhachHang(kh);
        }
        public DataTable TimKiemTheoChucVu(string machucvu)
        {
            return xulikhachhang.TimKiemTheoChucVu(machucvu);
        }
        public DataTable TimKiemTheoTen(string ten)
        {
            return xulikhachhang.TimKiemTheoTen(ten);
        }
        public List<string> layDSTenKhachHang()
        {
            return xulikhachhang.layDSTenKhachHang();
        }
        public string layMaKhachHang(string ten)
        {
            return xulikhachhang.layMaKhachHang(ten);
        }
        public int Count()
        {
            return xulikhachhang.Count();
        }
        public DataTable loadDSLoaiKhachHang()
        {
            return xulikhachhang.loadDSLoaiKhachHang();
        }
    }
}
