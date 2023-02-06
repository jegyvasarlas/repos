using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sutemeny
{
    public partial class Arlista : Form
    {
        public Arlista()
        {
            InitializeComponent();
        }

        private void Check(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) textBox1.Text = "0";
            if (!checkBox2.Checked) textBox2.Text = "0";
            if (!checkBox3.Checked) textBox3.Text = "0";
            if (!checkBox4.Checked) textBox4.Text = "0";
            if (!checkBox5.Checked) textBox5.Text = "0";
        }

        private void Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") checkBox1.Checked = true; 
            if (textBox2.Text != "0") checkBox2.Checked = true; 
            if (textBox3.Text != "0") checkBox3.Checked = true;
            if (textBox4.Text != "0") checkBox4.Checked = true; 
            if (textBox5.Text != "0") checkBox5.Checked = true; 
            if (textBox1.Text == "") textBox1.Text = "0";
            if (textBox2.Text == "") textBox2.Text = "0";
            if (textBox3.Text == "") textBox3.Text = "0";
            if (textBox4.Text == "") textBox4.Text = "0";
            if (textBox5.Text == "") textBox5.Text = "0";
            if (textBox1.Text == "0") checkBox1.Checked = false;
            if (textBox2.Text == "0") checkBox2.Checked = false;
            if (textBox3.Text == "0") checkBox3.Checked = false;
            if (textBox4.Text == "0") checkBox4.Checked = false;
            if (textBox5.Text == "0") checkBox5.Checked = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) MessageBox.Show("Sikeres rendelés!", "Rendelés", MessageBoxButtons.OK);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500, 600);
            RichTextBox rtb = new RichTextBox();
            if (checkBox1.Checked) rtb.Text += $"Somlói galuska;{textBox1.Text}db;{300*int.Parse(textBox1.Text)}ft{Environment.NewLine}";
            if (checkBox2.Checked) rtb.Text += $"Rákózci túrós;{textBox2.Text}db;{280*int.Parse(textBox2.Text)}ft{Environment.NewLine}";
            if (checkBox3.Checked) rtb.Text += $"Csoki torta;{textBox3.Text}db;{350*int.Parse(textBox3.Text)}ft{Environment.NewLine}";
            if (checkBox4.Checked) rtb.Text += $"Marcipán alagút;{textBox4.Text}db;{400*int.Parse(textBox4.Text)}ft{Environment.NewLine}";
            if (checkBox5.Checked) rtb.Text += $"Eszterházy szelet;{textBox5.Text}db;{400*int.Parse(textBox5.Text)}ft{Environment.NewLine}";
            rtb.Text += $"Összesen: {300*int.Parse(textBox1.Text)+280*int.Parse(textBox2.Text)+350*int.Parse(textBox3.Text)+400*int.Parse(textBox4.Text)+400*int.Parse(textBox5.Text)}ft";
            if (textBox1.Text == "0" && textBox2.Text == "0" && textBox3.Text == "0" && textBox4.Text == "0" && textBox5.Text == "0") rtb.Text = "Nincs kiválasztott sütemény!";
            else
            {
                rtb.Text += $"{Environment.NewLine}A rendelés sikeresen elküldve!{Environment.NewLine}Köszönjük a vásárlást!";
            }
            rtb.Size = new Size(452, 203);
            rtb.Location = new Point(20, 343);
            rtb.ReadOnly = true;
            this.Controls.Add(rtb);
            button1.Enabled = false;
        }
    }
}