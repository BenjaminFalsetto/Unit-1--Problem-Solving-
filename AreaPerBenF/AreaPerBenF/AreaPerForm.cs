/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/08
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - AreaPerBenF
 * This program displays the area and perimeter of a rectangle when the user inputs the width and length values
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

namespace AreaPerBenF
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();
            this.lblAreaAns.Hide();
            this.lblPerAns.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double length, width, area, perimeter;

            //convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtLength.Text);

            //calculate the area and the perimeter
            area = length * width;
            perimeter = 2 * length + 2 * width;

            /// This is a comment

            //insert the area and the perimeter into their respective labels
            this.lblPerAns.Text = Convert.ToString(perimeter) + " meters";
            this.lblAreaAns.Text = Convert.ToString(area) + " meters squared";

            //display the perimeter and the area labels with their respective answers
            this.lblPerAns.Show();
            this.lblAreaAns.Show();
        }

        private void lblPerAns_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
