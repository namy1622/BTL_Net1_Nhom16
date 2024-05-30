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
    public class Modify
    {
        private Modify() { }

        private static Modify instance; // mục đích là duy nhất trong chương trình 

        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();

        public static Modify Instance {
            get
            {
                if (instance == null) instance = new Modify();
                return Modify.instance;
            }
            private set => instance = value;  // private là để không thể sửa ở bên ngoài 
        }

        public void Command_NonQuery(string query)   // dùng để thực hiện câu truy vấn 
        {
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            
            
        }

        public object Command_Scalar(string query)   // dùng để thực hiện câu truy vấn 
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                var result = sqlCommand.ExecuteScalar();


                sqlConnection.Close();

                return result;
            }

           
        }


        public DataTable Table(string query) // trả về bảng dữ liệu
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                
                sqlConnection.Close();
            }
                return dataTable;
        }

        

    }
}
