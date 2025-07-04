/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 641). Pearson. ISBN-13: 9780138087562
*/


using CST_150_ListTogv.BusinessLayer;
using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {
        //create the class level object
        // this is called an inventory reference variable
        // this is our master inventory object that MUST
        // always contain the most update to date inventory
        List<InvItem> invItems = new List<InvItem>();
        // list that will hold all items found for search
        List<InvItem> invSearch = new List<InvItem>();

        // properties
        private int SelectedGridIndex { get; set; }

        public FrmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// populate the grid when the form loads
        /// use this event handler to bind a datagrid
        /// control to list of objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void PopulateGrid_LoadEventHandler(object sender, EventArgs e)
        {
            // instantiate the business class and get all the inventory items
            // from tghe text file
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);

            // after the list has been populated, set the datasource property
            // of the datagrid control to the list
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            // what if we do not like the names in th handler of the gridview?
            // lets iterate through the header one column at a time
            // and change the header names
            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                // switch statment to change header text
                // column.index starts at 0 - end count
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Bunny Type";
                        break;
                    case 1:
                        column.HeaderText = "Bunny Color";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        // number format with noting to the right of the decimal
                        // column.DefaultCellStyle.Format = "NO";
                        // all numbers should be right justified
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        // show a message indicating something did not work correctly
                        MessageBox.Show("Invalid column was trying to be accessed!");
                        // C# requires a closing break
                        break;
                }
            }
        }

        /// <summary>
        /// event handler to manage click events of data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            // get the selected row
            SelectedGridIndex = gvInv.CurrentRow.Index;
            // now we also oknow the index into the list to get all our info
        }

        /// <summary>
        /// event handler to manage button to increment quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            // make sure the logic is not in the presentation layer so 
            // btnIncQty qty in the inventory class
            // instantiate the inventory class so we can use the inc qty method
            Inventory incQty = new Inventory();
            // invoke this method to inc qty and get the master list back
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);
            // since the list contains the master inventory
            // refresh the data in the data grid view
            // since we have already bound the list to the data grid view
            gvInv.Refresh();
        }

        /// <summary>
        /// Delete an item from inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteItem_EventHandler(object sender, EventArgs e)
        {
            // We already know the selected row which is the index
            // Make sure we remove the item from the master inventory
            invItems.RemoveAt(SelectedGridIndex);
            // we have to be carful when deleting items since we
            // will get an out of range exception since the datasource
            // is bound to the initial number of rows
            // therefore, we can not just refresh the data grid view
            // reset the datasource by clearing it out and setting it to null
            gvInv.DataSource = null;
            // last step is to bind the new data back to the data grid view
            gvInv.DataSource = invItems;
            // key --> invItems still has the master inventory !!!!
        }

        /// <summary>
        /// Search Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEvent(object sender, EventArgs e)
        {
            // our goal is to read from the textbox and search the
            // list in the type column for a match. if there is
            // a match or multiple matches then we show the match(s)
            // in the gridview on the secondary form
            string searchFor = txtSearch.Text;
            // since the searching is logic - we need to do this
            // in the business layer
            Inventory businessLayer = new Inventory();
            // search for match and put results in the search list
            invSearch = businessLayer.SearchItem(invItems, invSearch, searchFor);
            // send this invSearch over to the secondary form to be displayed
            // make sure to setup the secondary form now. . 
            FrmSecondary frmSecondary = new FrmSecondary(invSearch);

            frmSecondary.ShowDialog();
        }
    } 
} 
// <= LINE 77 NO => // ?? FrmInventory