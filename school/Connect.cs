using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public static class Connect
    {
        public static MySqlConnection InitDB()
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
