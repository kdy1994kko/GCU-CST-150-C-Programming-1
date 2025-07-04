/*
 * Kevvan D. Young
 * CST-150
 * T1 Activity 1
 * 5/26/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 26). Pearson. ISBN-13: 9780138087562
*/

namespace CST_150_Activity_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEarth = new System.Windows.Forms.Label();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.lblMars = new System.Windows.Forms.Label();
            this.lblMarsWeight = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEarth.Location = new System.Drawing.Point(68, 98);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(244, 23);
            this.lblEarth.TabIndex = 0;
            this.lblEarth.Text = "Enter your weight on Earth";
            this.lblEarth.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(318, 98);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 22);
            this.txtEarthWeight.TabIndex = 1;
            this.txtEarthWeight.TextChanged += new System.EventHandler(this.txtEarthWeight_TextChanged);
            // 
            // lblMars
            // 
            this.lblMars.AutoSize = true;
            this.lblMars.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMars.Location = new System.Drawing.Point(96, 181);
            this.lblMars.Name = "lblMars";
            this.lblMars.Size = new System.Drawing.Size(191, 23);
            this.lblMars.TabIndex = 2;
            this.lblMars.Text = "Your weight on Mars";
            this.lblMars.Click += new System.EventHandler(this.lblMars_Click);
            // 
            // lblMarsWeight
            // 
            this.lblMarsWeight.AutoSize = true;
            this.lblMarsWeight.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMarsWeight.Location = new System.Drawing.Point(314, 181);
            this.lblMarsWeight.Name = "lblMarsWeight";
            this.lblMarsWeight.Size = new System.Drawing.Size(51, 23);
            this.lblMarsWeight.TabIndex = 3;
            this.lblMarsWeight.Text = "label";
            this.lblMarsWeight.Click += new System.EventHandler(this.lblMarsWeight_Click);
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Font = new System.Drawing.Font("Arial", 12F);
            this.lbs.Location = new System.Drawing.Point(424, 98);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(35, 23);
            this.lbs.TabIndex = 4;
            this.lbs.Text = "lbs";
            this.lbs.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Arial", 12F);
            this.btnConvert.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnConvert.Location = new System.Drawing.Point(318, 256);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 38);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.ConvertButtonClickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbs);
            this.Controls.Add(this.lblMarsWeight);
            this.Controls.Add(this.lblMars);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.lblEarth);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.Label lblMars;
        private System.Windows.Forms.Label lblMarsWeight;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Button btnConvert;
    }
}

