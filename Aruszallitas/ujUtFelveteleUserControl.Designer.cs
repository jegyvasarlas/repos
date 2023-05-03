namespace Aruszallitas
{
    partial class ujUtFelveteleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.futarok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.honnan = new System.Windows.Forms.ComboBox();
            this.hova = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.felvetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futarok
            // 
            this.futarok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.futarok.FormattingEnabled = true;
            this.futarok.Location = new System.Drawing.Point(260, 157);
            this.futarok.Name = "futarok";
            this.futarok.Size = new System.Drawing.Size(308, 29);
            this.futarok.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Futár:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(278, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új út felvétele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Honnan:";
            // 
            // honnan
            // 
            this.honnan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.honnan.FormattingEnabled = true;
            this.honnan.Location = new System.Drawing.Point(260, 192);
            this.honnan.Name = "honnan";
            this.honnan.Size = new System.Drawing.Size(308, 29);
            this.honnan.TabIndex = 7;
            // 
            // hova
            // 
            this.hova.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hova.FormattingEnabled = true;
            this.hova.Location = new System.Drawing.Point(260, 227);
            this.hova.Name = "hova";
            this.hova.Size = new System.Drawing.Size(308, 29);
            this.hova.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hova:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 29);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dátum:";
            // 
            // felvetel
            // 
            this.felvetel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felvetel.Location = new System.Drawing.Point(260, 328);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(308, 58);
            this.felvetel.TabIndex = 13;
            this.felvetel.Text = "Felvétel";
            this.felvetel.UseVisualStyleBackColor = true;
            this.felvetel.Click += new System.EventHandler(this.FelvetelClick);
            // 
            // ujUtFelveteleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.felvetel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hova);
            this.Controls.Add(this.honnan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.futarok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ujUtFelveteleUserControl";
            this.Size = new System.Drawing.Size(787, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox futarok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox honnan;
        private System.Windows.Forms.ComboBox hova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button felvetel;
    }
}
