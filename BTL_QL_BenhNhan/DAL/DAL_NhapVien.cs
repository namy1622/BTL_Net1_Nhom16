using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhapVien
    {
        public static void InsertNhapVienAndBN(DTO_NhapVien_q data)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    SqlCommand command = new SqlCommand("sp_InsertNhapVien_BenhNhan", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@NgayKham", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@LyDoKham", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@NgaySinh", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@CanNang", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@ChieuCao", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@MaBS", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@Khoa", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@CCCD", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@BHYT", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@AnhBenhNhan", SqlDbType.Image);

                    command.Parameters["@NgayKham"].Value = data.NgayNhap;
                    command.Parameters["@TinhTrang"].Value = data.TinhTrang;
                    command.Parameters["@LyDoKham"].Value = data.LyDoKham;
                    command.Parameters["@MaPhong"].Value = data.MaPhong;
                    command.Parameters["@HoTen"].Value = data.Ten;
                    command.Parameters["@GioiTinh"].Value = data.GioiTinh;
                    command.Parameters["@NgaySinh"].Value = data.NgaySinh;
                    command.Parameters["@DiaChi"].Value = data.DiaChi;
                    command.Parameters["@CanNang"].Value = data.CanNang;
                    command.Parameters["@ChieuCao"].Value = data.ChieuCao;
                    command.Parameters["@MaBS"].Value = data.MaBacSi;
                    command.Parameters["@Khoa"].Value = data.MaKhoa;
                    command.Parameters["@CCCD"].Value = data.CCCDS;
                    command.Parameters["@BHYT"].Value = data.BHYTS;
                    command.Parameters["@AnhBenhNhan"].Value = data.imageByte;
                    conn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Bạn đã lưu thông tin thành công!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
