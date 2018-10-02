using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCost
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
        }

        private void btnCalCost_Click(object sender, EventArgs e)
        {
            //declare local variables
            double size, numPizzas, subTotal, total, test;

            //declare constants
            const double RENT = 0.99, LABOURCOST = 0.75, HST = 1.13;

            //assign each variable it's value
            size = double.Parse(txtSize.Text);
            numPizzas = double.Parse(txtNumPizzas.Text);

            //calculate and display the subtotal the subtotal label
            subTotal = (numPizzas * RENT) + (numPizzas * LABOURCOST) + (0.5 * size);
            this.lblSubtotal.Text = Convert.ToString("Your subtotal is $" + subTotal);
            this.lblSubtotal.Show();

            //calculate and display the total the total label
            total = HST * subTotal;
            this.lblTotal.Text = Convert.ToString("Your total is: $" + total);
            this.lblTotal.Show();
        }
    }
}
