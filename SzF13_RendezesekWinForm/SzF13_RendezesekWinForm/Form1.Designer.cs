﻿
namespace SzF13_RendezesekWinForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GyorsIdo = new System.Windows.Forms.Label();
            this.BuborekIdo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tartomany = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.LadaIdo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tartomany)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(166, 32);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tömb elemszáma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Feltölt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gyors Rendezés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buborék Rendezés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GyorsIdo
            // 
            this.GyorsIdo.AutoSize = true;
            this.GyorsIdo.Location = new System.Drawing.Point(219, 160);
            this.GyorsIdo.Name = "GyorsIdo";
            this.GyorsIdo.Size = new System.Drawing.Size(0, 26);
            this.GyorsIdo.TabIndex = 5;
            // 
            // BuborekIdo
            // 
            this.BuborekIdo.AutoSize = true;
            this.BuborekIdo.Location = new System.Drawing.Point(219, 235);
            this.BuborekIdo.Name = "BuborekIdo";
            this.BuborekIdo.Size = new System.Drawing.Size(0, 26);
            this.BuborekIdo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tartomány";
            // 
            // Tartomany
            // 
            this.Tartomany.Location = new System.Drawing.Point(524, 30);
            this.Tartomany.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.Tartomany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Tartomany.Name = "Tartomany";
            this.Tartomany.Size = new System.Drawing.Size(166, 32);
            this.Tartomany.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "Láda Rendezés";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LadaIdo
            // 
            this.LadaIdo.AutoSize = true;
            this.LadaIdo.Location = new System.Drawing.Point(219, 309);
            this.LadaIdo.Name = "LadaIdo";
            this.LadaIdo.Size = new System.Drawing.Size(0, 26);
            this.LadaIdo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 413);
            this.Controls.Add(this.LadaIdo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Tartomany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuborekIdo);
            this.Controls.Add(this.GyorsIdo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tartomany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label GyorsIdo;
        private System.Windows.Forms.Label BuborekIdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Tartomany;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LadaIdo;
    }
}

