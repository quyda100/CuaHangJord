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
   public class BAL_NhanVien
    {
        DAL_NhanVien xulinhanvien = new DAL_NhanVien();
        public DataTable loadDSNhanVien()
        {
            return xulinhanvien.loadDSNhanVien();
        }
        public bool themNhanVien(NhanVien nv)
        {
            return xulinhanvien.themNhanVien(nv);
        }
        public bool capnhatNhanVien(NhanVien nv)
        {
            return xulinhanvien.capnhatNhanVien(nv);
        }
        public bool xoaNhanVien(NhanVien nv)
        {
            return xulinhanvien.xoaNhanVien(nv);
        }
        public DataTable TimKiemTheoChucVu(string machucvu)
        {
            return xulinhanvien.TimKiemTheoChucVu(machucvu);
        }
        public DataTable TimKiemTheoTen(string ten)
        {
            return xulinhanvien.TimKiemTheoTen(ten);
        }
        public int Count()
        {
            return xulinhanvien.Count();
        }
        public DataRow GetNhanVien(string ma)
        {
            return xulinhanvien.GetNhanVien(ma);
        }
    }
}
