using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kinai
{
    public partial class Rendeles : Form
    {
        MySqlConnection conn;
        public Rendeles()
        {
            InitializeComponent();
            conn = Connect.InitDB();
        }

        private void Rendeles_Load(object sender, EventArgs e)
        {
            HashSet<string> foodnames = new HashSet<string>();
            string query = "call pr_Food()";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foodnames.Add(reader["name"].ToString() + " " + reader["size"].ToString());
            }
            reader.Close();
            foreach (string foodname in foodnames)
            {
                etelek.Items.Add(foodname);
            }
            query = "call pr_VasarlokNevei()";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vevok.Items.Add(reader["name"]);
            }
            reader.Close();
        }

        private void leadas_Click(object sender, EventArgs e)
        {
            if (etelek.SelectedIndex == -1 || vevok.SelectedIndex == -1)
            {
                MessageBox.Show("Nem valasztottal ki etelt vagy vevot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("pr_InsertOrder", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@vevok", vevok.Text);
                    command.Parameters.AddWithValue("@etelek", etelek.Text);
                    command.Parameters.AddWithValue("@darab", darab.Value);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Rendeles sikeresen felveve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
