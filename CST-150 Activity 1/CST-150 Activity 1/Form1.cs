/*
 * Kevvan D. Young
 * CST-150
 * T1 Activity 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 26). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {   /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Hide the Weight on Mars labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        // lbs label at the top 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // lbs label at the top 
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click Event for Convert Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            // Declare and Initialize 
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.8M;
            decimal graveAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * graveAccMars;

            // Display the results
            // Use string.format to format the sring and show only 2 decimal places
            // This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true; 
        }

        // label that converts to mars weight in lbs
        private void lblMarsWeight_Click(object sender, EventArgs e)
        {

        }

        // Your weight on Mars label
        private void lblMars_Click(object sender, EventArgs e)
        {

        }

        // input Text box
        private void txtEarthWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 