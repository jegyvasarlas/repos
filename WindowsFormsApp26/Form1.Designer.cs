namespace WindowsFormsApp26
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlMegnyitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faajlMentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fajlMentesMaskentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kijeloltSzovegBetutipus = new System.Windows.Forms.Button();
            this.betumeret = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kisebbBetumeret = new System.Windows.Forms.Button();
            this.nagyobbBetumeret = new System.Windows.Forms.Button();
            this.athuzott = new System.Windows.Forms.Button();
            this.alahuzott = new System.Windows.Forms.Button();
            this.dolt = new System.Windows.Forms.Button();
            this.felkover = new System.Windows.Forms.Button();
            this.Hatter = new System.Windows.Forms.Button();
            this.betuszin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.help = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentFontLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentFontSizeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlMegnyitasToolStripMenuItem,
            this.faajlMentesToolStripMenuItem,
            this.fajlMentesMaskentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlMegnyitasToolStripMenuItem
            // 
            this.fajlMegnyitasToolStripMenuItem.Name = "fajlMegnyitasToolStripMenuItem";
            this.fajlMegnyitasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.fajlMegnyitasToolStripMenuItem.Text = "Fajl megnyitas";
            this.fajlMegnyitasToolStripMenuItem.Click += new System.EventHandler(this.fajlMegnyitasToolStripMenuItem_Click);
            // 
            // faajlMentesToolStripMenuItem
            // 
            this.faajlMentesToolStripMenuItem.Name = "faajlMentesToolStripMenuItem";
            this.faajlMentesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.faajlMentesToolStripMenuItem.Text = "Fajl mentes";
            this.faajlMentesToolStripMenuItem.Click += new System.EventHandler(this.faajlMentesToolStripMenuItem_Click);
            // 
            // fajlMentesMaskentToolStripMenuItem
            // 
            this.fajlMentesMaskentToolStripMenuItem.Name = "fajlMentesMaskentToolStripMenuItem";
            this.fajlMentesMaskentToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.fajlMentesMaskentToolStripMenuItem.Text = "Fajl mentes maskent";
            this.fajlMentesMaskentToolStripMenuItem.Click += new System.EventHandler(this.fajlMentesMaskentToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.kijeloltSzovegBetutipus);
            this.panel1.Controls.Add(this.betumeret);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kisebbBetumeret);
            this.panel1.Controls.Add(this.nagyobbBetumeret);
            this.panel1.Controls.Add(this.athuzott);
            this.panel1.Controls.Add(this.alahuzott);
            this.panel1.Controls.Add(this.dolt);
            this.panel1.Controls.Add(this.felkover);
            this.panel1.Controls.Add(this.Hatter);
            this.panel1.Controls.Add(this.betuszin);
            this.panel1.Location = new System.Drawing.Point(11, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 62);
            this.panel1.TabIndex = 1;
            // 
            // kijeloltSzovegBetutipus
            // 
            this.kijeloltSzovegBetutipus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kijeloltSzovegBetutipus.Font = new System.Drawing.Font("Palace Script MT", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kijeloltSzovegBetutipus.ForeColor = System.Drawing.Color.Black;
            this.kijeloltSzovegBetutipus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.kijeloltSzovegBetutipus.Location = new System.Drawing.Point(430, 7);
            this.kijeloltSzovegBetutipus.Name = "kijeloltSzovegBetutipus";
            this.kijeloltSzovegBetutipus.Size = new System.Drawing.Size(50, 50);
            this.kijeloltSzovegBetutipus.TabIndex = 10;
            this.kijeloltSzovegBetutipus.Text = "A";
            this.kijeloltSzovegBetutipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.SetToolTip(this.kijeloltSzovegBetutipus, "Kijelolt szoveg betutipus modositas");
            this.kijeloltSzovegBetutipus.UseVisualStyleBackColor = false;
            this.kijeloltSzovegBetutipus.Click += new System.EventHandler(this.kijeloltSzovegBetutipus_Click);
            // 
            // betumeret
            // 
            this.betumeret.FormattingEnabled = true;
            this.betumeret.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72"});
            this.betumeret.Location = new System.Drawing.Point(231, 24);
            this.betumeret.Name = "betumeret";
            this.betumeret.Size = new System.Drawing.Size(81, 29);
            this.betumeret.TabIndex = 9;
            this.betumeret.Text = "12";
            this.betumeret.SelectedValueChanged += new System.EventHandler(this.betumeret_SelectedValueChanged);
            this.betumeret.TextChanged += new System.EventHandler(this.betumeret_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Betumeret:";
            // 
            // kisebbBetumeret
            // 
            this.kisebbBetumeret.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kisebbBetumeret.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kisebbBetumeret.ForeColor = System.Drawing.Color.Black;
            this.kisebbBetumeret.Location = new System.Drawing.Point(374, 7);
            this.kisebbBetumeret.Name = "kisebbBetumeret";
            this.kisebbBetumeret.Size = new System.Drawing.Size(50, 50);
            this.kisebbBetumeret.TabIndex = 7;
            this.kisebbBetumeret.Text = "v";
            this.help.SetToolTip(this.kisebbBetumeret, "Kijelolt szoveg kisebb betumeret");
            this.kisebbBetumeret.UseVisualStyleBackColor = false;
            this.kisebbBetumeret.Click += new System.EventHandler(this.kisebbBetumeret_Click);
            // 
            // nagyobbBetumeret
            // 
            this.nagyobbBetumeret.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nagyobbBetumeret.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nagyobbBetumeret.ForeColor = System.Drawing.Color.Black;
            this.nagyobbBetumeret.Location = new System.Drawing.Point(318, 7);
            this.nagyobbBetumeret.Name = "nagyobbBetumeret";
            this.nagyobbBetumeret.Size = new System.Drawing.Size(50, 50);
            this.nagyobbBetumeret.TabIndex = 6;
            this.nagyobbBetumeret.Text = "^";
            this.help.SetToolTip(this.nagyobbBetumeret, "Kijelolt szoveg nagobb betumeret");
            this.nagyobbBetumeret.UseVisualStyleBackColor = false;
            this.nagyobbBetumeret.Click += new System.EventHandler(this.nagyobbBetumeret_Click);
            // 
            // athuzott
            // 
            this.athuzott.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.athuzott.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athuzott.ForeColor = System.Drawing.Color.Black;
            this.athuzott.Location = new System.Drawing.Point(171, 7);
            this.athuzott.Name = "athuzott";
            this.athuzott.Size = new System.Drawing.Size(50, 50);
            this.athuzott.TabIndex = 5;
            this.athuzott.Text = "S";
            this.help.SetToolTip(this.athuzott, "Athuzott");
            this.athuzott.UseVisualStyleBackColor = false;
            this.athuzott.Click += new System.EventHandler(this.athuzott_Click);
            // 
            // alahuzott
            // 
            this.alahuzott.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alahuzott.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alahuzott.ForeColor = System.Drawing.Color.Black;
            this.alahuzott.Location = new System.Drawing.Point(115, 7);
            this.alahuzott.Name = "alahuzott";
            this.alahuzott.Size = new System.Drawing.Size(50, 50);
            this.alahuzott.TabIndex = 4;
            this.alahuzott.Text = "U";
            this.help.SetToolTip(this.alahuzott, "Alahuzott");
            this.alahuzott.UseVisualStyleBackColor = false;
            this.alahuzott.Click += new System.EventHandler(this.alahuzott_Click);
            // 
            // dolt
            // 
            this.dolt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dolt.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolt.ForeColor = System.Drawing.Color.Black;
            this.dolt.Location = new System.Drawing.Point(59, 7);
            this.dolt.Name = "dolt";
            this.dolt.Size = new System.Drawing.Size(50, 50);
            this.dolt.TabIndex = 3;
            this.dolt.Text = "I";
            this.help.SetToolTip(this.dolt, "Dolt");
            this.dolt.UseVisualStyleBackColor = false;
            this.dolt.Click += new System.EventHandler(this.dolt_Click);
            // 
            // felkover
            // 
            this.felkover.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.felkover.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felkover.ForeColor = System.Drawing.Color.Black;
            this.felkover.Location = new System.Drawing.Point(3, 7);
            this.felkover.Name = "felkover";
            this.felkover.Size = new System.Drawing.Size(50, 50);
            this.felkover.TabIndex = 2;
            this.felkover.Text = "B";
            this.felkover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.SetToolTip(this.felkover, "Felkover");
            this.felkover.UseVisualStyleBackColor = false;
            this.felkover.Click += new System.EventHandler(this.felkover_Click);
            // 
            // Hatter
            // 
            this.Hatter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hatter.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hatter.ForeColor = System.Drawing.Color.Black;
            this.Hatter.Location = new System.Drawing.Point(542, 7);
            this.Hatter.Name = "Hatter";
            this.Hatter.Size = new System.Drawing.Size(50, 50);
            this.Hatter.TabIndex = 1;
            this.Hatter.Text = "A";
            this.Hatter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.SetToolTip(this.Hatter, "Kijelolt szoveg hatterszinenek valtoztatasa");
            this.Hatter.UseVisualStyleBackColor = false;
            this.Hatter.Click += new System.EventHandler(this.Hatter_Click);
            // 
            // betuszin
            // 
            this.betuszin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.betuszin.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betuszin.ForeColor = System.Drawing.Color.Red;
            this.betuszin.Location = new System.Drawing.Point(486, 7);
            this.betuszin.Name = "betuszin";
            this.betuszin.Size = new System.Drawing.Size(50, 50);
            this.betuszin.TabIndex = 0;
            this.betuszin.Text = "A";
            this.betuszin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.SetToolTip(this.betuszin, "Kijelolt szovegszin beallitas");
            this.betuszin.UseVisualStyleBackColor = false;
            this.betuszin.Click += new System.EventHandler(this.betuszin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(831, 399);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // help
            // 
            this.help.AutomaticDelay = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kijelolt szoveg modositasa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jelenlegi betutipus:";
            // 
            // currentFontLabel
            // 
            this.currentFontLabel.AutoSize = true;
            this.currentFontLabel.Location = new System.Drawing.Point(160, 527);
            this.currentFontLabel.Name = "currentFontLabel";
            this.currentFontLabel.Size = new System.Drawing.Size(72, 21);
            this.currentFontLabel.TabIndex = 13;
            this.currentFontLabel.Text = "Segoe UI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Jelenlegi betumeret:";
            // 
            // currentFontSizeLabel
            // 
            this.currentFontSizeLabel.AutoSize = true;
            this.currentFontSizeLabel.Location = new System.Drawing.Point(819, 527);
            this.currentFontSizeLabel.Name = "currentFontSizeLabel";
            this.currentFontSizeLabel.Size = new System.Drawing.Size(28, 21);
            this.currentFontSizeLabel.TabIndex = 15;
            this.currentFontSizeLabel.Text = "12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 557);
            this.Controls.Add(this.currentFontSizeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentFontLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Szovegszerkeszto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlMegnyitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faajlMentesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button betuszin;
        private System.Windows.Forms.ToolTip help;
        private System.Windows.Forms.Button Hatter;
        private System.Windows.Forms.Button kisebbBetumeret;
        private System.Windows.Forms.Button nagyobbBetumeret;
        private System.Windows.Forms.Button athuzott;
        private System.Windows.Forms.Button alahuzott;
        private System.Windows.Forms.Button dolt;
        private System.Windows.Forms.Button felkover;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox betumeret;
        private System.Windows.Forms.ToolStripMenuItem fajlMentesMaskentToolStripMenuItem;
        private System.Windows.Forms.Button kijeloltSzovegBetutipus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentFontLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentFontSizeLabel;
    }
}

