using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szerviz
{
    public partial class frmVevoLista : Form
    {
        MySqlConnection Conn;
        public frmVevoLista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            String sql = $"select nev, cim from vevo where nev like '%{textBox1.Text}%';";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("nev", "Nev");
            dataGridView1.Columns.Add("cim", "Cim");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        reader["nev"].ToString(),
                        reader["cim"].ToString(),
                    });
            }
            if (textBox1.Text == "") { dataGridView1.Columns.Clear(); dataGridView1.Rows.Clear(); }
            Conn.Close();
        }
    }
}
