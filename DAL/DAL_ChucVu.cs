using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_ChucVu:Connection
    {
        public DataTable loadDSChucVu()
        {
            DataTable dt = new DataTable();
            String sql = "select * from tbChucVu";
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

        public string LayMaChucVu(string text)
        {
            String maChucVu = null;
            String sql = "select MaChucVu from tbchucvu where size = '" + text + "'";
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            try
            {
                SqlCommand Cmd = new SqlCommand(sql, Conn);
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    maChucVu = rd["MaChucVu"].ToString();
                }
                rd.Close();
                Conn.Close();
            }
            catch
            {
                throw;
            }
            return maChucVu;
        }
    }
}
