using BUS;
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
using System.Windows.Forms;
using System.Windows.Media;

namespace BTL_QL_BenhNhan
{
    public partial class Form_XuatVien : Form
    {
        public Form_XuatVien()
        {
            InitializeComponent();
            LoadData();
            LoadDS_BenhNhan();
            dtgv_DSBenhNhan.SelectionChanged += dataGridView1_SelectionChanged;
        }
        DataGridViewRow row = new DataGridViewRow();
        BUS_XuatVien xuatVien = new BUS_XuatVien();
        private void LoadData()
        {

        }

        void LoadDS_BenhNhan()
        {
            dtgv_DSBenhNhan.DataSource = xuatVien.GetXuatVien();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_DSBenhNhan.SelectedRows.Count > 0)
            {
                var row = dtgv_DSBenhNhan.SelectedRows[0];
                txb_MaBN.Text = row.Cells["MaBN"].Value.ToString();
                txb_TenBN.Text = row.Cells["HoTen"].Value.ToString();
                txb_GioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpk_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txb_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                dtpk_NgayNV.Value = Convert.ToDateTime(row.Cells["NgayNV"].Value);
                txb_Benh.Text = row.Cells["Benh"].Value.ToString();
                //txb_VienPhi.Text = row.Cells["VienPhi"].Value.ToString();
                txb_TinhTrang.Text = row.Cells["VienPhi"].Value.ToString();
            }
        }


        private void Form_XuatVien_Load(object sender, EventArgs e)
        {

        }


        private void dtgv_DSBenhNhan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            row = dtgv_DSBenhNhan.Rows[e.RowIndex];

            txb_MaBN.Text = row.Cells[0].Value.ToString();
            txb_TenBN.Text = row.Cells[1].Value.ToString();

            txb_GioiTinh.Text = row.Cells[2].Value.ToString();
            dtpk_NgaySinh.Text = row.Cells[3].Value.ToString();
            txb_CCCD.Text = row.Cells[4].Value.ToString();
            dtpk_NgayNV.Text = row.Cells[5].Value.ToString();
            txb_Benh.Text = row.Cells[6].Value.ToString();
            int _maBN = Convert.ToInt32(row.Cells[0].Value.ToString());


            xuatVien.DisplayImageVienPhi(txb_VienPhi, pb_AnhBN, _maBN);
        }

        private void btn_XuatVien_Click(object sender, EventArgs e)
        {
            if (txb_TinhTrang.Text == "đã đóng")
            {
                int maBN = Convert.ToInt32(row.Cells[0].Value.ToString());
                xuatVien.UpdateXuatVien(maBN.ToString());
                MessageBox.Show("Xuất viện thành công");
                LoadDS_BenhNhan();
            }
            else if (txb_TinhTrang.Text == "chưa đóng")
            {
                MessageBox.Show("Chưa thể xuất viện");
            }
            else if (txb_TinhTrang.Text == "")
            {
                MessageBox.Show("Chọn bệnh nhân từ bảng trước");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}