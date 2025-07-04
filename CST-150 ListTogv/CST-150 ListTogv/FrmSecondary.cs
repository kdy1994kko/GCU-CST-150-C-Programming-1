/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 641). Pearson. ISBN-13: 9780138087562
*/

using CST_150_ListTogv.Models;
using CST_150_ListTogv.BusinessLayer;
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
    public partial class FrmSecondary : Form
    {
        // class level list
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        /// Parameterized constructor
        /// since this class is public we have to
        /// make invitems.cs a public class 
        /// </summary>
        /// <param name="invSearch"></param>
        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();

            this.mySearch = invSearch;
        }

        /// <summary>
        /// when the form is loaded populate the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void BtnClose_ClickEvent(object sender, EventArgs e)
        {
            this.Close(); // Closes FrmSecondary and returns to FrmInventory
        }
    }
}
