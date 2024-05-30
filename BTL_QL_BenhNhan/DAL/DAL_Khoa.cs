using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Khoa
    {


        public static DataTable getKhoa()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_getAllKhoa", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void insertKhoa(DTO_Khoa khoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_insertKhoa", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@ngayThanhLap", SqlDbType.Date);
            command.Parameters["@ten"].Value = khoa.Ten;
            command.Parameters["@ngayThanhLap"].Value = khoa.NgayThanhLap;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void updateKhoa(DTO_Khoa khoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_updateKhoa", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ma", SqlDbType.Int);
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@ngayThanhLap", SqlDbType.Date);
            command.Parameters["@ma"].Value = khoa.Ma;
            command.Parameters["@ten"].Value = khoa.Ten;
            command.Parameters["@ngayThanhLap"].Value = khoa.NgayThanhLap;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void deleteKhoa(int maKhoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_deleteKhoa", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ma", SqlDbType.Int);
            command.Parameters["@ma"].Value = maKhoa;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable timKiemKhoa(string timKiem)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_timKiemKhoa", conn);
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
    }
}
