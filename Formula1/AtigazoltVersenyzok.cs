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

namespace Formula1
{
    public partial class AtigazoltVersenyzok : UserControl
    {
        MySqlConnection Conn;
        public AtigazoltVersenyzok()
        {
            InitializeComponent();
        }
        public void Megjelenit()
        {
            Conn = Connect.InitDB();
            string sql = "CALL pr_AtigazoltVersenyzok();";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    new object[]{
                        reader["Nev"].ToString(),
                        reader["CsapatNev"].ToString(),
                        Convert.ToInt32(reader["Rajtszam"]),
                        reader["Belepes"].ToString().Substring(0, 10),
                    }
                );
            }
            Conn.Close();
        }
    }
}
