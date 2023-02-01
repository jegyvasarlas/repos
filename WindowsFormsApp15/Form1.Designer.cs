namespace WindowsFormsApp15
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
            this.statisztika = new System.Windows.Forms.GroupBox();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.atlag = new System.Windows.Forms.Label();
            this.darab = new System.Windows.Forms.Label();
            this.statisztika.SuspendLayout();
            this.SuspendLayout();
            // 
            // statisztika
            // 
            this.statisztika.Controls.Add(this.max);
            this.statisztika.Controls.Add(this.min);
            this.statisztika.Controls.Add(this.atlag);
            this.statisztika.Controls.Add(this.darab);
            this.statisztika.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisztika.Location = new System.Drawing.Point(13, 14);
            this.statisztika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statisztika.Name = "statisztika";
            this.statisztika.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statisztika.Size = new System.Drawing.Size(163, 154);
            this.statisztika.TabIndex = 0;
            this.statisztika.TabStop = false;
            this.statisztika.Text = "Statisztika";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(7, 99);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(0, 21);
            this.max.TabIndex = 3;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(7, 78);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(0, 21);
            this.min.TabIndex = 2;
            // 
            // atlag
            // 
            this.atlag.AutoSize = true;
            this.atlag.Location = new System.Drawing.Point(7, 57);
            this.atlag.Name = "atlag";
            this.atlag.Size = new System.Drawing.Size(0, 21);
            this.atlag.TabIndex = 1;
            // 
            // darab
            // 
            this.darab.AutoSize = true;
            this.darab.Location = new System.Drawing.Point(7, 36);
            this.darab.Name = "darab";
            this.darab.Size = new System.Drawing.Size(0, 21);
            this.darab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.Controls.Add(this.statisztika);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.statisztika.ResumeLayout(false);
            this.statisztika.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label darab;
        private System.Windows.Forms.Label atlag;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;

        private System.Windows.Forms.GroupBox statisztika;

        #endregion
    }
}