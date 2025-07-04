/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 337). Pearson. ISBN-13: 9780138087562
*/

using CST_150_DiceClass.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Namespace for the presentation layer of the Dice application
namespace CST_150_DiceClass.PresentationLayer
{
    // Partial class for the main form of the application
    public partial class FrmMain : Form
    {
        // Declare two Dice objects
        private Dice die1;
        private Dice die2;

        // Constructor for the form
        public FrmMain()
        {
            InitializeComponent(); // Initialize UI components
            die1 = new Dice(); // Instantiate first dice
            die2 = new Dice(); // Instantiate second dice
        }

        // Event handler for the Roll button click
        private void btnRoll_ClickEvent(object sender, EventArgs e)
        {
            // Roll both dice
            die1.Roll();
            die2.Roll();

            // Update the dice images on the form based on their rolled values
            picDie1.Image = Utility.GetDiceImage(die1.Value);
            picDie2.Image = Utility.GetDiceImage(die2.Value);
        }
    }
}
