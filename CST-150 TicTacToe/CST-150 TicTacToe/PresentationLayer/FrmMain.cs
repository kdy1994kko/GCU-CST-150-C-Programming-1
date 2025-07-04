/*
 * Kevvan D. Young
 * CST-150
 * T6 Activity 6
 * 6/30/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 470). Pearson. ISBN-13: 9780138087562
*/

using CST_150_TicTacToe.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_TicTacToe.PresentationLayer
{
    // Main form class for the Tic Tac Toe game
    public partial class FrmMain : Form
    {
        // Instance of the game logic class
        private TicTacToe game;

        // 2D array to hold references to the label controls representing the game board
        private Label[,] labels;

        // Constructor initializes the form, the game object, and links the labels to the board
        public FrmMain()
        {
            InitializeComponent(); // Initializes the form controls

            game = new TicTacToe(); // Creates a new TicTacToe game instance

            // Associates each label control with a specific cell in the 3x3 board
            labels = new Label[3, 3]
            {
                { lbl00, lbl01, lbl02 },
                { lbl10, lbl11, lbl12 },
                { lbl20, lbl21, lbl22 }
            };
        }

        // Event handler for the New Game button click
        private void btnNewGameClickEvent(object sender, EventArgs e)
        {
            game.ResetBoard();      // Resets the board to its initial state
            game.FillRandom();      // Randomly fills the board (likely simulating a completed game)
            UpdateLabels();         // Updates the UI labels to reflect the current board state

            // Checks the result of the game and shows the appropriate message
            int winner = game.CheckWinner();
            if (winner == 0)
                MessageBox.Show("Player O wins!");
            else if (winner == 1)
                MessageBox.Show("Player X wins!");
            else if (winner == 2)
                MessageBox.Show("The game is a tie!");
        }

        // Event handler for the Exit button click
        private void btnExitClickEvent(object sender, EventArgs e)
        {
            Application.Exit(); // Exits the application
        }

        // Updates the text of the labels based on the current game board
        private void UpdateLabels()
        {
            int[,] board = game.GetBoard(); // Retrieves the current state of the board

            // Loop through each cell and set the label text accordingly
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                        labels[i, j].Text = "O"; // 0 represents Player O
                    else if (board[i, j] == 1)
                        labels[i, j].Text = "X"; // 1 represents Player X
                    else
                        labels[i, j].Text = "";  // Any other value means the cell is empty
                }
            }
        }
    }
}

