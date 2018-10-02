namespace PizzaCost
{
    partial class frmPizzaCost
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
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblNumPizzas = new System.Windows.Forms.Label();
            this.txtNumPizzas = new System.Windows.Forms.TextBox();
            this.btnCalCost = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudTest = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(38, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(496, 24);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "What diameter would you like your pizza(s) to have? (in)";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(549, 56);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            // 
            // lblNumPizzas
            // 
            this.lblNumPizzas.AutoSize = true;
            this.lblNumPizzas.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPizzas.Location = new System.Drawing.Point(38, 138);
            this.lblNumPizzas.Name = "lblNumPizzas";
            this.lblNumPizzas.Size = new System.Drawing.Size(300, 24);
            this.lblNumPizzas.TabIndex = 2;
            this.lblNumPizzas.Text = "How many pizzas would you like?";
            // 
            // txtNumPizzas
            // 
            this.txtNumPizzas.Location = new System.Drawing.Point(549, 143);
            this.txtNumPizzas.Name = "txtNumPizzas";
            this.txtNumPizzas.Size = new System.Drawing.Size(100, 20);
            this.txtNumPizzas.TabIndex = 3;
            // 
            // btnCalCost
            // 
            this.btnCalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalCost.Location = new System.Drawing.Point(295, 241);
            this.btnCalCost.Name = "btnCalCost";
            this.btnCalCost.Size = new System.Drawing.Size(144, 28);
            this.btnCalCost.TabIndex = 4;
            this.btnCalCost.Text = "Calculate the cost";
            this.btnCalCost.UseVisualStyleBackColor = true;
            this.btnCalCost.Click += new System.EventHandler(this.btnCalCost_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(38, 310);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(307, 21);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "This is where the subtotal will appear.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(38, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(281, 21);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "This is where the total will appear.";
            // 
            // nudTest
            // 
            this.nudTest.Location = new System.Drawing.Point(583, 217);
            this.nudTest.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTest.Name = "nudTest";
            this.nudTest.Size = new System.Drawing.Size(120, 20);
            this.nudTest.TabIndex = 7;
            this.nudTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudTest);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalCost);
            this.Controls.Add(this.txtNumPizzas);
            this.Controls.Add(this.lblNumPizzas);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost Benjamin Falsetto";
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblNumPizzas;
        private System.Windows.Forms.TextBox txtNumPizzas;
        private System.Windows.Forms.Button btnCalCost;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudTest;
    }
}

