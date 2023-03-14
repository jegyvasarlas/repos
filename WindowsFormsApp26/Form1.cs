using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        ColorDialog cd;
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            cd = new ColorDialog();
            sfd = new SaveFileDialog();
        }

        private void fajlMegnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".txt"))
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string sor;
                    while ((sor = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text += sor;
                        richTextBox1.Text += Environment.NewLine;
                    }
                    sr.Close();
                    fs.Close();
                }
                else if (ofd.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(ofd.FileName);
                }
            }
        }

        private Color? setSzin()
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                return cd.Color;
            }
            else
            {
                return null;
            }
        }

        private void betuszin_Click(object sender, EventArgs e)
        {
            Color? szin = setSzin();
            if (szin.Equals(null).Equals(false))
            {
                richTextBox1.SelectionColor = (Color)szin;
            }
        }

        private void Hatter_Click(object sender, EventArgs e)
        {
            Color? szin = setSzin();
            if (szin.Equals(null).Equals(false))
            {
                richTextBox1.SelectionBackColor = (Color)szin;
            }
        }

        private void felkover_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            switch (kijelolt.Style)
            {
                case 0: // regular
                    SetStyle(ref richTextBox1, FontStyle.Bold);
                    break;
                case (FontStyle)1: // bold
                    SetStyle(ref richTextBox1, FontStyle.Regular);
                    break;
                case (FontStyle)2: // italic
                    SetStyle(ref richTextBox1, (FontStyle)3);
                    break;
                case (FontStyle)3: // bold italic
                    SetStyle(ref richTextBox1, FontStyle.Italic);
                    break;
                case (FontStyle)4: // underline
                    SetStyle(ref richTextBox1, (FontStyle)5);
                    break;
                case (FontStyle)5: // bold underline
                    SetStyle(ref richTextBox1, (FontStyle)6);
                    break;
                case (FontStyle)6: // italic underline
                    SetStyle(ref richTextBox1, (FontStyle)7);
                    break;
                case (FontStyle)7: // bold italic underline
                    SetStyle(ref richTextBox1, (FontStyle)4);
                    break;
                case (FontStyle)8: // strikeout
                    SetStyle(ref richTextBox1, (FontStyle)9);
                    break;
                case (FontStyle)9: // bold strikeout
                    SetStyle(ref richTextBox1, (FontStyle)10);
                    break;
                case (FontStyle)10: // italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)11);
                    break;
                case (FontStyle)11: // bold italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)8);
                    break;
                case (FontStyle)12: // underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)13);
                    break;
                case (FontStyle)13: // bold underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)14);
                    break;
                case (FontStyle)14: // italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)15);
                    break;
                case (FontStyle)15: // bold italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)12);
                    break;
            }
        }

        private void dolt_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            switch (kijelolt.Style)
            {
                case 0: // regular
                    SetStyle(ref richTextBox1, FontStyle.Italic);
                    break;
                case (FontStyle)1: // bold
                    SetStyle(ref richTextBox1, (FontStyle)3);
                    break;
                case (FontStyle)2: // italic
                    SetStyle(ref richTextBox1, FontStyle.Regular);
                    break;
                case (FontStyle)3: // bold italic
                    SetStyle(ref richTextBox1, FontStyle.Bold);
                    break;
                case (FontStyle)4: // underline
                    SetStyle(ref richTextBox1, (FontStyle)6);
                    break;
                case (FontStyle)5: // bold underline
                    SetStyle(ref richTextBox1, (FontStyle)7);
                    break;
                case (FontStyle)6: // italic underline
                    SetStyle(ref richTextBox1, (FontStyle)4);
                    break;
                case (FontStyle)7: // bold italic underline
                    SetStyle(ref richTextBox1, (FontStyle)5);
                    break;
                case (FontStyle)8: // strikeout
                    SetStyle(ref richTextBox1, (FontStyle)10);
                    break;
                case (FontStyle)9: // bold strikeout
                    SetStyle(ref richTextBox1, (FontStyle)11);
                    break;
                case (FontStyle)10: // italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)8);
                    break;
                case (FontStyle)11: // bold italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)9);
                    break;
                case (FontStyle)12: // underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)14);
                    break;
                case (FontStyle)13: // bold underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)15);
                    break;
                case (FontStyle)14: // italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)12);
                    break;
                case (FontStyle)15: // bold italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)13);
                    break;
            }
        }

        private void SetStyle(ref RichTextBox f, FontStyle s)
        {
            f.SelectionFont = new Font(f.SelectionFont.FontFamily, f.SelectionFont.Size, s);
        }

        private void alahuzott_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            switch (kijelolt.Style)
            {
                case 0: // regular
                    SetStyle(ref richTextBox1, FontStyle.Underline);
                    break;
                case (FontStyle)1: // bold
                    SetStyle(ref richTextBox1, (FontStyle)5);
                    break;
                case (FontStyle)2: // italic
                    SetStyle(ref richTextBox1, (FontStyle)6);
                    break;
                case (FontStyle)3: // bold italic
                    SetStyle(ref richTextBox1, (FontStyle)7);
                    break;
                case (FontStyle)4: // underline
                    SetStyle(ref richTextBox1, FontStyle.Regular);
                    break;
                case (FontStyle)5: // bold underline
                    SetStyle(ref richTextBox1, (FontStyle)1);
                    break;
                case (FontStyle)6: // italic underline
                    SetStyle(ref richTextBox1, (FontStyle)2);
                    break;
                case (FontStyle)7: // bold italic underline
                    SetStyle(ref richTextBox1, (FontStyle)3);
                    break;
                case (FontStyle)8: // strikeout
                    SetStyle(ref richTextBox1, (FontStyle)12);
                    break;
                case (FontStyle)9: // bold strikeout
                    SetStyle(ref richTextBox1, (FontStyle)13);
                    break;
                case (FontStyle)10: // italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)14);
                    break;
                case (FontStyle)11: // bold italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)15);
                    break;
                case (FontStyle)12: // underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)8);
                    break;
                case (FontStyle)13: // bold underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)9);
                    break;
                case (FontStyle)14: // italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)10);
                    break;
                case (FontStyle)15: // bold italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)11);
                    break;
            }
        }

        private void athuzott_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            switch (kijelolt.Style)
            {
                case 0: // regular
                    SetStyle(ref richTextBox1, FontStyle.Strikeout);
                    break;
                case (FontStyle)1: // bold
                    SetStyle(ref richTextBox1, (FontStyle)9);
                    break;
                case (FontStyle)2: // italic
                    SetStyle(ref richTextBox1, (FontStyle)10);
                    break;
                case (FontStyle)3: // bold italic
                    SetStyle(ref richTextBox1, (FontStyle)11);
                    break;
                case (FontStyle)4: // underline
                    SetStyle(ref richTextBox1, (FontStyle)12);
                    break;
                case (FontStyle)5: // bold underline
                    SetStyle(ref richTextBox1, (FontStyle)13);
                    break;
                case (FontStyle)6: // italic underline
                    SetStyle(ref richTextBox1, (FontStyle)14);
                    break;
                case (FontStyle)7: // bold italic underline
                    SetStyle(ref richTextBox1, (FontStyle)15);
                    break;
                case (FontStyle)8: // strikeout
                    SetStyle(ref richTextBox1, FontStyle.Regular);
                    break;
                case (FontStyle)9: // bold strikeout
                    SetStyle(ref richTextBox1, FontStyle.Bold);
                    break;
                case (FontStyle)10: // italic strikeout
                    SetStyle(ref richTextBox1, FontStyle.Italic);
                    break;
                case (FontStyle)11: // bold italic strikeout
                    SetStyle(ref richTextBox1, (FontStyle)3);
                    break;
                case (FontStyle)12: // underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)4);
                    break;
                case (FontStyle)13: // bold underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)5);
                    break;
                case (FontStyle)14: // italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)6);
                    break;
                case (FontStyle)15: // bold italic underline strikeout
                    SetStyle(ref richTextBox1, (FontStyle)7);
                    break;
            }
        }

        private void betumeret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FontStyle fontStyle = richTextBox1.SelectionFont.Style;
                float size = (float)Convert.ToDouble(betumeret.Text);
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, fontStyle);
                currentFontSizeLabel.Text = size.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nem számot adtál meg!");
            }
        }

        private void betumeret_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FontStyle fontStyle = richTextBox1.SelectionFont.Style;
                float size = (float)Convert.ToDouble(betumeret.Text);
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, fontStyle);
                currentFontSizeLabel.Text = size.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nem számot adtál meg!");
            }
        }


        SaveFileDialog sfd;

        private void faajlMentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd is OpenFileDialog)
            {
                if (ofd.FileName.Equals(string.Empty).Equals(false))
                {
                    sfd.FileName = ofd.FileName;

                    if (sfd.FileName.EndsWith(".txt"))
                    {
                        SaveTxt();
                    }
                    else if (sfd.FileName.EndsWith(".rtf"))
                    {
                        richTextBox1.SaveFile(sfd.FileName);
                    }
                }
                else
                {
                    SaveAs();
                }
            }
        }

        private void SaveTxt()
        {
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            string[] sorok = richTextBox1.Lines;

            for (int i = 0; i < sorok.Length; i++)
                sw.WriteLine(sorok[i]);

            sw.Close();
            fs.Close();
        }

        private void SaveAs()
        {
            sfd.Filter = "Rich Text formátum (*.rtf) | *.rtf|" +
             "Szöveges fájl (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith(".txt"))
                {
                    SaveTxt();
                }
                else if (sfd.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.SaveFile(sfd.FileName);
                }

                ofd.FileName = sfd.FileName;
            }
        }

        private void fajlMentesMaskentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void nagyobbBetumeret_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            FontStyle fontStyle = richTextBox1.SelectionFont.Style;
            float size = kijelolt.Size;
            size += 1;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, fontStyle);
            betumeret.Text = size.ToString();
            currentFontSizeLabel.Text = size.ToString();
        }

        private void openAISzoveggeneraloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kisebbBetumeret_Click(object sender, EventArgs e)
        {
            Font kijelolt = richTextBox1.SelectionFont;
            FontStyle fontStyle = richTextBox1.SelectionFont.Style;
            float size = kijelolt.Size;
            size -= 1;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, fontStyle);
            betumeret.Text = size.ToString();
            currentFontSizeLabel.Text = size.ToString();
        }

        private void kijeloltSzovegBetutipus_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            float fontSize = fontDialog1.Font.Size;
            FontStyle fontStyle = richTextBox1.SelectionFont.Style;
            richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontSize, fontStyle);
            betumeret.Text = fontSize.ToString();
            currentFontLabel.Text = fontDialog1.Font.Name;
            currentFontSizeLabel.Text = fontSize.ToString();
        }

    }
}
