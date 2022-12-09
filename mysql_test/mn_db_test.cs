using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace db_test;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql_drop = "drop database if exists centrum";
                MySqlCommand cmd_drop = new MySqlCommand(sql_drop, conn);
                cmd_drop.ExecuteNonQuery();

                string sql_createDatabase = "CREATE DATABASE centrum DEFAULT CHARACTER set utf8 COLLATE utf8_hungarian_ci;";
                MySqlCommand cmd_createDatabase = new MySqlCommand(sql_createDatabase, conn);
                cmd_createDatabase.ExecuteNonQuery();

                string sql_useDatabase = "use centrum";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();

                string sql_createTable = File.ReadAllText("tablak.sql");
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();

                string sql_insert = File.ReadAllText("adatok.sql");
                MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                cmd_insert.ExecuteNonQuery();

                //4
                string sql_select4 = "SELECT torpek.nev, torpek.magassag from torpek order by torpek.magassag desc limit 1;";
                MySqlCommand cmd4 = new MySqlCommand(sql_select4, conn);
                MySqlDataReader rdr4 = cmd4.ExecuteReader(); // mn_db_test.cs

                Console.WriteLine("4. feladat:");
                while (rdr4.Read())
                {
                    Console.WriteLine(rdr4[0] + ", " + rdr4[1]); //annyi rdr[] mennyi mezo ki van valasztva 
                }
                rdr4.Close();
                // ha nincs select
                string sql_insertIntoTorpe = "INSERT INTO `torpek`(`nev`, `klan`, `nem`, `suly`, `magassag`) VALUES ('Trad Morf', 'Vasököl', 'F', '69', '136');";
                MySqlCommand cmd_insertIntoTorpe = new MySqlCommand(sql_insertIntoTorpe, conn);
                cmd_insertIntoTorpe.ExecuteNonQuery();
                Console.WriteLine("a 8. feladat lefutott");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("DB kapcsolat bontva, nyomj bármely billentyűt ...");
            Console.Read();
        }
    }
}