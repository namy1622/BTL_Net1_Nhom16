using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_BacSi
    {
        public static DataTable getBacSi()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_getAllBacSi", conn);
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
        public static void insertBacSi(DTO_BacSi_q bs)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_insertBacSi", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gioiTinh", SqlDbType.Bit);
            command.Parameters.Add("@ngaySinh", SqlDbType.Date);
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@trinhDo", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@chucVu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@maKhoa", SqlDbType.Int);




            command.Parameters["@ten"].Value = bs.Ten;
            command.Parameters["@gioiTinh"].Value = bs.GioiTinh;
            command.Parameters["@ngaySinh"].Value = bs.NgaySinh;
            command.Parameters["@diaChi"].Value = bs.DiaChi;
            command.Parameters["@trinhDo"].Value = bs.TrinhDo;
            command.Parameters["@chucVu"].Value = bs.ChucVu;
            command.Parameters["@maKhoa"].Value = bs.MaKhoa;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void updateBacSi(DTO_BacSi_q bs)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_updateBacSi", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ma", SqlDbType.Int);
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gioiTinh", SqlDbType.Bit);
            command.Parameters.Add("@ngaySinh", SqlDbType.Date);
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@trinhDo", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@chucVu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@maKhoa", SqlDbType.Int);

            command.Parameters["@ma"].Value = bs.Ma;
            command.Parameters["@ten"].Value = bs.Ten;
            command.Parameters["@gioiTinh"].Value = bs.GioiTinh;
            command.Parameters["@ngaySinh"].Value = bs.NgaySinh;
            command.Parameters["@diaChi"].Value = bs.DiaChi;
            command.Parameters["@trinhDo"].Value = bs.TrinhDo;
            command.Parameters["@chucVu"].Value = bs.ChucVu;
            command.Parameters["@maKhoa"].Value = bs.MaKhoa;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void deleteBacSi(int maBacSi)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_deleteBacSi", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ma", SqlDbType.Int);
            command.Parameters["@ma"].Value = maBacSi;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("- Bác sĩ này đang điều trị bệnh nhân. Không thể xóa!!!\n Hãy sửa phần bác sĩ điều trị ở bệnh nhân để có thể xóa!!!");
            }
            
        }
        public static DataTable timKiemBacSi(string timKiem)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            SqlCommand command = new SqlCommand("sp_timKiemBacSi", conn);
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
