/*
 * Kevvan D. Young
 * CST-150
 * T6 Activity 6
 * 6/30/2025
 * Gaddis, T. (2023). Starting out with Visual C# (6th ed., p. 470). Pearson. ISBN-13: 9780138087562
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_TicTacToe.BusinessLayer
{
    // Class that handles the core logic of the Tic Tac Toe game
    public class TicTacToe
    {
        // 2D array representing the game board (3x3)
        private int[,] board;

        // Board size is fixed at 3 (3x3 grid)
        private readonly int size = 3;

        // Constructor: Initializes the board and resets it
        public TicTacToe()
        {
            board = new int[size, size];
            ResetBoard();
        }

        // Resets the board by filling every cell with -1 (indicates empty)
        public void ResetBoard()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    board[i, j] = -1; // -1 indicates empty
        }

        // Fills the board with random values of 0 or 1, then stops if a winner is found
        public void FillRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = rand.Next(0, 2); // Assigns 0 or 1 randomly
                    if (CheckWinner() != -1) return; // Stop if there's already a winner
                }
            }
        }

        // Returns the current state of the game board
        public int[,] GetBoard()
        {
            return board;
        }

        // Checks for a winner:
        // Returns 0 (O) or 1 (X) if there's a winner,
        // -1 if the game is still ongoing,
        // 2 if the board is full and it's a tie
        public int CheckWinner()
        {
            // Check each row and column for a winning line
            for (int i = 0; i < size; i++)
            {
                // Check rows
                if (board[i, 0] != -1 && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];

                // Check columns
                if (board[0, i] != -1 && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            // Check diagonals
            if (board[0, 0] != -1 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];

            if (board[0, 2] != -1 && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            // Check if any cell is still empty (-1)
            foreach (int val in board)
                if (val == -1)
                    return -1; // Game still in progress

            // If no winner and no empty cells, it's a tie
            return 2;
        }
    }
}

