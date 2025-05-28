using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  
using MySql.Data.MySqlClient;

namespace DBConnectionClass
{
    internal class DBConnectionClass
    {
        public DBConnectionClass()
        {
            
        }
        public static string GetConnectionString(string connectionname)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[connectionname].ConnectionString;

                return connectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hibatörtént {ex.Message}");
                return null;
            }
        }
        public static string GetConnectionString_1(string connectionname)
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
            connectionStringBuilder.Server = ConfigurationManager.AppSettings["server"];
            connectionStringBuilder.Database = ConfigurationManager.AppSettings["Database"];
            connectionStringBuilder.UserID = ConfigurationManager.AppSettings["user"];
            connectionStringBuilder.Password = ConfigurationManager.AppSettings["password"];

            connectionStringBuilder.IntegratedSecurity = true;

            connectionStringBuilder.ConnectionTimeout = 30;

            MySqlConnection cn = new MySqlConnection();

            cn.ConnectionString = connectionStringBuilder.ToString();

            return cn.ConnectionString;

        }
    }
}