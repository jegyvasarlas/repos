namespace Mar24Feladatok
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
            this.feladatLabel = new System.Windows.Forms.Label();
            this.szin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feladatLabel
            // 
            this.feladatLabel.AutoSize = true;
            this.feladatLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feladatLabel.Location = new System.Drawing.Point(152, 9);
            this.feladatLabel.Name = "feladatLabel";
            this.feladatLabel.Size = new System.Drawing.Size(221, 65);
            this.feladatLabel.TabIndex = 6;
            this.feladatLabel.Text = "4. feladat";
            // 
            // szin
            // 
            this.szin.BackColor = System.Drawing.Color.Black;
            this.szin.Location = new System.Drawing.Point(159, 107);
            this.szin.Name = "szin";
            this.szin.Size = new System.Drawing.Size(200, 200);
            this.szin.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "Szin beallitasa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Beallitas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kivalasztott szin RGB kodja: Color.FromArgb(0, 0, 0);";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szin);
            this.Controls.Add(this.feladatLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "4. feladat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label feladatLabel;
        private System.Windows.Forms.Label szin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

