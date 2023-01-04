using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private int sdt;
        private string hinhAnh;
        private string machucvu;

        public NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, int sdt, string hinhAnh, string machucvu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.HinhAnh = hinhAnh;
            this.Machucvu = machucvu;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string Machucvu { get => machucvu; set => machucvu = value; }
    }
}
