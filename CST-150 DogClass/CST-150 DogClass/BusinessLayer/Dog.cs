/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 695). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_DogClass.BusinessLayer
{
    internal class Dog
    {
        // Define the properties
        public string Name { get; set; }
        public double NeckRad { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public bool Sit { get; set; }

        /// <summary>
        /// Default Contructor
        /// </summary>
        public Dog()
        {
            // Initialize the Properties
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="neckRad"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="sit"></param>
        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            // Main purpose of constructor is to initialize the properties
            Name = name;
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit; 
        }

        /// <summary>
        /// Method that takes the property NeckRad and returns
        /// the circumference in centementers.
        /// </summary>
        /// <returns></returns>

        public double CalCircumference()
        {
            // Declare and Initialize
            const double cmConversion = 2.54D;
            double circumference = 0.00D;

            // Since NeckRad is at the class level we can use this
            // property inside this method.
            // Conversion from radius to circumference (2*Pi*r)
            circumference = 2 * Math.PI * NeckRad;
            // Then convert to centemeters from inches
            return (circumference * cmConversion);
        }

        /// <summary> 
        /// Convert Weight pounds to kilograms 
        /// </summary> 
        /// <returns></returns>  
        public double CalWeight()
        {
            // Declare and Initialize 
            const double kgConversion = 0.453592D;
            // Convert the property Weight from pounds to kilograms
            return (Weight * kgConversion);
        }
    }
}