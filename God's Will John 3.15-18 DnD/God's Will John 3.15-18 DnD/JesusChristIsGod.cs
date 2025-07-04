using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace God_s_Will_John_3._15_18_DnD
{
    // This is the main form class for the Christian-themed dice game
    public partial class JesusChristIsGod : Form
    {
        // Random number generator for dice rolls
        private Random random = new Random();

        // Tracks the current "Sin Score"
        private int sinScore = 1;

        // Indicates if the player has won by accepting Jesus
        private bool isWinner = false;

        // Constructor: Initializes form and displays welcome messages
        public JesusChristIsGod()
        {
            InitializeComponent();
            UpdateSinLabel();
            ShowMessage("Welcome to 'John 3:15-18' - A Christian Dice Rolling Game!");
            ShowMessage("Click 'Roll' to roll the D20, 'Accept Jesus', or 'Quit'.");
        }

        // Event handler for the 'Roll' button click
        private void BtnRollClickEvent(object sender, EventArgs e)
        {
            // Prevent rolling if the game is already won or sin score is 100+
            if (isWinner || sinScore >= 100) return;
            RollD20();
        }

        // Event handler for the 'Accept Jesus' button click
        private void BtnAcceptClickEvent(object sender, EventArgs e)
        {
            AcceptJesus();
        }

        // Event handler for the 'Quit' button click
        private void BtnQuitClickEvent(object sender, EventArgs e)
        {
            ShowMessage("You chose to give up... Please reconsider accepting Jesus before it's too late.");
            ShowMessage("John 3:17: 'For God did not send his Son into the world to condemn the world, but to save the world through him.'");
            ShowMessage("John 3:18: 'Whoever believes in him is not condemned, but whoever does not believe stands condemned already. .");
            ShowMessage("because they have not believed in the name of God’s one and only Son.'");
            Application.Exit(); // Closes the application
        }

        // Rolls a 20-sided dice and processes the result
        private void RollD20()
        {
            int roll = random.Next(1, 21); // Roll a number between 1 and 20
            ShowMessage($"You rolled a D20: {roll}");

            // Instant win if a 20 is rolled
            if (roll == 20)
            {
                ShowMessage("You accepted Jesus Christ as your Lord and Savior!");
                isWinner = true;
                EndGameWin();
                return;
            }

            // Rolling a 1 automatically triggers acceptance
            if (roll == 1)
            {
                ShowMessage("You rolled a 1. It's time to repent and turn to Jesus Christ.");
                AcceptJesus();
                return;
            }

            // Add to sin score on certain odd-numbered rolls
            if (new[] { 19, 18, 17, 16, 15, 14, 13, 11, 9, 7, 5, 3, 2 }.Contains(roll))
            {
                sinScore += roll;
                ShowMessage($"Sin increased by {roll}. New Sin Score: {sinScore}");
            }
            else
            {
                // For even-numbered rolls, perform a saving throw
                switch (roll)
                {
                    case 12:
                    case 10:
                    case 8:
                    case 6:
                    case 4:
                        SavingThrow(roll);
                        break;
                    default:
                        ShowMessage("Nothing happened this turn.");
                        break;
                }
            }

            // End game if sin score reaches 100 or more
            if (sinScore >= 100)
            {
                ShowMessage("You reached a sin score of 100. Game Over.");
                ShowMessage("Before it's too late, turn to Jesus! Accept Him as your Lord and Savior.");
                ShowMessage("John 3:17: 'For God did not send his Son into the world to condemn the world, but to save the world through him.'");
                ShowMessage("John 3:18: 'Whoever believes in him is not condemned, but whoever does not believe stands condemned already. .");
                ShowMessage("because they have not believed in the name of God’s one and only Son.'");
            }

            UpdateSinLabel();
        }

        // Performs a saving throw that reduces the sin score
        private void SavingThrow(int dieSize)
        {
            int savingThrow = random.Next(1, dieSize + 1); // Roll a die of specified size
            sinScore -= savingThrow;
            if (sinScore <= 0) sinScore = 1; // Ensure sin score doesn't go below 1
            ShowMessage($"Saving throw D{dieSize} rolled: {savingThrow}. Sin reduced. New Sin Score: {sinScore}");
        }

        // Called when the user accepts Jesus; resets sin and declares victory
        private void AcceptJesus()
        {
            ShowMessage("You accepted Jesus Christ as God, King, your Lord and Savior!");
            ShowMessage("Your sins are forgiven. You are a winner through Christ.");
            sinScore = 0;
            isWinner = true;
            EndGameWin();
            UpdateSinLabel();
        } 

        // Displays winning messages and relevant scripture
        private void EndGameWin()
        {
            ShowMessage("Congratulations! You have eternal life through Jesus Christ!");
            ShowMessage("John 3:15: 'That whoever believes in Him should not perish but have eternal life.'");
            ShowMessage("John 3:16: 'For God so loved the world that he gave his one and only Son,");
            ShowMessage("that whoever believes in him shall not perish but have eternal life.'");
        }

        // Updates the label showing the current sin score
        private void UpdateSinLabel()
        {
            lblSin.Text = $"Current Sin Score: {sinScore}";
        }

        // Appends a message to the list box and scrolls to the latest entry
        private void ShowMessage(string message)
        {
            boxMessage.Items.Add(message);
            boxMessage.TopIndex = boxMessage.Items.Count - 1;
        }
    }
}