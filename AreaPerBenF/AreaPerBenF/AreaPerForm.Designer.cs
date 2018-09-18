namespace AreaPerBenF
{
    partial class frmAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerAns = new System.Windows.Forms.Label();
            this.lblAreaAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(92, 121);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(135, 29);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(259, 129);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 1;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(92, 256);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(123, 29);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width (m)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(259, 264);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(373, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblPerAns
            // 
            this.lblPerAns.AutoSize = true;
            this.lblPerAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerAns.Location = new System.Drawing.Point(90, 332);
            this.lblPerAns.Name = "lblPerAns";
            this.lblPerAns.Size = new System.Drawing.Size(287, 39);
            this.lblPerAns.TabIndex = 5;
            this.lblPerAns.Text = "Answer Perimeter";
            // 
            // lblAreaAns
            // 
            this.lblAreaAns.AutoSize = true;
            this.lblAreaAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAns.Location = new System.Drawing.Point(90, 407);
            this.lblAreaAns.Name = "lblAreaAns";
            this.lblAreaAns.Size = new System.Drawing.Size(212, 39);
            this.lblAreaAns.TabIndex = 6;
            this.lblAreaAns.Text = "Answer Area";
            // 
            // frmAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 490);
            this.Controls.Add(this.lblAreaAns);
            this.Controls.Add(this.lblPerAns);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAreaPer";
            this.Text = "Area Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerAns;
        private System.Windows.Forms.Label lblAreaAns;
    }
}

