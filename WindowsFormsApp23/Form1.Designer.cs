namespace WindowsFormsApp23
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ido = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.lepesszam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // Ido
            // 
            this.Ido.AutoSize = true;
            this.Ido.Location = new System.Drawing.Point(12, 538);
            this.Ido.Name = "Ido";
            this.Ido.Size = new System.Drawing.Size(32, 21);
            this.Ido.TabIndex = 1;
            this.Ido.Text = "Ido";
            // 
            // timer1
            // 
            this.timer1.Interval = 10D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lepesszam:";
            // 
            // lepesszam
            // 
            this.lepesszam.AutoSize = true;
            this.lepesszam.Location = new System.Drawing.Point(107, 570);
            this.lepesszam.Name = "lepesszam";
            this.lepesszam.Size = new System.Drawing.Size(19, 21);
            this.lepesszam.TabIndex = 3;
            this.lepesszam.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 611);
            this.Controls.Add(this.lepesszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ido);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tilitoli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label Ido;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lepesszam;
        private System.Windows.Forms.Label label1;
    }
}

