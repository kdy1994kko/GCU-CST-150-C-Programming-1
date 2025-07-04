/*
 * Kevvan D. Young
 * CST-150
 * T1 Activity 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 21). Pearson. ISBN-13: 9780138087562
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

namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {   
        // Constructor for the Form1 class, initializes the form components
        public Form1()
        {   
            InitializeComponent();
        }

        // Event handler for button1 click event
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for label1 click event
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for Form1's Load event
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Create an event handler for the click here button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            label1.Text = "Kevvan D. Young";
        }
    }
}
