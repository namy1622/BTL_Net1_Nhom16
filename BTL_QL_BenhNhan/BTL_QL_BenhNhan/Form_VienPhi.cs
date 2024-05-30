using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;

namespace BTL_QL_BenhNhan
{
    public partial class Form_VienPhi : Form
    {
        

        BUS_VienPhi busVienPhi = new BUS_VienPhi();
        DTO_BenhNhan DTO_benhNhan;

        public Form_VienPhi()
        {
            InitializeComponent();

            AddValue_CbMaBN();
        }

 

        private void Form_VienPhi_Load(object sender, EventArgs e)
        {
            
        }


        //
        public void AddValue_CbMaBN()
        {      
            // truyền cb_MaBN --> truyền dl vào cb 
            busVienPhi.AddValueCB(cb_MaBN);

            
        }

        //public void ReloadData()
        //{
        //    // Gọi lại hàm AddValue_CbMaBN để cập nhật dữ liệu cho comboBox
        //    AddValue_CbMaBN();

        //    // Gọi lại hàm display_ThongTin_VienPhi để hiển thị thông tin mới cho bệnh nhân được chọn
        //    busVienPhi.display_ThongTin_VienPhi(cb_MaBN, lb_MaBN, txb_HoTen, txb_GioiTinh, txb_DiaChi, txb_Khoa, txb_NgayNV,
        //                                         txb_SN_NhapVien, txb_KhamChua, txb_TienThuoc, txb_TienPhong, txb_TongVienPhi, pb_AnhBN);
        //}

        private void cb_MaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lb_MaBN.Text = "";
            busVienPhi.display_ThongTin_VienPhi(cb_MaBN, lb_MaBN, txb_HoTen, txb_GioiTinh, txb_DiaChi, txb_Khoa, txb_NgayNV,
                                            txb_SN_NhapVien, txb_KhamChua, txb_TienThuoc, txb_TienPhong, txb_TongVienPhi, pb_AnhBN);

            //Form_VienPhi_Load(sender, e);

            // Load lại dữ liệu trên form
           
        }

        private void pb_AnhBN_Click(object sender, EventArgs e)
        {

        }





        // hamf chọn ảnh 
        //private void btn_Anh_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.Title = "Chọn ảnh";
        //    open.Filter = "Image Files(*.gif; *jpg; *.jpeg; *.bmp; *.wmf, *.png) |*.gif; *jpg; *.jpeg; *.bmp; *.wmf, *.png";


        //    //đã chọn ảnh bất kì 
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        pb_AnhBN.ImageLocation = open.FileName; //sex show ra picBox
        //    }
        //}

        //------------------------

        //hamf gọi để lưu ảnh vào sql 
        //private void btn_Add_Click(object sender, EventArgs e)
        //{
        //    busVienPhi.addAnh_sql(pb_AnhBN, cb_MaBN);
        //}
    }
}
