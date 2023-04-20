using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LegyenOnIsMilliomos
{
    public partial class RanglistaFeliratkozasDialog : Form
    {
        int pontszam;

        public RanglistaFeliratkozasDialog(int pontszam)
        {
            InitializeComponent();
            this.pontszam = pontszam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textBox1.Text;

            MySqlConnection Con = Connect.InitDB();
            String query = "CALL pr_UjPontszam(@nev, @pontszam);";
            MySqlCommand cmd = new MySqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@nev", nev);
            cmd.Parameters.AddWithValue("@pontszam", pontszam);
            cmd.Parameters["@nev"].Direction = ParameterDirection.Input;
            cmd.Parameters["@pontszam"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();

            Con.Close();
        }
    }
}
