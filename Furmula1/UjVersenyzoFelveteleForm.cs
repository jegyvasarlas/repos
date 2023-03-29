using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Furmula1
{
    public partial class UjVersenyzoFelveteleForm : Form
    {
        MySqlConnection Conn;

        public UjVersenyzoFelveteleForm()
        {
            InitializeComponent();
        }

        private void UjVersenyzoFelveteleForm_Load(object sender, EventArgs e)
        {
            CsapatokLoad();
        }
        
        void CsapatokLoad()
        {
            Conn = Connect.InitDB();
            String sql = "CALL pr_ListCsapatok();";
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string csapatNev = reader["CsapatNev"].ToString();
                csapat.Items.Add(csapatNev);
            }
            Conn.Close();
        }
    }
}
