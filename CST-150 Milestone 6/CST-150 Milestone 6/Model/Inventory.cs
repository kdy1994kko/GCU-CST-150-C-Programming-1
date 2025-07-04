/*
 * Kevvan D. Young
 * CST-150
 * T6 Milestone 6
 * 6/30/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 695). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Define the namespace for organizing related classes in the Business Layer
namespace CST_150_Milestone_6.Model
{
    // The Inventory class represents an item in the inventory
    public class Inventory
    {
        // Properties representing the attributes of the inventory item
        public string Description { get; set; } // Description of the item
        public string Type { get; set; } // Type/category of the item
        public string Size { get; set; } // Size of the item (e.g., Small, Medium, Large)
        public string Color { get; set; } // Color of the item
        public int Quantity { get; set; } // Quantity in stock
        public double Cost { get; set; } // Cost per unit

        // Default constructor initializing properties with default values
        public Inventory()
        {
            Description = "";
            Type = "";
            Size = "";
            Color = "";
            Quantity = 0;
            Cost = 0.0;
        }

        // Parameterized constructor for creating a fully initialized Inventory object
        public Inventory(string description, string type, string size, string color, int quantity, double cost)
        {
            Description = description;
            Type = type;
            Size = size;
            Color = color;
            Quantity = quantity;
            Cost = cost;
        }

        // Overrides the default ToString method to return a comma-separated string of all property values
        public override string ToString()
        {
            return $"{Description}, {Type}, {Size}, {Color}, {Quantity}, {Cost}";
        }

        // Static method to load a list of Inventory objects from a file
        public static List<Inventory> LoadFromFile(string path)
        {
            var inventoryList = new List<Inventory>();

            // If file doesn't exist, return an empty list
            if (!File.Exists(path)) return inventoryList;

            // Read each line in the file
            foreach (var line in File.ReadAllLines(path))
            {
                // Split the line by comma and space to extract item properties
                var parts = line.Split(", ");

                // Ensure the line contains exactly 6 parts before creating an Inventory object
                if (parts.Length == 6)
                {
                    inventoryList.Add(new Inventory(
                        // Description, Type, Size, Color
                        parts[0], parts[1], parts[2], parts[3],

                        // Quantity, Cost 
                        int.Parse(parts[4]), double.Parse(parts[5])
                    ));
                }
            }
            return inventoryList;
        }

        // Static method to save a list of Inventory objects to a file
        public static void SaveToFile(string path, List<Inventory> items)
        {
            var lines = new List<string>();

            // Convert each Inventory item to a string and add it to the list of lines
            foreach (var item in items)
                lines.Add(item.ToString());

            // Write all lines to the specified file
            File.WriteAllLines(path, lines);
        }
    }
}
