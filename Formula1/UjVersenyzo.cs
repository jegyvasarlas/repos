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
    public partial class UjVersenyzo : UserControl
    {
        public UjVersenyzo()
        {
            InitializeComponent();
        }
        
        private void CsapatokBetoltese()
        {
            MySqlConnection Conn = Connect.InitDB();
            string sql = "CALL pr_Csapatok;";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            csapatInput.Items.Clear();
            while (reader.Read())
            {
                csapatInput.Items.Add(reader["CsapatNev"].ToString());
            }
            Conn.Close();
        }

        private void UjVersenyzo_Load(object sender, EventArgs e)
        {
            CsapatokBetoltese();
        }

        private void felvetel_Click(object sender, EventArgs e)
        {
            try
            {
                siker.Text = String.Empty;
                string nev = nevInput.Text;
                int rajtszam = (int)rajtszamInput.Value;
                string nemzetiseg = nemzetisegInput.Text;
                string csapat = csapatInput.Items[csapatInput.SelectedIndex].ToString();
                int ujonc = ujoncInput.Checked ? 1 : 0;
                string datum = belepesInput.Value.ToString("yyyy-MM-dd");
                MySqlConnection Conn = Connect.InitDB();
                string sql = "CALL pr_UjVersenyzoFelvetel('" + nev + "', " + rajtszam + ", '" + nemzetiseg + "', '" + csapat + "', " + ujonc + ", '" + datum + "');";
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                int ret = cmd.ExecuteNonQuery();
                Conn.Close();
                if (ret == 2)
                {
                    siker.ForeColor = Color.Green;
                    siker.Text = "Sikerult";
                }
                else
                {
                    siker.ForeColor = Color.Red;
                    siker.Text = "Nem sikerult";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                siker.ForeColor = Color.Red;
                siker.Text = "Nem sikerult";
            }
        }

        private void rajtszamInput_ValueChanged(object sender, EventArgs e)
        {
            
        }      
    }
}
