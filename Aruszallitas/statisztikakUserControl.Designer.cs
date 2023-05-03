namespace Aruszallitas
{
    partial class statisztikakUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.legtobbUtatMegtettFutarok = new System.Windows.Forms.ListBox();
            this.legkevesebbUtatMegtettFutarok = new System.Windows.Forms.ListBox();
            this.innenNemIndultMegFutar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legtöbb utat megtett futár(ok):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(375, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legkevesebb utat megtett futár(ok):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Innen nem indult még futár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(375, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Még nem teljesített utak száma:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.number.Location = new System.Drawing.Point(409, 293);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(68, 25);
            this.number.TabIndex = 4;
            this.number.Text = "(szám)";
            // 
            // legtobbUtatMegtettFutarok
            // 
            this.legtobbUtatMegtettFutarok.FormattingEnabled = true;
            this.legtobbUtatMegtettFutarok.ItemHeight = 21;
            this.legtobbUtatMegtettFutarok.Location = new System.Drawing.Point(44, 109);
            this.legtobbUtatMegtettFutarok.Name = "legtobbUtatMegtettFutarok";
            this.legtobbUtatMegtettFutarok.Size = new System.Drawing.Size(255, 130);
            this.legtobbUtatMegtettFutarok.TabIndex = 5;
            // 
            // legkevesebbUtatMegtettFutarok
            // 
            this.legkevesebbUtatMegtettFutarok.FormattingEnabled = true;
            this.legkevesebbUtatMegtettFutarok.ItemHeight = 21;
            this.legkevesebbUtatMegtettFutarok.Location = new System.Drawing.Point(380, 109);
            this.legkevesebbUtatMegtettFutarok.Name = "legkevesebbUtatMegtettFutarok";
            this.legkevesebbUtatMegtettFutarok.Size = new System.Drawing.Size(255, 130);
            this.legkevesebbUtatMegtettFutarok.TabIndex = 6;
            // 
            // innenNemIndultMegFutar
            // 
            this.innenNemIndultMegFutar.FormattingEnabled = true;
            this.innenNemIndultMegFutar.ItemHeight = 21;
            this.innenNemIndultMegFutar.Location = new System.Drawing.Point(44, 293);
            this.innenNemIndultMegFutar.Name = "innenNemIndultMegFutar";
            this.innenNemIndultMegFutar.Size = new System.Drawing.Size(255, 130);
            this.innenNemIndultMegFutar.TabIndex = 7;
            // 
            // statisztikakUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.innenNemIndultMegFutar);
            this.Controls.Add(this.legkevesebbUtatMegtettFutarok);
            this.Controls.Add(this.legtobbUtatMegtettFutarok);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "statisztikakUserControl";
            this.Size = new System.Drawing.Size(787, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.ListBox legtobbUtatMegtettFutarok;
        private System.Windows.Forms.ListBox legkevesebbUtatMegtettFutarok;
        private System.Windows.Forms.ListBox innenNemIndultMegFutar;
    }
}
