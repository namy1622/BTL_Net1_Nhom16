using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;
namespace BUS
{
    public class BUS_BenhNhan
    {

        DAL_BenhNhan dal_benhNhan = new DAL_BenhNhan();

        public static DataTable getBenhNhan()
        {
            return DAL_BenhNhan.getBenhNhan();
        }
        public static DataTable getKhoa()
        {
            return DAL_Khoa.getKhoa();
        }
        public static DataTable getBacSi()
        {
            return DAL_BacSi.getBacSi();
        }
        public static void insertBenhNhan(DTO_BenhNhan_q bn)
        {
            DAL_BenhNhan.insertBenhNhan(bn);
        }
        public static void updateBenhNhan(DTO_BenhNhan_q bn)  //, byte[] image)
        {
                DAL_BenhNhan.updateBenhNhan(bn);//, image);
        }
        public static void deleteBenhNhan(int maBenhNhan)
        {
            DAL_BenhNhan.deleteBenhNhan(maBenhNhan);
        }
        public static DataTable timKiemBenhNhan(string timKiem)
        {
            return DAL_BenhNhan.timKiemBenhNhan(timKiem);
        }

        //-------------------------------------------

        XuatExcel xuatExcel = new XuatExcel();
        public  void toExCel(DataGridView dtgv)
        {
            xuatExcel.toExcel(dtgv);
        }
        //---------------------------------------

        public void addValue_To_cbKhoa(ComboBox cbKhoa)
        {
            dal_benhNhan.addValueToCB_Khoa(cbKhoa);
        }

        public void addValue_To_cbBacSi(ComboBox cbBacSi, ComboBox cbKhoa)
        {
            dal_benhNhan.addValue_To_cbBacSi(cbBacSi, cbKhoa);
        }


        public static DataTable getBSTheoKhoa(string maKhoa)
        {
            Console.WriteLine(maKhoa);
            return DAL_BenhNhan.getBSTheoKhoa(maKhoa);
        }

    }
}
