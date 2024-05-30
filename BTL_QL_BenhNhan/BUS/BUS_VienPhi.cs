using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_VienPhi
    {

        DAL_VienPhi vienPhi = new DAL_VienPhi();

        public void AddValueCB(ComboBox cb_Ma_Ten_BN)
        {
            vienPhi.AddValueToCbMaBN(cb_Ma_Ten_BN);
        }

        public void display_ThongTin_VienPhi(ComboBox cb_Ma_Ten_BN, Label lb_MaBN, TextBox txb_HoTen, TextBox txb_GioiTinh,
                                            TextBox txb_DiaChi, TextBox txb_Khoa, TextBox txb_NgayNV,
                                            TextBox txb_SN_NhapVien, TextBox txb_KhamChua, TextBox txb_TienThuoc,
                                            TextBox txb_TienPhong, TextBox txb_TongVienPhi, PictureBox anhBN)
        {
            vienPhi.display_ThongTin_VienPhi(cb_Ma_Ten_BN, lb_MaBN, txb_HoTen, txb_GioiTinh, txb_DiaChi, txb_Khoa, txb_NgayNV,
                                            txb_SN_NhapVien, txb_KhamChua, txb_TienThuoc, txb_TienPhong, txb_TongVienPhi, anhBN);
        }

        //public void addAnh_sql(PictureBox pb, ComboBox cb_maBN)
        //{
        //    vienPhi.addImage(pb, cb_maBN);
        //}
    }
}
