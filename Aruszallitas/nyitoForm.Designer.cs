namespace Aruszallitas
{
    partial class nyitoForm
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
            this.budapestrőlIndultUtakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újÚtFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.budapestrolIndultUtakUserControl1 = new Aruszallitas.budapestrolIndultUtakUserControl();
            this.ujUtFelveteleUserControl1 = new Aruszallitas.ujUtFelveteleUserControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budapestrőlIndultUtakToolStripMenuItem,
            this.újÚtFelvételeToolStripMenuItem,
            this.statisztikákToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // budapestrőlIndultUtakToolStripMenuItem
            // 
            this.budapestrőlIndultUtakToolStripMenuItem.Name = "budapestrőlIndultUtakToolStripMenuItem";
            this.budapestrőlIndultUtakToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.budapestrőlIndultUtakToolStripMenuItem.Text = "Budapestről indult utak";
            this.budapestrőlIndultUtakToolStripMenuItem.Click += new System.EventHandler(this.budapestrőlIndultUtakToolStripMenuItem_Click);
            // 
            // újÚtFelvételeToolStripMenuItem
            // 
            this.újÚtFelvételeToolStripMenuItem.Name = "újÚtFelvételeToolStripMenuItem";
            this.újÚtFelvételeToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.újÚtFelvételeToolStripMenuItem.Text = "Új út felvétele";
            this.újÚtFelvételeToolStripMenuItem.Click += new System.EventHandler(this.újÚtFelvételeToolStripMenuItem_Click);
            // 
            // statisztikákToolStripMenuItem
            // 
            this.statisztikákToolStripMenuItem.Name = "statisztikákToolStripMenuItem";
            this.statisztikákToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.statisztikákToolStripMenuItem.Text = "Statisztikák";
            this.statisztikákToolStripMenuItem.Click += new System.EventHandler(this.statisztikákToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Aruszallitas.Properties.Resources.szallitas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // budapestrolIndultUtakUserControl1
            // 
            this.budapestrolIndultUtakUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.budapestrolIndultUtakUserControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budapestrolIndultUtakUserControl1.Location = new System.Drawing.Point(0, 24);
            this.budapestrolIndultUtakUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.budapestrolIndultUtakUserControl1.Name = "budapestrolIndultUtakUserControl1";
            this.budapestrolIndultUtakUserControl1.Size = new System.Drawing.Size(787, 466);
            this.budapestrolIndultUtakUserControl1.TabIndex = 2;
            this.budapestrolIndultUtakUserControl1.Visible = false;
            // 
            // ujUtFelveteleUserControl1
            // 
            this.ujUtFelveteleUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ujUtFelveteleUserControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujUtFelveteleUserControl1.Location = new System.Drawing.Point(0, 24);
            this.ujUtFelveteleUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ujUtFelveteleUserControl1.Name = "ujUtFelveteleUserControl1";
            this.ujUtFelveteleUserControl1.Size = new System.Drawing.Size(787, 466);
            this.ujUtFelveteleUserControl1.TabIndex = 3;
            this.ujUtFelveteleUserControl1.Visible = false;
            // 
            // nyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 490);
            this.Controls.Add(this.ujUtFelveteleUserControl1);
            this.Controls.Add(this.budapestrolIndultUtakUserControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(803, 529);
            this.Name = "nyitoForm";
            this.Text = "Aruszallitas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem budapestrőlIndultUtakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újÚtFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private budapestrolIndultUtakUserControl budapestrolIndultUtakUserControl1;
        private ujUtFelveteleUserControl ujUtFelveteleUserControl1;
    }
}

