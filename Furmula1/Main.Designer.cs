namespace Furmula1
{
    partial class Main
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
            this.Átigazolt_versenyzők = new System.Windows.Forms.ToolStripMenuItem();
            this.Új_versenyző_felvétele = new System.Windows.Forms.ToolStripMenuItem();
            this.Kilépés = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Átigazolt_versenyzők,
            this.Új_versenyző_felvétele,
            this.Kilépés});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Átigazolt_versenyzők
            // 
            this.Átigazolt_versenyzők.Name = "Átigazolt_versenyzők";
            this.Átigazolt_versenyzők.Size = new System.Drawing.Size(127, 20);
            this.Átigazolt_versenyzők.Text = "Átigazolt versenyzők";
            this.Átigazolt_versenyzők.Click += new System.EventHandler(this.Átigazolt_versenyzők_Click);
            // 
            // Új_versenyző_felvétele
            // 
            this.Új_versenyző_felvétele.Name = "Új_versenyző_felvétele";
            this.Új_versenyző_felvétele.Size = new System.Drawing.Size(132, 20);
            this.Új_versenyző_felvétele.Text = "Új versenyző felvétele";
            this.Új_versenyző_felvétele.Click += new System.EventHandler(this.Új_versenyző_felvétele_Click);
            // 
            // Kilépés
            // 
            this.Kilépés.Name = "Kilépés";
            this.Kilépés.Size = new System.Drawing.Size(56, 20);
            this.Kilépés.Text = "Kilépés";
            this.Kilépés.Click += new System.EventHandler(this.Kilépés_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Furmula1.Properties.Resources.formula1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Formula 1 versenyzők 2022-ben";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Átigazolt_versenyzők;
        private System.Windows.Forms.ToolStripMenuItem Új_versenyző_felvétele;
        private System.Windows.Forms.ToolStripMenuItem Kilépés;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

