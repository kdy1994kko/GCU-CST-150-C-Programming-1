/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
*/


using CST_150_DogClass.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_DogClass.PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // error label not visible
            lblErrorMessage.Visible = false;
        }

        /// <summary>
        /// Click event to add a new dog to the datagridview tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDog_ClickEvent(object sender, EventArgs e)
        {
            // How do we read from cmbBox
            var combobox = cmbSit.SelectedItem;

            // Test our class
            // Instantiate the Dog class and create a new Dog object called ginger
            Dog ginger = new Dog("Ginger", 12.24, "Golden Cream", 57.25, false);

            var name = ginger.Name;
            var color = ginger.Color;

            // Declare and initialize
            // flag that tracks if all entries are valid
            bool isValidEntries = true;
            double weight = 0.00D, neckRad = 0.00D, neckCircum = 0.00D;
            // flag to verify parsing doubles is true or false
            bool isValid = false;

            // make sure the error labl is not visible
            lblErrorMessage.Visible = false;

            // intantiate our utility class so we can use it
            Utility utility = new Utility();

            //------------------------------
            // verify all boxes have correct inputs
            // we will be using a utility / helper class to verify inputs
            if (!utility.NotNull(txtName.Text) || !utility.NotNull(txtColor.Text) || (cmbSit.SelectedItem == null))
            {
                isValidEntries = false;
            }
            // Now test the text box for valid double neck size
            (neckRad, isValid) = utility.ValidDouble(txtNeck.Text);
            if(!isValid)
            {
                isValidEntries = false;
            }
            (neckCircum, isValid) = utility.ValidDouble(txtNeck.Text);
            if (!isValid)
            {
                isValidEntries = false;
            } 
            // now test for weight
            // test the text box for valid double neck size
            // if valid the weight will contain the double value
            (weight, isValid) = utility.ValidDouble(txtWeight.Text);
            if (!isValid)
            {
                isValidEntries = false;
            }
            // datagridview with the entry
            // else display error message
            if(isValidEntries)
            {
                // if we are here we know we have valid entries
                // so lets populate the datagrideview
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumference(), dogObject.Sit, dogObject.CalWeight(), dogObject.Color);
            }
            else
            {
                // if we are here there is a problem with an entry
                // show the error message
                lblErrorMessage.Visible = true;
            }
        }

        /// <summary>
        /// when the form loads execute this event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            // set the number of rows to 5 and configure each row
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Circum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            // format number in neck and weight for 2 decimals
            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";
        }
    }
}

