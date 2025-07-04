
namespace CST_150_Milestone_6.PresentationLayer
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
            this.gvInventory = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lblManually = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // gvInventory
            // 
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Location = new System.Drawing.Point(112, 99);
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.RowHeadersWidth = 51;
            this.gvInventory.RowTemplate.Height = 29;
            this.gvInventory.Size = new System.Drawing.Size(798, 282);
            this.gvInventory.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDisplay.Location = new System.Drawing.Point(12, 100);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_ClickEvent);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(12, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_ClickEvent);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_ClickEvent);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.Orange;
            this.btnIncrement.Location = new System.Drawing.Point(12, 295);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(94, 29);
            this.btnIncrement.TabIndex = 4;
            this.btnIncrement.Text = "Inc Qty++";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_ClickEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 66);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(125, 27);
            this.txtDescription.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(243, 66);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 27);
            this.txtType.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(770, 66);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(140, 27);
            this.txtCost.TabIndex = 11;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(374, 66);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(125, 27);
            this.txtSize.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(505, 66);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(125, 27);
            this.txtColor.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(636, 66);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 10;
            // 
            // btnDecrement
            // 
            this.btnDecrement.BackColor = System.Drawing.Color.Yellow;
            this.btnDecrement.Location = new System.Drawing.Point(12, 353);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(94, 29);
            this.btnDecrement.TabIndex = 12;
            this.btnDecrement.Text = "Dec Qty --";
            this.btnDecrement.UseVisualStyleBackColor = false;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_ClickEvent);
            // 
            // lblManually
            // 
            this.lblManually.AutoSize = true;
            this.lblManually.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManually.Location = new System.Drawing.Point(13, 71);
            this.lblManually.Name = "lblManually";
            this.lblManually.Size = new System.Drawing.Size(93, 17);
            this.lblManually.TabIndex = 13;
            this.lblManually.Text = "Manually Input";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(112, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(243, 43);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(374, 43);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 20);
            this.lblSize.TabIndex = 16;
            this.lblSize.Text = "Size";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(505, 43);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 20);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(636, 43);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(770, 43);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 20);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Cost";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 538);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblManually);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.gvInventory);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvInventory;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblManually;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCost;
    }
}