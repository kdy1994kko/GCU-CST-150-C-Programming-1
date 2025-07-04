/*
 * Kevvan D. Young
 * CST-150
 * T5 Activity 5
 * 6/23/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 825). Pearson. ISBN-13: 9780138087562
*/

namespace CST_150_DogClass.PresentationLayer
{
    partial class FrmMain
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
            this.btnAddDog = new System.Windows.Forms.Button();
            this.lblDogName = new System.Windows.Forms.Label();
            this.lblNeckRadius = new System.Windows.Forms.Label();
            this.lblSitting = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.cmbSit = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNeck = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.grbAttributes = new System.Windows.Forms.GroupBox();
            this.lblPounds = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.gvShowDogs = new System.Windows.Forms.DataGridView();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.grbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDog
            // 
            this.btnAddDog.AutoSize = true;
            this.btnAddDog.Location = new System.Drawing.Point(63, 47);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(142, 33);
            this.btnAddDog.TabIndex = 0;
            this.btnAddDog.Text = "Add New Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_ClickEvent);
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(17, 49);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(103, 23);
            this.lblDogName.TabIndex = 2;
            this.lblDogName.Text = "Dog Name";
            // 
            // lblNeckRadius
            // 
            this.lblNeckRadius.AutoSize = true;
            this.lblNeckRadius.Location = new System.Drawing.Point(5, 98);
            this.lblNeckRadius.Name = "lblNeckRadius";
            this.lblNeckRadius.Size = new System.Drawing.Size(120, 23);
            this.lblNeckRadius.TabIndex = 3;
            this.lblNeckRadius.Text = "Neck Radius";
            // 
            // lblSitting
            // 
            this.lblSitting.AutoSize = true;
            this.lblSitting.Location = new System.Drawing.Point(56, 143);
            this.lblSitting.Name = "lblSitting";
            this.lblSitting.Size = new System.Drawing.Size(64, 23);
            this.lblSitting.TabIndex = 4;
            this.lblSitting.Text = "Sitting";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(63, 189);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(57, 23);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(257, 95);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(65, 23);
            this.lblInches.TabIndex = 6;
            this.lblInches.Text = "inches";
            // 
            // cmbSit
            // 
            this.cmbSit.FormattingEnabled = true;
            this.cmbSit.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cmbSit.Location = new System.Drawing.Point(126, 143);
            this.cmbSit.Name = "cmbSit";
            this.cmbSit.Size = new System.Drawing.Size(125, 31);
            this.cmbSit.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 30);
            this.txtName.TabIndex = 8;
            // 
            // txtNeck
            // 
            this.txtNeck.Location = new System.Drawing.Point(126, 95);
            this.txtNeck.Name = "txtNeck";
            this.txtNeck.Size = new System.Drawing.Size(125, 30);
            this.txtNeck.TabIndex = 9;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(126, 189);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(125, 30);
            this.txtColor.TabIndex = 10;
            // 
            // grbAttributes
            // 
            this.grbAttributes.Controls.Add(this.lblPounds);
            this.grbAttributes.Controls.Add(this.txtWeight);
            this.grbAttributes.Controls.Add(this.lblWeight);
            this.grbAttributes.Controls.Add(this.lblDogName);
            this.grbAttributes.Controls.Add(this.txtColor);
            this.grbAttributes.Controls.Add(this.lblNeckRadius);
            this.grbAttributes.Controls.Add(this.txtNeck);
            this.grbAttributes.Controls.Add(this.lblSitting);
            this.grbAttributes.Controls.Add(this.txtName);
            this.grbAttributes.Controls.Add(this.lblColor);
            this.grbAttributes.Controls.Add(this.cmbSit);
            this.grbAttributes.Controls.Add(this.lblInches);
            this.grbAttributes.Location = new System.Drawing.Point(63, 97);
            this.grbAttributes.Name = "grbAttributes";
            this.grbAttributes.Size = new System.Drawing.Size(336, 299);
            this.grbAttributes.TabIndex = 11;
            this.grbAttributes.TabStop = false;
            this.grbAttributes.Text = "Dog Attributes";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(257, 236);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(73, 23);
            this.lblPounds.TabIndex = 13;
            this.lblPounds.Text = "pounds";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(126, 233);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(125, 30);
            this.txtWeight.TabIndex = 12;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(49, 233);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(71, 23);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "Weight";
            // 
            // gvShowDogs
            // 
            this.gvShowDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowDogs.Location = new System.Drawing.Point(439, 97);
            this.gvShowDogs.Name = "gvShowDogs";
            this.gvShowDogs.RowHeadersWidth = 51;
            this.gvShowDogs.RowTemplate.Height = 29;
            this.gvShowDogs.Size = new System.Drawing.Size(626, 299);
            this.gvShowDogs.TabIndex = 12;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(63, 399);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(470, 23);
            this.lblErrorMessage.TabIndex = 13;
            this.lblErrorMessage.Text = "Please fix the incorrect data entry…Then try again…";
            this.lblErrorMessage.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 518);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.gvShowDogs);
            this.Controls.Add(this.grbAttributes);
            this.Controls.Add(this.btnAddDog);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMainLoadEventHandler);
            this.grbAttributes.ResumeLayout(false);
            this.grbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.Label lblNeckRadius;
        private System.Windows.Forms.Label lblSitting;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.ComboBox cmbSit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNeck;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox grbAttributes;
        private System.Windows.Forms.DataGridView gvShowDogs;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}