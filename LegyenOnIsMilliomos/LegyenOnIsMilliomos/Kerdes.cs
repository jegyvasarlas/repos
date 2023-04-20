using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LegyenOnIsMilliomos
{
    internal class Kerdes
    {
        internal int nehezseg;
        internal string kerdes;
        internal string A, B, C, D;
        internal char helyes;
        internal string kategoria;

        public Kerdes(int nehezseg)
        {
            MySqlConnection Con = Connect.InitDB();
            String query = "CALL pr_UjKerdes(@szint);";
            MySqlCommand cmd = new MySqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@szint", nehezseg);
            cmd.Parameters["@szint"].Direction = ParameterDirection.Input;

            MySqlDataReader reader = cmd.ExecuteReader();            

            reader.Read();

            this.nehezseg = Convert.ToInt32(reader["nehezseg"]);
            this.kerdes = reader["kerdes"].ToString();
            this.A = reader["A"].ToString();
            this.B = reader["B"].ToString();
            this.C = reader["C"].ToString();
            this.D = reader["D"].ToString();
            this.helyes = reader["helyes"].ToString()[0];
            this.kategoria = reader["kategoria"].ToString();

            Con.Close();

        }
    }
}
