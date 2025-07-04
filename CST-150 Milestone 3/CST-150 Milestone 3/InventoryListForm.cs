/*
 * Kevvan D. Young
 * CST-150
 * T3 Milestone 3
 * 6/9/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 319). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone_3
{
    public partial class InventoryListForm : Form
    {
        // Inventory list to hold items read from file or added by the user
        private List<string> inventory = new List<string>();

        // Path to the inventory file stored in the Data folder
        private string inventoryFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Inventory.txt");

        // Random object used for generating random inventory items
        private Random random = new Random();

        // Padding constant for aligning output in labels
        private const int PadSpace = 20;

        // Constructor - Initializes form controls and sets dialog properties
        public InventoryListForm()
        {
            InitializeComponent();

            // Set OpenFileDialog properties
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Hide labels initially
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;

            // Attempt to load inventory when form starts
            LoadInventoryFromFile(); 
        }

        /// <summary>
        /// Attempts to load inventory from the predefined file on startup.
        /// </summary>
        private void LoadInventoryFromFile()
        {
            try
            {
                if (!File.Exists(inventoryFile))
                {
                    MessageBox.Show($"Inventory file not found:\n{inventoryFile}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read all lines into inventory list
                inventory = new List<string>(File.ReadAllLines(inventoryFile));

                // Display confirmation path in label
                selectFileDialog.DefaultExt = "Loaded: " + inventoryFile;
                lblSelectedFile.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }

        /// <summary>
        /// Displays all inventory items currently in memory.
        /// </summary>
        private void btnDisplayClickEvent(object sender, EventArgs e)
        {
            lblResults.Text = "";
            lblResults.ForeColor = Color.Black;

            if (inventory.Count == 0)
            {
                lblResults.Text = "Inventory is empty.";
            }
            else
            {
                lblResults.Text = "Current Inventory:\n\n";
                foreach (var item in inventory)
                {
                    lblResults.Text += item + "\n";
                }
            }

            lblResults.Visible = true;
        }

        /// <summary>
        /// Adds a randomly generated clothing item to the inventory list.
        /// </summary>
        private void btnAddClickEvent(object sender, EventArgs e)
        {
            string[] descriptions = { "Sweater", "Hoodie", "Skirt", "Shorts", "Blouse" };
            string[] types = { "Casual", "Formal", "Sport", "Beach", "Lounge" };
            string[] sizes = { "S", "M", "L", "XL" };
            string[] colors = { "Red", "Green", "Blue", "Black", "White" };

            // Generate random values
            string desc = descriptions[random.Next(descriptions.Length)];
            string type = types[random.Next(types.Length)];
            string size = sizes[random.Next(sizes.Length)];
            string color = colors[random.Next(colors.Length)];
            int quantity = random.Next(1, 21);
            double cost = Math.Round(random.NextDouble() * 50 + 10, 2);

            string newItem = $"{desc}, {type}, {size}, {color}, {quantity}, {cost}";
            inventory.Add(newItem);

            lblResults.Text = $"Item Added:\n{newItem}";
            lblResults.ForeColor = Color.Green;
            lblResults.Visible = true;
        }

        /// <summary>
        /// Deletes the last item in the inventory list.
        /// </summary>
        private void btnDeleteClickEvent(object sender, EventArgs e)
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

        /// <summary>
        /// Increments the quantity of the first inventory item.
        /// </summary>
        private void btnModifyClickEvent(object sender, EventArgs e)
        {
            if (inventory.Count == 0)
            {
                lblResults.Text = "No inventory to modify.";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
                return;
            }

            try
            {
                string[] fields = inventory[0].Split(", ");
                if (fields.Length < 6)
                {
                    throw new Exception("Invalid inventory line format.");
                }

                // Parse and increment quantity

                int qty = int.Parse(fields[4]);
                qty++;
                fields[4] = qty.ToString();

                // Recombine updated item
                inventory[0] = string.Join(", ", fields);

                lblResults.Text = $"Modified First Item (Qty++):\n{inventory[0]}";
                lblResults.ForeColor = Color.Blue;
                lblResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification error: " + ex.Message);
            }
        }

        /// <summary>
        /// Triggered when the user clicks the Load File button.
        /// Reads selected inventory file and displays it in formatted layout.
        /// </summary>
        private void btnLoadFileClickEvent(object sender, EventArgs e)
        {
            // Declare display headers
            string txtFile = "";
            string dirLocation = "";

            string header1 = "Desc", header2 = "Type", header3 = "Size", header4 = "Color", header5 = "Qty", header6 = "Cost";
            string headerLine1 = "----", headerLine2 = "----", headerLine3 = "----", headerLine4 = "-----", headerLine5 = "---", headerLine6 = "----";

            selectFileDialog.InitialDirectory = Application.StartupPath + @"\Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Open file dialog
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Clear existing inventory list
                    inventory.Clear();

                    // Read the selected file path and content
                    txtFile = selectFileDialog.FileName;
                    dirLocation = Path.GetFullPath(selectFileDialog.FileName);
                    lblSelectedFile.Text = txtFile;
                    lblSelectedFile.Visible = true;

                    string[] lines = File.ReadAllLines(txtFile);
                    inventory.AddRange(lines); // Store for modify/delete

                    lblResults.Text = "";

                    // Display headers
                    lblResults.Text = string.Format("{0}{1}{2}{3}{4}{5}\n",
                        header1.PadRight(PadSpace), header2.PadRight(PadSpace),
                        header3.PadRight(PadSpace), header4.PadRight(PadSpace),
                        header5.PadRight(PadSpace), header6.PadRight(PadSpace));

                    lblResults.Text += string.Format("{0}{1}{2}{3}{4}{5}\n",
                        headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace),
                        headerLine3.PadRight(PadSpace), headerLine4.PadRight(PadSpace),
                        headerLine5.PadRight(PadSpace), headerLine6.PadRight(PadSpace));

                    // Format and display each inventory item
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(", ");
                        for (int i = 0; i < fields.Length; i++)
                        {
                            lblResults.Text += fields[i].PadRight(PadSpace);
                        }
                        lblResults.Text += "\n";
                    }

                    lblResults.Visible = true;
                    lblResults.ForeColor = Color.Black;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file:\n" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
