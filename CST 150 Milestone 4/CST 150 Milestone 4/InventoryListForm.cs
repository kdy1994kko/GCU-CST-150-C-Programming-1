/*
 * Kevvan D. Young
 * CST-150
 * T4 Milestone 4
 * 6/17/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 342). Pearson. ISBN-13: 9780138087562
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
 
namespace CST_150_Milestone_4
{
    public partial class InventoryListForm : Form
    {
        // ===================== Event Handlers ======================

        // Displays inventory when the Display button is clicked
        private void btnDisplayClickEvent(object sender, EventArgs e) => DisplayInventory();

        // Adds a new item when the Add button is clicked
        private void btnAddClickEvent(object sender, EventArgs e) => AddInventoryItem();
        
        // Deletes the last item when the Delete button is clicked
        private void btnDeleteClickEvent(object sender, EventArgs e) => DeleteLastInventoryItem();
        
        // Modifies quantities of first three items when Modify button is clicked
        private void btnModifyClickEvent(object sender, EventArgs e) 
        {
            IncrementFirstItemQuantity();
            IncrementSecondItemQuantity();
            IncrementThirdItemQuantity();
        }

        // List to store inventory items as strings
        private List<string> inventory = new List<string>();

        // File path to the inventory text file
        private string inventoryFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Inventory.txt");

        // Random generator used for adding random inventory items
        private Random random = new Random();

        // Constant for padding spaces in text formatting
        private const int PadSpace = 20;

        public InventoryListForm()
        {
            InitializeComponent();

            // Setup file dialog properties
            selectFileDialog.InitialDirectory = Application.StartupPath + @"\Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Hide labels initially
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;

            // Attempt to load the default inventory file on startup
            LoadInventoryFromFile();
        }

        // Loads inventory from the default file
        private void LoadInventoryFromFile()
        {
            if (File.Exists(inventoryFile))
            {
                inventory = ReadInventoryFile(inventoryFile);
                lblSelectedFile.Text = "Loaded: " + inventoryFile;
                lblSelectedFile.Visible = false;
            }
            else
            {
                MessageBox.Show($"Inventory file not found:\n{inventoryFile}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 

        // Reads all lines from the specified inventory file
        private List<string> ReadInventoryFile(string path)
        {
            try
            {
                return new List<string>(File.ReadAllLines(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading inventory file: " + ex.Message);
                return new List<string>();
            }
        }

        // Displays the current inventory in the label
        private void DisplayInventory()
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

        // Adds a randomly generated inventory item to the list
        private void AddInventoryItem()
        {
            string[] descriptions = { "Sweater", "Hoodie", "Skirt", "Shorts", "Blouse" };
            string[] types = { "Casual", "Formal", "Sport", "Beach", "Lounge" };
            string[] sizes = { "S", "M", "L", "XL" };
            string[] colors = { "Red", "Green", "Blue", "Black", "White" };

            string desc = descriptions[random.Next(descriptions.Length)];
            string type = types[random.Next(types.Length)];
            string size = sizes[random.Next(sizes.Length)];
            string color = colors[random.Next(colors.Length)];
            int quantity = random.Next(1, 21);
            double cost = Math.Round(random.NextDouble() * 50 + 10, 2);

            string newItem = $"{desc}, {type}, {size}, {color}, {quantity}, {cost}";
            inventory.Add(newItem);

            UpdateInventoryFile();
            lblResults.Text = $"Item Added:\n{newItem}";
            lblResults.ForeColor = Color.Green;
            lblResults.Visible = true;
        }

        // Removes the last item from the inventory list
        private void DeleteLastInventoryItem()
        {
            if (inventory.Count > 0)
            {
                string removedItem = inventory[inventory.Count - 1];
                inventory.RemoveAt(inventory.Count - 1);

                UpdateInventoryFile();
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

        // Increments quantity of the first inventory item
        private void IncrementFirstItemQuantity()
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
                    throw new Exception("Invalid inventory line format.");

                int qty = int.Parse(fields[4]);
                qty++;
                fields[4] = qty.ToString();

                inventory[0] = string.Join(", ", fields);

                UpdateInventoryFile();

                lblResults.Text = $"Modified First Item (Qty++):\n{inventory[0]}";
                lblResults.ForeColor = Color.Blue; 
                lblResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification error: " + ex.Message);
            }
        }

        // Increments quantity of the second inventory item
        private void IncrementSecondItemQuantity()
        {
            if (inventory.Count < 2)
            {
                lblResults.Text = "Not enough items to modify second item.";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
                return;
            }

            try
            {
                string[] fields = inventory[1].Split(", ");
                if (fields.Length < 6)
                    throw new Exception("Invalid inventory line format.");

                int qty = int.Parse(fields[4]);
                qty++;
                fields[4] = qty.ToString();

                inventory[1] = string.Join(", ", fields);

                UpdateInventoryFile();

                lblResults.Text += $"\nModified Second Item (Qty++):\n{inventory[1]}";
                lblResults.ForeColor = Color.Blue;
                lblResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification error (Second Item): " + ex.Message);
            }
        }

        // Increments quantity of the third inventory item
        private void IncrementThirdItemQuantity()
        {
            if (inventory.Count < 3)
            {
                lblResults.Text = "Not enough items to modify third item.";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
                return;
            }

            try
            {
                string[] fields = inventory[2].Split(", ");
                if (fields.Length < 6)
                    throw new Exception("Invalid inventory line format.");

                int qty = int.Parse(fields[4]);
                qty++;
                fields[4] = qty.ToString();

                inventory[2] = string.Join(", ", fields);

                UpdateInventoryFile();

                lblResults.Text += $"\nModified Third Item (Qty++):\n{inventory[2]}";
                lblResults.ForeColor = Color.Blue;
                lblResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification error (Third Item): " + ex.Message);
            }
        }

        // Saves the inventory list to file
        private void UpdateInventoryFile()
        {
            try
            {
                File.WriteAllLines(inventoryFile, inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to inventory file: " + ex.Message);
            }
        }

        

        // Loads a user-selected file when Load File button is clicked
        private void btnLoadFileClickEvent(object sender, EventArgs e)
        {
            string txtFile = "";
            string dirLocation = "";

            // Column headers for display formatting
            string header1 = "Desc", header2 = "Type", header3 = "Size", header4 = "Color", header5 = "Qty", header6 = "Cost";
            string headerLine1 = "----", headerLine2 = "----", headerLine3 = "----", headerLine4 = "-----", headerLine5 = "---", headerLine6 = "----";

            // File dialog setup
            selectFileDialog.InitialDirectory = Application.StartupPath + @"\Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inventory.Clear();
                    txtFile = selectFileDialog.FileName;
                    dirLocation = Path.GetFullPath(selectFileDialog.FileName);
                    lblSelectedFile.Text = txtFile;
                    lblSelectedFile.Visible = true;

                    string[] lines = File.ReadAllLines(txtFile);
                    inventory.AddRange(lines);

                    lblResults.Text = "";

                    // Print headers
                    lblResults.Text = string.Format("{0}{1}{2}{3}{4}{5}\n",
                        header1.PadRight(PadSpace), header2.PadRight(PadSpace),
                        header3.PadRight(PadSpace), header4.PadRight(PadSpace),
                        header5.PadRight(PadSpace), header6.PadRight(PadSpace));

                    // Print header underlines
                    lblResults.Text += string.Format("{0}{1}{2}{3}{4}{5}\n",
                        headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace),
                        headerLine3.PadRight(PadSpace), headerLine4.PadRight(PadSpace),
                        headerLine5.PadRight(PadSpace), headerLine6.PadRight(PadSpace));

                    // Print each inventory line
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



