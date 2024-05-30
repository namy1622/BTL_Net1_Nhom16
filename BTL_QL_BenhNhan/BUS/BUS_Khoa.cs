using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_Khoa
    {
        public static DataTable getKhoa()
        {
            return DAL_Khoa.getKhoa();
        }
        public static void insertKhoa(DTO_Khoa khoa)
        {
            DAL_Khoa.insertKhoa(khoa);
        }
        public static void updateKhoa(DTO_Khoa khoa)
        {
            DAL_Khoa.updateKhoa(khoa);
        }
        public static void deleteKhoa(int maKhoa)
        {
            DAL_Khoa.deleteKhoa(maKhoa);
        }
        public static DataTable timKiemKhoa(string timKiem)
        {
            return DAL_Khoa.timKiemKhoa(timKiem);
        }
    }
}
