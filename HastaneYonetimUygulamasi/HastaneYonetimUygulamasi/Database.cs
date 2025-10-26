using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimUygulamasi
{
    public class Database
    {

        private string connectionString;

        public Database()
        {
            // Bağlantı dizesini burada tanımlayın.
            connectionString = "server=localhost;";
        }

        // Veritabanı bağlantısı oluşturma
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        // SQL sorgularını çalıştırma (SELECT )
        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // SQL komutlarını çalıştırma (INSERT, UPDATE, DELETE )
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

     
    }
}

