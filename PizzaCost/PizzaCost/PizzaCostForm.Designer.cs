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
            this.lblNumPizzas = new System.Windows.Forms.Label();
            this.btnCalCost = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.nudNumPizza = new System.Windows.Forms.NumericUpDown();
            this.lblHst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(38, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(549, 25);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "What diameter would you like your pizza(s) to have? (in)";
            // 
            // lblNumPizzas
            // 
            this.lblNumPizzas.AutoSize = true;
            this.lblNumPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPizzas.Location = new System.Drawing.Point(38, 138);
            this.lblNumPizzas.Name = "lblNumPizzas";
            this.lblNumPizzas.Size = new System.Drawing.Size(334, 25);
            this.lblNumPizzas.TabIndex = 2;
            this.lblNumPizzas.Text = "How many pizzas would you like?";
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
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(38, 310);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(322, 24);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "This is where the subtotal will appear.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(38, 379);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(291, 24);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "This is where the total will appear.";
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(593, 58);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 20);
            this.nudDiameter.TabIndex = 7;
            this.nudDiameter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNumPizza
            // 
            this.nudNumPizza.Location = new System.Drawing.Point(593, 145);
            this.nudNumPizza.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudNumPizza.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudNumPizza.Name = "nudNumPizza";
            this.nudNumPizza.Size = new System.Drawing.Size(120, 20);
            this.nudNumPizza.TabIndex = 8;
            this.nudNumPizza.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblHst
            // 
            this.lblHst.AutoSize = true;
            this.lblHst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblHst.Location = new System.Drawing.Point(38, 344);
            this.lblHst.Name = "lblHst";
            this.lblHst.Size = new System.Drawing.Size(291, 24);
            this.lblHst.TabIndex = 9;
            this.lblHst.Text = "This is where the HST will appear";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHst);
            this.Controls.Add(this.nudNumPizza);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalCost);
            this.Controls.Add(this.lblNumPizzas);
            this.Controls.Add(this.lblSize);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost Benjamin Falsetto";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblNumPizzas;
        private System.Windows.Forms.Button btnCalCost;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.NumericUpDown nudNumPizza;
        private System.Windows.Forms.Label lblHst;
    }
}

