/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 682). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Pet_Class.Models
{
    // Define a class named Pet
    public class Pet
    {
        // Property to store the name of the pet
        public string Name { get; set; }

        // Property to store the type of the pet (e.g., Dog, Cat, etc.)
        public string Type { get; set; }

        // Property to store the age of the pet
        public int Age { get; set; }

        // Constructor that initializes a new Pet object with specified name, type, and age
        public Pet(string name, string type, int age)
        {
            // Assign the passed-in name to the Name property
            Name = name;

            // Assign the passed-in type to the Type property
            Type = type;

            // Assign the passed-in age to the Age property
            Age = age;
        }
    }
}
