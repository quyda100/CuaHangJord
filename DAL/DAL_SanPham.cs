using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_SanPham:Connection
    {
        //Form cửa hàng
        public static DataTable layDSSanPham()
        {
            DataTable dt = new DataTable();
            String sql = "select MaSP,TenSP,DonGia,SoLuong,HinhAnh, MaSize, MaNSX from tbSanPham where DaXoa = 0";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try {
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
        public String laySize(String maSize)
        {
            String Size = null;
            String sql = "select Size from tbKichThuoc where masize = '" + maSize + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try { 
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            SqlDataReader rd = Cmd.ExecuteReader();
            rd.Read();
            Size = rd["Size"].ToString();
            rd.Close();
            Conn.Close();
            }
            catch
            {
                throw;
            }
            return Size;
        }
        public String layTenNSX(String maNSX)
        {
            String TenNSX = null;
            String sql = "select TenNSX from tbNhaSanXuat where mansx = '" + maNSX + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try { 
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            SqlDataReader rd = Cmd.ExecuteReader();
            rd.Read();
            TenNSX = rd["TenNSX"].ToString();
            rd.Close();
            Conn.Close();
            }
            catch
            {
                throw;
            }
            return TenNSX;
        }
        public String layMaSize(String tenSize)
        {
            String maNSX = null;
            String sql = "select MaSize from tbkichthuoc where size = '" + tenSize + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    maNSX = rd["MaSize"].ToString();
                }
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return maNSX;
        }
        public String layMaNSX(String tenNSX)
        {
            String maNSX = null;
            String sql = "select MaNSX from tbNhaSanXuat where TenNSX = '" + tenNSX + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    maNSX = rd["MaNSX"].ToString();
                }
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return maNSX;
        }
        public DataTable loadSanPhamBySize(String maSize)
        {
            DataTable dt = new DataTable();
            String sql = "select MaSP,TenSP,DonGia,SoLuong,HinhAnh, MaSize, MaNSX from tbSanPham where DaXoa = 0 and masize = "+maSize;
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try {
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
        public DataTable loadSanPhamByNSX(String maNSX)
        {
            DataTable dt = new DataTable();
            String sql = "select MaSP,TenSP,DonGia,SoLuong,HinhAnh, MaSize, MaNSX from tbSanPham where DaXoa = 0 and mansx = " + maNSX;
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try {
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
        public bool updateSoLuongSP(SanPham sp)
        {
            String sql = "update tbsanpham set soluong = soluong - " + sp.SoLuong + " where masp =" + sp.ma;
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            try
            {
                if (Cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                throw;
            }
            return false;
        }
        public DataTable loadSanPhamByName(string name)
        {
            DataTable dt = new DataTable();
            string sql = "select MaSP,TenSP,DonGia,SoLuong,HinhAnh, MaSize, MaNSX from tbSanPham where DaXoa = 0 and tensp like '%" + name+"%'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try { 
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
        //Form quản lí

        public DataTable loadSanpham()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MaSP, TenSP, DonGia, SoLuong, HinhAnh, Size, TenNSX " +
                      "FROM tbSanPham INNER JOIN " +
                      "tbNhaSanXuat ON tbSanPham.MaNSX = tbNhaSanXuat.MaNSX INNER JOIN " +
                      "tbKichThuoc ON dbo.tbSanPham.MaSize = tbKichThuoc.MaSize " +
                      "WHERE tbsanpham.DaXoa = 0";
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
        public DataTable loadSanphamTheoSizedgv(string maSize)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MaSP, TenSP, DonGia, SoLuong, HinhAnh, Size, TenNSX " +
                      "FROM tbSanPham INNER JOIN " +
                      "tbNhaSanXuat ON tbSanPham.MaNSX = tbNhaSanXuat.MaNSX INNER JOIN " +
                      "tbKichThuoc ON dbo.tbSanPham.MaSize = tbKichThuoc.MaSize " +
                      "WHERE tbsanpham.DaXoa = 0 and tbsanpham.MaSize = '"+maSize+"'";
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
        public DataTable loadSanphamTheoNSXdgv(string maNSX)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MaSP, TenSP, DonGia, SoLuong, HinhAnh, Size, TenNSX " +
                      "FROM tbSanPham INNER JOIN " +
                      "tbNhaSanXuat ON tbSanPham.MaNSX = tbNhaSanXuat.MaNSX INNER JOIN " +
                      "tbKichThuoc ON dbo.tbSanPham.MaSize = tbKichThuoc.MaSize " +
                      "WHERE tbsanpham.DaXoa = 0 and tbsanpham.MaNSX = '"+ maNSX+ "'";
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

        public DataTable loadSize()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tbKichThuoc";
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
        public DataTable loadNhaSanXuat()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tbNhaSanXuat";
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

        public bool themSanPham(SanPham sp)
        {
            string sql = "insert into tbsanpham(masp,tensp,dongia,soluong,hinhanh,masize,mansx)"+
                "values('"+sp.ma+"',N'"+sp.Ten + "','"+sp.donGia + "','"+sp.SoLuong + "','" +sp.HinhAnh + "','" +sp.maSize + "','" +sp.maNSX+"')";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    Conn.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public bool capnhatSanPham(SanPham sp)
        {
            string sql = "update tbsanpham " +
                    "set tensp=N'" + sp.Ten + "',dongia=" + sp.donGia + ",soluong=" + sp.SoLuong + ",hinhanh='" + sp.HinhAnh + "',masize='" + sp.maSize + "',mansx='" + sp.maNSX + "'" +
                    " where masp ='" + sp.ma+"'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    Conn.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public bool xoaSanPham(SanPham sp)
        {
            string sql = "update tbsanpham set daxoa = 1 where masp = '"+sp.ma+"'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                if (Cmd.ExecuteNonQuery() > 0)
                {
                    Conn.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
            return false;
        }
        public int Count()
        {
            int kq = 0;
            String sql = "select count(manv) from tbsanpham";
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
    }
}
