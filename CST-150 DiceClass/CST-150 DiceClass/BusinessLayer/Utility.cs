/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 337). Pearson. ISBN-13: 9780138087562
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

// Define the namespace for organizing related classes in the BusinessLayer of the CST_150_DiceClass project
namespace CST_150_DiceClass.BusinessLayer
{
    // Define a static class named Utility that contains helper methods
    public static class Utility
    {
        /// <summary>
        /// Returns the image of a dice face based on the given value.
        /// </summary>
        /// <param name="value">An integer from 1 to 6 representing the face of a dice.</param>
        /// <returns>An Image object loaded from the corresponding dice image file.</returns>
        public static Image GetDiceImage(int value)
        {
            // Construct the file path based on the dice value (e.g., "Resources/dice1.png")
            string filePath = $"Resources/dice{value}.png";

            // Load and return the image from the specified file path
            return Image.FromFile(filePath);
        }
    }
}
