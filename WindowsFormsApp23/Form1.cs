using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        Label[,] csempek;
        static Random r = new Random();
        bool idomeres;
        private Stopwatch sw;
        int cserek;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            csempek = new Label[4, 4];
            for(int i=0; i<csempek.GetLength(0); i++)
            {
                for (int j = 0; j < csempek.GetLength(1); j++)
                {
                    csempek[i, j] = new Label();
                    csempek[i, j].Size = new Size(125, 125);
                    csempek[i, j].AutoSize = false;
                    csempek[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    csempek[i, j].Font = new Font("Arial", 40);
                    csempek[i, j].Text = ((j * 4) + (i + 1)).ToString();   
                    csempek[i, j].Location = new Point(i * 125, j * 125);
                    csempek[i, j].Name = "Label" + csempek[i,j].Text;
                    if (!(i == 3 && j == 3))
                    {
                        csempek[i, j].BackColor = Color.DarkBlue;
                        csempek[i, j].ForeColor = Color.White;
                        
                    }
                    else
                    {
                        csempek[i, j].BackColor = Color.White;
                        csempek[i, j].ForeColor = Color.White;
                    }
                    csempek[i, j].Click += CsempeClick;
                    panel1.Controls.Add(csempek[i, j]);
                }
            }

            idomeres = false;
            cserek = 0;
            Megkever();
        }
        
        private void CsempeClick(object sender, EventArgs e)
        {
            if (!idomeres)
            {
                idomeres = true;
                timer1.Enabled = true;
                sw = new Stopwatch();
                sw.Reset();
                sw.Start();
            }
            Label l = sender as Label;
            int szam = int.Parse(l.Name.Substring(5));
            int i = (szam - 1) % 4;
            int j = (szam - 1) / 4;
            if (i!=0 && csempek[i-1, j].Text.Equals("16")) // bal szomszed
            {
                Csere(csempek[i - 1, j], l);
            }
            else if (i != 3 && csempek[i + 1, j].Text.Equals("16")) // jobb szomszed
            {
                Csere(csempek[i + 1, j], l);
            }
            else if (j != 0 && csempek[i, j - 1].Text.Equals("16")) // felso szomszed
            {
                Csere(csempek[i , j - 1], l);
            }
            else if (j != 3 && csempek[i, j + 1].Text.Equals("16")) // also szomszed
            {
                Csere(csempek[i, j + 1], l);
            }

            if (Kirakva())
            {
                sw.Stop();
                idomeres = false;
                panel1.Enabled = false;
                MessageBox.Show("Sikerult kirakni!");
            }
        }
        
        private void Csere(Label uresCsempe, Label teliCsempe)
        {
            uresCsempe.Text = teliCsempe.Text;
            uresCsempe.BackColor = Color.DarkBlue;

            teliCsempe.Text = "16";
            teliCsempe.BackColor = Color.White;

            if (idomeres)
            {
                cserek++;
                lepesszam.Text = cserek.ToString();
            }
        }

        private bool Kirakva()
        {
            for(int i = 0; i<csempek.GetLength(0); i++ )
            {
                for (int j = 0; j < csempek.GetLength(1); j++)
                {
                    if (!csempek[i, j].Name.Substring(5).Equals(csempek[i, j].Text))
                        return false;
                }
            }
            return true;
        }

        private void Megkever()
        {
            for(int x=0; x<10000; x++)
            {
                int i = r.Next(0, 4);
                int j = r.Next(0, 4);

                int irany = r.Next(1, 5);

                if (irany == 1 && i != 0 && csempek[i - 1, j].Text.Equals("16"))
                    Csere(csempek[i - 1, j], csempek[i, j]);
                else if (irany == 2 && j != 0 && csempek[i, j-1].Text.Equals("16"))
                    Csere(csempek[i, j-1], csempek[i, j]);
                else if (irany == 3 && i != 3 && csempek[i+1, j].Text.Equals("16"))
                    Csere(csempek[i+1, j], csempek[i, j]);
                else if (irany == 4 && j != 3 && csempek[i, j+1].Text.Equals("16"))
                    Csere(csempek[i, j+1], csempek[i, j]);
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Ido.Text = sw.Elapsed.ToString();
        }
    }
}
