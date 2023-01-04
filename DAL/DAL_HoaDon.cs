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
    public class DAL_HoaDon : Connection
    {
        public DataTable loadDSHoaDon()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT tbHoaDon.MaHD, tbHoaDon.TongTien, tbHoaDon.NgayLap, tbNhanVien.TenNV, tbKhachHang.TenKH " +
                          "FROM tbKhachHang INNER JOIN " +
                          "tbHoaDon ON tbKhachHang.MaKH = tbHoaDon.MaKhachHang INNER JOIN " +
                          "tbNhanVien ON tbHoaDon.MaNVLap = tbNhanVien.MaNV ";
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
        public bool luuHD(HoaDon HD)
        {
            String sql = "INSERT INTO tbHoadon(maHD, TongTien, NgayLap, MaNVLap, MaKhachHang) VALUES('" + HD.MaHD + "', '" + HD.tongHD + "', '" + HD.NgayLap + "', '" + HD.MaNV + "', '" + HD.MaKH + "')";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            try
            {
                if (Cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch
            {
                throw;
            }
        }
        public bool luuCTHD(String maHD, SanPham SP)
        {
            String sql = "INSERT INTO tbChiTietHoaDon(maHD, maSP, SoLuong, DonGia) VALUES('" + maHD + "', '" + SP.ma + "', '" + SP.SoLuong + "', '" + SP.donGia + "')";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            try
            {
                if (Cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch
            {
                throw;
            }
        }
        public DataTable TimKiemTheoMa(string ma)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT tbHoaDon.MaHD, tbHoaDon.TongTien, tbHoaDon.NgayLap, tbNhanVien.TenNV, tbKhachHang.TenKH " +
                          "FROM tbKhachHang INNER JOIN " +
                          "tbHoaDon ON tbKhachHang.MaKH = tbHoaDon.MaKhachHang INNER JOIN " +
                          "tbNhanVien ON tbHoaDon.MaNVLap = tbNhanVien.MaNV where mahd ='" + ma + "'";
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
        public DataTable TimKiemTheoTenNV(string ten)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT tbHoaDon.MaHD, tbHoaDon.TongTien, tbHoaDon.NgayLap, tbNhanVien.TenNV, tbKhachHang.TenKH " +
                          "FROM tbKhachHang INNER JOIN " +
                          "tbHoaDon ON tbKhachHang.MaKH = tbHoaDon.MaKhachHang INNER JOIN " +
                          "tbNhanVien ON tbHoaDon.MaNVLap = tbNhanVien.MaNV where tbnhanvien.TenNV like N'%" + ten + "%'";
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
        public DataTable TimKiemTheoTenKH(string ten)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT tbHoaDon.MaHD, tbHoaDon.TongTien, tbHoaDon.NgayLap, tbNhanVien.TenNV, tbKhachHang.TenKH " +
                          "FROM tbKhachHang INNER JOIN " +
                          "tbHoaDon ON tbKhachHang.MaKH = tbHoaDon.MaKhachHang INNER JOIN " +
                          "tbNhanVien ON tbHoaDon.MaNVLap = tbNhanVien.MaNV where tbKhachHang.TenKH like N'%" + ten + "%'";
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
        public DataTable layChiTietHoaDon(string maHD)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("getChiTietHoaDon", Conn);
                cmd.Parameters.Add(new SqlParameter("@ma", maHD));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch
            {
                throw;
            }
            return dt;
        }
    }
}
