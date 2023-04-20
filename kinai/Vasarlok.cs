using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kinai
{
    public partial class Vasarlok : Form
    {
        MySqlConnection conn;
        public Vasarlok()
        {
            InitializeComponent();
            conn = Connect.InitDB();
        }

        private void Vasarlok_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("nev", "Nev");
            dataGridView1.Columns.Add("cim", "Cim");
            dataGridView1.Columns.Add("telefon", "Telefon");
            dataGridView1.Columns.Add("email", "E-mail cim");
            dataGridView1.Columns.Add("count", "Vasarlasok szama");
            string query = "call pr_Vasarlok()";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["name"], reader["address"], reader["phone"], reader["email"], reader["purchasecount"]);
            }
            reader.Close();
        }
    }
}
