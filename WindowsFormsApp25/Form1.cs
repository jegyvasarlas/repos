using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        ColorDialog cd;
        FontDialog fd;
        public Form1()
        {
            InitializeComponent();
            cd = new ColorDialog();
            fd = new FontDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void betu_Click(object sender, EventArgs e)
        {
            if (cd is ColorDialog)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    label1.ForeColor = cd.Color;
                }
            }
        }

        private void hatter_Click(object sender, EventArgs e)
        {
            if (cd is ColorDialog)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    label1.BackColor = cd.Color;
                }
            }
        }

        private void PictureOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath, "*.png");
                if (files.Length > 0)
                {
                    label2.Image = Image.FromFile(files[0]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.Font;
            FontStyle currentStyle = currentFont.Style;
            richTextBox1.Font = new Font(currentFont.FontFamily, (float)numericUpDown1.Value, currentStyle);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (fd is FontDialog)
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fd.Font;
                    numericUpDown1.Value = (decimal)fd.Font.Size;
                }
            }
        }
    }
}
