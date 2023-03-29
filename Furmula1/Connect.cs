﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Furmula1
{
    static class Connect
    {
        const String server = "localhost";
        const String user = "felhasznalo";
        const String password = "Oszibarack120";
        const String db = "formula1";

        public static MySqlConnection InitDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            builder.SslMode = MySqlSslMode.None;

            string ConnString = builder.ToString();

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return default(MySqlConnection);
            }
        }
    }
}
