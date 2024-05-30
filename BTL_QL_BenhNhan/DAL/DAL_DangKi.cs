using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL
{
    public class DAL_DangKi
    {
        public DAL_DangKi() { }

        public void dangKi(DTO_TaiKhoan tai_khoan)
        {
            // câu truy vấn kiểm tra tài khoản nhập vào tồn tại chưa 
            // neeus tồn tại--> trả về 1 
            // nếu chưa có --> trả về rỗng 
            string check_TaiKhoan = "SELECT COUNT(taiKhoan) FROM nguoiDung WHERE taiKhoan = '" + tai_khoan.Tai_Khoan + "'";

            //khi chưa tồn tại 
            if ((int)Modify.Instance.Command_Scalar(check_TaiKhoan) != 1)
            {
                try
                {
                    // truy vấn thêm giá trị vào bàng nguoiDung 
                    string query = "INSERT INTO nguoiDung(taiKhoan, matKhau, soDienThoai)" +
                    " VALUES ('" + tai_khoan.Tai_Khoan + "','" + tai_khoan.Mat_Khau + "','" + tai_khoan.So_Dien_Thoai + "')";

                    Modify.Instance.Command_NonQuery(query); // thực hiện câu truy vấn 

                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("(DAL_DangKi) Lỗi: " + ex.Message);
                }
            }
            //
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }


        }
    }
}
