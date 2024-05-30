using BUS;
using DTO;
using Microsoft.Win32;
using System;
using System.Collections;
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

namespace BTL_QL_BenhNhan
{
    public partial class Form_BenhNhan : Form
    {
        public Form_BenhNhan()
        {
            InitializeComponent();

            //load_cbKhoa();
           
            //cbb_MaBS.Items.Clear();
        }

        BUS_BenhNhan busBenhNhan = new BUS_BenhNhan();
        BUS_Color bus_color = new BUS_Color();
        private void Form_BenhNhan_Load(object sender, EventArgs e)
        {
            dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();

            loadKhoa();
            loadBacSi();
        }

        private void loadKhoa()
        {
            cbb_MaKhoa.DataSource = BUS_BenhNhan.getKhoa();
            cbb_MaKhoa.DisplayMember = "ten";
            cbb_MaKhoa.ValueMember = "ma";
        }
        private void loadBacSi()
        {
            cbb_MaBS.DataSource = BUS_BenhNhan.getBacSi();
            cbb_MaBS.DisplayMember = "ten";
            cbb_MaBS.ValueMember = "ma";
        }

        private void load_cbKhoa()
        {
            ////cbb_MaBS.Items.Clear();
            //busBenhNhan.addValue_To_cbKhoa(cbb_MaKhoa);

            //cbb_MaKhoa.DisplayMember = "ten";
            //cbb_MaKhoa.ValueMember = "ma";


           
        }
        private void load_cbBacSi()
        {

           // var selectedMaKhoa = (((DataRowView)cbb_MaKhoa.SelectedItem)["ma"]).ToString();
            busBenhNhan.addValue_To_cbBacSi(cbb_MaBS, cbb_MaKhoa);



            //// Gán danh sách bác sĩ đã lọc vào combobox cbb_maBS
            //cbb_MaBS.DataSource = filteredBacSi;
            cbb_MaBS.DisplayMember = "ten";
            cbb_MaBS.ValueMember = "ma";
            //cbb_MaBS.DisplayMember = "ma";
        }


        private void dtgv_DS_BenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng được chọn có hợp lệ không
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_DS_BenhNhan.Rows[e.RowIndex];

                txb_MaBN.Text = row.Cells[0].Value.ToString();
                txb_TenBN.Text = row.Cells[1].Value.ToString();
                txb_GioiTinh.Text = row.Cells[2].Value.ToString();
                dtpk_NgaySinh.Text = row.Cells[3].Value.ToString();
                txb_CCCD.Text = row.Cells[4].Value.ToString();
                txb_CanNang.Text = row.Cells[5].Value.ToString();
                txb_ChieuCao.Text = row.Cells[6].Value.ToString();
                txb_BHYT.Text = row.Cells[7].Value.ToString();
                txb_TinhTrang.Text = row.Cells[8].Value.ToString();
                txb_DiaChi.Text = row.Cells[9].Value.ToString();
                //cbb_MaBS.SelectedValue = (int)row.Cells[11].Value;
                //cbb_MaKhoa.SelectedValue = (int)row.Cells[13].Value;

                cbb_MaBS.Text = row.Cells[10].Value.ToString();

                
                cbb_MaKhoa.Text = row.Cells[12].Value.ToString();

                
                object cellImage = dtgv_DS_BenhNhan.Rows[e.RowIndex].Cells[14].Value;

                if (cellImage != null && cellImage != DBNull.Value && cellImage is byte[])
                {
                    byte[] imageData = (byte[])cellImage; // Chuyển đổi object thành mảng byte
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Đọc dữ liệu từ mảng byte và chuyển đổi thành hình ảnh
                        Image image = Image.FromStream(ms);
                        // Gán hình ảnh cho PictureBox
                        pb_AnhBN.Image = image;
                    }
                }
                else
                {
                    // Xử lý khi không có dữ liệu hình ảnh hoặc không hợp lệ
                    // Ví dụ: Hiển thị thông báo lỗi
                    MessageBox.Show("Không có ảnh hoặc dữ liệu ảnh không hợp lệ.");

                    pb_AnhBN.Image = null;
                }
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            #region biến dự phòng
            //int ma = int.Parse(txb_MaBN.Text);
            //string ten = txb_TenBN.Text;
            //string gioiTinh = txb_GioiTinh.Text;
            //DateTime ngaySinh = dtpk_NgaySinh.Value;
            //string CCCD = txb_CCCD.Text;
            //float canNang = float.Parse(txb_CanNang.Text);
            //int chieuCao = int.Parse(txb_ChieuCao.Text);
            //string BHYT = txb_BHYT.Text;
            //string tinhTrang = txb_TinhTrang.Text;
            //string diaChi = txb_DiaChi.Text;
            //int maBacSi = int.Parse(cbb_MaBS.SelectedValue.ToString());
            //int maKhoa = int.Parse(cbb_MaKhoa.SelectedValue.ToString());
            //DTO_BenhNhan_q bn = new DTO_BenhNhan_q(ma, ten, gioiTinh, ngaySinh, CCCD, canNang, chieuCao, BHYT, tinhTrang, diaChi, maBacSi, maKhoa);
            //BUS_BenhNhan.insertBenhNhan(bn);
            //dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();

            //MessageBox.Show("Thêm thành công!");
            #endregion biến dự phòng

            #region biến 
            int ma = int.Parse(txb_MaBN.Text);
            string ten = txb_TenBN.Text;
            string gioiTinh = txb_GioiTinh.Text;
            DateTime ngaySinh = dtpk_NgaySinh.Value;
            string CCCD = txb_CCCD.Text;
            float canNang = float.Parse(txb_CanNang.Text);
            int chieuCao = int.Parse(txb_ChieuCao.Text);
            string BHYT = txb_BHYT.Text;
            string tinhTrang = txb_TinhTrang.Text;
            string diaChi = txb_DiaChi.Text;
            //int maBacSi = int.Parse(cbb_MaBS.SelectedValue.ToString());
            //int maKhoa = int.Parse(cbb_MaKhoa.SelectedValue.ToString());

            String maBacSi = cbb_MaBS.SelectedValue.ToString();
            String maKhoa = cbb_MaKhoa.Text;

            #endregion biến 

            DTO_BenhNhan_q bn = new DTO_BenhNhan_q(ma, ten, gioiTinh, ngaySinh, CCCD, canNang, chieuCao, BHYT, tinhTrang, diaChi,maBacSi, maKhoa);
            BUS_BenhNhan.insertBenhNhan(bn);
            dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();

            Form_BenhNhan_Load(sender, e);
        }

        private byte[] ImageToByte_Array(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);

                    return memoryStream.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh bệnh nhân");
                return null;
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
           // byte[] imageByte = ImageToByte_Array(pb_AnhBN);

            #region biến
            int ma = int.Parse(txb_MaBN.Text);
            string ten = txb_TenBN.Text;
            string gioiTinh = (txb_GioiTinh.Text);
            DateTime ngaySinh = dtpk_NgaySinh.Value;
            string CCCD = txb_CCCD.Text;
            int canNang = int.Parse(txb_CanNang.Text);
            int chieuCao = int.Parse(txb_ChieuCao.Text);
            string BHYT = txb_BHYT.Text;
            string tinhTrang = txb_TinhTrang.Text;
            string diaChi = txb_DiaChi.Text;
            //int maBacSi = int.Parse(cbb_MaBS.SelectedValue.ToString());
            //int maKhoa = int.Parse(cbb_MaKhoa.SelectedValue.ToString());
            string maBacSi = (cbb_MaBS.Text);
            string maKhoa = (cbb_MaKhoa.Text);
            #endregion biến

            DTO_BenhNhan_q bn = new DTO_BenhNhan_q(ma, ten, gioiTinh, ngaySinh, CCCD, canNang, chieuCao, BHYT, tinhTrang, diaChi, maBacSi, maKhoa);
            BUS_BenhNhan.updateBenhNhan(bn);//, imageByte);
                                            // dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();
                                            // 
            Form_BenhNhan_Load(sender, e);
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            int maBenhNhan = int.Parse(txb_MaBN.Text);
            BUS_BenhNhan.deleteBenhNhan(maBenhNhan);
            //dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();
            Form_BenhNhan_Load(sender, e);
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_TimKiem.Text))
            {
                dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();
            }
            else
            {
                string timKiem = txb_TimKiem.Text;
                dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.timKiemBenhNhan(timKiem);
            }
        }

        private void txb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_TimKiem.Text))
            {
                dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.getBenhNhan();
            }
            else
            {
                string timKiem = txb_TimKiem.Text;
                dtgv_DS_BenhNhan.DataSource = BUS_BenhNhan.timKiemBenhNhan(timKiem);
            }
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgv_DS_BenhNhan.Rows.Count > 0)
            {
                busBenhNhan.toExCel(dtgv_DS_BenhNhan);
            }
        }

        private void pb_AnhBN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_AnhBN.ImageLocation = openFileDialog.FileName;
            }
        }

        private void dtgv_DS_BenhNhan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bus_color.colorDataGridView1(dtgv_DS_BenhNhan);
        }

        private void dtgv_DS_BenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //      
        private void cbb_MaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  load_cbBacSi();

            //loadKhoa();

            var selectedMaKhoa = (((DataRowView)cbb_MaKhoa.SelectedItem)["ma"]).ToString();
            //// Lọc danh sách bác sĩ dựa trên mã phụ maKhoa
            var filteredBacSi = BUS_BenhNhan.getBSTheoKhoa(selectedMaKhoa);

            //// Gán danh sách bác sĩ đã lọc vào combobox cbb_maBS
            cbb_MaBS.DataSource = filteredBacSi;
            cbb_MaBS.DisplayMember = "ten";
            cbb_MaBS.ValueMember = "ma";
            // cbb_MaBS.DisplayMember = "ma";

        }


    } 
}      


        #region Thừa
        //---------------------------------
        //private void toExcel(DataGridView dtgv, string fileName)
        //{
        //    Microsoft.Office.Interop.Excel.Application excel = null;
        //    Microsoft.Office.Interop.Excel.Workbook workbook = null;
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

        //    //try
        //    //{
        //        // Tạo đối tượng COM
        //        excel = new Microsoft.Office.Interop.Excel.Application();
        //        excel.Visible = false;
        //        excel.DisplayAlerts = false;

        //        //tạo mới Workbooks bằng phương thức add()
        //        workbook = excel.Workbooks.Add(Type.Missing);
        //        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

        //        // đặt tên cho sheet 
        //        worksheet.Name = "Danh sách bệnh nhân";

        //        // export header trong DataGridView
        //        for (int i = 0; i < dtgv.ColumnCount; i++)
        //        {
        //            worksheet.Cells[1, i + 1] = dtgv.Columns[i].HeaderText;
        //        }

        //        // export nội dung trong DataGridView
        //        for (int row = 0; row < dtgv.RowCount; row++)
        //        {
        //            for (int col = 0; col < dtgv.ColumnCount; col++)
        //            {
        //                if (dtgv.Rows[row].Cells[col].Value != null)
        //                {
        //                    worksheet.Cells[row + 2, col + 1] = dtgv.Rows[row].Cells[col].Value.ToString();
        //                }
        //            }
        //        }

        //        // sử dụng phương thức SaveAs() để lưu workbook với filename 
        //        workbook.SaveAs(fileName);

        //        //đóng workbook
        //        workbook.Close();

        //        //Thoát ứng dụng Excel
        //        excel.Quit();

        //        MessageBox.Show("Xuất dữ liệu ra excel thành công");
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Lỗi xuất excel: " + ex.Message);
        //}
        //finally
        //{
        //    //Giải phóng tài nguyên COM
        //    ReleaseObject(worksheet);
        //    ReleaseObject(workbook);
        //    ReleaseObject(excel);
        //}
   // }

    // Phương thức giải phóng đối tượng Excel
    //private void ReleaseObject(object obj)
    //{
    //    try
    //    {
    //        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
    //        obj = null;
    //    }
    //    catch (Exception ex)
    //    {
    //        obj = null;
    //        MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
    //    }
    //    finally
    //    {
    //        GC.Collect();
    //    }
    //}
    #endregion Thừa



       


