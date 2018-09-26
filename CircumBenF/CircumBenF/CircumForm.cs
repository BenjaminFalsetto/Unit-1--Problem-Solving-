using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumBenF
{
    public partial class frmCircum : Form
    {
        public frmCircum()
        {
            InitializeComponent();
            this.lblCircumference.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare the local variables
            double radius, circumference;

            //convert the string from the text box to a double
            radius = double.Parse(txtRadius.Text);

            //calculate the circumference
            circumference = 2 * Math.PI * Math.Pow(radius, 2);

            //insert the circumference into it's label
            lblCircumference.Text = Convert.ToString(circumference) + " cm";

            //display the answer when the button is clicked
            this.lblCircumference.Show();
        }
    }
}
