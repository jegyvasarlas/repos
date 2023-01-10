namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.szam = new System.Windows.Forms.Label();
            this.novel = new System.Windows.Forms.Button();
            this.csokkent = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.oszt = new System.Windows.Forms.Button();
            this.szoroz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, World!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 234);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(219, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 234);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(223, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nyomj meg!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GombNyomas);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(23, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 117);
            this.label6.TabIndex = 5;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(76, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 117);
            this.label7.TabIndex = 6;
            this.label7.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 89);
            this.button2.TabIndex = 7;
            this.button2.Text = "Label feliratok megvaltoztatasa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LabelNevek);
            // 
            // szam
            // 
            this.szam.AutoSize = true;
            this.szam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szam.Location = new System.Drawing.Point(211, 701);
            this.szam.Name = "szam";
            this.szam.Size = new System.Drawing.Size(41, 43);
            this.szam.TabIndex = 8;
            this.szam.Text = "0";
            this.szam.Click += new System.EventHandler(this.szam_Click);
            // 
            // novel
            // 
            this.novel.Location = new System.Drawing.Point(443, 701);
            this.novel.Name = "novel";
            this.novel.Size = new System.Drawing.Size(87, 43);
            this.novel.TabIndex = 9;
            this.novel.Text = "Novel";
            this.novel.UseVisualStyleBackColor = true;
            this.novel.Click += new System.EventHandler(this.novel_Click);
            // 
            // csokkent
            // 
            this.csokkent.Location = new System.Drawing.Point(12, 701);
            this.csokkent.Name = "csokkent";
            this.csokkent.Size = new System.Drawing.Size(105, 43);
            this.csokkent.TabIndex = 10;
            this.csokkent.Text = "Csokkent";
            this.csokkent.UseVisualStyleBackColor = true;
            this.csokkent.Click += new System.EventHandler(this.csokkent_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(16, 764);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(101, 37);
            this.reset.TabIndex = 11;
            this.reset.Text = "Nullazas";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // oszt
            // 
            this.oszt.Location = new System.Drawing.Point(123, 764);
            this.oszt.Name = "oszt";
            this.oszt.Size = new System.Drawing.Size(118, 37);
            this.oszt.TabIndex = 12;
            this.oszt.Text = "2-vel oszt";
            this.oszt.UseVisualStyleBackColor = true;
            this.oszt.Click += new System.EventHandler(this.oszt_Click);
            // 
            // szoroz
            // 
            this.szoroz.Location = new System.Drawing.Point(247, 764);
            this.szoroz.Name = "szoroz";
            this.szoroz.Size = new System.Drawing.Size(140, 37);
            this.szoroz.TabIndex = 13;
            this.szoroz.Text = "2-vel szoroz";
            this.szoroz.UseVisualStyleBackColor = true;
            this.szoroz.Click += new System.EventHandler(this.szoroz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 825);
            this.Controls.Add(this.szoroz);
            this.Controls.Add(this.oszt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.csokkent);
            this.Controls.Add(this.novel);
            this.Controls.Add(this.szam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Az elso formom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label szam;
        private System.Windows.Forms.Button novel;
        private System.Windows.Forms.Button csokkent;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button oszt;
        private System.Windows.Forms.Button szoroz;
    }
}

