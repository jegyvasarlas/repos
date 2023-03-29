using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Furmula1
{
    public partial class AtigazoltVersenyzokForm : Form
    {
        MySqlConnection Conn;
        public AtigazoltVersenyzokForm()
        {
            InitializeComponent();
        }

        private void AtigazoltVersenyzokForm_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            String sql = "CALL pr_SelectVersenyzok();";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            eredmeny.Columns.Add("Nev", "Név");
            eredmeny.Columns.Add("Rajtszam", "Rajtszám");
            eredmeny.Columns.Add("Nemzetiseg", "Nemzetiség");
            eredmeny.Columns.Add("Ujonc", "Újonc");
            eredmeny.Columns.Add("Belepes", "Belépés");
            while (reader.Read())
            {
                eredmeny.Rows.Add(
                    new object[]
                    {
                        reader["Nev"].ToString(),
                        reader["Rajtszam"].ToString(),
                        reader["Nemzetiseg"].ToString(),
                        reader["Ujonc"].ToString(),
                        reader["Belepes"].ToString()
                    });
            }
            Conn.Close();
        }
    }
}
