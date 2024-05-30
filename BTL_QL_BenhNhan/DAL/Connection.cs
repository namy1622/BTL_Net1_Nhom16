using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=NAMY-SP\NAMY; database = qlBenhVien; Integrated Security=True;";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
