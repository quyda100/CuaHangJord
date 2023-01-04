using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_NhanVien:Connection
    {
        public DataTable loadDSNhanVien()
        {
            DataTable dt = new DataTable();
            String sql = "select MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,NgayVaoLam,TenChucVu,HinhAnh from tbNhanVien a, tbChucVu b where a.MaChucVu = b.MaChucVu and DaXoa = 0";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return dt;
        }
        public bool themNhanVien(NhanVien nv)
        {
            string sql = "insert into tbnhanvien(manv,tennv,ngaysinh,gioitinh,diachi,sdt,hinhanh,machucvu) values('" +
                nv.MaNV + "',N'" + nv.TenNV + "','" + nv.NgaySinh + "',N'" + nv.GioiTinh + "',N'" + nv.DiaChi + "','" + nv.Sdt + "','" + nv.HinhAnh + "','" + nv.Machucvu + "')";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public bool capnhatNhanVien(NhanVien nv)
        {
            string sql = "update tbnhanvien set " +
                "tennv = N'" + nv.TenNV + "',ngaysinh='" + nv.NgaySinh + "',gioitinh=N'" + nv.GioiTinh + "',diachi=N'" + nv.DiaChi + "',sdt=" + nv.Sdt + ",hinhanh='" + nv.HinhAnh + "',machucvu='" + nv.Machucvu + "' " +
                "where manv = '" + nv.MaNV + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public bool xoaNhanVien(NhanVien nv)
        {
            string sql = "update tbnhanvien set daxoa = 1 where manv = '" + nv.MaNV + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemTheoChucVu(string machucvu)
        {
            DataTable dt = new DataTable();
            String sql = "select MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,NgayVaoLam,TenChucVu,HinhAnh from tbNhanVien a, tbChucVu b where a.MaChucVu = b.MaChucVu and DaXoa = 0 and a.machucvu ='"+machucvu+"'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemTheoTen(string ten)
        {
            DataTable dt = new DataTable();
            String sql = "select MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,NgayVaoLam,TenChucVu,HinhAnh from tbNhanVien a, tbChucVu b where a.MaChucVu = b.MaChucVu and DaXoa = 0 and a.TenNV like N'%" + ten + "%'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return dt;
        }
        public int Count()
        {
            int kq = 0;
            String sql = "select count(manv) from tbnhanvien";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                rd.Read();
                kq = int.Parse(rd[0].ToString());
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return kq;
        }
        public DataRow GetNhanVien(string ma)
        {
            DataTable dt = new DataTable();
            String sql = "select MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,NgayVaoLam,TenChucVu,HinhAnh from tbNhanVien a, tbChucVu b where a.MaChucVu = b.MaChucVu and DaXoa = 0 and a.MaNV = '"+ma+"'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                dt.Load(rd);
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return dt.Rows[0];
        }
    }
}
