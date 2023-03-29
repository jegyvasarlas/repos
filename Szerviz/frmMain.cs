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

namespace Szerviz
{
    public partial class frmMain : Form
    {
        DateTime dt;
        public frmMain()
        {
            InitializeComponent();
            dt = DateTime.Now;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label2.Text = dt.ToString("yyyy. MMMM dd.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVevo frmv = new frmVevo();
            frmv.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVevoLista frmvl = new frmVevoLista();
            frmvl.Show();
        }
    }
}
