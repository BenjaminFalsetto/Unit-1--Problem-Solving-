namespace MovingCatBenF
{
    partial class frmMovingCat
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
            this.mnuMovingCat = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCats = new System.Windows.Forms.PictureBox();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovingCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMovingCat
            // 
            this.mnuMovingCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuMovingCat.Location = new System.Drawing.Point(0, 0);
            this.mnuMovingCat.Name = "mnuMovingCat";
            this.mnuMovingCat.Size = new System.Drawing.Size(531, 24);
            this.mnuMovingCat.TabIndex = 1;
            this.mnuMovingCat.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat 1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat 2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // picCats
            // 
            this.picCats.Image = global::MovingCatBenF.Properties.Resources.cat1;
            this.picCats.Location = new System.Drawing.Point(203, 100);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(107, 124);
            this.picCats.TabIndex = 0;
            this.picCats.TabStop = false;
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 400);
            this.Controls.Add(this.picCats);
            this.Controls.Add(this.mnuMovingCat);
            this.MainMenuStrip = this.mnuMovingCat;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat Ben F";
            this.mnuMovingCat.ResumeLayout(false);
            this.mnuMovingCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCats;
        private System.Windows.Forms.MenuStrip mnuMovingCat;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

