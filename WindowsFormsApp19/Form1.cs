using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFajlok(string mappa, string maszk, bool rekurzivE, Action<string> action)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(mappa);
                FileInfo[] fis = di.GetFiles(maszk);
                foreach(FileInfo fi in fis)
                {
                    action(fi.FullName);
                }
                if (rekurzivE)
                {
                    DirectoryInfo[] dis = di.GetDirectories();
                    foreach (DirectoryInfo di2 in dis)
                    {
                        GetFajlok(Path.Combine(mappa, di2.Name), maszk, rekurzivE, action);
                    }
                }
            } catch (Exception ex) 
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }

        private void kereses_Click(object sender, EventArgs e)
        {
            Kereses();
        }
        
        private void Kereses()
        {
            string mappa = Path.GetDirectoryName(eleresiUt.Text);
            string maszk = eleresiUt.Text.Substring(mappa.Length + 1);
            listBox1.Items.Clear();
            listBox1.BeginUpdate();

            GetFajlok(mappa, maszk, rekurziv.Checked, fajlNev => listBox1.Items.Add(fajlNev));

            listBox1.EndUpdate();
        }

        private void eleresiUt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Kereses();
        }
    }
}
