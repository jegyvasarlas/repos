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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LegyenOnIsMilliomos
{
    public partial class RanglistaForm : Form
    {
        public RanglistaForm()
        {
            InitializeComponent();
        }

        private void RanglistaForm_Load(object sender, EventArgs e)
        {
            MySqlConnection Conn = Connect.InitDB();
            String sql = "CALL pr_Ranglista();";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Columns.Add("nev", "Név");
            dataGridView1.Columns.Add("pontszam", "Pontszám");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        reader["nev"].ToString(),
                        reader["pontszam"].ToString(),
                    });
            }
            Conn.Close();
        }
    }
}
