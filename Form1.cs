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

        // Tells Who's Turn it is
        void turn()
        {
            if (Checker == false)
            {
                label3.Text = "X Turn!";
            }
            else
            {
                label3.Text = "O Turn!";
            }
        }

        // Win Conditions
        void Win()
        {
            // Conditions for X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            // Conditions for O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O WON!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Game_End();
            }

            if (Turn_Count == 8)
            {
                MessageBox.Show("It's a Draw! Restart the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public Form1()
        {
            InitializeComponent();

            if (Checker == false)
            {
                label3.Text = "X Turn!";
            }
            else
            {
                label3.Text = "O Turn!";
            }
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
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
            Win();
            turn();
            Turn_Count++;
            button9.Enabled = false;
        }

        // Restart the Game
        private void restart_Click(object sender, EventArgs e)
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
    }
}
