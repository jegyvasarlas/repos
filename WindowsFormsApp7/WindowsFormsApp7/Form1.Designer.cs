namespace WindowsFormsApp7
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdatokLista = new System.Windows.Forms.ListBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.feltoltButton = new System.Windows.Forms.Button();
            this.megjelenitButton = new System.Windows.Forms.Button();
            this.szamolButton = new System.Windows.Forms.Button();
            this.kilepesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adatok";
            // 
            // AdatokLista
            // 
            this.AdatokLista.FormattingEnabled = true;
            this.AdatokLista.ItemHeight = 21;
            this.AdatokLista.Location = new System.Drawing.Point(12, 43);
            this.AdatokLista.Name = "AdatokLista";
            this.AdatokLista.Size = new System.Drawing.Size(141, 130);
            this.AdatokLista.TabIndex = 1;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(166, 33);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(146, 29);
            this.maxBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(166, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(166, 89);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(146, 29);
            this.minBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(166, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avg";
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(166, 145);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(146, 29);
            this.avgBox.TabIndex = 6;
            // 
            // feltoltButton
            // 
            this.feltoltButton.Location = new System.Drawing.Point(12, 188);
            this.feltoltButton.Name = "feltoltButton";
            this.feltoltButton.Size = new System.Drawing.Size(140, 34);
            this.feltoltButton.TabIndex = 8;
            this.feltoltButton.Text = "Feltolt";
            this.feltoltButton.UseVisualStyleBackColor = true;
            this.feltoltButton.Click += new System.EventHandler(this.feltoltButton_Click);
            // 
            // megjelenitButton
            // 
            this.megjelenitButton.Enabled = false;
            this.megjelenitButton.Location = new System.Drawing.Point(12, 228);
            this.megjelenitButton.Name = "megjelenitButton";
            this.megjelenitButton.Size = new System.Drawing.Size(140, 34);
            this.megjelenitButton.TabIndex = 9;
            this.megjelenitButton.Text = "Megjelenit";
            this.megjelenitButton.UseVisualStyleBackColor = true;
            this.megjelenitButton.Click += new System.EventHandler(this.megjelenitButton_Click);
            // 
            // szamolButton
            // 
            this.szamolButton.Enabled = false;
            this.szamolButton.Location = new System.Drawing.Point(172, 188);
            this.szamolButton.Name = "szamolButton";
            this.szamolButton.Size = new System.Drawing.Size(140, 34);
            this.szamolButton.TabIndex = 10;
            this.szamolButton.Text = "Szamol";
            this.szamolButton.UseVisualStyleBackColor = true;
            this.szamolButton.Click += new System.EventHandler(this.szamolButton_Click);
            // 
            // kilepesButton
            // 
            this.kilepesButton.Location = new System.Drawing.Point(172, 228);
            this.kilepesButton.Name = "kilepesButton";
            this.kilepesButton.Size = new System.Drawing.Size(140, 34);
            this.kilepesButton.TabIndex = 11;
            this.kilepesButton.Text = "Kilepes";
            this.kilepesButton.UseVisualStyleBackColor = true;
            this.kilepesButton.Click += new System.EventHandler(this.kilepesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 275);
            this.Controls.Add(this.kilepesButton);
            this.Controls.Add(this.szamolButton);
            this.Controls.Add(this.megjelenitButton);
            this.Controls.Add(this.feltoltButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.AdatokLista);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button megjelenitButton;
        private System.Windows.Forms.Button kilepesButton;

        private System.Windows.Forms.Button feltoltButton;
        private System.Windows.Forms.Button szamolButton;

        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avgBox;

        private System.Windows.Forms.ListBox AdatokLista;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}