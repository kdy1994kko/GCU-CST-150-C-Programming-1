/*
 * Kevvan D. Young
 * CST-150
 * T2 Milestone 2
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

namespace CST_150_Milestone_2
{
    public partial class InventoryListForm : Form
    {
        // Inventory list
        private List<string> inventory = new List<string>();

        // Random generator
        private Random random = new Random();

        public InventoryListForm()
        {
            InitializeComponent();

            // Add initial hardcoded items using primitive types
            string item1 = "T-Shirt, Casual, M, Red, 10, 15.99";
            string item2 = "Jeans, Denim, L, Blue, 5, 29.99";
            string item3 = "Jacket, Outerwear, XL, Black, 3, 59.99";

            inventory.Add(item1);
            inventory.Add(item2); 
            inventory.Add(item3);

            lblResults.Visible = false;
        }

        // Button: Display Inventory
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblResults.Text = "";
            lblResults.ForeColor = Color.Black;

            if (inventory.Count == 0)
            {
                lblResults.Text = "Inventory is empty.";
            }
            else
            {
                lblResults.Text = "Current Inventory:\n";
                foreach (var item in inventory)
                {
                    lblResults.Text += item + "\n";
                }
            }

            lblResults.Visible = true;
        }

        // Button: Add Random Item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] descriptions = { "Sweater", "Hoodie", "Skirt", "Shorts", "Blouse" };
            string[] types = { "Casual", "Formal", "Sport", "Beach", "Lounge" };
            string[] sizes = { "S", "M", "L", "XL" };
            string[] colors = { "Red", "Green", "Blue", "Black", "White" };

            string desc = descriptions[random.Next(descriptions.Length)];
            string type = types[random.Next(types.Length)];
            string size = sizes[random.Next(sizes.Length)];
            string color = colors[random.Next(colors.Length)];
            int quantity = random.Next(1, 21); // 1 to 20
            double cost = Math.Round(random.NextDouble() * 50 + 10, 2); // $10 to $60

            string newItem = $"{desc}, {type}, {size}, {color}, {quantity}, {cost:C}";
            inventory.Add(newItem);

            lblResults.Text = $"Item Added:\n{newItem}";
            lblResults.ForeColor = Color.Green;
            lblResults.Visible = true;
        }

        // Button: Delete Last Item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (inventory.Count > 0)
            {
                string removedItem = inventory[inventory.Count - 1];
                inventory.RemoveAt(inventory.Count - 1);

                lblResults.Text = $"Item Deleted:\n{removedItem}";
                lblResults.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblResults.Text = "Inventory is already empty.";
                lblResults.ForeColor = Color.Red;
            }

            lblResults.Visible = true;
        }

    }
}
