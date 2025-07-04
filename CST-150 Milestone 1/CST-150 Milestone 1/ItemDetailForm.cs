/*
 * Kevvan D. Young
 * CST-150
 * T1 Milestone 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 116). Pearson. ISBN-13: 9780138087562
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
    /// Form for displaying and editing details of an inventory item.
    /// </summary>
    public partial class ItemDetailForm : Form
    {
        // The inventory item being edited
        private InventoryItem _item;

        /// <summary>
        /// Initializes a new instance of the ItemDetailForm class.
        /// </summary>
        /// <param name="itemId">The ID of the item to display.</param>
        public ItemDetailForm(int itemId)
        {
            // Initialize the form's components
            InitializeComponent();
            // Retrieve the item from the inventory service
            _item = InventoryService.GetItem(itemId);
            // Bind the item's data to the form's controls
            BindItem();
        }

        /// <summary>
        /// Binds the item's data to the form's controls.
        /// </summary>
        private void BindItem()
        {
            // If the item is null, exit the method
            if (_item == null) return;
            // Populate the form's controls with the item's data
            txtId.Text = _item.Id.ToString();
            txtType.Text = _item.Type;
            txtDescription.Text = _item.Description;
            txtSize.Text = _item.Size;
            txtColor.Text = _item.Color;
            txtQuantity.Text = _item.Quantity.ToString();
            txtCost.Text = _item.Cost.ToString("F2");
        }

        /// <summary>
        /// Saves changes to the item.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the item's properties from the form's controls
            _item.Type = txtType.Text;
            _item.Description = txtDescription.Text;
            _item.Size = txtSize.Text;
            _item.Color = txtColor.Text;
            _item.Quantity = int.Parse(txtQuantity.Text);
            _item.Cost = decimal.Parse(txtCost.Text);
            // Save the updated item to the inventory service
            InventoryService.UpdateItem(_item);
            // Display a confirmation message
            MessageBox.Show("Item updated.");
            // Close the form
            Close();
        }

        /// <summary>
        /// Increases the item's quantity.
        /// </summary>
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            // Increment the item's quantity
            _item.Quantity++;
            // Update the quantity control
            txtQuantity.Text = _item.Quantity.ToString();
        }

        /// <summary>
        /// Decreases the item's quantity.
        /// </summary>
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            // If the quantity is greater than 0, decrement it
            if (_item.Quantity > 0) _item.Quantity--;
            // Update the quantity control
            txtQuantity.Text = _item.Quantity.ToString();
        }

        /// <summary>
        /// Deletes the item.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Remove the item from the inventory service
            InventoryService.DeleteItem(_item.Id);
            // Display a confirmation message
            MessageBox.Show("Item deleted.");
            // Close the form
            Close();
        }

        // Unused event handlers
        private void label6_Click(object sender, EventArgs e) { }
        private void ItemDetailForm_Load(object sender, EventArgs e) { }
    }
}