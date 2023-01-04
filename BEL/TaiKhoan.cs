using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TaiKhoan
    {
        private String Username;
        private String tenHienThi;
        private String loaiTaiKhoan;

        public string username { get => Username; set => Username = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }

        public TaiKhoan()
        {
            this.Username = null;
            this.loaiTaiKhoan = null;
        }
        public TaiKhoan(string username,string tenHienThi, string loaitaikhoan)
        {
            this.Username = username;
            this.tenHienThi = tenHienThi;
            this.loaiTaiKhoan = loaitaikhoan;
        }
    }
}
