using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Project
{
    public partial class Form1 : Form
    {
        // Checks whether X or O turn
        Boolean Checker;

        // Checks how many turns it is
        int Turn_Count = 0;

        // Score for each player
        int X_score = 0;
        int O_score = 0;

        // Game over buttons cannot be pressed
        void Game_End()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        // Indicate who's turn it is
        void Turn()
        {
            if (Checker == false)
            {
                TurnIndicator.Text = "X Turn!";
            }
            else
            {
                TurnIndicator.Text = "O Turn!";
            }
        }
        // Win Conditions
        void Win()
        {
            bool Xwinner = false;
            bool Owinner = false;

            // X conditions
            if (
            button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
            button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
            button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
            button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
            button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
            button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
                Xwinner = true;

            // O conditions
            else if (
            button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
            button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
            button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
            button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
            button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
            button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
                Owinner = true;

            // Checks if there is a winner else it is draw
            if (Xwinner)
            {
                X_score++;
                LabelX.Text = Convert.ToString(X_score);
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }
            if (Owinner)
            {
                O_score++;
                LabelO.Text = Convert.ToString(O_score);
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }
            if (Xwinner == false && Owinner == false && Turn_Count == 8)
            {
                MessageBox.Show("It's a Draw! ", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        // Restart the game
        void Play_again()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            Turn_Count = 0;
        }

        public Form1()
        {
            InitializeComponent();
            Turn();
        }

        // Button Clicks
        private void button1_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button1.Text = "X";
                Checker = true;
            }
            else
            {
                button1.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button2.Text = "X";
                Checker = true;
            }
            else
            {
                button2.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button3.Text = "X";
                Checker = true;
            }
            else
            {
                button3.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button4.Text = "X";
                Checker = true;
            }
            else
            {
                button4.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button5.Text = "X";
                Checker = true;
            }
            else
            {
                button5.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button6.Text = "X";
                Checker = true;
            }
            else
            {
                button6.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button7.Text = "X";
                Checker = true;
            }
            else
            {
                button7.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button8.Text = "X";
                Checker = true;
            }
            else
            {
                button8.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                button9.Text = "X";
                Checker = true;
            }
            else
            {
                button9.Text = "O";
                Checker = false;
            }
            Turn();
            Win();
            Turn_Count++;
            button9.Enabled = false;
        }

        // Restart the Game
        private void restart_Click(object sender, EventArgs e)
        {
            Play_again();
        }

        // New Game
        private void new_game_Click(object sender, EventArgs e)
        {
            Play_again();
            X_score = 0;
            O_score = 0;

            LabelX.Text = "0";
            LabelO.Text = "0";
        }
    }
}