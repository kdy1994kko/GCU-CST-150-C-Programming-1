/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 641). Pearson. ISBN-13: 9780138087562
*/


using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_ListTogv.BusinessLayer
{
    class Inventory
    {
        // the purpose of this class is to read the txt file into a list 
        // then pass the list to the FrmInventory.cs

        /// <summary>
        /// read the Inventory txt file and return a list of type InvItems class
        /// </summary>
        /// <param name="invItems"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            // enter the location of the file to open
            string dirLoc = Application.StartupPath + "Data\\topic6.txt";

            // open the file with "using"
            // the main goal to use "using" is to manage resources and the
            // resources automatically when done. (garbage collector)
            using (var str = File.OpenText(dirLoc))
            {
                // iterate through the text file one line at a time
                foreach(string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    // split up the line at each comma and dont forget to trim
                    string[] rowData = line.Split(",");
                    // now we can add the line to our List<InvItem>
                    // which is our class model
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(),
                        rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));
                }
            }
            // return the list
            return invItems;
        }

        
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            // i++ quantity value using the property name from the model
            int updatedQty = ++invItems[selectedRowIndex].Qty;

            // then put the value back into the list so we keep a master list
            invItems[selectedRowIndex].Qty = updatedQty;

            // the just return the list
            return invItems; 
        }

        /// <summary>
        /// search the item in the main inventory list and return the new search list
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="searchItem"></param>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> searchItem, string searchCriteria)
        {
            // make sure the searchItem list is cleared before we start
            searchItem.Clear();

            // now iterate over the main inventory and see if can find
            // any matches to be the search criteria
            foreach (InvItem item in invItems)
            {
                if (item.Type.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // if an item was found add it to the list
                    searchItem.Add(item);
                }
            }

            // return the end results of the search
            return searchItem;
        }
    }
}

