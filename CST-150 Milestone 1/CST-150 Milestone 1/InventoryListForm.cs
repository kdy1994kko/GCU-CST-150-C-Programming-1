/*
 * Kevvan D. Young
 * CST-150
 * T1 Milestone 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
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
    /// Form for displaying a list of inventory items.
    /// </summary>
    public partial class InventoryListForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the InventoryListForm class.
        /// </summary>
        public InventoryListForm()
        {
            // Initialize the form's components
            InitializeComponent();
            // Load the list of inventory items
            LoadItems();
        }

        /// <summary>
        /// Loads the list of inventory items, optionally filtering by description.
        /// </summary>
        /// <param name="filter">The filter string to apply to the list.</param>
        private void LoadItems(string filter = "")
        {
            // If no filter is specified, display all items; otherwise, filter the list
            var filtered = string.IsNullOrEmpty(filter)
                ? InventoryService.Items
                : InventoryService.Items
                    .Where(i => i.Description != null && i.Description.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            // Clear the data grid view's data source
            dataGridView1.DataSource = null;
            // Bind the filtered list to the data grid view
            dataGridView1.DataSource = filtered;
        }

        /// <summary>
        /// Opens the Add Item form and reloads the list after adding a new item.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Show the Add Item form as a dialog
            new AddItemForm().ShowDialog();
            // Reload the list of items
            LoadItems();
        }

        /// <summary>
        /// Opens the Item Detail form for the selected item and reloads the list after editing.
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            // Get the selected item
            if (dataGridView1.CurrentRow?.DataBoundItem is InventoryItem item)
            {
                // Show the Item Detail form as a dialog
                new ItemDetailForm(item.Id).ShowDialog();
                // Reload the list of items
                LoadItems();
            }
        }

        /// <summary>
        /// Filters the list of items based on the search text.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Reload the list with the current search filter
            LoadItems(txtSearch.Text);
        }

        // Unused event handlers
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void btnAdd_Click_1(object sender, EventArgs e) { }
        private void btnView_Click_1(object sender, EventArgs e) { }
        private void InventoryListForm_Load(object sender, EventArgs e) { }
    }
}
