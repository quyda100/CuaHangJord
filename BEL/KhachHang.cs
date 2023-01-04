using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class KhachHang
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public int sdt { get; set; }
        public string loai { get; set; }

        public KhachHang(string ma, string ten, string gioitinh, string diachi, int sdt, string loai)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.loai = loai;
        }
    }
}
