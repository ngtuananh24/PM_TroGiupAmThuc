using System;
using System.Data.SqlClient;

namespace PM_TroGiupAmThuc
{
    internal class Connection
    {
        private static string strconnection1 = @"Data Source=TUANANH\SQLEXPRESS;Initial Catalog=thudon_đinhuong;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strconnection1);
        }

        public static void TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    Console.WriteLine("Kết nối thành công!");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khác: " + ex.Message);
            }
        }
    }
}
