using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school
{
    public partial class tanuloForm : Form
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public tanuloForm()
        {
            InitializeComponent();
            conn = Connect.InitDB();
            conn.Open();
        }

        private void Lekerdezes()
        {
            dataGridView1.DataSource = null;
            string query = "SELECT * FROM vizsga_tanulo";
            command = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].HeaderText = "Azonosító";
            dataGridView1.Columns["vezeteknev"].HeaderText = "Vezetéknév";
            dataGridView1.Columns["keresztnev"].HeaderText = "Keresztnév";
            dataGridView1.Columns["osztaly"].HeaderText = "Osztály";
            dataGridView1.Columns["ofo_neve"].HeaderText = "Osztályfőnök";
        }

        private void tanuloForm_Load(object sender, EventArgs e)
        {
            Lekerdezes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lekerdezes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                kesesekForm kesesek = new kesesekForm(id);
                kesesek.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ujDiakFelveteleForm ujDiak = new ujDiakFelveteleForm();
            ujDiak.ShowDialog();
        }
    }
}