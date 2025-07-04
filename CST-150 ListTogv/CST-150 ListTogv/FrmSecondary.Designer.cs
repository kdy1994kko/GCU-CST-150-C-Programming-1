/*
 * Kevvan D. Young
 * CST-150
 * T7 Activity 7
 * 7/7/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 641). Pearson. ISBN-13: 9780138087562
*/

namespace CST_150_ListTogv
{
    partial class FrmSecondary
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
            this.gvSearchResults = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSearchResults
            // 
            this.gvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResults.Location = new System.Drawing.Point(88, 93);
            this.gvSearchResults.Name = "gvSearchResults";
            this.gvSearchResults.RowHeadersWidth = 51;
            this.gvSearchResults.RowTemplate.Height = 29;
            this.gvSearchResults.Size = new System.Drawing.Size(606, 188);
            this.gvSearchResults.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(88, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_ClickEvent);
            // 
            // FrmSecondary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gvSearchResults);
            this.Name = "FrmSecondary";
            this.Text = "FrmSecondary";
            this.Load += new System.EventHandler(this.FrmLoad_EventHandler);
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSearchResults;
        private System.Windows.Forms.Button btnClose;
    }
}