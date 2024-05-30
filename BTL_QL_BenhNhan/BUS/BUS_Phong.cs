using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Phong
    {
        public DataTable GetPhong()
        {
            return DAL_Phong.getPhong();
        }
    }
}
