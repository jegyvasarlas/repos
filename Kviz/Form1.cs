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

namespace Kviz
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
            try
            {
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

                /*string sql_createTable = File.ReadAllText("adatbazis.sql");
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Az adatfajl sikeresen beillesztesre kerult!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                string fileContent = string.Empty;
                string filePath = string.Empty;

                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.Filter = "SQL Database (*.sql)|*.sql";
                    openFileDialog1.FilterIndex = 1;
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog1.FileName;
                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog1.OpenFile();

                        using (StreamReader reader1 = new StreamReader(fileStream))
                        {
                            fileContent = reader1.ReadToEnd();
                        }
                        string sql_insert = File.ReadAllText(filePath);
                        MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                        cmd_insert.ExecuteNonQuery();
                        MessageBox.Show("Az adatfajl sikeresen beillesztesre kerult!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba tortent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void button4_Click(object sender, EventArgs e) // 16.feladat
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
        }*/

        //blob konvertáló metódus
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* Kép megjelenítése képfájlból
            Image img = Image.FromFile("mala_studena.jpg");
            Graphics g = this.CreateGraphics();
            g.DrawImage(img, 0, 0, this.Width, this.Height);
            g.Dispose();
            */

            /* Kép megjelenítése képfájlból PictureBox-ba
            PictureBox p = new PictureBox();
            p.ImageLocation = "mala_studena.jpg";
            p.Location = new Point(100, 75);
            p.Width = 500;
            p.Height =200;
            this.Controls.Add(p);
            */

            //kép lekérdezése, és a konvertáló metódus meghívása
            string connStr = $"server=localhost;user=root;database={textBox1.Text};port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);         
            conn.Open();

            string select_kep = "SELECT kep FROM `kerdes` WHERE id=1;";
            MySqlCommand cmd = new MySqlCommand(select_kep, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            byte[] kep;
            int db = 1;

            //CSAK TESZT, egy db képre!
            while (rdr.Read())
            {
                kep = (byte[])rdr[0];
                PictureBox p = new PictureBox();
                p.Image = byteArrayToImage(kep);
                p.Location = new Point(100, 75);
                p.Width = 500;
                p.Height = 200;
                this.Controls.Add(p);
                db++;
            }
            rdr.Close();
            conn.Close();
        }
    }
}
