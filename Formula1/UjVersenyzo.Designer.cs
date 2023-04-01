namespace Formula1
{
    partial class UjVersenyzo
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
            this.label1 = new System.Windows.Forms.Label();
            this.nevInput = new System.Windows.Forms.TextBox();
            this.rajtszamInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nemzetisegInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.csapatInput = new System.Windows.Forms.ComboBox();
            this.ujoncInput = new System.Windows.Forms.CheckBox();
            this.belepesInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.felvetel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.siker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rajtszamInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versenyzo neve:";
            // 
            // nevInput
            // 
            this.nevInput.Location = new System.Drawing.Point(147, 122);
            this.nevInput.Name = "nevInput";
            this.nevInput.Size = new System.Drawing.Size(256, 29);
            this.nevInput.TabIndex = 1;
            // 
            // rajtszamInput
            // 
            this.rajtszamInput.Location = new System.Drawing.Point(147, 163);
            this.rajtszamInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rajtszamInput.Name = "rajtszamInput";
            this.rajtszamInput.Size = new System.Drawing.Size(122, 29);
            this.rajtszamInput.TabIndex = 2;
            this.rajtszamInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rajtszamInput.ValueChanged += new System.EventHandler(this.rajtszamInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rajtszam:";
            // 
            // nemzetisegInput
            // 
            this.nemzetisegInput.Location = new System.Drawing.Point(147, 204);
            this.nemzetisegInput.Name = "nemzetisegInput";
            this.nemzetisegInput.Size = new System.Drawing.Size(256, 29);
            this.nemzetisegInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nemzetiseg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Csapat:";
            // 
            // csapatInput
            // 
            this.csapatInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csapatInput.FormattingEnabled = true;
            this.csapatInput.Location = new System.Drawing.Point(147, 242);
            this.csapatInput.Name = "csapatInput";
            this.csapatInput.Size = new System.Drawing.Size(256, 29);
            this.csapatInput.TabIndex = 7;
            // 
            // ujoncInput
            // 
            this.ujoncInput.AutoSize = true;
            this.ujoncInput.Location = new System.Drawing.Point(147, 290);
            this.ujoncInput.Name = "ujoncInput";
            this.ujoncInput.Size = new System.Drawing.Size(69, 25);
            this.ujoncInput.TabIndex = 8;
            this.ujoncInput.Text = "Ujonc";
            this.ujoncInput.UseVisualStyleBackColor = true;
            // 
            // belepesInput
            // 
            this.belepesInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.belepesInput.Location = new System.Drawing.Point(147, 327);
            this.belepesInput.Name = "belepesInput";
            this.belepesInput.Size = new System.Drawing.Size(256, 29);
            this.belepesInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Belepes datuma:";
            // 
            // felvetel
            // 
            this.felvetel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felvetel.Location = new System.Drawing.Point(83, 374);
            this.felvetel.Name = "felvetel";
            this.felvetel.Size = new System.Drawing.Size(290, 53);
            this.felvetel.TabIndex = 11;
            this.felvetel.Text = "Felvetel";
            this.felvetel.UseVisualStyleBackColor = true;
            this.felvetel.Click += new System.EventHandler(this.felvetel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(958, 58);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uj versenyzo felvetele";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siker
            // 
            this.siker.AutoSize = true;
            this.siker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siker.Location = new System.Drawing.Point(91, 453);
            this.siker.Name = "siker";
            this.siker.Size = new System.Drawing.Size(0, 32);
            this.siker.TabIndex = 13;
            // 
            // UjVersenyzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.felvetel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.belepesInput);
            this.Controls.Add(this.ujoncInput);
            this.Controls.Add(this.csapatInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nemzetisegInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rajtszamInput);
            this.Controls.Add(this.nevInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UjVersenyzo";
            this.Size = new System.Drawing.Size(958, 663);
            this.Load += new System.EventHandler(this.UjVersenyzo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rajtszamInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevInput;
        private System.Windows.Forms.NumericUpDown rajtszamInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nemzetisegInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox csapatInput;
        private System.Windows.Forms.CheckBox ujoncInput;
        private System.Windows.Forms.DateTimePicker belepesInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button felvetel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label siker;
    }
}
