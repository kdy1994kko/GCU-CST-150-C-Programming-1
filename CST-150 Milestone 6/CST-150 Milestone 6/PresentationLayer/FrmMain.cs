/*
 * Kevvan D. Young
 * CST-150
 * T6 Milestone 6
 * 6/30/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
*/

using CST_150_Milestone_6.BusinessLayer;
using CST_150_Milestone_6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone_6.PresentationLayer
{
    // This class represents the main form of the application
    public partial class FrmMain : Form
    {
        // List to hold inventory items
        private List<Inventory> inventoryList = new();

        // Path to the inventory data file
        private readonly string inventoryFile = @"Data\Inventory.txt";

        // Random object used for generating inventory items
        private readonly Random random = new();

        // Constructor - initializes form and loads inventory from file
        public FrmMain()
        {
            InitializeComponent();
            LoadInventory();
        }

        // Loads inventory data from file and displays it in the UI
        private void LoadInventory()
        {
            inventoryList = Inventory.LoadFromFile(inventoryFile);
            DisplayInventory();
        }

        // Binds the inventory list to the DataGridView to show data on the form
        private void DisplayInventory()
        {
            gvInventory.DataSource = null;
            gvInventory.DataSource = inventoryList;

            // Format Columns
            gvInventory.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gvInventory.Columns["Quantity"].DefaultCellStyle.Format = "N0"; // commas

            gvInventory.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gvInventory.Columns["Cost"].DefaultCellStyle.Format = "C2"; // $ + 2 decimal places
        }

        // Handles the Add button click event
        private void btnAdd_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                // Read and trim input values from text fields
                string desc = txtDescription.Text.Trim();
                string type = txtType.Text.Trim();
                string size = txtSize.Text.Trim();
                string color = txtColor.Text.Trim();
                string qtyText = txtQuantity.Text.Trim();
                string costText = txtCost.Text.Trim();

                // If all fields are empty, generate a random inventory item
                if (string.IsNullOrEmpty(desc) && string.IsNullOrEmpty(type) &&
                    string.IsNullOrEmpty(size) && string.IsNullOrEmpty(color) &&
                    string.IsNullOrEmpty(qtyText) && string.IsNullOrEmpty(costText))
                {
                    var randomItem = Utility.GenerateRandomInventory(random); // Generate random item
                    inventoryList.Add(randomItem); // Add it to the inventory list
                }
                else
                {
                    // If some fields are empty (but not all), show validation error
                    if (string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(type) ||
                        string.IsNullOrEmpty(size) || string.IsNullOrEmpty(color))
                    {
                        MessageBox.Show("All fields must be filled out.", "Validation Error");
                        return;
                    }

                    // Parse quantity and cost values
                    int qty = int.Parse(qtyText);
                    double cost = double.Parse(costText);

                    // Create new inventory item and add it to the list
                    Inventory item = new(desc, type, size, color, qty, cost);
                    inventoryList.Add(item);
                }

                // Save updated list to file and refresh UI
                Inventory.SaveToFile(inventoryFile, inventoryList);
                DisplayInventory();
            }
            catch (FormatException)
            {
                // Handle invalid number inputs
                MessageBox.Show("Please enter valid numbers for Quantity and Cost.", "Input Error");
            }
        }

        // Handles the Delete button click event
        private void btnDelete_ClickEvent(object sender, EventArgs e)
        {
            // Ensure a row is selected in the grid
            if (gvInventory.CurrentRow != null && gvInventory.CurrentRow.Index >= 0)
            {
                int index = gvInventory.CurrentRow.Index;
                inventoryList.RemoveAt(index); // Remove selected item from list
                Inventory.SaveToFile(inventoryFile, inventoryList); // Save changes
                DisplayInventory(); // Refresh UI
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection");
            }
        }

        // Handles the Increment Quantity button click event
        private void btnIncrement_ClickEvent(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (gvInventory.CurrentRow != null)
            {
                int index = gvInventory.CurrentRow.Index;
                inventoryList[index].Quantity++; // Increment quantity
                Inventory.SaveToFile(inventoryFile, inventoryList); // Save changes
                DisplayInventory(); // Refresh UI
            }
        }

        // Handles the Decrement Quantity button click event
        private void btnDecrement_ClickEvent(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (gvInventory.CurrentRow != null)
            {
                int index = gvInventory.CurrentRow.Index;

                // Decrement only if quantity is greater than 0
                if (inventoryList[index].Quantity > 0)
                    inventoryList[index].Quantity--;

                Inventory.SaveToFile(inventoryFile, inventoryList); // Save changes
                DisplayInventory(); // Refresh UI
            }
        }

        // Event handler for the Display button - reloads the current inventory view
        private void btnDisplay_ClickEvent(object sender, EventArgs e)
        {
            DisplayInventory();
        }
    }
}
