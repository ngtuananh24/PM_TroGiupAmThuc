using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PM_TroGiupAmThuc
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan> Taikhoans(String query)
        {
            List<TaiKhoan> taikhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
                return taikhoans;
            }
        }
        //public void Command(string query)
        //{
        //    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        //    {
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        sqlCommand.ExecuteNonQuery();
        //        sqlConnection.Close();
        //    }
        //}
        public void CommandWithParameters(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TUANANH\\SQLEXPRESS;Initial Catalog=thudon_đinhuong;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
