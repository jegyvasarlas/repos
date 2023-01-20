using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelKozepreTesz();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = e.Location.ToString();
            this.Text = "X: " + e.X + " Y: " + e.Y;
        }
        
        private void PanelKozepreTesz()
        {
            //panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            //panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Width = this.ClientSize.Width /4;
            panel1.Height = this.ClientSize.Height / 4;
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            panel1.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelKozepreTesz();
        }
    }
}
