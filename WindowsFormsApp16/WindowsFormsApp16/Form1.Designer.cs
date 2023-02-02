namespace WindowsFormsApp16
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
            this.halmaz1 = new WindowsFormsApp16.Halmaz();
            this.halmaz2 = new WindowsFormsApp16.Halmaz();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Eredmeny = new WindowsFormsApp16.Halmaz();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // halmaz1
            // 
            this.halmaz1.Editable = false;
            this.halmaz1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halmaz1.Location = new System.Drawing.Point(13, 14);
            this.halmaz1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.halmaz1.Name = "halmaz1";
            this.halmaz1.Size = new System.Drawing.Size(246, 550);
            this.halmaz1.TabIndex = 0;
            // 
            // halmaz2
            // 
            this.halmaz2.Editable = false;
            this.halmaz2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halmaz2.Location = new System.Drawing.Point(267, 14);
            this.halmaz2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.halmaz2.Name = "halmaz2";
            this.halmaz2.Size = new System.Drawing.Size(246, 557);
            this.halmaz2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // Eredmeny
            // 
            this.Eredmeny.Editable = false;
            this.Eredmeny.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eredmeny.Location = new System.Drawing.Point(580, 14);
            this.Eredmeny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.Size = new System.Drawing.Size(246, 511);
            this.Eredmeny.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eredmeny";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "A u B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UnioClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "A n B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Metszet);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "A - B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AminuszB);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "B - A";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BminuszA);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 546);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.halmaz2);
            this.Controls.Add(this.halmaz1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label3;

        private WindowsFormsApp16.Halmaz Eredmeny;

        private System.Windows.Forms.Label label2;

        private WindowsFormsApp16.Halmaz halmaz2;
        private System.Windows.Forms.Label label1;

        private WindowsFormsApp16.Halmaz halmaz1;

        #endregion
    }
}