/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/14
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - AerialTeamsBen
 * This program...
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerialTeamsBen
{
    public partial class frmAerialTeamsBen : Form
    {
        public frmAerialTeamsBen()
        {
            InitializeComponent();
        }

        private void mniCanada_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Canada\n\nSnowbirds";
        }

        private void mniItaly_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Italia\n\nFrecce Tricolori";
        }

        private void mniUnitedStates_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "United States\n\nBlue Angels";
        }

        private void mniHome_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Aerial Aerobic Teams by Country";
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Why would you want to leave?\n\nThis is the best program ever!\n\nIf you're so desperate to leave,\n press alt + f4";
        }

        private void mniSnowbirds_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Canada\n\nSnowbirds";
        }

        private void mniFrecceTricolori_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "Italia\n\nFrecce Tricolori";
        }

        private void mniBlueAngels_Click(object sender, EventArgs e)
        {
            this.lblAerobicTeams.Text = "United States\n\nBlue Angels";
        }
    }
}
