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
    class Utility
    {
        /// <summary>
        /// Utility that returns false if the parameter string in null, empty,
        /// or just contains white spaces.
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            // Check if the string is empty, null or contains white spaces
            if(String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Test to determine if a Valid Double was entered.
        /// if true the string is parsed to double and true is returned.
        /// if false, -1 is returned and flase for bool.
        /// this return type is called a tuple.
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns></returns>
        public (double doubleValue, bool isConverted) ValidDouble(string valueToTest)
        {
            // Declare and Initialize
            double convertValue = 0.00D;
            // Test to see if the string can be pared to a double
            if(Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            // if parse fails return false and -1
            return (-1D, false);
        }

        /// <summary>
        /// Convert yes to bool true and no to bool false
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if(YesOrNo == "Yes")
            {
                return true;
            } 
            return false;
        }
    }
}
