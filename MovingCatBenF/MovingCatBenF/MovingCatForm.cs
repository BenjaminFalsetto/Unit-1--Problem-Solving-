/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/17
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program changes the image displayed on screen when the menu items are clicked.
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

namespace MovingCatBenF
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //Changes the image to cat1
            this.picCats.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //changes the image to cat2
            this.picCats.Image = Properties.Resources.cat2;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
