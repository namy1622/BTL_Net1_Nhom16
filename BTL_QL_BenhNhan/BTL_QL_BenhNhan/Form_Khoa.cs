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
    public partial class Form_Khoa : Form
    {
        public Form_Khoa()
        {
            InitializeComponent();
        }




        private void Form_Khoa_Load(object sender, EventArgs e)
        {
            dtgv_DSKhoa.DataSource = BUS_Khoa.getKhoa();
        }

    

        private void dtgv_DSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_DSKhoa.Rows[e.RowIndex];

            txb_MaKhoa.Text = row.Cells[0].Value.ToString();
            txb_TenKhoa.Text = row.Cells[1].Value.ToString();
            dtpk_NgayThanhLap.Text = row.Cells[2].Value.ToString();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            int ma = int.Parse(txb_MaKhoa.Text);
            string ten = txb_TenKhoa.Text;
            DateTime ngayThanhLap = dtpk_NgayThanhLap.Value;
            DTO_Khoa khoa = new DTO_Khoa(ma, ten, ngayThanhLap);
            BUS_Khoa.updateKhoa(khoa);
            MessageBox.Show("Đã sửa thành công");
            dtgv_DSKhoa.DataSource = BUS_Khoa.getKhoa();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            int ma = int.Parse(txb_MaKhoa.Text);
            string ten = txb_TenKhoa.Text;
            DateTime ngayThanhLap = dtpk_NgayThanhLap.Value;
            DTO_Khoa khoa = new DTO_Khoa(ma, ten, ngayThanhLap);
            BUS_Khoa.insertKhoa(khoa);
            MessageBox.Show("Đã thêm thành công");
            dtgv_DSKhoa.DataSource = BUS_Khoa.getKhoa();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            int maKhoa = int.Parse(txb_MaKhoa.Text);
            BUS_Khoa.deleteKhoa(maKhoa);
            MessageBox.Show("Đã xóa thành công");
            dtgv_DSKhoa.DataSource = BUS_Khoa.getKhoa();
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Search.Text))
            {
                dtgv_DSKhoa.DataSource = BUS_Khoa.getKhoa();
            }
            else
            {
                string timKiem = txb_Search.Text;
                BUS_Khoa.timKiemKhoa(timKiem);
                dtgv_DSKhoa.DataSource = BUS_Khoa.timKiemKhoa(timKiem);
            }
        }

        BUS_Color bus_color = new BUS_Color();
        private void dtgv_DSKhoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bus_color.colorDataGridView1(dtgv_DSKhoa);
        }
    }
}
