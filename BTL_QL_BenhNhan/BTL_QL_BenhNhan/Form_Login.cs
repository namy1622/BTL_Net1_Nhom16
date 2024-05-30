using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;
using System.Text.RegularExpressions;


namespace BTL_QL_BenhNhan
{
    public partial class Form_Login : Form
    {
        // khai báo 
        DTO_TaiKhoan tai_khoan;
        BUS_Login busLogin = new BUS_Login();

        public Form_Login()
        {
            InitializeComponent();

            gb_ReMK.Hide();
            gb_SDT.Hide();

            


            SetHintText();
            
        }

        #region THIẾT LẬP MẶC ĐỊNH TEXTBOX 
        // thiết lập hint ô textBox 
        string hintTaiKhoan = "nhập email";
        string hintMatKhau = "nhập mật khẩu ";
        string hintNhapLaiMK = "nhập lại mật khẩu";

        public void SetHintText()
        {
            txb_MatKhau.PasswordChar = '\0';

            // thiết lập chữ hint 
            txb_TaiKhoan.ForeColor = txb_MatKhau.ForeColor = txb_ReMK.ForeColor = Color.Gray;
            // text hint 
            txb_TaiKhoan.Text = hintTaiKhoan;
            txb_MatKhau.Text = hintMatKhau;
            txb_ReMK.Text = hintNhapLaiMK;

        }
        #endregion THIẾT LẬP MẶC ĐỊNH TEXTBOX 

        #region KHI NHẤN NHẬP VÀO Ô TEXTBOX 
        private void txb_TaiKhoan_Enter(object sender, EventArgs e)
        {
            if(txb_TaiKhoan.Text == hintTaiKhoan)
            {
                
                // xóa văn bản và màu chữ 
                txb_TaiKhoan.Text = "";
                txb_TaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txb_MatKhau_Enter(object sender, EventArgs e)
        {
            if (txb_MatKhau.Text == hintMatKhau)
            {
                txb_MatKhau.PasswordChar= '*';
                // xóa văn bản và màu chữ 
                txb_MatKhau.Text = "";
                txb_MatKhau.ForeColor = Color.Black;
            }
        }

        private void txb_ReMK_Enter(object sender, EventArgs e)
        {
            if (txb_ReMK.Text == hintNhapLaiMK)
            {
                txb_ReMK.PasswordChar = '*';
                // xóa văn bản và màu chữ 
                txb_ReMK.Text = "";
                txb_ReMK.ForeColor = Color.Black;
            }
        }
        #endregion KHI NHẤN NHẬP VÀO Ô TEXTBOX 

        #region KHI RỜI Ô TEXTBOX + GIÁ TRỊ NULL 
        private void txb_TaiKhoan_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txb_TaiKhoan.Text))
            {

                txb_TaiKhoan.ForeColor = Color.Gray;
                txb_TaiKhoan.Text = hintTaiKhoan;
            }

            if (!DangTaiKhoan(txb_TaiKhoan.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.\n Là tài khoản gmail\n Có dạng ...@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_TaiKhoan.Focus(); // Đưa con trỏ về lại textBox để nhập lại
                txb_TaiKhoan.SelectAll(); // Chọn toàn bộ văn bản trong textBox để dễ dàng nhập lại
            }
        }

        private void txb_MatKhau_Leave(object sender, EventArgs e)
        {
            // Kiểm tra xem textBox chứa chuỗi định dạng email hợp lệ hay không
            
            if (string.IsNullOrWhiteSpace(txb_MatKhau.Text))
            {
                txb_MatKhau.PasswordChar = '\0';
                txb_MatKhau.ForeColor = Color.Gray;
                txb_MatKhau.Text = hintTaiKhoan;
            }
        }

        private void txb_ReMK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_ReMK.Text))
            {
                txb_ReMK.PasswordChar = '\0';
                txb_ReMK.ForeColor = Color.Gray;
                txb_ReMK.Text = hintTaiKhoan;
            }
        }
        #endregion  KHI RỜI Ô TEXTBOX + GIÁ TRỊ NULL 

        // sk để form this hiện lại 
        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        #region CHUYỂN ĐỔI GIỮA CÁC CHỨC NĂNG ĐKI - ĐNHAP - QUÊNMK 
        // chuyển đổi giữa Đăng kí - Đăng nhập 
        private void btn_DK_DN_Click(object sender, EventArgs e)
        {
            if(btn_DK_DN.Text == "Đăng kí")
            {
                pn_TK_MK.Show();
                btn_LogIn_Out.Text = "Đăng kí";
                btn_DK_DN.Text = "Đăng nhập";
                gb_ReMK.Show();
                gb_SDT.Show();
                lb_Main.Text = "Đăng kí";

                //gb_TK.Location = new Point(556, 190);
                //gb_MK.Location = new Point(556, 271);

            }
            else if (btn_DK_DN.Text == "Đăng nhập")
            {
                pn_TK_MK.Show();
                btn_LogIn_Out.Text = "Đăng nhập";
                btn_DK_DN.Text = "Đăng kí";
                gb_ReMK.Hide();
                gb_SDT.Hide();
                lb_Main.Text = "Đăng nhập";

                //gb_TK.Location = new Point(556, 170);
                //gb_MK.Location = new Point(556, 251);

            }
        }

        // bấm để chuyển qua phần Quên mật khẩu 
        private void btn_QuenMK_Click(object sender, EventArgs e)
        {
            pn_TK_MK.Hide();
            lb_Main.Text = "Quên mật khẩu";
        }


        #endregion CHUYỂN ĐỔI GIỮA CÁC CHỨC NĂNG ĐKI - ĐNHAP - QUÊNMK 

        #region ĐĂNG KÍ - ĐĂNG NHẬP 
        private void btn_LogIn_Out_Click_1(object sender, EventArgs e)
        {
            // TH text là Đăn nhập
            if (btn_LogIn_Out.Text == "Đăng nhập")
            {

                String taikhoan = txb_TaiKhoan.Text;
                String matkhau = txb_MatKhau.Text;

                // khởi tạo đôi tượng 
                tai_khoan = new DTO_TaiKhoan(taikhoan, matkhau, "");

                if (busLogin.DangNhap(tai_khoan))
                {

                    Form_TrangChu tranchu = new Form_TrangChu();
                    tranchu.Show();
                    // Đăng kí sk khi form TrangChu đóng -> Form thí sẽ hiện lên 
                    tranchu.FormClosed += TrangChu_FormClosed;

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản & mật khẩu ");
                }

            }
            
            // TH là Đăng kí
            else if (btn_LogIn_Out.Text == "Đăng kí")
            {
                String taikhoan = txb_TaiKhoan.Text;
                String matkhau = txb_MatKhau.Text;
                String reMK = txb_ReMK.Text;

                tai_khoan = new DTO_TaiKhoan(taikhoan, matkhau, reMK);
                busLogin.DangKi(tai_khoan);
            }

            //////////////////////////
            ///



            ///////////////////////
        }

        #endregion  ĐĂNG KÍ - ĐĂNG NHẬP 

        #region QUÊN MẬT KHẨU 

        
        // bấm để gửi mã 
        private void btn_GuiMa_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của textbox nhập email
            string nhapEmail = txb_NhapEmail.Text;

            // Kiểm tra xem nhapEmail có giá trị hợp lệ không
            if (!string.IsNullOrWhiteSpace(nhapEmail))
            {
                // Tạo đối tượng DTO_TaiKhoan và gọi phương thức từ BUS_Login
                tai_khoan = new DTO_TaiKhoan(nhapEmail);
                busLogin.QuenMatKhau(tai_khoan);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // bấm để xác nhận mã 
        private void btn_LayMK_Click(object sender, EventArgs e)
        {
            int otp = Convert.ToInt32(txb_NhapMa.Text);

            tai_khoan = new DTO_TaiKhoan(txb_NhapEmail.Text);

            busLogin.CheckCode(tai_khoan, otp);
        }


        #endregion End QuenMatKhau


        #region HÀM 
        // sự kiện khi tích vào ô Hiện Mật Khẩu 
        private void cb_ShowMK_CheckedChanged(object sender, EventArgs e)
        {
            // khi check 
            if(cb_ShowMK.Checked)
            {
                txb_MatKhau.PasswordChar = '\0';
                txb_ReMK.PasswordChar = '\0';

            }
            // khi uncheck 
            else
            {
                // nếu là hint thì không chịu ảnh hưởng uncheck 
                if(txb_MatKhau.ForeColor == Color.Gray && txb_ReMK.ForeColor == Color.Gray)
                {
                    txb_MatKhau.PasswordChar = '\0';
                    txb_ReMK.PasswordChar = '\0';
                }
                else
                {
                    txb_MatKhau.PasswordChar = '*';
                    txb_ReMK.PasswordChar = '*';
                }
                

            }
        }

        
        // Phương thức kiểm tra chuỗi có đúng định dạng email không
        private bool DangTaiKhoan(string email)
        {
            // Sử dụng Regular Expression để kiểm tra chuỗi có phù hợp với định dạng email không
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        #endregion HÀM 

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
