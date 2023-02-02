using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Halmaz : UserControl
    {
        static Random r = new Random();
        private HashSet<int> halmaz;
        public Halmaz()
        {
            InitializeComponent();
            halmaz = new HashSet<int>();
        }

        private void feltolt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            halmaz.Clear();
            int elemszam = (int)numericUpDown1.Value;
            while (halmaz.Count != elemszam)
            {
                halmaz.Add(r.Next(-500, 501));
            }

            foreach (int i in halmaz)
            {
                listBox1.Items.Add(i);
            }
        }

        public bool Editable
        {
            
            set
            {
                if (value)
                {
                    button1.Visible = numericUpDown1.Visible = true;
                }
                else
                {
                    button1.Visible = numericUpDown1.Visible = false;
                }
            }
            get
            {
                if(button1.Visible && numericUpDown1.Visible)
                    return true;
                return false;
            }
        }
        
        public HashSet<int> GetElemek()
        {
            return halmaz;
        }
        
        public void SetElemek(HashSet<int> h)
        {
            listBox1.Items.Clear();
            this.halmaz = h;
            foreach (int i in halmaz)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}