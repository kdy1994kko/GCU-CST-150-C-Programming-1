
namespace CST_150_Methods
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
            this.lblResults = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(126, 177);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(85, 25);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results";
            // 
            // btnMain
            // 
            this.btnMain.AutoSize = true;
            this.btnMain.Location = new System.Drawing.Point(126, 88);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(193, 35);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Execute Methods";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnExecuteMethods);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 562);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblResults);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnMain;
    }
}

