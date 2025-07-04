/*
 * Kevvan D. Young
 * CST-150
 * T1 Milestone 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed.). Pearson. ISBN-13: 9780138087562
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
    /// Provides methods for managing inventory items.
    /// </summary>
    public static class InventoryService
    {
        // In-memory collection of inventory items
        public static List<InventoryItem> Items = new List<InventoryItem>();

        // Unique identifier generator for inventory items
        private static int _nextId = 1;

        /// <summary>
        /// Adds a new inventory item to the collection.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public static void AddItem(InventoryItem item)
        {
            // Assign a unique ID to the item
            item.Id = _nextId++;
            // Add the item to the collection
            Items.Add(item);
        }

        /// <summary>
        /// Retrieves an inventory item by its ID.
        /// </summary>
        /// <param name="id">The ID of the item to retrieve.</param>
        /// <returns>The item with the specified ID, or null if not found.</returns>
        public static InventoryItem GetItem(int id) => Items.FirstOrDefault(i => i.Id == id);

        /// <summary>
        /// Updates an existing inventory item in the collection.
        /// </summary>
        /// <param name="updatedItem">The updated item.</param>
        public static void UpdateItem(InventoryItem updatedItem)
        {
            // Find the index of the item to update
            var index = Items.FindIndex(i => i.Id == updatedItem.Id);
            // If the item exists, replace it with the updated item
            if (index != -1) Items[index] = updatedItem;
        }

        /// <summary>
        /// Deletes an inventory item by its ID.
        /// </summary>
        /// <param name="id">The ID of the item to delete.</param>
        public static void DeleteItem(int id) => Items.RemoveAll(i => i.Id == id);
    }
}
