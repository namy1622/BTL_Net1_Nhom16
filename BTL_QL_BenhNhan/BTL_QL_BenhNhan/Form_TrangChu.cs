using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QL_BenhNhan
{
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {

        }




        #region methods
        
            #region showFormChild
                private Form showForm;

                private void OpenForm(Form childForm)
                {
                    if (showForm != null)
                    {
                        showForm.Close();
                    }

                    showForm = childForm;
                    childForm.TopLevel = false; // chỉ định là form con 
                    childForm.Dock = DockStyle.Fill; // để tự động lấp đầy không gian
                    childForm.FormBorderStyle = FormBorderStyle.None; // bỏ viền 
                    pn_showForm.Controls.Add(childForm); // thêm vào ds controls 
                    pn_showForm.Tag = childForm; // lưu trữ tt tùy chỉnh 
                    childForm.BringToFront(); // xếp lên phía trước của panel để hiện form con 
                    childForm.Show();
                }
            #endregion showFormChild


        #endregion methods


        #region events
        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            if (showForm != null)
            {
                showForm.Close();
            }
        }

        private void btn_Form_BenhNhan_Click(object sender, EventArgs e)
         {
            // tham chiếu form BenhNhan tới hàm OpenForm 
              OpenForm(new Form_BenhNhan());


         }

        private void btn_BacSi_Click(object sender, EventArgs e)
        {
            OpenForm(new BacSi());
        }

        private void btn_BenhAn_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_BenhAn());
        }

        private void btn_Form_Khoa_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_Khoa());
        }

        private void btn_VienPhi_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_VienPhi());
        }

        private void btn_NhapVien_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_NhapVien());
        }

        private void btn_XuatVien_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_XuatVien());
        }
        // thoát ứng dụng 
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát ứng dụng ? ","Cảnh báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit() ;
            }
        }
        // thoát u.d bằng dấu x
        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }
        // đăng xuất 
        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ? ", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                
                Form_Login login = new Form_Login();
                login.Show();
            }
           
        }










        #endregion events

       
    }
}
