using System;

namespace WindowsFormsApp6
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.calculateButtonWithFor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.calculateButtonWithWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 40);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(126, 33);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // calculateButtonWithFor
            // 
            this.calculateButtonWithFor.Location = new System.Drawing.Point(12, 79);
            this.calculateButtonWithFor.Name = "calculateButtonWithFor";
            this.calculateButtonWithFor.Size = new System.Drawing.Size(182, 43);
            this.calculateButtonWithFor.TabIndex = 3;
            this.calculateButtonWithFor.Text = "For ciklussal";
            this.calculateButtonWithFor.UseVisualStyleBackColor = true;
            this.calculateButtonWithFor.Click += new System.EventHandler(this.CalculateButtonWithFor_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Faktorialis";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(144, 40);
            this.resultBox.MaxLength = 2147483647;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(397, 33);
            this.resultBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Faktorialis";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(430, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 43);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Torles";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // calculateButtonWithWhile
            // 
            this.calculateButtonWithWhile.Location = new System.Drawing.Point(200, 79);
            this.calculateButtonWithWhile.Name = "calculateButtonWithWhile";
            this.calculateButtonWithWhile.Size = new System.Drawing.Size(182, 43);
            this.calculateButtonWithWhile.TabIndex = 8;
            this.calculateButtonWithWhile.Text = "While ciklussal";
            this.calculateButtonWithWhile.UseVisualStyleBackColor = true;
            this.calculateButtonWithWhile.Click += new System.EventHandler(this.calculateButtonWithWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 134);
            this.Controls.Add(this.calculateButtonWithWhile);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButtonWithFor);
            this.Controls.Add(this.inputBox);
            this.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button calculateButtonWithWhile;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox resultBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button calculateButtonWithFor;

        private System.Windows.Forms.TextBox inputBox;

        #endregion
    }
}