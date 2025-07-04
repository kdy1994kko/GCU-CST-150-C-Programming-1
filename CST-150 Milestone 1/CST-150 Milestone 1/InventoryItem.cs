/*
 * Kevvan D. Young
 * CST-150
 * T1 Milestone 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 119). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Milestone_1
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public partial class InventoryItem
    {
        /// <summary>
        /// Unique identifier for the item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Type or category of the item (e.g., clothing, electronics, etc.).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Brief description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Size of the item (e.g., small, medium, large, etc.).
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Color of the item.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Quantity of the item in stock.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Cost or price of the item.
        /// </summary>
        public decimal Cost { get; set; }
    }
}
