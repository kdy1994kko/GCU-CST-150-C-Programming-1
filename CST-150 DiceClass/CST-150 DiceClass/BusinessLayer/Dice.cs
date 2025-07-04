/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 337). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declare the namespace for the business logic layer of the Dice application
namespace CST_150_DiceClass.BusinessLayer
{
    // Defines a class named Dice
    public class Dice
    {
        // Static instance of Random to ensure better randomness and avoid repeated values
        private static Random _random = new Random();

        // Public property to store the result of the dice roll, read-only outside the class
        public int Value { get; private set; }

        // Method to simulate rolling the dice
        public void Roll()
        {
            // Assigns a random number between 1 and 6 (inclusive) to Value
            Value = _random.Next(1, 7); // 1 to 6
        }
    }
}
