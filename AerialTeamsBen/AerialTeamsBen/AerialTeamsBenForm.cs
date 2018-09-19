/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/14
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - AerialTeamsBen
 * This program changes the text on screen when a menu item is clicked
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
            //change the text to Canada  Snowbirds when mniCanada is clicked
            this.lblAerobicTeams.Text = "Canada\n\nSnowbirds";
        }

        private void mniItaly_Click(object sender, EventArgs e)
        {
            //change the text to Italia  Frecce  Tricolori when mniItaly is clicked
            this.lblAerobicTeams.Text = "Italia\n\nFrecce Tricolori";
        }

        private void mniUnitedStates_Click(object sender, EventArgs e)
        {
            //change the text to United States  Blue Angels when mniUnitedStates is clicked
            this.lblAerobicTeams.Text = "United States\n\nBlue Angels";
        }

        private void mniHome_Click(object sender, EventArgs e)
        {
            //change the tect to Aerial Aerobic Teams by Country when mniHome is clicked
            this.lblAerobicTeams.Text = "Aerial Aerobic Teams by Country";
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when mniExit is clicked
            this.Close();
        }

        private void mniSnowbirds_Click(object sender, EventArgs e)
        {
            //change the text to Canada  Snowbirds when mniSnowbirds is clicked
            this.lblAerobicTeams.Text = "Canada\n\nSnowbirds";
        }

        private void mniFrecceTricolori_Click(object sender, EventArgs e)
        {
            //change the text to Italia  Frecce  Tricolori when mniFrecceTricolori is clicked
            this.lblAerobicTeams.Text = "Italia\n\nFrecce Tricolori";
        }

        private void mniBlueAngels_Click(object sender, EventArgs e)
        {
            //change the text to United States  Blue Angels when mniBlueAngels is clicked
            this.lblAerobicTeams.Text = "United States\n\nBlue Angels";
        }
    }
}
