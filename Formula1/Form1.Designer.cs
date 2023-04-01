namespace Formula1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atigazotVersenyzokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujVersenyzoFelvetelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ujVersenyzo1 = new Formula1.UjVersenyzo();
            this.atigazoltVersenyzok1 = new Formula1.AtigazoltVersenyzok();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atigazotVersenyzokToolStripMenuItem,
            this.ujVersenyzoFelvetelToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atigazotVersenyzokToolStripMenuItem
            // 
            this.atigazotVersenyzokToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atigazotVersenyzokToolStripMenuItem.Name = "atigazotVersenyzokToolStripMenuItem";
            this.atigazotVersenyzokToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.atigazotVersenyzokToolStripMenuItem.Text = "Atigazot versenyzok";
            this.atigazotVersenyzokToolStripMenuItem.Click += new System.EventHandler(this.atigazotVersenyzokToolStripMenuItem_Click);
            // 
            // ujVersenyzoFelvetelToolStripMenuItem
            // 
            this.ujVersenyzoFelvetelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujVersenyzoFelvetelToolStripMenuItem.Name = "ujVersenyzoFelvetelToolStripMenuItem";
            this.ujVersenyzoFelvetelToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.ujVersenyzoFelvetelToolStripMenuItem.Text = "Uj versenyzo felvetel";
            this.ujVersenyzoFelvetelToolStripMenuItem.Click += new System.EventHandler(this.ujVersenyzoFelvetelToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.kilepesToolStripMenuItem.Text = "Kilepes";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Formula1.Properties.Resources.formula1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 682);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ujVersenyzo1
            // 
            this.ujVersenyzo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujVersenyzo1.Location = new System.Drawing.Point(0, 29);
            this.ujVersenyzo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ujVersenyzo1.Name = "ujVersenyzo1";
            this.ujVersenyzo1.Size = new System.Drawing.Size(958, 663);
            this.ujVersenyzo1.TabIndex = 3;
            this.ujVersenyzo1.Visible = false;
            // 
            // atigazoltVersenyzok1
            // 
            this.atigazoltVersenyzok1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atigazoltVersenyzok1.Location = new System.Drawing.Point(0, 29);
            this.atigazoltVersenyzok1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.atigazoltVersenyzok1.Name = "atigazoltVersenyzok1";
            this.atigazoltVersenyzok1.Size = new System.Drawing.Size(958, 680);
            this.atigazoltVersenyzok1.TabIndex = 2;
            this.atigazoltVersenyzok1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 682);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ujVersenyzo1);
            this.Controls.Add(this.atigazoltVersenyzok1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(977, 721);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atigazotVersenyzokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujVersenyzoFelvetelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AtigazoltVersenyzok atigazoltVersenyzok1;
        private UjVersenyzo ujVersenyzo1;
    }
}

