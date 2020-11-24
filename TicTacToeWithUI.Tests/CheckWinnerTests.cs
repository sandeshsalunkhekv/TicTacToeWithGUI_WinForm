using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicTacTieWithUI.Tests
{
    [TestClass]
    public class CheckWinnerTests
    {
        [TestMethod]
        public void Start_noWinner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.checkWinner();
            Assert.AreEqual(ticTacToeMainForm.isWinner, false);
        }
        [TestMethod]
        public void Only2Rounds_noWinner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "0";
            ticTacToeMainForm.checkWinner();
            Assert.AreEqual(ticTacToeMainForm.isWinner, false);
        }
        [TestMethod]
        public void Player1Wins_Winner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            TicTacToeMainForm.player1 = "X";
            TicTacToeMainForm.player2 = "O";
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.checkWinner();
            Assert.AreEqual(ticTacToeMainForm.isWinner, true);
        }
        [TestMethod]
        public void Player2Wins_Winner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            TicTacToeMainForm.player1 = "X";
            TicTacToeMainForm.player2 = "O";
            ticTacToeMainForm.Board[0, 0].Text = "O";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "O";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.checkWinner();
            Assert.AreEqual(ticTacToeMainForm.isWinner, true);
        }
        [TestMethod]
        public void Draw_Winner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            TicTacToeMainForm.player1 = "X";
            TicTacToeMainForm.player2 = "O";
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            ticTacToeMainForm.checkWinner();
            ticTacToeMainForm.numberOfTurns = 9;
            Assert.AreEqual(ticTacToeMainForm.isDraw, false);
        }
    }
}
