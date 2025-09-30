using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class SqlUtility
    {
        private readonly string _connectionString;

        public SqlUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int ExecuteSqlCommand(string sql)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            if(connection.State != System.Data.ConnectionState.Open) 
                connection.Open();

            using SqlCommand cmd = new SqlCommand(sql, connection);

            int effected = cmd.ExecuteNonQuery();

            return effected;
        }

        public List<Dictionary<string, object>> ExecuteSqlQuery(string sql)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            using SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }

                data.Add(row);
            }

            return data;
        }
    }
}
