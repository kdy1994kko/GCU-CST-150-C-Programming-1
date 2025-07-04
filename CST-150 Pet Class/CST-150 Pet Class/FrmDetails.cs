/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 682). Pearson. ISBN-13: 9780138087562
*/

using System;
using CST_150_Pet_Class.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Pet_Class
{
    // This partial class represents a Windows Form used to display details of pets.
    public partial class FrmDetails : Form
    {
        // A list to store pet objects passed from another form or class.
        List<Pet> petResults;

        // Constructor for FrmDetails. It receives a list of pets and initializes the form.
        public FrmDetails(List<Pet> pets)
        {
            InitializeComponent(); // Initializes form controls and layout.
            petResults = pets;     // Assigns the incoming pet list to the class-level variable.
        }

        // Event handler for when the form loads.
        private void FrmDetails_Load(object sender, EventArgs e)
        {
            gvDetails.DataSource = null;         // Clears any existing data source in the grid view.
            gvDetails.DataSource = petResults;   // Sets the grid view to display the list of pets.
        }

        // Event handler for the "Close" button click.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form.
        }
    }
}
