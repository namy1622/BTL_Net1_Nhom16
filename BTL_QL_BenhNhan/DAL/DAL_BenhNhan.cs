using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Diagnostics;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_BenhNhan
    {
        public static DataTable getBenhNhan()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_getAllBenhNhan", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable getKhoa()
        {
            return DAL_Khoa.getKhoa();
        }
        public static DataTable getBacSi()
        {
            return DAL_BacSi.getBacSi();
        }
        public static void insertBenhNhan(DTO_BenhNhan_q bn)
        {
            try
            {
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        SqlCommand command = new SqlCommand("sp_insertBenhNhan", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@gioiTinh", SqlDbType.NVarChar);
                        command.Parameters.Add("@ngaySinh", SqlDbType.Date);
                        command.Parameters.Add("@CCCD", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@canNang", SqlDbType.Float);
                        command.Parameters.Add("@chieuCao", SqlDbType.Int);
                        command.Parameters.Add("@BHYT", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@tinhTrang", SqlDbType.NVarChar, 50);
                        command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                    // command.Parameters.Add("@maBacSi", SqlDbType.Int);
                    // command.Parameters.Add("@maKhoa", SqlDbType.Int);

                    command.Parameters.Add("@tenBacSi", SqlDbType.NVarChar); //.Value = bn.MaBacSi;
                    command.Parameters.Add("@tenKhoa", SqlDbType.NVarChar); //.Value = bn.MaKhoa;

                        command.Parameters["@ten"].Value = bn.Ten;
                        command.Parameters["@gioiTinh"].Value = bn.GioiTinh;
                        command.Parameters["@ngaySinh"].Value = bn.NgaySinh;
                        command.Parameters["@CCCD"].Value = bn.CCCD1;
                        command.Parameters["@canNang"].Value = bn.CanNang;
                        command.Parameters["@chieuCao"].Value = bn.ChieuCao;
                        command.Parameters["@BHYT"].Value = bn.BHYT1;
                        command.Parameters["@tinhTrang"].Value = bn.TinhTrang;
                        command.Parameters["@diaChi"].Value = bn.DiaChi;
                        command.Parameters["@tenBacSi"].Value = bn.MaBacSi;
                        command.Parameters["@tenKhoa"].Value = bn.MaKhoa;


                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                        conn.Close();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message );
            }
            
        }
        public static void updateBenhNhan(DTO_BenhNhan_q bn)//, byte[] image)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("sp_updateBenhNhan", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ma", SqlDbType.Int);
                    command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@gioiTinh", SqlDbType.NVarChar);
                    command.Parameters.Add("@ngaySinh", SqlDbType.Date);
                    command.Parameters.Add("@CCCD", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@canNang", SqlDbType.Int);
                    command.Parameters.Add("@chieuCao", SqlDbType.Int);
                    command.Parameters.Add("@BHYT", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@tinhTrang", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
                //command.Parameters.Add("@maBacSi", SqlDbType.Int);
                //command.Parameters.Add("@maKhoa", SqlDbType.Int);

                command.Parameters.Add("@maBacSi", SqlDbType.NVarChar);
                command.Parameters.Add("@maKhoa", SqlDbType.NVarChar);


                command.Parameters["@ma"].Value = bn.Ma;
                    command.Parameters["@ten"].Value = bn.Ten;
                    command.Parameters["@gioiTinh"].Value = bn.GioiTinh;
                    command.Parameters["@ngaySinh"].Value = bn.NgaySinh;
                    command.Parameters["@CCCD"].Value = bn.CCCD1;
                    command.Parameters["@canNang"].Value = bn.CanNang;
                    command.Parameters["@chieuCao"].Value = bn.ChieuCao;
                    command.Parameters["@BHYT"].Value = bn.BHYT1;
                    command.Parameters["@tinhTrang"].Value = bn.TinhTrang;
                    command.Parameters["@diaChi"].Value = bn.DiaChi;
                    command.Parameters["@maBacSi"].Value = bn.MaBacSi;
                    command.Parameters["@maKhoa"].Value = bn.MaKhoa;

                   // command.Parameters.Add("@image", SqlDbType.VarBinary, image.Length).Value = image;

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
}
        
        public static void deleteBenhNhan(int maBenhNhan)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("sp_deleteBenhNhan", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ma", SqlDbType.Int);
                    command.Parameters["@ma"].Value = maBenhNhan;

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công");

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("- Lỗi: Không xóa được bệnh nhân - " + ex.Message);
            }
            
        }
        public static DataTable timKiemBenhNhan(string timKiem)
        {

            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_timKiemBenhNhan", conn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào command
            command.Parameters.AddWithValue("@timKiem", timKiem);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;


        }
        //------------------------------------------------
        DataTable dt_Khoa = new DataTable();

        DataTable dt_BacSi = new DataTable();

        public void addValueToCB_Khoa(ComboBox cb_Khoa)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                cb_Khoa.Items.Clear();
                string query = "Select  ten  from khoa";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(dt_Khoa);

                    sqlConnection.Close();

                    foreach (DataRow i in dt_Khoa.Rows)
                    {
                        cb_Khoa.Items.Add($"{i["ten"]}");
                    }
                    // MessageBox.Show("thanh cong");
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm data vào cbBS");
                }

            }

            
        }

        public void addValue_To_cbBacSi(ComboBox cb_BacSi, ComboBox cb_khoa)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                

                string query = "Select bacSi.ten  from bacSi " +
                    " Right join khoa on khoa.ma = bacSi.maKhoa " +
                    "where khoa.ten = N'" + (cb_khoa.Text) + "'";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(dt_BacSi);

                    sqlConnection.Close();

                    cb_BacSi.Items.Clear();
                    foreach (DataRow i in dt_BacSi.Rows)
                    {
                        cb_BacSi.Items.Add($"{i["ten"]}");
                    }
                    //MessageBox.Show("thanh cong");
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm data vào cbBS");
                }
                
                
            }
        }

        public static DataTable getBSTheoKhoa(string maKhoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_getBSTheoKhoa", conn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào command
            command.Parameters.AddWithValue("@maKhoa", maKhoa);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
