using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BAL
{
   public class BAL_ChucVu
    {
        DAL_ChucVu xulichucvu = new DAL_ChucVu();
        public DataTable loadDSChucVu()
        {
            return xulichucvu.loadDSChucVu();
        }

        public string layMaChucVu(string text)
        {
            return xulichucvu.LayMaChucVu(text);
        }
    }
}
