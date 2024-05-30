using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DTO;
using BUS;

namespace BTL_QL_BenhNhan
{
    public partial class Form_BenhAn : Form
    {

        BUS_BenhAn bus_BenhAn = new BUS_BenhAn();

        public Form_BenhAn()
        {
            InitializeComponent();
        }

        private void SearchPatient(string patientId)
        {
            DTO_BenhAn data = bus_BenhAn.GetBenhAnByMaBN(patientId);
            if (data != null && !string.IsNullOrEmpty(data.Ten))
            {
                txb_HoTen.Text = data.Ten;
                txb_GioiTinh.Text = data.GioiTinh;
                txb_ThuocKhoa.Text = data.MaKhoa.ToString();
                txb_ChuanDoan.Text = data.TinhTrang;
                txb_DiaChi.Text = data.DiaChi;
                txb_HuongDieuTri.Text = data.TinhTrang;
                txb_NgayNhapVien.Text = data.NgayNhap;
                txb_NgayXV.Text = data.NgayXuat;
                byte[] imageData = data.AnhBenhNhan;
                //MemoryStream để tạo một hình ảnh từ mảng byte
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pb_AnhBN.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy bệnh nhân.");
            }

        }

        private void Form_BenhAn_Load(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            string patientId = txb_Search_MaBN.Text;
            if (!string.IsNullOrEmpty(patientId))
            {
                SearchPatient(patientId.Trim());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân.");
            }
        }

        private void Form_BenhAn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
