/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 682). Pearson. ISBN-13: 9780138087562
*/

using CST_150_Pet_Class.BusinessLayer;
using CST_150_Pet_Class.Models;
using System;
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
    // Main form for managing a list of pets
    public partial class FrmMain : Form
    {
        // List to store all pets
        List<Pet> pets = new List<Pet>();

        // List to store search results
        List<Pet> searchResults = new List<Pet>();

        // Index of the currently selected pet in the grid view
        int selectedIndex;

        // Constructor
        public FrmMain()
        {
            InitializeComponent(); // Initialize UI components
        }

        // Event triggered when the form loads
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Instantiate the pet manager and fetch all pets
            PetManager manager = new PetManager();
            pets = manager.GetPets();

            // Bind the list of pets to the data grid view
            gvPets.DataSource = null;
            gvPets.DataSource = pets;
        }

        // Event triggered when a cell in the grid view is clicked
        private void gvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Store the selected row index
            selectedIndex = gvPets.CurrentRow.Index;
        }

        // Event triggered when the "Search" button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Use PetManager to search for pets based on search text
            PetManager manager = new PetManager();
            searchResults = manager.SearchPets(pets, txtSearch.Text.Trim());

            // Show search results in a details form
            FrmDetails frmDetails = new FrmDetails(searchResults);
            frmDetails.ShowDialog();
        }

        // Event triggered when the "Add Pet" button is clicked
        private void btnAddPet_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            string name = txtName.Text.Trim();
            string type = txtType.Text.Trim();
            string ageText = txtAge.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(ageText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Try to parse the age input
            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }

            // Create a new pet and add it to the list
            Pet newPet = new Pet(name, type, age);
            pets.Add(newPet);

            // Refresh the grid view to display the updated list
            gvPets.DataSource = null;
            gvPets.DataSource = pets;

            // Show confirmation message
            MessageBox.Show($"Pet Added:\nName: {name}\nType: {type}\nAge: {age}");

            // Clear input fields
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";
        }
         
        // Event triggered when the "Delete Pet" button is clicked
        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (gvPets.CurrentRow == null || gvPets.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a pet to delete.");
                return;
            }

            // Get index of the selected row
            int indexToRemove = gvPets.CurrentRow.Index;

            // Ensure index is within bounds
            if (indexToRemove >= 0 && indexToRemove < pets.Count)
            {
                // Ask for confirmation before deleting
                var result = MessageBox.Show($"Are you sure you want to delete {pets[indexToRemove].Name}?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If confirmed, remove pet and refresh the grid view
                if (result == DialogResult.Yes)
                {
                    pets.RemoveAt(indexToRemove);
                    gvPets.DataSource = null;
                    gvPets.DataSource = pets;
                }
            }
        }
    }
}
