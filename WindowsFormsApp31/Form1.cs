using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap kep;
            kep = new Bitmap(@"C:\Users\admin\Downloads\welcome.jpg");
            Graphics grafika;
            grafika = this.CreateGraphics();
            grafika.DrawImage(kep, 0, 0);
        }
    }
}
