/*
 * Kevvan D. Young
 * CST-150
 * T4 Activity 4
 * 6/16/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 342). Pearson. ISBN-13: 9780138087562
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

namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event handler to execute the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            // This will be considered our Main Method and our
            // goal is to keep this method clean (no logic just calling
            // methods).
            // Declare and Initialize
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };

            // 1st Method
            SumInts(num1, num2);

            // 2nd Method 
            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);

            // 3rd Method 
            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);

            // 4th Method 
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);


            // 5th Method
            string firstString = "This is test number 82";
            string secondString = "The sky is blue today";
            FewestChars(firstString, secondString);

            // 6th Method 
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);


            // 7th Method Solution
            int[] generatedArray = GenerateIntArray();

            // 8th Method Solution
            bool boolResult = CompareBooleans(true, false);

            // 9th Method Solution
            double productResult = MultiplyIntAndDouble(num1, double4);

        }

        //----------------------
        // 1st Method 
        //----------------------

        /// <summary>
        /// Write a method that takes two integers and displays their sum with descriptive text.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            // Find the sum
            int sum = num1 + num2;
            // Display needs to be it's own method
            DisplayResults("Method 1: The sum of " + num1 + " + " + num2 + " = " + sum, true);
        }

        /// <summary>
        /// Displays the string that is sent to the method.
        /// Requires Descriptive text and result both in one string.
        /// Third parameter is to clear the label before writing to it.
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="result"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            // Only clear the label if the parameter is true
            if (clearLabel)
            {
                lblResults.Text = "";
            }
            // Display the results in the label
            lblResults.Text += string.Format("{0}\n", descText);
        }

        //----------------------
        // 2nd Method 
        //----------------------

        /// <summary>
        /// Find the average of the 5 doubles and then return average.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns></returns>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            // Declare and Initialize
            const double AvgDenominator = 5.0D;
            // Find and return the avarage of the 5 doubles
            return ((num1 + num2 + num3 + num4 + num5) / AvgDenominator);
        }

        //----------------------
        // 3rd Method 
        //----------------------

        /// <summary>
        /// Returns a randomly generated int
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            // Declare and Initilize
            int num1 = 0, num2 = 0, sum = 0;
            // Get the random numbers
            // C# provides a Random class to generate random numbers.
            // Instantiate random number generator create an object called rand
            // Syntax -> ClassName object/variable name = new ClassName();
            Random rand = new Random();
            // Within the Random class there are several methods that have access modifier set to Public that we can use
            // One of those methods is Next(int min, int max) that returns random number >= 1 and < 101
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            // Generate the sum and return it.
            // Break this out to multiple lines so it is easier to understand.
            sum = num1 + num2;
            return sum;
        }
         
        //----------------------
        // 4th Method 
        //----------------------

        /// <summary>
        /// Return bool true or false if the sum of the ints are divisible by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            // Find the sum
            int sum = num1 + num2 + num3;
            // Is the sum divisible by 2
            if (sum % 2 == 0)
            {
                return true;
            }
            // If the sum is not divisible by 2
            // return false
            return false;
        }

        //----------------------
        // 5th Method 
        //----------------------

        /// <summary>
        /// Write a method that takes two strings and displays the
        /// string that has the fewer letters with descriptive text.
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            // Declare and Initialize
            int countChar1 = 0, countChar2 = 0, pointer = 0;

            // Iterate through the strings using a do while loop
            // exit loop when both strings have been fully iterated through
            do
            {
                // string1 -> Try and test if the char being pointed to is a letter
                try
                {
                    if (char.IsLetter(string1[pointer]))
                    {
                        countChar1++;
                    }
                }
                catch (Exception) { }

                // string2 -> Try and test if the char being pointed to is a letter
                try
                {
                    if (char.IsLetter(string2[pointer]))
                    {
                        countChar2++;
                    }
                }
                catch (Exception) { }

                pointer++;
            }
            while ((pointer < string1.Length) || (pointer < string2.Length));

            // Compare and display result
            if (countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters", false);
            }
            else if (countChar2 < countChar1)
            {
                DisplayResults("Method 5: string 2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: Both strings have the same number of letters", false);
            }
        }

        //----------------------
        // 6th Method 
        //----------------------

        /// <summary>
        /// Write a method that takes an array of doubles and returns the largest value in the array.
        /// </summary>
        /// <param name="arrDoubles"></param>
        /// <returns></returns>
        private double LargestDouble(double[] arrDoubles)
        {
            // Declare and Initialize
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;
            // Iterate through array using while loop
            while (arrPointer < arrDoubles.Length)
            {
                // Read double from array at index of pointer
                valueAtIndex = arrDoubles[arrPointer];

                // Now test the double against biggestDouble
                // if the value we just read is larger than value
                // in biggestDouble - replace with valueAtIndex
                if (valueAtIndex > biggestDouble)
                {
                    // We just found a larger double
                    biggestDouble = valueAtIndex;
                }
                // Inc the pointer so it points to the next index.
                arrPointer++;
                // show how arrDoubles [arrPointer++] would do same
            }
            // All done so return the biggest double
            return biggestDouble;
        }

        //----------------------
        // 7th Method 
        //----------------------

        /// <summary>
        /// Generates and returns an array of 10 random integers. Also displays them.
        /// </summary>
        /// <returns></returns>
        private int[] GenerateIntArray()
        {
            int[] intArray = new int[10];
            Random rand = new Random();
            StringBuilder sb = new StringBuilder("Method 7: Generated Integer Array: ");

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rand.Next(1, 101); // Random int between 1 and 100
                sb.Append(intArray[i] + " ");
            }

            DisplayResults(sb.ToString(), false);
            return intArray;
        }

        //----------------------
        // 8th Method 
        //----------------------

        /// <summary>
        /// Compares two boolean values and returns true if they are the same.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        private bool CompareBooleans(bool val1, bool val2)
        {
            bool result = (val1 == val2);
            DisplayResults($"Method 8: Are both booleans the same? {result}", false);
            return result;
        }

        //----------------------
        // 9th Method 
        //----------------------

        /// <summary>
        /// Takes an int and a double and returns their product.
        /// </summary>
        /// <param name="intVal"></param>
        /// <param name="doubleVal"></param>
        /// <returns></returns>
        private double MultiplyIntAndDouble(int intVal, double doubleVal)
        {
            double product = intVal * doubleVal;
            DisplayResults($"Method 9: Product of {intVal} and {doubleVal} is {product}", false);
            return product;
        }
    }
}
