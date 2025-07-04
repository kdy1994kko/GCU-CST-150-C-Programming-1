
namespace God_s_Will_John_3._15_18_DnD
{
    partial class JesusChristIsGod
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
            this.lblSin = new System.Windows.Forms.Label();
            this.boxMessage = new System.Windows.Forms.ListBox();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSin
            // 
            this.lblSin.AutoSize = true;
            this.lblSin.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lblSin.ForeColor = System.Drawing.Color.Red;
            this.lblSin.Location = new System.Drawing.Point(25, 28);
            this.lblSin.Name = "lblSin";
            this.lblSin.Size = new System.Drawing.Size(408, 51);
            this.lblSin.TabIndex = 0;
            this.lblSin.Text = "Current Sin Score:";
            // 
            // boxMessage
            // 
            this.boxMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMessage.FormattingEnabled = true;
            this.boxMessage.ItemHeight = 23;
            this.boxMessage.Location = new System.Drawing.Point(34, 101);
            this.boxMessage.Name = "boxMessage";
            this.boxMessage.Size = new System.Drawing.Size(784, 234);
            this.boxMessage.TabIndex = 1;
            // 
            // BtnRoll
            // 
            this.BtnRoll.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnRoll.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoll.Location = new System.Drawing.Point(34, 370);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(138, 43);
            this.BtnRoll.TabIndex = 2;
            this.BtnRoll.Text = "Roll";
            this.BtnRoll.UseVisualStyleBackColor = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRollClickEvent);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAccept.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Location = new System.Drawing.Point(336, 370);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(169, 43);
            this.BtnAccept.TabIndex = 3;
            this.BtnAccept.Text = "Accept Jesus";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAcceptClickEvent);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Red;
            this.BtnQuit.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuit.Location = new System.Drawing.Point(680, 370);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(138, 43);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuitClickEvent);
            // 
            // JesusChristIsGod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 543);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.boxMessage);
            this.Controls.Add(this.lblSin);
            this.Name = "JesusChristIsGod";
            this.Text = "John 3:15-18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSin;
        private System.Windows.Forms.ListBox boxMessage;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnQuit;
    }
}

