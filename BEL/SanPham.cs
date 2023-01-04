using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class SanPham
    {
        private String MaSP;
        private String TenSP;
        private int DonGia;
        private int soLuong;
        private string hinhAnh;
        private String MaSize;
        private String MaNSX;

        public string ma { get => MaSP; set => MaSP = value; }
        public string Ten { get => TenSP; set => TenSP = value; }
        public int donGia { get => DonGia; set => DonGia = value; }
        public string maSize { get => MaSize; set => MaSize = value; }
        public string maNSX { get => MaNSX; set => MaNSX = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public SanPham()
        {
            MaSP = null;
            TenSP = null;
            DonGia = 0;
            MaSize = null;
            MaNSX = null;
            soLuong = 0;
        }
        public SanPham(string maSP, string tenSP, int donGia,int soLuong ,string maSize, string maNSX)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            MaSize = maSize;
            MaNSX = maNSX;
            this.soLuong = soLuong;
        }

        public SanPham(string maSP, string tenSP, int donGia, int soLuong, string maSize, string maNSX, string hinhAnh)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            MaSize = maSize;
            MaNSX = maNSX;
            this.soLuong = soLuong;
            this.hinhAnh = hinhAnh;
        }
    }
}
