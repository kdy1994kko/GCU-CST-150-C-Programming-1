/*
 * Kevvan D. Young
 * CST-150
 * T6 Activity 6
 * 6/30/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 470). Pearson. ISBN-13: 9780138087562
*/

namespace CST_150_TicTacToe.PresentationLayer
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
            this.Box00 = new System.Windows.Forms.PictureBox();
            this.Box01 = new System.Windows.Forms.PictureBox();
            this.Box02 = new System.Windows.Forms.PictureBox();
            this.Box10 = new System.Windows.Forms.PictureBox();
            this.Box11 = new System.Windows.Forms.PictureBox();
            this.Box12 = new System.Windows.Forms.PictureBox();
            this.Box20 = new System.Windows.Forms.PictureBox();
            this.Box21 = new System.Windows.Forms.PictureBox();
            this.Box22 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box22)).BeginInit();
            this.SuspendLayout();
            // 
            // Box00
            // 
            this.Box00.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box00.Location = new System.Drawing.Point(92, 50);
            this.Box00.Name = "Box00";
            this.Box00.Size = new System.Drawing.Size(125, 125);
            this.Box00.TabIndex = 0;
            this.Box00.TabStop = false;
            // 
            // Box01
            // 
            this.Box01.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box01.Location = new System.Drawing.Point(223, 50);
            this.Box01.Name = "Box01";
            this.Box01.Size = new System.Drawing.Size(125, 125);
            this.Box01.TabIndex = 1;
            this.Box01.TabStop = false;
            // 
            // Box02
            // 
            this.Box02.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box02.Location = new System.Drawing.Point(354, 50);
            this.Box02.Name = "Box02";
            this.Box02.Size = new System.Drawing.Size(125, 125);
            this.Box02.TabIndex = 2;
            this.Box02.TabStop = false;
            // 
            // Box10
            // 
            this.Box10.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box10.Location = new System.Drawing.Point(92, 181);
            this.Box10.Name = "Box10";
            this.Box10.Size = new System.Drawing.Size(125, 125);
            this.Box10.TabIndex = 3;
            this.Box10.TabStop = false;
            // 
            // Box11
            // 
            this.Box11.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box11.Location = new System.Drawing.Point(223, 181);
            this.Box11.Name = "Box11";
            this.Box11.Size = new System.Drawing.Size(125, 125);
            this.Box11.TabIndex = 4;
            this.Box11.TabStop = false;
            // 
            // Box12
            // 
            this.Box12.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box12.Location = new System.Drawing.Point(354, 181);
            this.Box12.Name = "Box12";
            this.Box12.Size = new System.Drawing.Size(125, 125);
            this.Box12.TabIndex = 5;
            this.Box12.TabStop = false;
            // 
            // Box20
            // 
            this.Box20.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box20.Location = new System.Drawing.Point(92, 312);
            this.Box20.Name = "Box20";
            this.Box20.Size = new System.Drawing.Size(125, 125);
            this.Box20.TabIndex = 6;
            this.Box20.TabStop = false;
            // 
            // Box21
            // 
            this.Box21.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box21.Location = new System.Drawing.Point(223, 312);
            this.Box21.Name = "Box21";
            this.Box21.Size = new System.Drawing.Size(125, 125);
            this.Box21.TabIndex = 7;
            this.Box21.TabStop = false;
            // 
            // Box22
            // 
            this.Box22.Image = global::CST_150_TicTacToe.Properties.Resources.White_Space;
            this.Box22.Location = new System.Drawing.Point(354, 312);
            this.Box22.Name = "Box22";
            this.Box22.Size = new System.Drawing.Size(125, 125);
            this.Box22.TabIndex = 8;
            this.Box22.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(132, 463);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(119, 33);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGameClickEvent);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(316, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitClickEvent);
            // 
            // lbl00
            // 
            this.lbl00.AutoSize = true;
            this.lbl00.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl00.Location = new System.Drawing.Point(120, 81);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(0, 67);
            this.lbl00.TabIndex = 11;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl01.Location = new System.Drawing.Point(251, 81);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(0, 67);
            this.lbl01.TabIndex = 12;
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl02.Location = new System.Drawing.Point(385, 81);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(0, 67);
            this.lbl02.TabIndex = 13;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl10.Location = new System.Drawing.Point(120, 210);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(0, 67);
            this.lbl10.TabIndex = 14;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl11.Location = new System.Drawing.Point(251, 210);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(0, 67);
            this.lbl11.TabIndex = 15;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl12.Location = new System.Drawing.Point(385, 210);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(0, 67);
            this.lbl12.TabIndex = 16;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl20.Location = new System.Drawing.Point(120, 341);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(0, 67);
            this.lbl20.TabIndex = 17;
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl21.Location = new System.Drawing.Point(251, 341);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(0, 67);
            this.lbl21.TabIndex = 18;
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl22.Location = new System.Drawing.Point(385, 341);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(0, 67);
            this.lbl22.TabIndex = 19;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl00);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.Box22);
            this.Controls.Add(this.Box21);
            this.Controls.Add(this.Box20);
            this.Controls.Add(this.Box12);
            this.Controls.Add(this.Box11);
            this.Controls.Add(this.Box10);
            this.Controls.Add(this.Box02);
            this.Controls.Add(this.Box01);
            this.Controls.Add(this.Box00);
            this.Name = "FrmMain";
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.Box00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box00;
        private System.Windows.Forms.PictureBox Box01;
        private System.Windows.Forms.PictureBox Box02;
        private System.Windows.Forms.PictureBox Box10;
        private System.Windows.Forms.PictureBox Box11;
        private System.Windows.Forms.PictureBox Box12;
        private System.Windows.Forms.PictureBox Box20;
        private System.Windows.Forms.PictureBox Box21;
        private System.Windows.Forms.PictureBox Box22;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
    }
}