using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_QuenMatKhau
    {
        private int otp;
        public void check_Code(DTO_TaiKhoan taiKhoan, int code)
        {
            // nếu code nhập == otp gửi 
           if(code == otp)
            {
                string query = "SELECT matKhau FROM nguoiDung WHERE taiKhoan = '" + taiKhoan.EmailXacNhan + "'";

                
                try
                {
                    // thưc hiện câu truy vấn để lấy MK 
                     String checkTaiKhoan = (String)Modify.Instance.Command_Scalar(query);

                    MessageBox.Show("Mật khẩu tài khoản: " + taiKhoan.EmailXacNhan + " là: " + checkTaiKhoan,
                   "Thông báo",
                   MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn : " + ex.Message);
                }             

            }

        }


        #region Create Sample Code
        // hàm tạo mã ngẫu nhiên 6 chữ số 
        private string createCode()
        {
            Random random = new Random();
            const string chars = "0123456789"; // các kí tự sử dụng để tạo chuỗi ngẫu nhiên 

            //  Enumerable.Repeat(chars, 6): chuỗi gồm 6 LẦN LẶP chuỗi chars 
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion

        ////////////////////////////
        ///
       

        public void send_Email(DTO_TaiKhoan taikhoan)
        {
            // câu truy vấn kiểm tra tài khoản nhập vào tồn tại chưa 
            // neeus tồn tại--> trả về 1 
            // nếu chưa có --> trả về rỗng 
            string check_TaiKhoan = "SELECT COUNT(taiKhoan) FROM nguoiDung WHERE taiKhoan = '" + taikhoan.EmailXacNhan + "'";

            //khi chưa tồn tại 
            if ((int)Modify.Instance.Command_Scalar(check_TaiKhoan) == 1)
            {
                Random random = new Random();
                try
                {
                    otp = random.Next(1000, 10000); // taoj mã ngẫu nhiên từ 1000 -> 10000

                    var fromAddress = new MailAddress("namgoku235@gmail.com","Quản Lý Bệnh Nhân");
                    var toAddress = new MailAddress(taikhoan.EmailXacNhan);

                    const string fromPass = "putm xvul wdxi cdpp";
                    const string subject = "Mã xác nhận";
                    string body = "\t Code: " + otp.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        
                        Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                        Timeout = 2000000

                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Otp đã được gửi vào email", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email không tồn tại", "Thông báo", MessageBoxButtons.OK);

            }

        }
    }
}
