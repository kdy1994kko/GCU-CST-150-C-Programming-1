/*
 * Kevvan D. Young
 * CST-150
 * T3 Activity 3
 * 6/9/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 319). Pearson. ISBN-13: 9780138087562
*/

namespace CST_150_Activity_3
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectRow = new System.Windows.Forms.Label();
            this.cmbSelectRow = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.BackColor = System.Drawing.Color.ForestGreen;
            this.ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.ReadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.ReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReadFile.Location = new System.Drawing.Point(336, 35);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(137, 48);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Read File";
            this.ReadFile.UseVisualStyleBackColor = false;
            this.ReadFile.Click += new System.EventHandler(this.BtnReadFileClickEvent);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedFile.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSelectedFile.Location = new System.Drawing.Point(12, 360);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(776, 81);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.Text = "Selected File";
            this.lblSelectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResults.Location = new System.Drawing.Point(124, 170);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(93, 20);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Results";
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.FileName = "selectFileDialog";
            // 
            // lblSelectRow
            // 
            this.lblSelectRow.AutoSize = true;
            this.lblSelectRow.Location = new System.Drawing.Point(124, 35);
            this.lblSelectRow.Name = "lblSelectRow";
            this.lblSelectRow.Size = new System.Drawing.Size(82, 20);
            this.lblSelectRow.TabIndex = 3;
            this.lblSelectRow.Text = "Select Row";
            // 
            // cmbSelectRow
            // 
            this.cmbSelectRow.FormattingEnabled = true;
            this.cmbSelectRow.Location = new System.Drawing.Point(124, 58);
            this.cmbSelectRow.Name = "cmbSelectRow";
            this.cmbSelectRow.Size = new System.Drawing.Size(93, 28);
            this.cmbSelectRow.TabIndex = 4;
            this.cmbSelectRow.DropDownClosed += new System.EventHandler(this.SelectRowToInc);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSelectRow);
            this.Controls.Add(this.lblSelectRow);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.ReadFile);
            this.Name = "FrmMain";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.Label lblSelectRow;
        private System.Windows.Forms.ComboBox cmbSelectRow;
    }
}

