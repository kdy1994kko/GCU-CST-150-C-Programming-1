/*
 * Kevvan D. Young
 * CST-150
 * T1 Activity 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 21). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
