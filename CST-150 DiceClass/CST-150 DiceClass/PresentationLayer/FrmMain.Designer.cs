
namespace CST_150_DiceClass.PresentationLayer
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(272, 80);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(94, 29);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_ClickEvent);
            // 
            // picDie1
            // 
            this.picDie1.Location = new System.Drawing.Point(87, 146);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(194, 193);
            this.picDie1.TabIndex = 3;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.Location = new System.Drawing.Point(358, 146);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(193, 190);
            this.picDie2.TabIndex = 4;
            this.picDie2.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Controls.Add(this.btnRoll);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie2;
    }
}