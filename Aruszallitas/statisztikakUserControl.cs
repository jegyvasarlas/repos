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

namespace Aruszallitas
{
    public partial class statisztikakUserControl : UserControl
    {
        MySqlConnection conn;
        MySqlCommand command;
        public statisztikakUserControl()
        {
            InitializeComponent();
            conn = Connect.InitDB();
            Betoltes();
        }

        private void Betoltes()
        {
            
        }
    }
}
