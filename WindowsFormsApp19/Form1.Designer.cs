namespace WindowsFormsApp19
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
            this.eleresiUt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rekurziv = new System.Windows.Forms.CheckBox();
            this.kereses = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eleresiUt
            // 
            this.eleresiUt.Location = new System.Drawing.Point(154, 9);
            this.eleresiUt.Name = "eleresiUt";
            this.eleresiUt.Size = new System.Drawing.Size(635, 29);
            this.eleresiUt.TabIndex = 0;
            this.eleresiUt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eleresiUt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eleresi ut + maszk";
            // 
            // rekurziv
            // 
            this.rekurziv.AutoSize = true;
            this.rekurziv.Location = new System.Drawing.Point(12, 53);
            this.rekurziv.Name = "rekurziv";
            this.rekurziv.Size = new System.Drawing.Size(145, 25);
            this.rekurziv.TabIndex = 2;
            this.rekurziv.Text = "Rekurziv kereses";
            this.rekurziv.UseVisualStyleBackColor = true;
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(603, 44);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(186, 40);
            this.kereses.TabIndex = 3;
            this.kereses.Text = "Kereses";
            this.kereses.UseVisualStyleBackColor = true;
            this.kereses.Click += new System.EventHandler(this.kereses_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(15, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(774, 174);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 284);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.rekurziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eleresiUt);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eleresiUt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rekurziv;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.ListBox listBox1;
    }
}

