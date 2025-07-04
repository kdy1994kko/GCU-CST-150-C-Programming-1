/*
 * Kevvan D. Young
 * CST-150
 * T2 Activity 2
 * 6/2/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 236). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Activity_2
{
    public partial class FrmSeconds : Form 
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmSeconds()
        {
            InitializeComponent();
            // Make sure the label is not visible
            lblResults.Visible = false;
        }

        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // Declare and Initialize
            int seconds = 0; // Declare the value user entered in seconds
            // Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;

            // Make sure the label is not visible
            lblResults.Visible = false;
            // Default the color to black
            lblResults.ForeColor = Color.Black;
            // Test to determine in integer was entered correctly by user
            // if try to parse string to int is successful continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                // This block of code is where all our business logic will be placed.
                // In future classes we will put this code (business logic) in the business layer
                // Practice with nested if statements
                if (seconds >= SecondsInMinutes)
                {
                    // if we are here we know the user has entered a value that we can, at a minimum
                    // display how many minutes are in the seconds entered.
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds.\n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;

                    //-------------------------------------------------------------
                    // Now that we know there were minutes - test for hours
                    // using nested if statments
                    // Nested statments stop code from being exectuted if there is 
                    // no need.
                    //-------------------------------------------------------------
                    
                    if (seconds >= SecondsInHours)
                    {
                        // Display how many Hours are in the seconds entered.
                        lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);
                        
                        //-------------------------------------------------------------
                        // Now that we know there were hours - test for days
                        // using nested if statments
                        //-------------------------------------------------------------
                        
                        if (seconds >= SecondsInDays)
                        {
                            // Display how many Hours are in the seconds entered.
                            lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds.\n", seconds / SecondsInDays, seconds);
                        }
                    }
                }
                else
                {

                    // if we are here we know the user did not enter a value that meets the minimum
                    // requirenents of at least 60
                    // Ask the user to enter a valid number
                    lblResults.Text = "Please enter an integer larger than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }
            }
            else
            {
                // This is the code block that will be executed if the user did not put an int in
                lblResults.Text = "Please enter an int to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }
        } 
    }
}
