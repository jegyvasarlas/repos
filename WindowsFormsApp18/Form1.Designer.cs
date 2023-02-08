namespace WindowsFormsApp18
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.budapest = new System.Windows.Forms.RadioButton();
            this.hatvan = new System.Windows.Forms.RadioButton();
            this.szekesfehervar = new System.Windows.Forms.RadioButton();
            this.kecskemet = new System.Windows.Forms.RadioButton();
            this.nappaliTagozatosDiak = new System.Windows.Forms.CheckBox();
            this.nyugdijas = new System.Windows.Forms.CheckBox();
            this.torzsutasKartya = new System.Windows.Forms.CheckBox();
            this.kutya = new System.Windows.Forms.CheckBox();
            this.bicikli = new System.Windows.Forms.CheckBox();
            this.tulmeretesPoggyasz = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.osszeg = new System.Windows.Forms.Label();
            this.nyomtatas = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valasszon a lehetosegek kozul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hova szeretne utazni?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Milyen kedvezmenyekre jogosult?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Milyen egyeb szolgaltatast ker?";
            // 
            // budapest
            // 
            this.budapest.AutoSize = true;
            this.budapest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budapest.Location = new System.Drawing.Point(28, 116);
            this.budapest.Name = "budapest";
            this.budapest.Size = new System.Drawing.Size(83, 20);
            this.budapest.TabIndex = 4;
            this.budapest.Text = "Budapest";
            this.budapest.UseVisualStyleBackColor = true;
            this.budapest.CheckedChanged += new System.EventHandler(this.budapest_CheckedChanged);
            // 
            // hatvan
            // 
            this.hatvan.AutoSize = true;
            this.hatvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatvan.Location = new System.Drawing.Point(28, 142);
            this.hatvan.Name = "hatvan";
            this.hatvan.Size = new System.Drawing.Size(68, 20);
            this.hatvan.TabIndex = 5;
            this.hatvan.Text = "Hatvan";
            this.hatvan.UseVisualStyleBackColor = true;
            this.hatvan.CheckedChanged += new System.EventHandler(this.hatvan_CheckedChanged);
            // 
            // szekesfehervar
            // 
            this.szekesfehervar.AutoSize = true;
            this.szekesfehervar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szekesfehervar.Location = new System.Drawing.Point(28, 168);
            this.szekesfehervar.Name = "szekesfehervar";
            this.szekesfehervar.Size = new System.Drawing.Size(119, 20);
            this.szekesfehervar.TabIndex = 6;
            this.szekesfehervar.Text = "Szekesfehervar";
            this.szekesfehervar.UseVisualStyleBackColor = true;
            this.szekesfehervar.CheckedChanged += new System.EventHandler(this.szekesfehervar_CheckedChanged);
            // 
            // kecskemet
            // 
            this.kecskemet.AutoSize = true;
            this.kecskemet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecskemet.Location = new System.Drawing.Point(27, 194);
            this.kecskemet.Name = "kecskemet";
            this.kecskemet.Size = new System.Drawing.Size(92, 20);
            this.kecskemet.TabIndex = 7;
            this.kecskemet.Text = "Kecskemet";
            this.kecskemet.UseVisualStyleBackColor = true;
            this.kecskemet.CheckedChanged += new System.EventHandler(this.kecskemet_CheckedChanged);
            // 
            // nappaliTagozatosDiak
            // 
            this.nappaliTagozatosDiak.AutoSize = true;
            this.nappaliTagozatosDiak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappaliTagozatosDiak.Location = new System.Drawing.Point(223, 116);
            this.nappaliTagozatosDiak.Name = "nappaliTagozatosDiak";
            this.nappaliTagozatosDiak.Size = new System.Drawing.Size(165, 20);
            this.nappaliTagozatosDiak.TabIndex = 8;
            this.nappaliTagozatosDiak.Text = "Nappali tagozatos diak";
            this.nappaliTagozatosDiak.UseVisualStyleBackColor = true;
            this.nappaliTagozatosDiak.CheckedChanged += new System.EventHandler(this.nappaliTagozatosDiak_CheckedChanged);
            // 
            // nyugdijas
            // 
            this.nyugdijas.AutoSize = true;
            this.nyugdijas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyugdijas.Location = new System.Drawing.Point(223, 142);
            this.nyugdijas.Name = "nyugdijas";
            this.nyugdijas.Size = new System.Drawing.Size(87, 20);
            this.nyugdijas.TabIndex = 9;
            this.nyugdijas.Text = "Nyugdijas";
            this.nyugdijas.UseVisualStyleBackColor = true;
            this.nyugdijas.CheckedChanged += new System.EventHandler(this.nyugdijas_CheckedChanged);
            // 
            // torzsutasKartya
            // 
            this.torzsutasKartya.AutoSize = true;
            this.torzsutasKartya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torzsutasKartya.Location = new System.Drawing.Point(223, 168);
            this.torzsutasKartya.Name = "torzsutasKartya";
            this.torzsutasKartya.Size = new System.Drawing.Size(125, 20);
            this.torzsutasKartya.TabIndex = 10;
            this.torzsutasKartya.Text = "Torzsutas kartya";
            this.torzsutasKartya.UseVisualStyleBackColor = true;
            this.torzsutasKartya.CheckedChanged += new System.EventHandler(this.torzsutasKartya_CheckedChanged);
            // 
            // kutya
            // 
            this.kutya.AutoSize = true;
            this.kutya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kutya.Location = new System.Drawing.Point(504, 116);
            this.kutya.Name = "kutya";
            this.kutya.Size = new System.Drawing.Size(95, 20);
            this.kutya.TabIndex = 11;
            this.kutya.Text = "Kutyam van";
            this.kutya.UseVisualStyleBackColor = true;
            // 
            // bicikli
            // 
            this.bicikli.AutoSize = true;
            this.bicikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bicikli.Location = new System.Drawing.Point(504, 142);
            this.bicikli.Name = "bicikli";
            this.bicikli.Size = new System.Drawing.Size(97, 20);
            this.bicikli.TabIndex = 12;
            this.bicikli.Text = "Biciklim van";
            this.bicikli.UseVisualStyleBackColor = true;
            // 
            // tulmeretesPoggyasz
            // 
            this.tulmeretesPoggyasz.AutoSize = true;
            this.tulmeretesPoggyasz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulmeretesPoggyasz.Location = new System.Drawing.Point(504, 169);
            this.tulmeretesPoggyasz.Name = "tulmeretesPoggyasz";
            this.tulmeretesPoggyasz.Size = new System.Drawing.Size(201, 20);
            this.tulmeretesPoggyasz.TabIndex = 13;
            this.tulmeretesPoggyasz.Text = "Tulmeretes poggyaszom van";
            this.tulmeretesPoggyasz.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Osszkoltseg:";
            // 
            // osszeg
            // 
            this.osszeg.AutoSize = true;
            this.osszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osszeg.Location = new System.Drawing.Point(126, 252);
            this.osszeg.Name = "osszeg";
            this.osszeg.Size = new System.Drawing.Size(45, 24);
            this.osszeg.TabIndex = 15;
            this.osszeg.Text = "0 Ft";
            // 
            // nyomtatas
            // 
            this.nyomtatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyomtatas.Location = new System.Drawing.Point(65, 356);
            this.nyomtatas.Name = "nyomtatas";
            this.nyomtatas.Size = new System.Drawing.Size(265, 54);
            this.nyomtatas.TabIndex = 16;
            this.nyomtatas.Text = "Jegy nyomtatasa";
            this.nyomtatas.UseVisualStyleBackColor = true;
            // 
            // torles
            // 
            this.torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torles.Location = new System.Drawing.Point(422, 356);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(265, 54);
            this.torles.TabIndex = 17;
            this.torles.Text = "Torles";
            this.torles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.nyomtatas);
            this.Controls.Add(this.osszeg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tulmeretesPoggyasz);
            this.Controls.Add(this.bicikli);
            this.Controls.Add(this.kutya);
            this.Controls.Add(this.torzsutasKartya);
            this.Controls.Add(this.nyugdijas);
            this.Controls.Add(this.nappaliTagozatosDiak);
            this.Controls.Add(this.kecskemet);
            this.Controls.Add(this.szekesfehervar);
            this.Controls.Add(this.hatvan);
            this.Controls.Add(this.budapest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jegykiado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton budapest;
        private System.Windows.Forms.RadioButton hatvan;
        private System.Windows.Forms.RadioButton szekesfehervar;
        private System.Windows.Forms.RadioButton kecskemet;
        private System.Windows.Forms.CheckBox nappaliTagozatosDiak;
        private System.Windows.Forms.CheckBox nyugdijas;
        private System.Windows.Forms.CheckBox torzsutasKartya;
        private System.Windows.Forms.CheckBox kutya;
        private System.Windows.Forms.CheckBox bicikli;
        private System.Windows.Forms.CheckBox tulmeretesPoggyasz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label osszeg;
        private System.Windows.Forms.Button nyomtatas;
        private System.Windows.Forms.Button torles;
    }
}

