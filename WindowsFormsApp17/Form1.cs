using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        int sor;
        int oszlop;
        int jo;
        int rossz;
        
        public Form1()
        {
            InitializeComponent();
            sor = oszlop = -1;
            jo = rossz = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szorzotabla.AllowUserToAddRows = false;
            szorzotabla.AllowUserToResizeColumns = false;
            szorzotabla.AllowUserToResizeRows = false;
            szorzotabla.AllowUserToDeleteRows = false;
            szorzotabla.AllowUserToOrderColumns = false;
            szorzotabla.EnableHeadersVisualStyles = false;
            szorzotabla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            szorzotabla.RowHeadersWidth = 50;

            for (int i = 1; i <= 10; i++)
            {
                szorzotabla.Columns.Add("Oszlop" + i, i.ToString());
                szorzotabla.Columns[i - 1].Width = 50;
                szorzotabla.Columns[i - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                szorzotabla.Columns[i - 1].HeaderCell.Style.Font = new Font("Segoe UI", 9);
                szorzotabla.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            for (int i = 1; i <= 10; i++)
            {
                szorzotabla.Rows.Add();
                szorzotabla.Rows[i - 1].HeaderCell.Value = i.ToString();
                szorzotabla.Rows[i - 1].Height = 50;
                szorzotabla.Rows[i - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                szorzotabla.Rows[i - 1].HeaderCell.Style.Font = new Font("Segoe UI", 9);
            }

            //szorzotabla.ReadOnly = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    szorzotabla[i, j].ReadOnly = true;
                }
            }

            szorzotabla.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            szorzotabla.MultiSelect = false;

            Sorsol();
        }
        
        private void Sorsol()
        {
            do
            {
                sor = r.Next(10);
                oszlop = r.Next(10);
            } while (szorzotabla[oszlop, sor].Style.BackColor == Color.LightGreen);


            szorzotabla[oszlop, sor].ReadOnly = false;
            szorzotabla[oszlop, sor].Style.BackColor = Color.HotPink;
            szorzotabla.Rows[sor].HeaderCell.Style.BackColor = Color.Pink;
            szorzotabla.Columns[oszlop].HeaderCell.Style.BackColor = Color.Pink;
            
            szorzotabla.CurrentCell = szorzotabla[oszlop, sor];
            szorzotabla.BeginEdit(true);
        }


        private void szorzotabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MessageBox.Show("sor: " + sor + " oszlop: " + oszlop);
                if (!(sor == -1 && oszlop == -1))
                {
                    int szorzat = Convert.ToInt32(szorzotabla[oszlop, sor].Value);

                    if (szorzat == (sor + 1) * (oszlop + 1))
                    {
                        MessageBox.Show("Helyes");
                        szorzotabla[oszlop, sor].Style.BackColor = Color.LightGreen;
                        szorzotabla[oszlop, sor].ReadOnly = true;
                        joCount.Text = (++jo).ToString();
                        szorzotabla.Rows[sor].HeaderCell.Style.BackColor = default;
                        szorzotabla.Columns[oszlop].HeaderCell.Style.BackColor = default;

                        if (jo == 100)
                        {
                            MessageBox.Show("Gratulalok, ugyes voltal!");
                            szorzotabla.ReadOnly = true;
                            return;
                        }
                        Sorsol();
                    }
                    else if (szorzotabla[oszlop, sor].Value == null)
                    {
                        return;
                    }
                    else
                    {
                        rosszCount.Text = (++rossz).ToString();
                        szorzotabla[oszlop, sor].Value = null;
                        MessageBox.Show("Helytelen\nIrd be ujra a helyes megoldast!");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Helytelen\nIrd be ujra a helyes megoldast!");
            }
        }
    }
}
