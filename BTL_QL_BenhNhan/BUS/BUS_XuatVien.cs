using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_XuatVien
    {
        public DataTable GetXuatVien()
        {
            return DAL_XuatVien.getXuatVien();
        }
        public void UpdateXuatVien(string mabn)
        {
            DAL_XuatVien.updateVienPhi(mabn);
        }
        public void DisplayImageVienPhi(TextBox txt_VienPhi, PictureBox anhBA, int maBN)
        {
            DAL_XuatVien.DisplayImageVienPhi(txt_VienPhi, anhBA, maBN);
        }
    }
}
