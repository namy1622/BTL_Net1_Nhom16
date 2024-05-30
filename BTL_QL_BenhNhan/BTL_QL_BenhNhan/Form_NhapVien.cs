using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_QL_BenhNhan
{
    public partial class Form_NhapVien : Form
    {
        DataTable dataTable_BS = new DataTable();

        DataTable dataTable_Khoa = new DataTable();

        DataTable dataTable_Phong = new DataTable();
        BUS_Phong bus_Phong = new BUS_Phong();
        BUS_NhapVien bus_NhapVien = new BUS_NhapVien();
        public Form_NhapVien()
        {
            InitializeComponent();

            ValueToCB_maBS_tenBS();
            ValueToCB_Khoa();
            ValueToCB_Phong();

            cb_maBS.Items.Clear();

            foreach (DataRow row in dataTable_BS.Rows)
            {
                cb_maBS.Items.Add(row["ma"]);
            }

            cb_maKhoa.Items.Clear();

            foreach (DataRow row in dataTable_Khoa.Rows)
            {
                cb_maKhoa.Items.Add(row["ma"]);
            }

            cb_Phong.Items.Clear();
            foreach (DataRow row in dataTable_Phong.Rows)
            {
                cb_Phong.Items.Add(row["ma"]);
            }
        }




        private void Form_NhapVien_Load(object sender, EventArgs e)
        {

        }

        private void cb_maBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueToCB_maBS_tenBS();

            // Kiểm tra SelectedItem khác null
            if (cb_maBS.SelectedItem != null)
            {
                string selectedMaBS = cb_maBS.SelectedItem.ToString();

                // Duyệt qua các hàng trong dataTable
                foreach (DataRow row in dataTable_BS.Rows)
                {
                    // So sánh giá trị của cột "ma" với giá trị được chọn từ ComboBox
                    if (row["ma"].ToString() == selectedMaBS)
                    {
                        // Gán giá trị của cột "ten" vào TextBox
                        txb_TenBS.Text = row["ten"].ToString();

                        // Thoát khỏi vòng lặp sau khi tìm thấy hàng tương ứng
                        break;
                    }
                }
            }
        }


        public void ValueToCB_maBS_tenBS()
        {
            dataTable_BS = BUS_BacSi.getBacSi();
        }

        public void ValueToCB_Phong()
        {
            dataTable_Phong = bus_Phong.GetPhong();
        }
        public void ValueToCB_Khoa()
        {
            dataTable_Khoa = BUS_Khoa.getKhoa();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            var data = new DTO_NhapVien_q();
            byte[] imageByte = null;
            string _gioiTinh = cb_GioiTinh.SelectedItem.ToString();

            MessageBox.Show(_gioiTinh);
            if (pb_AnhBN.Image != null)
            {
                imageByte = ImageToByte_Array(pb_AnhBN);
            }
            data.NgayNhap = dtpk_NgayKham.Value.ToString();
            data.TinhTrang = txb_LyDoKham.Text.ToString();
            data.LyDoKham = txb_LyDoKham.Text.ToString();
            data.MaPhong = cb_Phong.Text.ToString();
            data.Ten = txb_HoTen.Text.ToString();
            data.GioiTinh = _gioiTinh;
            data.NgaySinh = dtpk_NgaySinh.Value.ToString();
            data.DiaChi = txb_diaChi.Text;
            data.CanNang = txb_CanNang.Text;
            data.ChieuCao = txb_ChieuCao.Text;
            data.MaBacSi = cb_maBS.Text;
            data.MaKhoa = cb_maKhoa.Text;
            data.CCCDS = txb_CCCD.Text;
            data.BHYTS = txb_BHYT.Text;
            data.imageByte = imageByte;

            bus_NhapVien.InsertNhapVienAndBN(data);

           
        }

        // chuyển ảnh sang byte
        private byte[] ImageToByte_Array(PictureBox pictureBox)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);

                return memoryStream.ToArray();
            }

        }

        private void btn_TaiAnh_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_AnhBN.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            ClearControls(this.Controls);
            pb_AnhBN.Image = null;

            //foreach (Control x in this.Controls)
            //{
            //    if (x is TextBox)
            //    {
            //        ((TextBox)x).Clear();
            //    }
            //    else if (x is ComboBox)
            //    {
            //        ((ComboBox)x).SelectedIndex = -1;
            //    }
            //}
            //pb_AnhBN.Image = null;
        }
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
                else if (control.HasChildren)
                {
                    ClearControls(control.Controls);
                }
            }
        }

    }
}
