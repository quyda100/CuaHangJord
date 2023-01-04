using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
       public static SqlConnection Conn = new SqlConnection(@"Data Source =DESKTOP-FUF7IKR;Initial Catalog = JordShop;Integrated Security=True;MultipleActiveResultSets=true;");
    }
}
