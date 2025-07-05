/*
 * Kevvan D. Young
 * CST-150
 * T7 Milestone 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
*/

using System;
using CST_150_Milestone_7.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone_7.PresentationLayer
{
    // Defines a partial class for the secondary form in the application
    public partial class FrmSecondary : Form
    {
        // Constructor for FrmSecondary that takes a list of filtered inventory items
        public FrmSecondary(List<Inventory> filteredItems)
        {
            InitializeComponent(); // Initializes the form components (UI elements)
            DisplaySearchResults(filteredItems); // Displays the filtered items in the DataGridView
        }

        // Method to display the search results in the DataGridView (gvResults)
        private void DisplaySearchResults(List<Inventory> items)
        {
            gvResults.DataSource = null; // Clears any existing data source
            gvResults.DataSource = items; // Sets the new data source to the provided list

            // Formats the "Quantity" column to align left and display as a number with no decimals
            gvResults.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gvResults.Columns["Quantity"].DefaultCellStyle.Format = "N0";

            // Formats the "Cost" column to align left and display as currency with 2 decimal places
            gvResults.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gvResults.Columns["Cost"].DefaultCellStyle.Format = "C2";
        }

        // Event handler for the Close button click event
        private void BtnClose_ClickEvent(object sender, EventArgs e)
        {
            this.Close(); // Closes the FrmSecondary form
        }
    }
}
