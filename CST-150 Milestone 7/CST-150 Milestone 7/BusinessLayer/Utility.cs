/*
 * Kevvan D. Young
 * CST-150
 * T7 Milestone 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 695). Pearson. ISBN-13: 9780138087562
*/

using CST_150_Milestone_7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for business logic components of the application
namespace CST_150_Milestone_7.BusinessLayer
{
    // Static Utility class containing helper methods
    public static class Utility
    {
        /// <summary>
        /// Generates a random Inventory item using provided Random object.
        /// </summary>
        /// <param name="random">An instance of the Random class used to generate random values.</param>
        /// <returns>A randomly generated Inventory object.</returns>
        public static Inventory GenerateRandomInventory(Random random)
        {
            // Arrays containing possible values for each inventory property
            string[] descriptions = { "Sweater", "Hoodie", "Skirt", "Shorts", "Blouse" };
            string[] types = { "Casual", "Formal", "Sport", "Beach", "Lounge" };
            string[] sizes = { "S", "M", "L", "XL" };
            string[] colors = { "Red", "Green", "Blue", "Black", "White" };

            // Randomly select one value from each array
            string desc = descriptions[random.Next(descriptions.Length)];
            string type = types[random.Next(types.Length)];
            string size = sizes[random.Next(sizes.Length)];
            string color = colors[random.Next(colors.Length)];

            // Generate a random quantity between 1 and 20
            int qty = random.Next(1, 21);

            // Generate a random cost between $10.00 and $60.00 (rounded to 2 decimal places)
            double cost = Math.Round(random.NextDouble() * 50 + 10, 2);

            // Create and return a new Inventory object with the randomly selected values
            return new Inventory(desc, type, size, color, qty, cost);
        }
    }
}
