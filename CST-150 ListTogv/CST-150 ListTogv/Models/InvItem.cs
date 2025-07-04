/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 641). Pearson. ISBN-13: 9780138087562
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.Models
{
    /// <summary>
    /// Model class that will structure
    /// all my inventory items.
    /// </summary> 
    public class InvItem
    {
        // Define the Properties
        public string Type { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }

        /// <summary>
        /// Model class Parameterized Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            Type = type;
            Color = color;
            Qty = qty;
        }
    }
}
