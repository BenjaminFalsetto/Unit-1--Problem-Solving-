/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/10/02
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pizza Cost
 * This program takes a size input and a number of pizzas input from numeric updown boxes and then
 * gives subtotal, hst, and total
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

namespace PizzaCost
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            this.lblSubtotal.Hide();
            this.lblHst.Hide();
            this.lblTotal.Hide();
        }

        private void btnCalCost_Click(object sender, EventArgs e)
        {
            //declare local variables
            double size, numPizzas, subTotal, total, hst;

            //declare constants
            const double RENT = 0.99, LABOURCOST = 0.75, HST = 1.13;

            //assign each variable it's value
            size = (double)(nudDiameter.Value);
            numPizzas = (double)(nudNumPizza.Value);

            //calculate and display the subtotal the subtotal label
            subTotal = (numPizzas * RENT) + (numPizzas * LABOURCOST) + (0.5 * size);
            this.lblSubtotal.Text = String.Format("Your subtotal is ${0:0.00}", subTotal);
            this.lblSubtotal.Show();

            //calculate the tax and display it in it's label
            hst = subTotal * 0.13;
            lblHst.Text = String.Format("Tax is ${0:0.00}", hst);
            this.lblHst.Show();

            //calculate and display the total the total label
            total = HST * subTotal;
            this.lblTotal.Text = String.Format("Your total is ${0:0.00}", total);
            this.lblTotal.Show();
        }
    }
}
