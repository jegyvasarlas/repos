namespace kinai
{
    partial class Rendeles
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
            this.etelek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.darab = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.vevok = new System.Windows.Forms.ComboBox();
            this.leadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.darab)).BeginInit();
            this.SuspendLayout();
            // 
            // etelek
            // 
            this.etelek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etelek.FormattingEnabled = true;
            this.etelek.Location = new System.Drawing.Point(77, 84);
            this.etelek.Name = "etelek";
            this.etelek.Size = new System.Drawing.Size(351, 29);
            this.etelek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rendeles leadasa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Etel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Darab:";
            // 
            // darab
            // 
            this.darab.Location = new System.Drawing.Point(77, 133);
            this.darab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.darab.Name = "darab";
            this.darab.Size = new System.Drawing.Size(120, 29);
            this.darab.TabIndex = 4;
            this.darab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vevo:";
            // 
            // vevok
            // 
            this.vevok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vevok.FormattingEnabled = true;
            this.vevok.Location = new System.Drawing.Point(77, 177);
            this.vevok.Name = "vevok";
            this.vevok.Size = new System.Drawing.Size(173, 29);
            this.vevok.TabIndex = 6;
            // 
            // leadas
            // 
            this.leadas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadas.Location = new System.Drawing.Point(113, 228);
            this.leadas.Name = "leadas";
            this.leadas.Size = new System.Drawing.Size(245, 64);
            this.leadas.TabIndex = 7;
            this.leadas.Text = "Leadas";
            this.leadas.UseVisualStyleBackColor = true;
            this.leadas.Click += new System.EventHandler(this.leadas_Click);
            // 
            // Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 312);
            this.Controls.Add(this.leadas);
            this.Controls.Add(this.vevok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.darab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etelek);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Rendeles";
            this.Text = "Rendeles";
            this.Load += new System.EventHandler(this.Rendeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox etelek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown darab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vevok;
        private System.Windows.Forms.Button leadas;
    }
}