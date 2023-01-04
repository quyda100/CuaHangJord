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
    public class BAL_SanPham
    {
        DAL_SanPham xulisanpham = new DAL_SanPham();
        public static DataTable layDSSanPham()
        {
            return DAL_SanPham.layDSSanPham();
        }
        public String laySize(String maSize)
        {
            
            return xulisanpham.laySize(maSize);
        }
        public String layMaSize(String tenSize)
        {
            return xulisanpham.layMaSize(tenSize);
        }
        public String layMaNSX(String tenSize)
        {
            return xulisanpham.layMaNSX(tenSize);
        }
        public String layTenNSX(String maNSX)
        {
            return xulisanpham.layTenNSX(maNSX);
        }
        public DataTable loadSanPhamBySize(String maSize)
        {
            return xulisanpham.loadSanPhamBySize(maSize);
        }
        public DataTable loadSanPhamByNSX(String maNSX)
        {
            return xulisanpham.loadSanPhamByNSX(maNSX);
        }
        public bool updateSoLuongSP(SanPham sanPham)
        {
            return xulisanpham.updateSoLuongSP(sanPham);
        }
        public DataTable loadSanPhamByName(string name)
        {
            return xulisanpham.loadSanPhamByName(name);
        }
        public DataTable loadAllSanPham()
        {
            return xulisanpham.loadSanpham();
        }
        public DataTable loadSize()
        {
            return xulisanpham.loadSize();
        }
        public DataTable loadNhaSanXuat()
        {
            return xulisanpham.loadNhaSanXuat();
        }
        public bool themSanPham(SanPham sp)
        {
            return xulisanpham.themSanPham(sp);
        }
        public bool capnhatSanPham(SanPham sp)
        {
            return xulisanpham.capnhatSanPham(sp);
        }
        public bool xoaSanPham(SanPham sp)
        {
            return xulisanpham.xoaSanPham(sp);
        }
        public DataTable loadSanPhamTheoSizedgv(string maSize)
        {
            return xulisanpham.loadSanphamTheoSizedgv(maSize);
        }
        public DataTable loadSanPhamTheoNSXdgv(string maNSX)
        {
            return xulisanpham.loadSanphamTheoNSXdgv(maNSX);
        }
        public int Count()
        {
            return xulisanpham.Count();
        }
    }
}
