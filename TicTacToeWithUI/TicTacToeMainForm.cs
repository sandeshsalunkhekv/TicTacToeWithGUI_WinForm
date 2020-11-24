using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTieWithUI
{
    public partial class TicTacToeMainForm : Form
    {
        #region Parameters
        public bool turn = true;   //true -> X, false -> O
        public int numberOfTurns = 0;
        public bool isWinner = false;
        public bool isDraw = false;
        public bool isAgainstComputer = false;

        public static string player1, player2;
        public Button[,] Board = null;
        #endregion

        public TicTacToeMainForm()
        {
            InitializeComponent();
            Board = new Button[3, 3] { {A1, A2, A3 },
                                       {B1, B2, B3 },
                                       {C1, C2, C3 } };
        }

        public static void setPlayerNames(string name1, string name2)
        {
            player1 = name1;
            player2 = name2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "By Sandesh Salunkhe, visit my profile @ https://www.linkedin.com/in/sandydecoder by clicking on Help",
                "About Tic Tac Toe",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                0,
                "https://www.linkedin.com/in/sandydecoder"
            );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Button checkForOpenSpace()
        {
            //traverse entire board for open or unvisited spaces and return the first such space encountered
            foreach(Button button in Board)
            {
                if (button.Text == "") return button;
            }
            return null;
        }
        
        public Button checkForCorners()
        {
            //check for all corners one by one and prioritize the opposite corner selection
            //O  __ __    __ __ O     __ __ __    __ __ __
            //__ __ __ or __ __ __ or __ __ __ or __ __ __
            //__ __ __    __ __ __    __ __ O     O  __ __
            if (A1.Text == "O")
            {
                if (C3.Text == "") return C3;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }
            else if (A3.Text == "O")
            {
                if (C1.Text == "") return C1;
                if (A1.Text == "") return A1;
                if (C3.Text == "") return C3;
            }
            else if (C1.Text == "O")
            {
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
                if (A1.Text == "") return A1;
            }
            else if (C3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (C1.Text == "") return C1;
                if (A3.Text == "") return A3;
            }

            //if no such situation encountered, go for any of the unvisited corners
            else if (A1.Text == "") return A1;
            else if (A3.Text == "") return A3;
            else if (C1.Text == "") return C1;
            else if (C3.Text == "") return C3;

            //otherwise return null
            return null;
        }

        public Button checkForWin(string moveToPerform)
        {
            //checks for horizontal win possibility
            //X  X  __    __ __ __    __ __ __              O  O   __    __ __ __    __ __ __
            //__ __ __ or X  X  __ or __ __ __      or      __ __  __ or O  O  __ or __ __ __
            //__ __ __    __ __ __    X  X  __              __ __  __    __ __ __    O  O  __
            //then go for the desired move
            //i.e., if it is your turn (O), go for a Winning move to get 3 consecutive Os in a row
            //or else, block Player 1 from Winning by blocking the 3rd empty position for X by O
            if (A1.Text == moveToPerform && A2.Text == moveToPerform && A3.Text == "")
                return A3;
            if (A3.Text == moveToPerform && A2.Text == moveToPerform && A1.Text == "")
                return A1;
            if (A3.Text == moveToPerform && A1.Text == moveToPerform && A2.Text == "")
                return A2;

            if (B1.Text == moveToPerform && B2.Text == moveToPerform && B3.Text == "")
                return B3;
            if (B3.Text == moveToPerform && B2.Text == moveToPerform && B1.Text == "")
                return B1;
            if (B3.Text == moveToPerform && B1.Text == moveToPerform && B2.Text == "")
                return B2;

            if (C1.Text == moveToPerform && C2.Text == moveToPerform && C3.Text == "")
                return C3;
            if (C3.Text == moveToPerform && C2.Text == moveToPerform && C1.Text == "")
                return C1;
            if (C3.Text == moveToPerform && C1.Text == moveToPerform && C2.Text == "")
                return C2;

            //checks for vertical win possibilities
            //X  __ __    __ X  __    __ __ X               O  __  __    __ O  __    __ __ O 
            //X  __ __ or __ X  __ or __ __ X       or      O  __  __ or __ O  __ or __ __ O 
            //X  __ __    __ X  __    __ __ X               O  __  __    __ O  __    __ __ O 
            //then go for the desired move
            //i.e., if it is your turn (O), go for a Winning move to get 3 consecutive Os in a column
            //or else, block Player 1 from Winning by blocking the 3rd empty position for X by O
            if (A1.Text == moveToPerform && B1.Text == moveToPerform && C1.Text == "")
                return C1;
            if (A1.Text == moveToPerform && C1.Text == moveToPerform && B1.Text == "")
                return B1;
            if (B1.Text == moveToPerform && C1.Text == moveToPerform && A1.Text == "")
                return A1;

            if (A2.Text == moveToPerform && B2.Text == moveToPerform && C2.Text == "")
                return C2;
            if (A2.Text == moveToPerform && C2.Text == moveToPerform && B2.Text == "")
                return B2;
            if (B2.Text == moveToPerform && C2.Text == moveToPerform && A2.Text == "")
                return A2;

            if (A3.Text == moveToPerform && B3.Text == moveToPerform && C3.Text == "")
                return C3;
            if (A3.Text == moveToPerform && C3.Text == moveToPerform && B3.Text == "")
                return B3;
            if (B3.Text == moveToPerform && C3.Text == moveToPerform && A3.Text == "")
                return A3;

            //checks for diagonal win possibilities
            //X  __ __    __ __ X               O  __ __    __ __ O 
            //__ X  __ or __ X  __      or      __ O  __ or __ O  __
            //__ __ X     X  __ __              __ __ O     O  __ __
            //then go for the desired move
            //i.e., if it is your turn (O), go for a Winning move to get 3 consecutive Os in a diagonal
            //or else, block Player 1 from Winning by blocking the 3rd empty position for X by O
            if (A1.Text == moveToPerform && B2.Text == moveToPerform && C3.Text == "")
                return C3;
            if (A1.Text == moveToPerform && C3.Text == moveToPerform && B2.Text == "")
                return B2;
            if (B2.Text == moveToPerform && C3.Text == moveToPerform && A1.Text == "")
                return A1;

            if (A3.Text == moveToPerform && B2.Text == moveToPerform && C1.Text == "")
                return C1;
            if (A3.Text == moveToPerform && C1.Text == moveToPerform && B2.Text == "")
                return B2;
            if (B2.Text == moveToPerform && C1.Text == moveToPerform && A3.Text == "")
                return A3;

            //otherwise return null
            return null;
        }

        public Button checkForSpecialCases()
        {
            //if any corner is occupied by Player 1 (X), go for center (if unvisited)
            //X  __ __    __ __ __    __ __ __    __ __ X              __ __ __
            //__ __ __ or __ __ __ or __ __ __ or __ __ __ then go for __ :: __     positions in order to avoid the
            //__ __ __    X  __ __    __ __ X     __ __ __             __ __ __     diagnoal case even before it takes shape
            if ((A1.Text == "X" && A2.Text == "" && A3.Text == "" && B1.Text == "" && B3.Text == "" && C1.Text == "" && C2.Text == "" && C3.Text == "")
              || (A1.Text == "" && A2.Text == "" && A3.Text == "X" && B1.Text == "" && B3.Text == "" && C1.Text == "" && C2.Text == "" && C3.Text == "")
              || (A1.Text == "" && A2.Text == "" && A3.Text == "" && B1.Text == "" && B3.Text == "" && C1.Text == "X" && C2.Text == "" && C3.Text == "")
              || (A1.Text == "" && A2.Text == "" && A3.Text == "" && B1.Text == "" && B3.Text == "" && C1.Text == "" && C2.Text == "" && C3.Text == "X"))
            {
                if (B2.Text == "") return B2;
            }

            //if any 2 opposite corners occupied by Player 1 (X) and the center occupied by O,
            //go for middle of outer rows or columns
            //X  __ __    __ __ X              __ :: __
            //__ O  __ or __ O  __ then go for :: __ ::     positions in order to block the L shape
            //__ __ X     X  __ __             __ :: __     the Player 1 (X) is planning to form
            else if (A1.Text == "X" && C3.Text == "X" && B2.Text == "O")
            {
                if (B1.Text == "") return B1;
                if (C2.Text == "") return C2;
                if (A2.Text == "") return A2;
                if (B3.Text == "") return B3;
            }
            else if (A3.Text == "X" && C1.Text == "X" && B2.Text == "O")
            {
                if (B1.Text == "") return B1;
                if (C2.Text == "") return C2;
                if (A2.Text == "") return A2;
                if (B3.Text == "") return B3;
            }

            //if 2 diagnoally adjacent (not lying on the diagonal) are marked X by Player 1,
            //block the corner in common to the row and column
            //__ X  __    __ X  __    __ __ __    __ __ __             :: __ ::     positions in order to block
            //X  __ __ or __ __ X  or __ __ X  or X  __ __ then go for __ :: __     the small L shape the Player 1 (X) is planning
            //__ __ __    __ __ __    __ X  __    __ X  __             :: __ ::     to form at the corner place(s)
            else if (A2.Text == "X" && B3.Text == "X")
            {
                if (A3.Text == "") return A3;
                if (B2.Text == "") return B2;
            }
            else if (C2.Text == "X" && B1.Text == "X")
            {
                if (C1.Text == "") return C1;
                if (B2.Text == "") return B2;
            }
            else if (C2.Text == "X" && B3.Text == "X")
            {
                if (C3.Text == "") return C3;
                if (B2.Text == "") return B2;
            }
            else if (A2.Text == "X" && B1.Text == "X")
            {
                if (A1.Text == "") return A1;
                if (B2.Text == "") return B2;
            }

            //if any of the non-central row/column's mid is marked as X by Player 1,
            //mark center of the tic tac toe board as visited with O or
            //mark any of the central row or central column's element as visited with O
            //to prevent the inverse-L that Player 1 is planning to form at middle of tic tac toe board
            //__ X  __    __ __ __    __ __ __    __ __ __             __ :: __
            //__ __ __ or __ __ X  or __ __ __ or X  __ __ then go for :: :: ::
            //__ __ __    __ __ __    __ X  __    __ __ __             __ :: __
            else if (A2.Text == "X" || C2.Text == "X")
            {
                if (B2.Text == "") return B2;
                if (B1.Text == "") return B1;
                if (B3.Text == "") return B3;
            }
            else if (B1.Text == "X" || B3.Text == "X")
            {
                if (B2.Text == "") return B2;
                if (A2.Text == "") return A2;
                if (C2.Text == "") return C2;
            }
            
            //otherwise return null
            return null;
        }

        public void computerPerformsMove()
        {
            Button computerMove = checkForWin("O");
            if (computerMove == null)
            {
                computerMove = checkForWin("X");
                if (computerMove == null)
                {
                    computerMove = checkForSpecialCases();
                    if(computerMove == null)
                    {
                        computerMove = checkForCorners();
                        if (computerMove == null)
                        {
                            computerMove = checkForOpenSpace();
                            if (computerMove == null)
                            {
                                MessageBox.Show("Computer cannot perform any Move!");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
            computerMove.BackColor = Color.Green;
            computerMove.PerformClick();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.ForeColor = Color.White;
                if (turn)
                {
                    button.Text = "X";
                    whoseTurn.Text = player2 + "'s Turn";
                }
                else
                {
                    button.Text = "O";
                    whoseTurn.Text = player1 + "'s Turn";
                }
                button.Enabled = false;
                numberOfTurns += 1;
                checkWinner();
                if (!isWinner && !isDraw)
                    turn = !turn;
                else if (isDraw || isWinner)
                    startNewGame();
                if (!turn && isAgainstComputer)
                    computerPerformsMove();
            }
        }
        
        public void checkWinner()
        {
            string winnerName = "";
            if (
                   (A1.Text == A2.Text && A2.Text == A3.Text && !string.IsNullOrEmpty(A1.Text))
                || (B1.Text == B2.Text && B2.Text == B3.Text && !string.IsNullOrEmpty(B1.Text))
                || (C1.Text == C2.Text && C2.Text == C3.Text && !string.IsNullOrEmpty(C1.Text))
                //diagonal checks
                || (A1.Text == B2.Text && B2.Text == C3.Text && !string.IsNullOrEmpty(A1.Text))
                || (C1.Text == B2.Text && B2.Text == A3.Text && !string.IsNullOrEmpty(C1.Text))
                //vertical checks on columns
                || (A1.Text == B1.Text && B1.Text == C1.Text && !string.IsNullOrEmpty(A1.Text))
                || (A2.Text == B2.Text && B2.Text == C2.Text && !string.IsNullOrEmpty(A2.Text))
                || (A3.Text == B3.Text && B3.Text == C3.Text && !string.IsNullOrEmpty(A3.Text))
                )
            {
                isWinner = true;
                if (
                       (A1.Text == A2.Text && A2.Text == A3.Text && !string.IsNullOrEmpty(A1.Text))
                    || (A1.Text == B2.Text && B2.Text == C3.Text && !string.IsNullOrEmpty(A1.Text))
                    || (A1.Text == B1.Text && B1.Text == C1.Text && !string.IsNullOrEmpty(A1.Text))
                    )
                    winnerName = A1.Text == "X"? player1:player2;
                else if (
                       (B1.Text == B2.Text && B2.Text == B3.Text && !string.IsNullOrEmpty(B1.Text))
                    || (C1.Text == B2.Text && B2.Text == A3.Text && !string.IsNullOrEmpty(C1.Text))
                    || (A2.Text == B2.Text && B2.Text == C2.Text && !string.IsNullOrEmpty(A2.Text))
                    )
                    winnerName = B2.Text == "X" ? player1 : player2;
                else if (
                       (C1.Text == C2.Text && C2.Text == C3.Text && !string.IsNullOrEmpty(C1.Text))
                    || (A3.Text == B3.Text && B3.Text == C3.Text && !string.IsNullOrEmpty(A3.Text))
                    )
                    winnerName = C3.Text == "X" ? player1 : player2;
            }
            if(isWinner)
            {
                //if (turn)
                {
                    MessageBox.Show("Player " + winnerName + " Won!", "Winner!");
                    Player1WinsCount.Text = Convert.ToString(Int32.Parse(Player1WinsCount.Text) + 1);
                }
                //else
                { 
                    //MessageBox.Show("Player " + winnerName + " Won!", "Winner!");
                    //Player2WinsCount.Text = Convert.ToString(Int32.Parse(Player2WinsCount.Text) + 1);
                }
                disableButtons();
                //Application.Exit();
            }
            else if(numberOfTurns == 9)
            {
                MessageBox.Show("This Game ended in a DRAW!", "DRAW!");
                TotalDrawsCount.Text = Convert.ToString(Int32.Parse(TotalDrawsCount.Text) + 1);
                isDraw = true;
                //Application.Exit();
            }
        }
        
        private void startNewGame()
        {
            turn = true;
            numberOfTurns = 0;
            
            foreach (Control control in Controls)
                try
                {
                    Button button = (Button)control;
                    if (button.Name != "switchGameMode")
                    {
                        button.Text = "";
                        button.Enabled = true;
                        button.BackColor = Color.White;
                        button.ForeColor = Color.White;
                    }
                    isWinner = false;
                    whoseTurn.Text = player1 + "'s Turn";
                    isDraw = false;
                }
                catch
                {

                }
        }
        
        public void disableButtons()
        {
            foreach (Button button in Board)
                button.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled && button.Name != "switchGameMode")
            {
                button.ForeColor = Color.White;
                if (turn)
                {
                    button.Text = "X";
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.Text = "O";
                    button.BackColor = Color.Green;
                }
            }
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
                button.BackColor = Color.White;
            }
        }

        private void resetScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player1WinsCount.Text = "0";
            Player2WinsCount.Text = "0";
            TotalDrawsCount.Text = "0";
            startNewGame();
        }
        
        private void switchGameMode_Click(object sender, EventArgs e)
        {
            if (!isAgainstComputer)
            {
                switchGameMode.Text = "Switch to Player VS Player";
                isAgainstComputer = true;
                Player2Wins.Text = player2 = "Computer";
                switchGameMode.ForeColor = Color.Red;
                switchGameMode.BackColor = Color.LightBlue;
                this.Text = "Tic Tac Toe (Player VS Computer Mode)";
                resetScoresToolStripMenuItem.PerformClick();
            }
            else
            {
                isAgainstComputer = false;
                AcceptPlayerNames acceptPlayerNames = new AcceptPlayerNames();
                acceptPlayerNames.ShowDialog();
                if (!string.IsNullOrEmpty(player1) && player1 != "X")
                    Player1Wins.Text = player1;
                else
                    Player1Wins.Text = player1 = "X";

                if ((!string.IsNullOrEmpty(player2) && player2 == "Computer") || string.IsNullOrEmpty(player2))
                    Player2Wins.Text = player2 = "O";
                else if (!string.IsNullOrEmpty(player2))
                    Player2Wins.Text = player2;

                switchGameMode.Text = "Switch to Player VS Computer";
                Player2Wins.Text = player2;
                switchGameMode.ForeColor = Color.Blue;
                switchGameMode.BackColor = Color.Yellow;
                this.Text = "Tic Tac Toe (Player VS Player Mode)";
                resetScoresToolStripMenuItem.PerformClick();
            }
        }

        private void TicTacToeForm1_Load(object sender, EventArgs e)
        {
            Introduction introduction = new Introduction();
            introduction.ShowDialog();
            RulesForTicTacToe rulesForTicTacToe = new RulesForTicTacToe();
            rulesForTicTacToe.ShowDialog();
            TicTacToeLauncherForm form2 = new TicTacToeLauncherForm();
            form2.ShowDialog();
            
            if (!string.IsNullOrEmpty(player1))
                Player1Wins.Text = player1;
            else
                player1 = "X";

            if (!string.IsNullOrEmpty(player2))
            {
                Player2Wins.Text = player2;
                switchGameMode.ForeColor = Color.Blue;
                switchGameMode.BackColor = Color.Yellow;
                this.Text = "Tic Tac Toe (Player VS Player Mode)";
            }
            else
            {
                player2 = Player2Wins.Text = "Computer";
                isAgainstComputer = true;
                switchGameMode.ForeColor = Color.Red;
                switchGameMode.BackColor = Color.LightBlue;
                switchGameMode.Text = "Switch to Player VS Player";
                this.Text = "Tic Tac Toe (Player VS Computer Mode)";
            }
            if (isAgainstComputer)
            {
                MessageBox.Show("You are now playing against the COMPUTER!");
            }
            startNewGame();
        }
    }
}
