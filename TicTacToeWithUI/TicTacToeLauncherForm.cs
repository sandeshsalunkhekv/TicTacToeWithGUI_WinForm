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
    public partial class TicTacToeLauncherForm : Form
    {
        bool checkedForBothPlayers = false;
        public TicTacToeLauncherForm()
        {
            InitializeComponent();
        }

        void performThisIfPlayerDetailsNotEnteredProperly()
        {
            string message = "You did not enter Name(s) for:";

            if (string.IsNullOrEmpty(Player1Name.Text) && string.IsNullOrEmpty(Player2Name.Text))
            {
                if (string.IsNullOrEmpty(Player2Name.Text))
                    message += " Player 1 & Player 2, so going with default names (X for Player 1 and Computer for Player 2).";
                else
                    message += " Player 1 & Player 2, so going with default names (X for Player 1 and O for Player 2).";
            }

            else if (string.IsNullOrEmpty(Player1Name.Text))
                message += " Player 1, so going with default name (X for Player 1)";
            else if (string.IsNullOrEmpty(Player2Name.Text))
                message += " Player 2, so going with a Player Versus Computer Game!";

            MessageBox.Show(message);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
           if ((string.IsNullOrEmpty(Player1Name.Text) || string.IsNullOrEmpty(Player2Name.Text)) && !checkedForBothPlayers)
                performThisIfPlayerDetailsNotEnteredProperly();
            TicTacToeMainForm.setPlayerNames(Player1Name.Text, Player2Name.Text);
            this.Close();
        }

        private void PlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                if (string.IsNullOrEmpty(Player1Name.Text) || string.IsNullOrEmpty(Player2Name.Text) && !checkedForBothPlayers)
                {
                    performThisIfPlayerDetailsNotEnteredProperly();
                    checkedForBothPlayers = true;
                }
                PlayButton.PerformClick();
            }
        }
    }
}
