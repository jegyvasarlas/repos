namespace CsevegesGUI
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
            this.Kezdemenyezo = new System.Windows.Forms.ComboBox();
            this.Fogado = new System.Windows.Forms.ComboBox();
            this.Csevegesek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kezdemenyezo
            // 
            this.Kezdemenyezo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kezdemenyezo.FormattingEnabled = true;
            this.Kezdemenyezo.Location = new System.Drawing.Point(159, 28);
            this.Kezdemenyezo.Name = "Kezdemenyezo";
            this.Kezdemenyezo.Size = new System.Drawing.Size(293, 29);
            this.Kezdemenyezo.TabIndex = 0;
            this.Kezdemenyezo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Fogado
            // 
            this.Fogado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Fogado.FormattingEnabled = true;
            this.Fogado.Location = new System.Drawing.Point(159, 63);
            this.Fogado.Name = "Fogado";
            this.Fogado.Size = new System.Drawing.Size(293, 29);
            this.Fogado.TabIndex = 1;
            this.Fogado.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Csevegesek
            // 
            this.Csevegesek.FormattingEnabled = true;
            this.Csevegesek.ItemHeight = 21;
            this.Csevegesek.Location = new System.Drawing.Point(16, 155);
            this.Csevegesek.Name = "Csevegesek";
            this.Csevegesek.Size = new System.Drawing.Size(436, 445);
            this.Csevegesek.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kezdemenyezo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fogado (partner)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Csevegesek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Csevegesek);
            this.Controls.Add(this.Fogado);
            this.Controls.Add(this.Kezdemenyezo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cseveges GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Kezdemenyezo;
        private System.Windows.Forms.ComboBox Fogado;
        private System.Windows.Forms.ListBox Csevegesek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

