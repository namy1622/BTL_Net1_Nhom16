using BUS;
using DTO;
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
    public partial class BacSi : Form
    {
        public BacSi()
        {
            InitializeComponent();
        }

   
        private void BacSi_Load(object sender, EventArgs e)
        {
            dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();

            loadKhoa();

        }

    
        private void loadKhoa()
        {
            cbb_Khoa.DataSource = BUS_BacSi.getKhoa();
            cbb_Khoa.DisplayMember = "ten";
            cbb_Khoa.ValueMember = "ma";
        }

    
        private void dtgv_DSBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            if (e.RowIndex >= 0)
            {
                row = dtgv_DSBacSi.Rows[e.RowIndex];

                txb_MaBS.Text = row.Cells[0].Value.ToString();
                txb_TenBS.Text = row.Cells[1].Value.ToString();

                if (row.Cells[2].Value.ToString() == "True")
                {
                    txb_GioiTinh.Text = "nam";
                }
                else if (row.Cells[2].Value.ToString() == "False")
                {
                    txb_GioiTinh.Text = "nữ";
                }
                //txb_GioiTinh.Text = row.Cells[2].Value.ToString();
                dtpk_NgaySinh.Text = row.Cells[3].Value.ToString();
                txb_DiaChi.Text = row.Cells[4].Value.ToString();
                txb_TrinhDo.Text = row.Cells[5].Value.ToString();
                txb_ChucVu.Text = row.Cells[6].Value.ToString();
                cbb_Khoa.SelectedValue = (int)row.Cells[8].Value;

            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            int ma = int.Parse(txb_MaBS.Text);
            string ten = txb_TenBS.Text;
            bool gioiTinh = bool.Parse(txb_GioiTinh.Text);
            //string gioiTinh = txb_GioiTinh.Text;

            DateTime ngaySinh = dtpk_NgaySinh.Value;
            string diaChi = txb_DiaChi.Text;
            string trinhDo = txb_TrinhDo.Text;
            string chucVu = txb_ChucVu.Text;
            int maKhoa = int.Parse(cbb_Khoa.SelectedValue.ToString());
            DTO_BacSi_q bs = new DTO_BacSi_q(ma, ten, gioiTinh, ngaySinh, diaChi, trinhDo, chucVu, maKhoa);
            BUS_BacSi.insertBacSi(bs);
            MessageBox.Show("Đã thêm thành công");
            dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            int ma = int.Parse(txb_MaBS.Text);
            string ten = txb_TenBS.Text;
            bool gioiTinh = bool.Parse(txb_GioiTinh.Text);

            //string gioiTinh = txb_GioiTinh.Text;
            DateTime ngaySinh = dtpk_NgaySinh.Value;
            string diaChi = txb_DiaChi.Text;
            string trinhDo = txb_TrinhDo.Text;
            string chucVu = txb_ChucVu.Text;
            int maKhoa = int.Parse(cbb_Khoa.SelectedValue.ToString());
            DTO_BacSi_q bs = new DTO_BacSi_q(ma, ten, gioiTinh, ngaySinh, diaChi, trinhDo, chucVu, maKhoa);
            BUS_BacSi.updateBacSi(bs);
            MessageBox.Show("Đã sửa thành công");
            dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            int maBacSi = int.Parse(txb_MaBS.Text);
            BUS_BacSi.deleteBacSi(maBacSi);
            //MessageBox.Show("Đã xóa thành công");
            dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Search_MaBS.Text))
            {
                dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();
            }
            else
            {
                string timKiem = txb_Search_MaBS.Text;
                dtgv_DSBacSi.DataSource = BUS_BacSi.timKiemBacSi(timKiem);
            }
        }
        private void txb_Search_MaBS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Search_MaBS.Text))
            {
                dtgv_DSBacSi.DataSource = BUS_BacSi.getBacSi();
            }
            else
            {
                string timKiem = txb_Search_MaBS.Text;
                dtgv_DSBacSi.DataSource = BUS_BacSi.timKiemBacSi(timKiem);
            }
        }

        private void dtgv_DSBacSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        BUS_BacSi bus_bacSi = new BUS_BacSi();
        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            bus_bacSi.toExcel(dtgv_DSBacSi);
        }

        BUS_Color bus_color = new BUS_Color();
        private void dtgv_DSBacSi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bus_color.colorDataGridView1(dtgv_DSBacSi);
        }

       
    }
}
