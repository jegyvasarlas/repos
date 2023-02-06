namespace WindowsFormsApp17
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
            this.szorzotabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.joCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rosszCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szorzotabla)).BeginInit();
            this.SuspendLayout();
            // 
            // szorzotabla
            // 
            this.szorzotabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.szorzotabla.Location = new System.Drawing.Point(13, 14);
            this.szorzotabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szorzotabla.Name = "szorzotabla";
            this.szorzotabla.Size = new System.Drawing.Size(553, 526);
            this.szorzotabla.TabIndex = 0;
            this.szorzotabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.szorzotabla_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jo valaszok:";
            // 
            // joCount
            // 
            this.joCount.AutoSize = true;
            this.joCount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.joCount.Location = new System.Drawing.Point(12, 582);
            this.joCount.Name = "joCount";
            this.joCount.Size = new System.Drawing.Size(0, 37);
            this.joCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rossz valaszok:";
            // 
            // rosszCount
            // 
            this.rosszCount.AutoSize = true;
            this.rosszCount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosszCount.ForeColor = System.Drawing.Color.Red;
            this.rosszCount.Location = new System.Drawing.Point(12, 652);
            this.rosszCount.Name = "rosszCount";
            this.rosszCount.Size = new System.Drawing.Size(0, 37);
            this.rosszCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 698);
            this.Controls.Add(this.rosszCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szorzotabla);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szorzotabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView szorzotabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label joCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rosszCount;
    }
}

