namespace Furmula1
{
    partial class UjVersenyzoFelveteleForm
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
            this.csapat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ujonc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.nev = new System.Windows.Forms.TextBox();
            this.rajtszam = new System.Windows.Forms.TextBox();
            this.nemzetiseg = new System.Windows.Forms.TextBox();
            this.felvetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // csapat
            // 
            this.csapat.FormattingEnabled = true;
            this.csapat.Location = new System.Drawing.Point(92, 179);
            this.csapat.Name = "csapat";
            this.csapat.Size = new System.Drawing.Size(309, 29);
            this.csapat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Csapat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nemzetiség:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Újonc?";
            // 
            // ujonc
            // 
            this.ujonc.AutoSize = true;
            this.ujonc.Location = new System.Drawing.Point(73, 111);
            this.ujonc.Name = "ujonc";
            this.ujonc.Size = new System.Drawing.Size(15, 14);
            this.ujonc.TabIndex = 6;
            this.ujonc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Belépés dátuma:";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(141, 142);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(260, 29);
            this.datum.TabIndex = 8;
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(73, 6);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(328, 29);
            this.nev.TabIndex = 9;
            // 
            // rajtszam
            // 
            this.rajtszam.Location = new System.Drawing.Point(92, 41);
            this.rajtszam.Name = "rajtszam";
            this.rajtszam.Size = new System.Drawing.Size(83, 29);
            this.rajtszam.TabIndex = 10;
            // 
            // nemzetiseg
            // 
            this.nemzetiseg.Location = new System.Drawing.Point(113, 74);
            this.nemzetiseg.Name = "nemzetiseg";
            this.nemzetiseg.Size = new System.Drawing.Size(146, 29);
            this.nemzetiseg.TabIndex = 11;
            // 
            // felvetel
            // 
            this.felvetel.Location = new System.Drawing.Point(128, 225);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(176, 40);
            this.felvetel.TabIndex = 12;
            this.felvetel.Text = "Felvétel";
            this.felvetel.UseVisualStyleBackColor = true;
            // 
            // UjVersenyzoFelveteleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 277);
            this.Controls.Add(this.felvetel);
            this.Controls.Add(this.nemzetiseg);
            this.Controls.Add(this.rajtszam);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ujonc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csapat);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UjVersenyzoFelveteleForm";
            this.Text = "Új versenyző felvétele";
            this.Load += new System.EventHandler(this.UjVersenyzoFelveteleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox csapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ujonc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox rajtszam;
        private System.Windows.Forms.TextBox nemzetiseg;
        private System.Windows.Forms.Button felvetel;
    }
}