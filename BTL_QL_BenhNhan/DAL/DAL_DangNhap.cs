using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_DangNhap
    {
        //private int _id;
        //private string _taiKhoan;
        //private string _matKhau;
        //private string _soDienThoai;
        public DAL_DangNhap() { }

        public Boolean dangNhap(DTO_TaiKhoan tai_khoan)
        {
            int i;
            // DTO_TaiKhoan tai_Khoan = new DTO_TaiKhoan(_id, _taiKhoan, _matKhau,_soDienThoai);
            try
            {
                
                string query = string.Format("select * from nguoiDung where taiKhoan = '{0}' {1}", tai_khoan.Tai_Khoan, "");
                DataTable dt = Modify.Instance.Table(query);
                i = dt.Rows.Count;
                if (i == 1) { return true; }

            }
            catch (Exception ex)
            {
                MessageBox.Show("(DAL_DangNhap) Lỗi: " + ex.Message);
            }            

            return false;

            ////////////////////////
        }

       
    }
}
