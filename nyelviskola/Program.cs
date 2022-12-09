using System;
using System.IO;
using MySql.Data.MySqlClient;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=;port=3306;password=";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql_drop = "drop database if exists beiskolazas";
                MySqlCommand cmd_drop = new MySqlCommand(sql_drop, conn);
                cmd_drop.ExecuteNonQuery();

                string sql_createDatabase = "CREATE DATABASE beiskolazas CHARACTER set utf8 COLLATE utf8_hungarian_ci;";
                MySqlCommand cmd_createDatabase = new MySqlCommand(sql_createDatabase, conn);
                cmd_createDatabase.ExecuteNonQuery();

                string sql_useDatabase = "use beiskolazas";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();

                string sql_createTable = File.ReadAllText("tablak.sql");
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();

                string sql_insert = File.ReadAllText("adatok.sql");
                MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                cmd_insert.ExecuteNonQuery();
                Console.WriteLine("Adatok beimportálva");

                string sql = "ALTER TABLE jelentkezesek ADD CONSTRAINT FK_1 FOREIGN KEY (diak) references diakok(oktazon)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "ALTER TABLE jelentkezesek ADD CONSTRAINT FK_2 FOREIGN KEY (tag) references tagozatok(akod)";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("3. feladat lefutott");

                sql = "UPDATE diakok SET kpmagy = 43 WHERE oktazon = 0143302";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("4. feladat lefutott");

                sql = "select nev from diakok where kpmagy = 50 and kpmat = 50 and hozott >= 40;";
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine("5. feladat:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
                rdr.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("DB kapcsolat bontva, nyomj bármely billenty?t ...");
            Console.Read();
        }
    }
}