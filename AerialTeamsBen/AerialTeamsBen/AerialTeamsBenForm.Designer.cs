namespace AerialTeamsBen
{
    partial class frmAerialTeamsBen
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
            this.mnuCountries = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCountries = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCanada = new System.Windows.Forms.ToolStripMenuItem();
            this.mniItaly = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnitedStates = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSnowbirds = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFreeceTricolori = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBlueAngels = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAerobicTeams = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mnuCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCountries
            // 
            this.mnuCountries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCountries,
            this.teamsToolStripMenuItem});
            this.mnuCountries.Location = new System.Drawing.Point(0, 0);
            this.mnuCountries.Name = "mnuCountries";
            this.mnuCountries.Size = new System.Drawing.Size(1214, 24);
            this.mnuCountries.TabIndex = 0;
            this.mnuCountries.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHome,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniHome
            // 
            this.mniHome.Name = "mniHome";
            this.mniHome.Size = new System.Drawing.Size(107, 22);
            this.mniHome.Text = "Home";
            this.mniHome.Click += new System.EventHandler(this.mniHome_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(107, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniCountries
            // 
            this.mniCountries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCanada,
            this.mniItaly,
            this.mniUnitedStates});
            this.mniCountries.Name = "mniCountries";
            this.mniCountries.Size = new System.Drawing.Size(70, 20);
            this.mniCountries.Text = "Countries";
            // 
            // mniCanada
            // 
            this.mniCanada.Name = "mniCanada";
            this.mniCanada.Size = new System.Drawing.Size(143, 22);
            this.mniCanada.Text = "Canada";
            this.mniCanada.Click += new System.EventHandler(this.mniCanada_Click);
            // 
            // mniItaly
            // 
            this.mniItaly.Name = "mniItaly";
            this.mniItaly.Size = new System.Drawing.Size(143, 22);
            this.mniItaly.Text = "Italy";
            this.mniItaly.Click += new System.EventHandler(this.mniItaly_Click);
            // 
            // mniUnitedStates
            // 
            this.mniUnitedStates.Name = "mniUnitedStates";
            this.mniUnitedStates.Size = new System.Drawing.Size(143, 22);
            this.mniUnitedStates.Text = "United States";
            this.mniUnitedStates.Click += new System.EventHandler(this.mniUnitedStates_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSnowbirds,
            this.mniFreeceTricolori,
            this.mniBlueAngels});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // mniSnowbirds
            // 
            this.mniSnowbirds.Name = "mniSnowbirds";
            this.mniSnowbirds.Size = new System.Drawing.Size(154, 22);
            this.mniSnowbirds.Text = "Snowbirds";
            this.mniSnowbirds.Click += new System.EventHandler(this.mniSnowbirds_Click);
            // 
            // mniFreeceTricolori
            // 
            this.mniFreeceTricolori.Name = "mniFreeceTricolori";
            this.mniFreeceTricolori.Size = new System.Drawing.Size(154, 22);
            this.mniFreeceTricolori.Text = "Frecce Tricolori";
            this.mniFreeceTricolori.Click += new System.EventHandler(this.mniFrecceTricolori_Click);
            // 
            // mniBlueAngels
            // 
            this.mniBlueAngels.Name = "mniBlueAngels";
            this.mniBlueAngels.Size = new System.Drawing.Size(154, 22);
            this.mniBlueAngels.Text = "Blue Angels";
            this.mniBlueAngels.Click += new System.EventHandler(this.mniBlueAngels_Click);
            // 
            // lblAerobicTeams
            // 
            this.lblAerobicTeams.AutoSize = true;
            this.lblAerobicTeams.Font = new System.Drawing.Font("Poplar Std", 60F, System.Drawing.FontStyle.Bold);
            this.lblAerobicTeams.ForeColor = System.Drawing.Color.Red;
            this.lblAerobicTeams.Location = new System.Drawing.Point(198, 106);
            this.lblAerobicTeams.Name = "lblAerobicTeams";
            this.lblAerobicTeams.Size = new System.Drawing.Size(841, 95);
            this.lblAerobicTeams.TabIndex = 1;
            this.lblAerobicTeams.Text = "Aerial Aerobic Teams by Country";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(542, 324);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // frmAerialTeamsBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1214, 668);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblAerobicTeams);
            this.Controls.Add(this.mnuCountries);
            this.MainMenuStrip = this.mnuCountries;
            this.Name = "frmAerialTeamsBen";
            this.Text = "Aerial Aerobic Teams by Country Ben";
            this.mnuCountries.ResumeLayout(false);
            this.mnuCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCountries;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniHome;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCountries;
        private System.Windows.Forms.ToolStripMenuItem mniCanada;
        private System.Windows.Forms.ToolStripMenuItem mniItaly;
        private System.Windows.Forms.ToolStripMenuItem mniUnitedStates;
        private System.Windows.Forms.Label lblAerobicTeams;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniSnowbirds;
        private System.Windows.Forms.ToolStripMenuItem mniFreeceTricolori;
        private System.Windows.Forms.ToolStripMenuItem mniBlueAngels;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

