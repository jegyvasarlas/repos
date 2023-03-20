using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        Label[] dobozok;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dobozok = new Label[4];
            int x, y;
            
            for(int i=0; i<dobozok.Length; i++)
            {
                dobozok[i] = new Label();
                dobozok[i].AutoSize = false;
                dobozok[i].Size = new Size(100, 100);
                x = (i % 2) * 150 + 50;
                y = (i / 2) * 150 + 50;
                dobozok[i].Location = new Point(x, y);
                dobozok[i].Name = "Label" + i.ToString();
                dobozok[i].Click += new EventHandler(DobozClick);
                this.Controls.Add(dobozok[i]);
            }
            dobozok[0].BackColor = Color.Red;
            dobozok[1].BackColor = Color.Green;
            dobozok[2].BackColor = Color.Yellow;
            dobozok[3].BackColor = Color.HotPink;

            this.Click += DobozClick;

        }
        
        private void DobozClick(object sender, EventArgs e)
        {
            Color tmp = dobozok[2].BackColor;
            dobozok[2].BackColor = dobozok[3].BackColor;
            dobozok[3].BackColor = dobozok[1].BackColor;
            dobozok[1].BackColor = dobozok[0].BackColor;
            dobozok[0].BackColor = tmp;
        }
    }
}
