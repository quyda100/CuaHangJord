using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BEL;
namespace DAL
{
   public class DAL_KhachHang:Connection
    {
        public DataTable loadDSKhachHang()
        {
            DataTable dt = new DataTable();
            String sql = "select MaKH,TenKH,GioiTinh,DiaChi,SDT,TenLoai from tbKhachHang a, tbLoaiKH b where a.MaLoaiKH = b.MaLoaiKH and DaXoa = 0";
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
        public DataTable loadDSLoaiKhachHang()
        {
            DataTable dt = new DataTable();
            String sql = "select * from tbLoaiKH";
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
        public bool themKhachHang(KhachHang kh)
        {
            string sql = "insert into tbkhachhang(makh,tenkh,gioitinh,diachi,sdt,maloaikh) values('" +
                kh.ma + "',N'" + kh.ten + "',N'" + kh.gioitinh + "',N'" + kh.diachi + "','" + kh.sdt+"','" + kh.loai + "')";
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
        public bool capnhatKhachHang(KhachHang kh)
        {
            string sql = "update tbkhachhang set " +
                "tenkh = N'" + kh.ten + "',gioitinh=N'" +kh.gioitinh + "',diachi=N'" + kh.diachi + "',sdt=" + kh.sdt + "',maloaikh='" + kh.loai + "' " +
                "where makh = '" + kh.ma + "'";
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
        public bool xoaKhachHang(KhachHang kh)
        {
            string sql = "update tbkhachhang set daxoa = 1 where makh = '" + kh.ma + "'";
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
        public DataTable TimKiemTheoChucVu(string maloai)
        {
            DataTable dt = new DataTable();
            String sql = "select MaKH,TenKH,GioiTinh,DiaChi,SDT,TenLoai from tbKhachHang a, tbLoaiKH b where a.MaKH = b.MaKH and DaXoa = 0 and a.maloaikh ='" + maloai + "'";
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
            String sql = "select MaKH,TenKH,GioiTinh,DiaChi,SDT,TenLoai from tbKhachHang a, tbLoaiKH b where a.MaKH = b.MaKH and DaXoa = 0 and a.Tenkh like N'%" + ten + "%'";
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
        public List<string> layDSTenKhachHang()
        {
            List<string> ds = new List<string>();
            String sql = "select tenkh from tbkhachhang where DaXoa = 0";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                    ds.Add(rd[0].ToString());
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return ds;
        }
        public string layMaKhachHang(string ten)
        {
            string ma = null;
            String sql = "select makh from tbkhachhang where DaXoa = 0 and tenkh = N'"+ten+"'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                rd.Read();
                ma = rd["makh"].ToString();
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return ma;
        }
        public int Count()
        {
            int count = 0;
            string sql = "select count(makh) from tbkhachhang";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                rd.Read();
                count = int.Parse(rd[0].ToString());
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return count;
        }
        public DataTable layDSLoaiKhachHang()
        {
            DataTable dt = new DataTable();
            String sql = "select * from tbloaikh";
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
    }
}
