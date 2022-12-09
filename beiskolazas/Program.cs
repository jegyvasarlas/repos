using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace beiskolazas
{
    class Program
    {
        static string connStr = "server=localhost;user=root;port=3306;password=";
        const string databaseName = "beiskolazas";
        static void Main(string[] args)
        {
            try
            {
                Elokeszuletek();
                Feladat3();
                Feladat4();
                Feladat5();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHiba tortent!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(err.ToString());
            }
            Console.ReadKey();
        }
        static void Elokeszuletek()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Elokeszuletek:\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Csatlakozas...");
                conn.Open();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("A program ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("csatlakozott a MySql szerverhez\n");

                Console.ForegroundColor = ConsoleColor.White;
                string sql_drop = $"drop database if exists {databaseName}";
                MySqlCommand cmd_drop = new MySqlCommand(sql_drop, conn);
                cmd_drop.ExecuteNonQuery();
                Console.Write("Elozo adatbazis ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("eldobva\n");

                string sql_createDatabase = $"CREATE DATABASE {databaseName} DEFAULT CHARACTER set utf8 COLLATE utf8_hungarian_ci;";
                MySqlCommand cmd_createDatabase = new MySqlCommand(sql_createDatabase, conn);
                cmd_createDatabase.ExecuteNonQuery();
                Console.Write("Adatbazis ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("letrehova\n");

                string sql_useDatabase = $"use {databaseName}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();

                string sql_createTable = File.ReadAllText("tablak.sql");
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();
                Console.Write("Tablak ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("beimportalva\n");

                string sql_insert = File.ReadAllText("adatok.sql");
                MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                cmd_insert.ExecuteNonQuery();
                Console.Write("Adatok ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("beimportalva\n");

                Console.Write("\nAz elokeszuletek ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("lefutottak\n");

            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHiba tortent!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(err.ToString());
            }
            conn.Close();
        }
        static void Feladat3()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "ALTER TABLE jelentkezesek ADD CONSTRAINT FK_1 FOREIGN KEY (diak) references diakok(oktazon)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "ALTER TABLE jelentkezesek ADD CONSTRAINT FK_2 FOREIGN KEY (tag) references tagozatok(akod)";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Console.Write("\nA 3. feladat ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("lefutott\n");
            }
            catch (Exception err) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHiba tortent!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(err.ToString());
            }
            conn.Close();
        }
        static void Feladat4()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "update diakok set kpmagy = 43 where oktazon = 0143302";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Console.Write("\nA 4. feladat ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("lefutott\n");
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHiba tortent!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(err.ToString());
            }
            conn.Close();
        }
        static void Feladat5()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "select nev from diakok where kpmagy = 50 and kpmat = 50 and hozott >= 40;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine("\n5. feladat:\n");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
                rdr.Close();
                Console.Write("\nAz 5. feladat ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sikeresen ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("lefutott\n");
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHiba tortent!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(err.ToString());
            }
            conn.Close();
        }
    }
}