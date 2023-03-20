using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        MySqlConnection Conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            String sql = "SELECT * FROM pizza";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        reader["pazon"].ToString(),
                        reader["pnev"].ToString(),
                        reader["par"].ToString()
                    });
            }
            Conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conn = Connect.InitDB();
            if (textBox1.Text.Length >= 3)
            {
                String sql = $"SELECT FelhasznaloNev FROM Felhasznalok where FelhasznaloNev like '%{textBox1.Text}%'";
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(
                        new object[]
                        {
                        reader["FelhasznaloNev"].ToString(),
                        });
                }
            }
            if (textBox1.Text == "") { dataGridView2.Rows.Clear(); }
            Conn.Close();
        }
    }

    static class Connect
    {
        const String server = "localhost";
        const String user = "root";
        const String password = "";
        const String db = "pizza";
        
        public static MySqlConnection InitDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            builder.SslMode = MySqlSslMode.None;

            string ConnString = builder.ToString();

            try 
            {
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return default(MySqlConnection);
            }
        }
    }
}
