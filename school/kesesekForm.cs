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
    public partial class kesesekForm : Form
    {
        private int tanuloId;
        private MySqlConnection conn;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public kesesekForm(int id)
        {
            InitializeComponent();
            conn = Connect.InitDB();
            conn.Open();
            tanuloId = id;

        }

        private void kesesekForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string query = "SELECT mikor, igazolt, megjegyzes FROM vizsga_keses WHERE tanuloID=@tanuloId";
            command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@tanuloId", tanuloId);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["mikor"].HeaderText = "Késés dátuma";
            dataGridView1.Columns["igazolt"].HeaderText = "Igazolt-e a késés";
            dataGridView1.Columns["megjegyzes"].HeaderText = "Megjegyzés";
            int totalKeses = table.Rows.Count;
            textBox1.Text = totalKeses.ToString();
            bool elerte = totalKeses >= 10;
            textBox2.Text = elerte ? "Igen" : "Nem";
        }
    }
}
