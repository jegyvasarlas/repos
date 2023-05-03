using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aruszallitas
{
    public partial class ujUtFelveteleUserControl : UserControl
    {
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader reader;
        public ujUtFelveteleUserControl()
        {
            InitializeComponent();
            conn = Connect.InitDB();
            FutarBetoltes();
            HonnanBetoltes();
            HovaBetoltes();
        }

        private void FutarBetoltes()
        {
            try
            {
                string query = "call pr_Futarok();";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    futarok.Items.Add(reader.GetString("FutarNev"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void HonnanBetoltes()
        {
            try
            {
                string query = "call pr_Telepulesek();";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    honnan.Items.Add(reader.GetString("TelepulesNev"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HovaBetoltes()
        {
            try
            {
                string query = "call pr_Telepulesek();";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hova.Items.Add(reader.GetString("TelepulesNev"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FelvetelClick(object sender, EventArgs e)
        {
            try
            {
                string futarNev = futarok.SelectedItem.ToString();
                string honnanNev = honnan.SelectedItem.ToString();
                string hovaNev = hova.SelectedItem.ToString();
                DateTime indulasIdopont = dateTimePicker1.Value;
                command = new MySqlCommand("pr_FuvarFelvetel", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_FutarNev", futarNev);
                command.Parameters.AddWithValue("p_HonnanNev", honnanNev);
                command.Parameters.AddWithValue("p_HovaNev", hovaNev);
                command.Parameters.AddWithValue("p_IndulasIdopont", indulasIdopont);
                command.ExecuteNonQuery();

                MessageBox.Show("Fuvar felvéve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
