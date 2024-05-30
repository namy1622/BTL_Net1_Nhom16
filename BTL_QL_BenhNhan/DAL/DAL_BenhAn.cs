using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_BenhAn
    {
        public static DTO_BenhAn GetBenhAnByMaBN(string maBN)
        {
            var data = new DTO_BenhAn();
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("sp_SearchBenhAnByMaBN", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mabn", maBN);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data.Ten = reader["ten"].ToString();
                            data.GioiTinh = reader["gioiTinh"].ToString();
                            data.MaKhoa = (!string.IsNullOrEmpty(reader["maKhoa"].ToString()) ? int.Parse(reader["maKhoa"].ToString()) : 0);
                            data.TinhTrang = reader["tinhTrang"].ToString();
                            data.DiaChi = reader["diachi"].ToString();
                            data.NgayNhap = reader["ngayNhap"].ToString();
                            data.NgayXuat = reader["ngayXuat"].ToString();
                            byte[] imageData = (byte[])reader["anhBenhNhan"];
                            data.AnhBenhNhan = imageData;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân.");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
            return data;
        }
    }
}
