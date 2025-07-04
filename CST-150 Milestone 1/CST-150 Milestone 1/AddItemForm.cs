/*
 * Kevvan D. Young
 * CST-150
 * T1 Milestone 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 120). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Milestone_1
{
    /// <summary>
    /// Form for adding a new item to the inventory.
    /// </summary>
    public partial class AddItemForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the AddItemForm class.
        /// </summary>
        public AddItemForm()
        {
            // Initialize the form's components
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new item to the inventory when the Add button is clicked.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new InventoryItem object from the form's input fields
            var item = new InventoryItem
            {
                Type = txtType.Text,
                Description = txtDescription.Text,
                Size = txtSize.Text,
                Color = txtColor.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Cost = decimal.Parse(txtCost.Text)
            };
            // Add the item to the inventory service
            InventoryService.AddItem(item);
            // Display a confirmation message
            MessageBox.Show("Item added.");
            // Close the form
            Close();
        }

        // Unused event handlers
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void AddItemForm_Load(object sender, EventArgs e) { }
    }
}
