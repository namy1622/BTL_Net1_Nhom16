using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using DTO;

namespace DAL
{
    public class DAL_XuatVien
    {
        public static DataTable getXuatVien()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_GetAllXuatVien", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void DisplayImageVienPhi(TextBox txt_VienPhi, PictureBox anhBA, int maBN)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("XuatVien", conn);
            command.Parameters.Add("@ma", maBN);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            try
            {
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            // cb_Ma_Ten_BN.Text = sqlDataReader.GetString(0);

                            double totalVP = double.Parse(sqlDataReader[10].ToString());
                            txt_VienPhi.Text = totalVP.ToString();


                            // chuyển dl từ cột 14 -> mảng byte 
                            byte[] imageData = (byte[])sqlDataReader[11];
                            //MemoryStream để tạo một hình ảnh từ mảng byte
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                anhBA.Image = Image.FromStream(ms);

                            }
                        }
                        //-----------------------------
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("(XuatVien) : Không có dữ liệu Viện phí");
            }
        }
        public static void updateVienPhi(string mabn)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_UpdateTinhTrangBN", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maBN", SqlDbType.NVarChar);
            command.Parameters["@maBN"].Value = mabn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
