﻿namespace CircumBenF
{
    partial class frmCircum
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
            this.lblEnterRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterRadius
            // 
            this.lblEnterRadius.AutoSize = true;
            this.lblEnterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterRadius.Location = new System.Drawing.Point(172, 75);
            this.lblEnterRadius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterRadius.Name = "lblEnterRadius";
            this.lblEnterRadius.Size = new System.Drawing.Size(215, 26);
            this.lblEnterRadius.TabIndex = 0;
            this.lblEnterRadius.Text = "Enter the radius (cm)";
            this.lblEnterRadius.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(398, 83);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(76, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(208, 147);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(223, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate the radius";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(123, 253);
            this.lblCircumference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(437, 24);
            this.lblCircumference.TabIndex = 3;
            this.lblCircumference.Text = "This is where the circumference value will show up";
            // 
            // frmCircum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 396);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblEnterRadius);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCircum";
            this.Text = "Circumference Ben F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCircumference;
    }
}

