namespace WindowsFormsApp11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redScroll = new System.Windows.Forms.HScrollBar();
            this.greenScroll = new System.Windows.Forms.HScrollBar();
            this.blueScroll = new System.Windows.Forms.HScrollBar();
            this.Hatterszin = new System.Windows.Forms.Label();
            this.redNumeric = new System.Windows.Forms.NumericUpDown();
            this.greenNumeric = new System.Windows.Forms.NumericUpDown();
            this.blueNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.opacityScroll = new System.Windows.Forms.HScrollBar();
            this.opacityNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zold";
            // 
            // redScroll
            // 
            this.redScroll.LargeChange = 1;
            this.redScroll.Location = new System.Drawing.Point(146, 24);
            this.redScroll.Maximum = 255;
            this.redScroll.Name = "redScroll";
            this.redScroll.Size = new System.Drawing.Size(318, 36);
            this.redScroll.TabIndex = 3;
            this.redScroll.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // greenScroll
            // 
            this.greenScroll.LargeChange = 1;
            this.greenScroll.Location = new System.Drawing.Point(146, 60);
            this.greenScroll.Maximum = 255;
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.Size = new System.Drawing.Size(318, 36);
            this.greenScroll.TabIndex = 4;
            this.greenScroll.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // blueScroll
            // 
            this.blueScroll.LargeChange = 1;
            this.blueScroll.Location = new System.Drawing.Point(146, 96);
            this.blueScroll.Maximum = 255;
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.Size = new System.Drawing.Size(318, 36);
            this.blueScroll.TabIndex = 5;
            this.blueScroll.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // Hatterszin
            // 
            this.Hatterszin.BackColor = System.Drawing.SystemColors.ControlText;
            this.Hatterszin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Hatterszin.Location = new System.Drawing.Point(78, 193);
            this.Hatterszin.Name = "Hatterszin";
            this.Hatterszin.Size = new System.Drawing.Size(506, 91);
            this.Hatterszin.TabIndex = 6;
            // 
            // redNumeric
            // 
            this.redNumeric.Location = new System.Drawing.Point(527, 24);
            this.redNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumeric.Name = "redNumeric";
            this.redNumeric.Size = new System.Drawing.Size(120, 29);
            this.redNumeric.TabIndex = 7;
            this.redNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // greenNumeric
            // 
            this.greenNumeric.Location = new System.Drawing.Point(527, 60);
            this.greenNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumeric.Name = "greenNumeric";
            this.greenNumeric.Size = new System.Drawing.Size(120, 29);
            this.greenNumeric.TabIndex = 8;
            this.greenNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // blueNumeric
            // 
            this.blueNumeric.Location = new System.Drawing.Point(527, 96);
            this.blueNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumeric.Name = "blueNumeric";
            this.blueNumeric.Size = new System.Drawing.Size(120, 29);
            this.blueNumeric.TabIndex = 9;
            this.blueNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Atlatszosag";
            // 
            // opacityScroll
            // 
            this.opacityScroll.LargeChange = 1;
            this.opacityScroll.Location = new System.Drawing.Point(146, 132);
            this.opacityScroll.Maximum = 255;
            this.opacityScroll.Name = "opacityScroll";
            this.opacityScroll.Size = new System.Drawing.Size(318, 36);
            this.opacityScroll.TabIndex = 11;
            this.opacityScroll.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // opacityNumeric
            // 
            this.opacityNumeric.Location = new System.Drawing.Point(527, 132);
            this.opacityNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacityNumeric.Name = "opacityNumeric";
            this.opacityNumeric.Size = new System.Drawing.Size(120, 29);
            this.opacityNumeric.TabIndex = 12;
            this.opacityNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 316);
            this.Controls.Add(this.opacityNumeric);
            this.Controls.Add(this.opacityScroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blueNumeric);
            this.Controls.Add(this.greenNumeric);
            this.Controls.Add(this.redNumeric);
            this.Controls.Add(this.Hatterszin);
            this.Controls.Add(this.blueScroll);
            this.Controls.Add(this.greenScroll);
            this.Controls.Add(this.redScroll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Szinkevero";
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar redScroll;
        private System.Windows.Forms.HScrollBar greenScroll;
        private System.Windows.Forms.HScrollBar blueScroll;
        private System.Windows.Forms.Label Hatterszin;
        private System.Windows.Forms.NumericUpDown redNumeric;
        private System.Windows.Forms.NumericUpDown greenNumeric;
        private System.Windows.Forms.NumericUpDown blueNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar opacityScroll;
        private System.Windows.Forms.NumericUpDown opacityNumeric;
    }
}

