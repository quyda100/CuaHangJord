using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HoaDon
    {
        private String maHD;
        private int Tong;
        private DateTime ngayLap;
        private String maNV;
        private String maKH;
        private List<SanPham> sanPhams;
        public HoaDon()
        {
            maHD = null;
            Tong = 0;
            ngayLap = new DateTime();
            maNV = null;
            maKH = null;
        }

        public HoaDon(string maHD, int tong, DateTime ngayLap, string maNV, string maKH)
        {
            this.maHD = maHD;
            Tong = tong;
            this.ngayLap = ngayLap;
            this.maNV = maNV;
            this.maKH = maKH;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public int tongHD { get => Tong; set => Tong = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }

        public int TinhTongHD()
        {
            int Tong = 0;
            foreach(SanPham it in sanPhams)
            {
                Tong += it.donGia * it.SoLuong;
            }
            return Tong;
        }
    }
}
