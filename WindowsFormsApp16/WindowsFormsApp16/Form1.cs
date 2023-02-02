using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnioClick(object sender, EventArgs e)
        {
            HashSet<int> unio = halmaz1.GetElemek();
            unio.UnionWith(halmaz2.GetElemek());
            Eredmeny.SetElemek(unio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            halmaz1.Editable = true;
            halmaz2.Editable = true;
        }

        private void Metszet(object sender, EventArgs e)
        {
            HashSet<int> metszet = halmaz1.GetElemek();
            metszet.IntersectWith(halmaz2.GetElemek());
            Eredmeny.SetElemek(metszet);
        }

        private void AminuszB(object sender, EventArgs e)
        {
            HashSet<int> aMinuszB = halmaz1.GetElemek();
            aMinuszB.ExceptWith(halmaz2.GetElemek());
            Eredmeny.SetElemek(aMinuszB);
        }

        private void BminuszA(object sender, EventArgs e)
        {
            HashSet<int> bMinuszA = halmaz2.GetElemek();
            bMinuszA.ExceptWith(halmaz1.GetElemek());
            Eredmeny.SetElemek(bMinuszA);
        }
    }
}