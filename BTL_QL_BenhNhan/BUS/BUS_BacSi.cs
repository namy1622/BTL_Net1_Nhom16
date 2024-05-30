using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_BacSi
    {
        public static DataTable getBacSi()
        {
            return DAL_BacSi.getBacSi();
        }
        public static DataTable getKhoa()
        {
            return DAL_BacSi.getKhoa();
        }
        public static void insertBacSi(DTO_BacSi_q bs)
        {
            DAL_BacSi.insertBacSi(bs);
        }
        public static void updateBacSi(DTO_BacSi_q bs)
        {
            DAL_BacSi.updateBacSi(bs);
        }
        public static void deleteBacSi(int maBacSi)
        {
            DAL_BacSi.deleteBacSi(maBacSi);
        }
        public static DataTable timKiemBacSi(string timKiem)
        {
            return DAL_BacSi.timKiemBacSi(timKiem);
        }


        //---------------------------
        XuatExcel xuatExcel = new XuatExcel();
        public void toExcel(DataGridView dtgv)
        {
            xuatExcel.toExcel(dtgv);
        }

    }
}
