using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aruszallitas
{
    public partial class budapestrolIndultUtakUserControl : UserControl
    {
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public budapestrolIndultUtakUserControl()
        {
            InitializeComponent();
            conn = Connect.InitDB();
            Betoltes();
        }
        
        private void Betoltes()
        {
            try
            {
                dataGridView1.DataSource = null;
                string query = "call pr_BudapestrolInduloFuvarok();";
                command = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Indulás időpontja"].DefaultCellStyle.FormatProvider = new CultureInfo("hu-HU");
                dataGridView1.Columns["Indulás időpontja"].DefaultCellStyle.Format = "G";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
