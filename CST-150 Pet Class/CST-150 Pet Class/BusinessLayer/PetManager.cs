/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 682). Pearson. ISBN-13: 9780138087562
*/

using System;
using CST_150_Pet_Class.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Pet_Class.BusinessLayer
{
    // This class manages operations related to pets
    public class PetManager
    {
        // This method returns a predefined list of pets
        public List<Pet> GetPets()
        {
            return new List<Pet>
        {
            new Pet("Buddy", "Dog", 4),       // Dog named Buddy, 4 years old
            new Pet("Whiskers", "Cat", 2),    // Cat named Whiskers, 2 years old
            new Pet("Tweety", "Bird", 1)      // Bird named Tweety, 1 year old
        };
        }

        // This method searches through a list of pets based on a keyword that matches their type (e.g., "dog")
        public List<Pet> SearchPets(List<Pet> pets, string keyword)
        {
            var result = new List<Pet>(); // Create a list to store matching pets

            foreach (var pet in pets)     // Loop through each pet in the provided list
            {
                // If the pet's type contains the keyword (case-insensitive), add it to the result list
                if (pet.Type.ToLower().Contains(keyword.ToLower()))
                {
                    result.Add(pet);
                }
            }

            return result; // Return the list of matching pets
        }
    }
}
