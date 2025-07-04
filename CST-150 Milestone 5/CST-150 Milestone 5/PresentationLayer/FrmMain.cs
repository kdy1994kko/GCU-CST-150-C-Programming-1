/*
 * Kevvan D. Young
 * CST-150
 * T5 Milestone 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
*/

using CST_150_Milestone_5.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone_5.PresentationLayer
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
            gvInventory.DataSource = null; // Reset the binding
            gvInventory.DataSource = inventoryList; // Rebind with updated list
        }

        // Event handler for the Add button - adds a new random inventory item
        private void btnAdd_ClickEvent(object sender, EventArgs e)
        {
            var item = Utility.GenerateRandomInventory(random); // Create random item
            inventoryList.Add(item); // Add item to the list
            Inventory.SaveToFile(inventoryFile, inventoryList); // Save updated list to file
            DisplayInventory(); // Refresh the UI
        }

        // Event handler for the Delete button - removes the last item in the list
        private void btnDelete_ClickEvent(object sender, EventArgs e)
        {
            if (inventoryList.Count > 0)
            {
                inventoryList.RemoveAt(inventoryList.Count - 1); // Remove last item
                Inventory.SaveToFile(inventoryFile, inventoryList); // Save updated list
                DisplayInventory(); // Refresh the UI
            }
        }

        // Event handler for the Modify button - increments quantity of first 3 items
        private void btnModify_ClickEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < Math.Min(3, inventoryList.Count); i++)
            {
                inventoryList[i].Quantity++; // Increase quantity by 1
            }
            Inventory.SaveToFile(inventoryFile, inventoryList); // Save changes
            DisplayInventory(); // Refresh the UI
        }

        // Event handler for the Display button - reloads the current inventory view
        private void btnDisplay_ClickEvent(object sender, EventArgs e)
        {
            DisplayInventory();
        }
    }
}
