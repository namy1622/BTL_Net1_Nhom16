using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DAL
{
    public class DAL_VienPhi
    {
         int maBN;
        
        public void  AddValueToCbMaBN(ComboBox cb_Ma_Ten_BN)
        {
            
            try
            {
                string query = "SELECT ma AS 'Mã bệnh nhân', ten AS 'Họ tên' FROM benhNhan";
                var ma_ten_BN = Modify.Instance.Table(query);

                // Xóa các mục có sẵn trong ComboBox
                cb_Ma_Ten_BN.Items.Clear();

                // Duyệt qua từng dòng trong DataTable và thêm giá trị vào ComboBox
                foreach (DataRow row in ma_ten_BN.Rows)
                {
                    //maBN = Convert.ToInt32(row["Mã bệnh nhân"]);
                    // Thêm một chuỗi được tạo từ các cột trong dòng hiện tại
                    cb_Ma_Ten_BN.Items.Add($"{row["Mã bệnh nhân"]}");
                  //  cb_Ma_Ten_BN.Items.Add($"{row["Mã bệnh nhân"]}  -  {row["Họ tên"]}");


                }
            }
            catch(Exception ex) {
                MessageBox.Show("DAL_VienPhi) Lỗi: " + ex.Message);
                
            }
           
        }

        public void display_ThongTin_VienPhi(ComboBox cb_Ma_Ten_BN, Label lb_MaBN, TextBox txb_HoTen, TextBox txb_GioiTinh,
                                            TextBox txb_DiaChi, TextBox txb_Khoa, TextBox txb_NgayNV,
                                            TextBox txb_SN_NhapVien, TextBox txb_KhamChua, TextBox txb_TienThuoc,
                                            TextBox txb_TienPhong, TextBox txb_TongVienPhi, PictureBox anhBN)
        {
            //int i = cb_Ma_Ten_BN.Items.ToString().Length;
            //MessageBox.Show("" + i);

            SqlCommand sqlCommand;

            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "test";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;

                    
                    int _maBN = Convert.ToInt32(cb_Ma_Ten_BN.Text);
                    
                    sqlCommand.Parameters.Add("@ma", _maBN) ;


                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if(sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                // cb_Ma_Ten_BN.Text = sqlDataReader.GetString(0);
                                lb_MaBN.Text = sqlDataReader.GetInt32(0).ToString();
                                txb_HoTen.Text = sqlDataReader.GetString(1).ToString();

                                txb_GioiTinh.Text = sqlDataReader.GetString(2).ToString();
                                txb_DiaChi.Text = sqlDataReader.GetString(3).ToString();
                                txb_Khoa.Text = sqlDataReader[4].ToString();
                                txb_NgayNV.Text = sqlDataReader[5].ToString();
                                txb_SN_NhapVien.Text = sqlDataReader[7].ToString();
                                txb_TienPhong.Text = sqlDataReader[10].ToString();
                                txb_KhamChua.Text = sqlDataReader[11].ToString();
                                txb_TienThuoc.Text = sqlDataReader[12].ToString();

                                txb_TongVienPhi.Text = sqlDataReader[13].ToString();


                                // chuyển dl từ cột 14 -> mảng byte 
                                byte[] imageData = (byte[])sqlDataReader[14];
                                    //MemoryStream để tạo một hình ảnh từ mảng byte
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    anhBN.Image = Image.FromStream(ms);

                                }
                            }   
                            //-----------------------------


                        }
                    
                    }
                    

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("(DAL_VienPhi-display_ThongTin_VienPhi) : " + ex.Message);
            }


        }

        //----------------------------------------

        private byte[] ImageToByte_Array(PictureBox pictureBox)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);

                return memoryStream.ToArray();
            }
                
        }


        //HÀM LƯU ẢNH VÀO SQL

        //public void addImage(PictureBox pb_AnhBN, ComboBox cb_Ma_Ten_BN)
        //{
        //    byte[] imageByte = ImageToByte_Array(pb_AnhBN);


        //    string query = "UPDATE benhNhan SET anhBenhNhan = @ImageBytes WHERE ma = @Ma";

        //    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        //    {
        //        sqlConnection.Open();

        //        SqlCommand cmd = new SqlCommand(query, sqlConnection);

        //        cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = imageByte;
        //        cmd.Parameters.Add("@Ma", SqlDbType.NVarChar).Value = cb_Ma_Ten_BN.Text;
        //        cmd.ExecuteNonQuery();

        //        MessageBox.Show("ThanhCong");
        //        sqlConnection.Close();
        //    }




        //}


    }
}
