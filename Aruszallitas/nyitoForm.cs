using System;
using System.Windows.Forms;

namespace Aruszallitas
{
    public partial class nyitoForm : Form
    {
        public nyitoForm()
        {
            InitializeComponent();
        }

        private void budapestrőlIndultUtakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (budapestrolIndultUtakUserControl1.Visible == false)
            {
                budapestrolIndultUtakUserControl1.Visible = true;
                ujUtFelveteleUserControl1.Visible = false;
            } 
            else
            {
                budapestrolIndultUtakUserControl1.Visible = false;
            }
        }

        private void újÚtFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ujUtFelveteleUserControl1.Visible == false)
            {
                ujUtFelveteleUserControl1.Visible = true;
                budapestrolIndultUtakUserControl1.Visible = false;
            }
            else
            {
                ujUtFelveteleUserControl1.Visible = false;
            }
        }

        private void statisztikákToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
