namespace Furmula1
{
    partial class AtigazoltVersenyzokForm
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
            this.eredmeny = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eredmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // eredmeny
            // 
            this.eredmeny.AllowUserToAddRows = false;
            this.eredmeny.AllowUserToDeleteRows = false;
            this.eredmeny.AllowUserToResizeColumns = false;
            this.eredmeny.AllowUserToResizeRows = false;
            this.eredmeny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eredmeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eredmeny.Location = new System.Drawing.Point(0, 0);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.ReadOnly = true;
            this.eredmeny.Size = new System.Drawing.Size(814, 453);
            this.eredmeny.TabIndex = 0;
            // 
            // AtigazoltVersenyzokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.eredmeny);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AtigazoltVersenyzokForm";
            this.Text = "Átigazolt versenyzők";
            this.Load += new System.EventHandler(this.AtigazoltVersenyzokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eredmeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eredmeny;
    }
}