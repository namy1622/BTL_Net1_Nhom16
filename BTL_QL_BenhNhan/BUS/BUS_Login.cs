using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class BUS_Login
    {
        DAL_DangNhap DAL_dangNhap = new DAL_DangNhap();
        DAL_DangKi DAL_dangKi = new DAL_DangKi();
        DAL_QuenMatKhau DAL_quenMatKhau = new DAL_QuenMatKhau();
        public BUS_Login() { }

        public Boolean DangNhap(DTO_TaiKhoan taikhoan)
        {
            return DAL_dangNhap.dangNhap(taikhoan);
        }
        public void DangKi(DTO_TaiKhoan taikhoan)
        {
            DAL_dangKi.dangKi(taikhoan);
        }
        public void QuenMatKhau(DTO_TaiKhoan taiKhoan)
        {
            DAL_quenMatKhau.send_Email(taiKhoan);
        }
        
        public void CheckCode(DTO_TaiKhoan taiKhoan,int  code)
        {
            DAL_quenMatKhau.check_Code(taiKhoan, code);
        }
    }
}
