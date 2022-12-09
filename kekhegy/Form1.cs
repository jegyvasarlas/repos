using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekhegy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // letrehozas
        {
            try {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_createDatabase = $"CREATE DATABASE {textBox1.Text} DEFAULT CHARACTER set utf8 COLLATE utf8_hungarian_ci;";
                MySqlCommand cmd_createDatabase = new MySqlCommand(sql_createDatabase, conn);
                cmd_createDatabase.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Az adatbazis sikeresen letrejott!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // torles
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_drop = $"drop database {textBox1.Text}";
                MySqlCommand cmd_drop = new MySqlCommand(sql_drop, conn);
                cmd_drop.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Az adatbazis sikeresen torolve lett!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A feladat hibatlan megoldasa miatt a szovegdoboz jelenleg csak olvashato!", "Figyelmeztetes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // beillesztes
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_createTable = File.ReadAllText("adatbazis.sql");
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Az adatfajl sikeresen beillesztesre kerult!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e) // 16.feladat
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_select = "SELECT COUNT(emelet) as \"masodik_emeleti_szobak_szama\" FROM `szobak` where `emelet`=2;";
                MySqlCommand cmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"masodik_emeleti_szobak_szama");
                    listBox1.Items.Add($"{rdr[0]}");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e) // 17. feladat
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_select = "SELECT foglalasok.szobaId, foglalasok.napok FROM foglalasok inner join vendegek on foglalasok.vendegId = vendegek.id WHERE vendegek.nev=\"Lugosi Béla\";";
                MySqlCommand cmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                listBox1.Items.Add($"szobaId\tnapok");
                while (rdr.Read())
                {
                    listBox1.Items.Add($"{rdr[0]}\t{rdr[1]}");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e) // 18. feladat insert
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_select = "INSERT INTO szobak (emelet, szobaszam, ferohelyek, ar, megjegyzes) VALUES (3, 301, 2, 15000, \"Tetoteri szoba\");";
                MySqlCommand cmd = new MySqlCommand(sql_select, conn);
                MessageBox.Show("A feladat sikeresen lefutott!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_select = "SELECT szobak.id, szobak.szobaszam, sum(foglalasok.napok) as szumma_nap FROM foglalasok inner join szobak on foglalasok.szobaId = szobak.id group by szobak.szobaszam order by szumma_nap desc limit 5;";
                MySqlCommand cmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                listBox1.Items.Add($"szobak.id\t\tszobak.szobaszam\t\tszumma_nap");
                while (rdr.Read())
                {
                    listBox1.Items.Add($"{rdr[0]}\t\t{rdr[1]}\t\t\t{rdr[2]}");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql_useDatabase = $"use {textBox1.Text}";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();
                string sql_select = "SELECT sum(foglalasok.napok * szobak.ar) as szumma_ar, vendegek.nev as foglalo_neve FROM foglalasok inner join szobak on foglalasok.szobaId = szobak.id inner join vendegek on foglalasok.vendegId = vendegek.id group by foglalasok.vendegId order by szumma_ar desc limit 1;";
                MySqlCommand cmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                listBox1.Items.Add($"szumma_ar\tfoglalo_neve");
                while (rdr.Read())
                {
                    listBox1.Items.Add($"{rdr[0]}\t{rdr[1]}");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
