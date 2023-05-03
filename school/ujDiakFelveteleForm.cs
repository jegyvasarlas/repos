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

namespace school
{
    public partial class ujDiakFelveteleForm : Form
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        public ujDiakFelveteleForm()
        {
            InitializeComponent();
            conn = Connect.InitDB();
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length >= 1 && textBox2.Text.Length >= 1 && textBox3.Text.Length >= 1 &&  textBox4.Text.Length >= 1)
                {
                    string query = $"INSERT INTO vizsga_tanulo(vezeteknev, keresztnev, osztaly, ofo_neve) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
                    command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres felvétel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tölts ki minden mezőt!", "Sikertelen felvétel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sikertelen felvétel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
