namespace Formula1
{
    partial class AtigazoltVersenyzok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csapat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rajtszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belepes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "2022-ben atigazolt versenyzok";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Csapat,
            this.Rajtszam,
            this.Belepes});
            this.dataGridView1.Location = new System.Drawing.Point(17, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(686, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Nev";
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Csapat
            // 
            this.Csapat.HeaderText = "Csapat";
            this.Csapat.Name = "Csapat";
            this.Csapat.ReadOnly = true;
            // 
            // Rajtszam
            // 
            this.Rajtszam.HeaderText = "Rajtszam";
            this.Rajtszam.Name = "Rajtszam";
            this.Rajtszam.ReadOnly = true;
            // 
            // Belepes
            // 
            this.Belepes.HeaderText = "Belepes";
            this.Belepes.Name = "Belepes";
            this.Belepes.ReadOnly = true;
            // 
            // AtigazoltVersenyzok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AtigazoltVersenyzok";
            this.Size = new System.Drawing.Size(725, 503);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rajtszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belepes;
    }
}
