/*
 * Kevvan D. Young
 * CST-150
 * T4 Activity 4
 * 6/16/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 339). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Activity_3
{
    public partial class FrmMain : Form
    {
        // Declare and initialize
        // Class Level Variable Scope
        string[] lines; // Only declare the array
        string txtFile = "";

        /// <summary>
        /// Class Constructor
        /// This method is the first method to get invoked
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            // Set the properties for the selectFileDialog control
            // Define the initial directory that is shown
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            // Set the title of open file dialog

            selectFileDialog.Title = "Browse Txt Files";
            // DefaultExt is only used when "All Files" is selected
            // from the filter box and no extension is specified
            // by the user.
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // When the form is initialized make sure the lblResults
            // and lblSelectedFile are not visible
            lblResults.Visible = false;
            lblSelectedFile.Visible = false;

            // Make sure the comboBox is not visible
            cmbSelectRow.Visible = false;
            lblSelectRow.Visible = false;
        }

        /// <summary>
        /// Click Event Handler to Read the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFileClickEvent(object sender, EventArgs e)
        {
            // Declare and initialize variables
            string txtFile = "";
            string dirLocation = "";
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "Qty";
            string headerLine1 = "----", headerLine2 = "-----", headerLine3 = "---";

            // Use this int to dynamically populate the comboBox
            int numberRows = 1;

            // Once the button is clicked - show the file dialog
            if (this.selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read in the text file that was selected
                txtFile = this.selectFileDialog.FileName;
                // Get the path of the file plus the filename
                dirLocation = Path.GetFullPath(selectFileDialog.FileName);

                // Show the selected file and path in the label
                lblSelectedFile.Text = txtFile;

                // Make sure to make this label visible
                lblSelectedFile.Visible = true;

                // Read all the lines into a one dimensional string array
                lines = File.ReadAllLines(txtFile);

                // Populate a label with the array
                // Make sure the label is cleared out before we start
                lblResults.Text = "";

                // Display the header
                DisplayHeader();

                // Make sure to clear out the combobox before runnng
                cmbSelectRow.Items.Clear();

                lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
                lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));

                foreach (string line in lines)
                {
                    // Dynamically Populate the comboBox
                    cmbSelectRow.Items.Add(numberRows);
                    // Inc to next row
                    numberRows++;

                    // Split each line into an array of elements
                    string[] inventoryList = line.Split(", ");
                    // Iterate through each element in the array
                    // using a for loop instead of for each loop
                    for (int i = 0; i < inventoryList.Length; i++)
                    {
                        // Call the method to convert all text to lower case
                        ConvertLowerCase(inventoryList[i]);

                        // REMOVED THIS Display each element using proper spacing
                        // REMOVED THIS lblResults.Text += inventoryList[i].PadRight(PadSpace);
                    }
                    // Need a new line after each iteration to show the next line
                    lblResults.Text += "\n";
                }
                // Make sure the label is visible
                lblResults.Visible = true;
                // Make sure the label is visible
                cmbSelectRow.Visible = true;
                lblSelectRow.Visible = true;
            }
        }

        /// <summary>
        /// Convert input string to all lower case characters 
        /// Then send the results to be displayed
        /// </summary>
        /// <param name="textToConvert"></param>
        private void ConvertLowerCase(string textToConvert)
        {
            // Convert all text to lower case useing the argument
            ResultsToLabel(textToConvert.ToLower());
        }

        /// <summary>
        /// Print results to label
        /// </summary>
        /// <param name="results"></param>
        private void ResultsToLabel(string results)
        {
            //Declare and Initialize Constant
            const int PadSpace = 20;
            // Display each element using proper spacing
            lblResults.Text += results.PadRight(PadSpace);
        }

        /// <summary>
        /// When the comboBox drop down closes trigger this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRowToInc(object sender, EventArgs e)
        {
            // Declare and Initialize
            int rowSelected = -1;
            int qtyValue = -1;

            // Get the selected index of the comboBox
            // -1 means no value was selected
            rowSelected = cmbSelectRow.SelectedIndex;

            // Only inc a qty if a row was selected
            if (rowSelected >= 0)
            {
                // Get the qty from the row selected
                qtyValue = GetQty(lines, rowSelected);

                // Now we can inc the qty and store it back to the file
                IncDisplayQty(lines, rowSelected, qtyValue, txtFile);
            }
        }

        /// <summary>
        /// Get the Qty value from selected Row 
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="selectedRow"></param>
        /// <returns></returns>
        private int GetQty(string[] lines, int selectedRow)
        {

            // Declare and initialize
            int qty = -1; // This way we know if there was an error
            // Iterate through the array until the selected row is found.
            // Since we know the exact number of times to iterate through the array
            // which loop is the best one to use?
            for (int x = 1; x < lines.Length; x++)
            {
                // Now only pull out the row we need
                if (x == selectedRow)
                {
                    string[] invRow = lines[x].Split(",");
                    // Now pull out the qty.
                    // Use exception handling to parse string to int
                    try
                    {
                        // Convert string representation of a number to its
                        // signed integer. 
                        qty = int.Parse(invRow[2].Trim());
                        return qty;
                    }
                    catch (FormatException e)
                    {
                        // Show an exception message
                        lblResults.Text = e.Message;
                    }
                }
            }
            // If there are any exceptions return -1
            return qty;
        }

        /// <summary>
        /// Inc qty value, build the string for file, save to file
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="invRowToUpdate"></param>
        /// <param name="qty"></param>
        /// <param name="txtFile"></param>
        private void IncDisplayQty(string[] lines, int invRowToUpdate, int qty, string txtFile)
        {

            // Declare and Initialize
            string updateLine = "";

            // First inc qty
            qty++;

            // Now we need to update the qty in the array
            // First we need to split up the row so we can update the array
            string[] invRow = lines[invRowToUpdate].Split(",");
            // Then we can update the element in the string array
            invRow[2] = qty.ToString();
            // We need to build the string to store in the Lines array
            updateLine = invRow[0].Trim() + ", " + invRow[1].Trim() + ", " + invRow[2].Trim();
            // Now update the Lines array
            lines[invRowToUpdate] = updateLine;
            // Now update the text file
            File.WriteAllLines(txtFile, lines);
        }

        /// <summary>
        /// Display the entire inventory
        /// </summary>
        private void DisplayInv()
        {
            // First need to clear out the label
            lblResults.Text = "";
            // Then display the header
            DisplayHeader();
            // Iterate through the inventory one line at a time
            foreach (string line in lines)
            {
                // Split each line into an array of elements
                string[] inventoryList = line.Split(", ");
                // Iterate through each element in the array
                // using a for loop instead of foreach loop
                for (int i = 0; i < inventoryList.Length; i++)
                {
                    // Send to display
                    ResultsToLabel(inventoryList[i]);
                }
                // Need a new line after each iteration to show next line
                lblResults.Text += "\n";
            }
        }
         
        /// <summary>
        /// Display the inventory header
        /// </summary>
        private void DisplayHeader()
        {
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "Qty";
            string headerLine1 = "----", headerLine2 = "-----", headerLine3 = "---";

            // Add in the header  
            lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
            lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));
        }
    }
}