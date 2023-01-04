using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TaiKhoan : Connection
    {
        public TaiKhoan KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            TaiKhoan tk = null;
            String sql = "select MaNV,TenNV,TenChucVu from tbnhanvien a,tbchucvu b where a.machucvu = b.machucvu and a.DaXoa = 0 and MaNV = '" + tendangnhap + "' and MatKhau='" + matkhau + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    tk = new TaiKhoan(rd["MaNV"].ToString(), rd["TenNV"].ToString(), rd["TenChucVu"].ToString());
                }
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return tk;
        }
    }
}
