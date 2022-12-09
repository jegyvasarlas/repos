using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace db_test_wfa
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public string connStr = "server=localhost;user=root;port=3306;password=";
        private void Form1_Load(object sender, EventArgs e)
        {
            //MySQL();
        }

        
        public string fileContent = string.Empty;
        public string filePath = string.Empty;
        public void MySQL()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql_drop = "drop database if exists torpetarna";
                MySqlCommand cmd_drop = new MySqlCommand(sql_drop, conn);
                cmd_drop.ExecuteNonQuery();

                string sql_createDatabase = "CREATE DATABASE torpetarna DEFAULT CHARACTER set utf8 COLLATE utf8_hungarian_ci;";
                MySqlCommand cmd_createDatabase = new MySqlCommand(sql_createDatabase, conn);
                cmd_createDatabase.ExecuteNonQuery();

                string sql_useDatabase = "use torpetarna";
                MySqlCommand cmd_useDatabase = new MySqlCommand(sql_useDatabase, conn);
                cmd_useDatabase.ExecuteNonQuery();

                string sql_createTable = "CREATE TABLE `torpetarna`.`kozetek` ( `id` INT(3) NOT NULL AUTO_INCREMENT , `nev` VARCHAR(20) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;CREATE TABLE `torpetarna`.`torpek` ( `id` INT(3) NOT NULL AUTO_INCREMENT , `nev` VARCHAR(30) NOT NULL , `klan` VARCHAR(30) NOT NULL , `nem` VARCHAR(1) NOT NULL , `suly` INT(3) NOT NULL , `magassag` INT(3) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;CREATE TABLE `torpetarna`.`tarnak` ( `id` INT(3) NOT NULL AUTO_INCREMENT , `nev` VARCHAR(30) NOT NULL , `kozet_id` INT(3) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;CREATE TABLE `torpetarna`.`kihol` ( `torpe_id` INT(3) NOT NULL , `tarna_id` INT(3) NOT NULL , `kitermelt_mennyiseg` INT(3) NOT NULL ) ENGINE = InnoDB;ALTER TABLE `kihol` ADD PRIMARY KEY( `torpe_id`, `tarna_id`);";
                MySqlCommand cmd_createTable = new MySqlCommand(sql_createTable, conn);
                cmd_createTable.ExecuteNonQuery();
                Console.WriteLine("az OSZTALY tábla létrejött");

                //string sql_insert = "INSERT INTO kozetek (id, nev) VALUES (1, 'arany'), (2, 'ezüst'), (3, 'réz'), (4, 'vas');INSERT INTO torpek (id, nev, klan, nem, suly, magassag) VALUES (1, 'Terrin Sak', 'Kova', 'F', '62', '130'),(2, 'Bal Eraffa', 'Vasököl', 'N', '45', '129'),(3, 'Sarsi Duri', 'Vasököl', 'F', '59', '141'),(4, 'Dorf Gein', 'Csille', 'F', '62', '138'),(5, 'Bombur Nori', 'Kova', 'N', '48', '132'),(6, 'Dorf Loopa', 'Csille', 'F', '63', '140'),(7, 'Trad Magraimn', 'Acél', 'F', '67', '138'),(8, 'Tardi Falgorran', 'Csille', 'F', '65', '140'),(9, 'Lok Dun', 'Acél', 'F', '70', '142'),(10, 'Sarrof Hro', 'Kova', 'F', '65', '137'),(11, 'Gor Morf', 'Csille', 'F', '58', '135'),(12, 'Heimal Morf', 'Vasököl', 'F', '61', '144'),(13, 'Odi Duri', 'Kova', 'F', '64', '145'),(14, 'Hardi Oggi', 'Vasököl', 'F', '64', '137'),(15, 'Bal Rian', 'Acél', 'N', '48', '134'),(16, 'Tor Edda', 'Vasököl', 'F', '61', '135'),(17, 'Forf Orsan', 'Csille', 'N', '50', '140'),(18, 'Krof Erag', 'Vasököl', 'N', '45', '145'),(19, 'Azul Luer', 'Vasököl', 'N', '43', '141'),(20, 'Forf Sak', 'Acél', 'F', '60', '146'),(21, 'Krof Glueggi', 'Kova', 'F', '62', '135'),(22, 'Tor Zian', 'Vasököl', 'N', '51', '138'),(23, 'Darrin Surroc', 'Acél', 'N', '48', '139'),(24, 'Nallid Grai', 'Vasököl', 'F', '58', '138'),(25, 'Lok Gran', 'Acél', 'F', '67', '140'),(26, 'Sarraain Sugran', 'Kova', 'F', '66', '138'),(27, 'Dorrin Dars', 'Csille', 'F', '68', '144'),(28, 'Nallid Fars', 'Vasököl', 'F', '71', '143'),(29, 'Dor Gerri', 'Kova', 'F', '69', '138'),(30, 'Darrin Rudga', 'Acél', 'F', '90', '140');INSERT INTO tarnak (id, nev, kozet_id) VALUES (1, 'Gir Lodur', '1'),(2, 'Tordirth', '4'),(3, 'Moldirth', '3'),(4, 'Gir Dorth', '4'),(5, 'Valthalla', '3'),(6, 'Midgarth', '2'),(7, 'Goldminer', '1'),(8, 'Aurumriver', '1'),(9, 'Argenteus', '2'),(10, 'Aquatinta', '3');INSERT INTO kihol (torpe_id, tarna_id, kitermelt_mennyiseg) VALUES ('6', '6', '25'), ('20', '2', '35'), ('19', '7', '22'), ('18', '8', '15'), ('22', '2', '22'),('4', '5', '25'),('13', '4', '40'), ('3', '5', '40'),('26', '1', '26'),('11', '4', '32'),('14', '4', '22'),('29', '3', '33'),('14', '7', '30'),('21', '1', '40'),('22', '10', '31'),('20', '3', '25'),('19', '2', '16'),('25', '1', '20'),('28', '10', '25'),('29', '10', '12'),('28', '1', '12'),('1', '10', '34'),('24', '1', '35'),('13', '3', '23'),('7', '7', '23'),('30', '4', '23'),('4', '6', '45'),('2', '1', '21'),('18', '1', '24'),('10', '1', '30'),('23', '5', '25'),('3', '10', '25'),('17', '4', '32'),('7', '10', '20'),('1', '5', '36'),('8', '8', '35'),('12', '1', '32'),('6', '3', '33'),('18', '3', '15'),('28', '5', '36'),('25', '7', '23'),('15', '3', '23'),('3', '2', '33'),('22', '4', '40'),('5', '5', '12'),('9', '3', '19'),('15', '10', '19'),('27', '6', '32'),('6', '9', '40'),('27', '1', '28'),('3', '1', '45'),('5', '4', '22'),('9', '6', '36'),('26', '2', '15'),('12', '8', '35'),('21', '9', '39'),('16', '7', '27'),('24', '6', '27'),('17', '8', '28'),('11', '3', '31'),('11', '8', '40'),('2', '10', '32');";
                string sql_insert = File.ReadAllText(filePath);
                MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                cmd_insert.ExecuteNonQuery();
                MessageBox.Show("az INSERT-ek lefutottak");

                /*
                //4
                string sql_select4 = "SELECT torpek.nev, torpek.magassag from torpek order by torpek.magassag desc limit 1;";
                MySqlCommand cmd4 = new MySqlCommand(sql_select4, conn);
                MySqlDataReader rdr4 = cmd4.ExecuteReader();

                Console.WriteLine("4. feladat:");
                while (rdr4.Read())
                {
                    Console.WriteLine(rdr4[0] + ", " + rdr4[1]);
                }
                rdr4.Close();
                //5
                string sql_select5 = "SELECT count(kihol.torpe_id) from tarnak inner join kihol ON tarnak.id=kihol.tarna_id where tarnak.nev=\"Gir Lodur\";";
                MySqlCommand cmd5 = new MySqlCommand(sql_select5, conn);
                MySqlDataReader rdr5 = cmd5.ExecuteReader();

                Console.WriteLine("5. feladat:");
                while (rdr5.Read())
                {
                    Console.WriteLine(rdr5[0]);
                }
                rdr5.Close();
                //6
                string sql_select6 = "SELECT tarnak.nev, sum(kihol.kitermelt_mennyiseg) as \"kitermelt mennyiseg\" from tarnak inner join kihol on tarnak.id=kihol.tarna_id inner join kozetek on kozetek.id=tarnak.kozet_id where kozetek.nev=\"Arany\" order by sum(kihol.kitermelt_mennyiseg) desc;";
                MySqlCommand cmd6 = new MySqlCommand(sql_select6, conn);
                MySqlDataReader rdr6 = cmd6.ExecuteReader();

                Console.WriteLine("6. feladat:");
                while (rdr6.Read())
                {
                    Console.WriteLine(rdr6[0] + ", " + rdr6[1]);
                }
                rdr6.Close();
                //7
                string sql_select7 = "SELECT torpek.nev from torpek inner join kihol on torpek.id=kihol.torpe_id where torpek.klan=\"Vasököl\" and torpek.nem=\"N\" order by kihol.kitermelt_mennyiseg desc limit 1;";
                MySqlCommand cmd7 = new MySqlCommand(sql_select7, conn);
                MySqlDataReader rdr7 = cmd7.ExecuteReader();

                Console.WriteLine("7. feladat:");
                while (rdr7.Read())
                {
                    Console.WriteLine(rdr7[0]);
                }
                rdr7.Close();
                //8
                string sql_insertIntoTorpe = "INSERT INTO `torpek`(`nev`, `klan`, `nem`, `suly`, `magassag`) VALUES ('Trad Morf', 'Vasököl', 'F', '69', '136');";

                MySqlCommand cmd_insertIntoTorpe = new MySqlCommand(sql_insertIntoTorpe, conn);
                cmd_insertIntoTorpe.ExecuteNonQuery();
                Console.WriteLine("a 8. feladat lefutott");
                //9
                string sql_insertIntoKihol = "INSERT INTO `kihol` (`torpe_id`, `tarna_id`, `kitermelt_mennyiseg`) VALUES (31, 1, 43),(31, 3, 28);";

                MySqlCommand cmd_insertIntoKihol = new MySqlCommand(sql_insertIntoKihol, conn);
                cmd_insertIntoKihol.ExecuteNonQuery();
                Console.WriteLine("a 9. feladat lefutott");*/
            }
            catch (Exception)
            {
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    pathlabel.Text = filePath;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader1 = new StreamReader(fileStream))
                    {
                        fileContent = reader1.ReadToEnd();
                    }

                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    string sql_insert = File.ReadAllText(filePath);
                    MySqlCommand cmd_insert = new MySqlCommand(sql_insert, conn);
                    cmd_insert.ExecuteNonQuery();
                    MessageBox.Show("az INSERT-ek lefutottak");
                    conn.Close();
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand drdatabase = new MySqlCommand($"DROP DATABASE IF EXISTS {textBox1.Text}", conn);
                drdatabase.ExecuteNonQuery();
                MySqlCommand crdatabase = new MySqlCommand($"CREATE DATABASE {textBox1.Text} DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci", conn);
                MessageBox.Show("A letrehozas sikeresen megtortent");
                conn.Close();
            } catch (IOException)
            {
                MessageBox.Show("Hiba tortent", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
