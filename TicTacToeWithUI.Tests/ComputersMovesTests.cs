using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TicTacTieWithUI.Tests
{
    [TestClass]
    public class ComputersMovesTests
    {
        //checkForOpenSpace tests
        [TestMethod]
        public void checkForOpenSpace_noOpenSpace()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForOpenSpace();
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForOpenSpace_oneOpenSpace()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            Button b = ticTacToeMainForm.checkForOpenSpace();
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 2]);
        }
        [TestMethod]
        public void checkForOpenSpace_manyOpenSpaces()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            Button b = ticTacToeMainForm.checkForOpenSpace();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 0]);
        }

        //checkForCorners tests
        [TestMethod]
        public void checkForCorners_noCorners()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForCorners();
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForCorners_oneCorner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForCorners();
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }
        [TestMethod]
        public void checkForCorners_manyCorners()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForCorners();
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }

        //checkForWin tests for player X
        [TestMethod]
        public void checkForWin_noWinInCaseOfADrawForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForWin_noWinMiddleOfAGameForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForWin_WinHorizontalForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b,ticTacToeMainForm.Board[0,2 ]);
        }
        [TestMethod]
        public void checkForWin_WinVerticalForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }
        [TestMethod]
        public void checkForWin_WinPrimaryDiagonalForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 2]);
        }
        [TestMethod]
        public void checkForWin_WinSecondaryDiagonalForX()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            Button b = ticTacToeMainForm.checkForWin("X");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }

        //checkForWin tests for player O
        [TestMethod]
        public void checkForWin_noWinInCaseOfADrawForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForWin_noWinMiddleOfAGameForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, null);
        }
        [TestMethod]
        public void checkForWin_WinHorizontalForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 0]);
        }
        [TestMethod]
        public void checkForWin_WinVerticalForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 1]);
        }
        [TestMethod]
        public void checkForWin_WinPrimaryDiagonalForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "O";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 2]);
        }
        [TestMethod]
        public void checkForWin_WinSecondaryDiagonalForO()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 2].Text = "O";
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            Button b = ticTacToeMainForm.checkForWin("O");
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }

        //checkForSpecialCases tests
        //in case of a Draw
        [TestMethod]
        public void checkForSpecialCases_NoSpecialCasesInCaseOfADraw()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[0, 1].Text = "O";
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "X";
            ticTacToeMainForm.Board[1, 2].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "O";
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[2, 2].Text = "O";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, null);
        }

        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXInCorner()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 1]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXIn2Corners()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[2, 2].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 0]);
        }

        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXInMidRow()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 1].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 1]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXInMidColumn()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[1, 0].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 1]);
        }

        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXFormingLAtRightTop()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[1, 2].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[0, 2]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXFormingLAtLeftTop()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 1].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[0, 0]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXFormingLAtRightBottom()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[1, 2].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 2]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXFormingLAtLeftBottom()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[2, 1].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[1, 0].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[2, 0]);
        }

        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXAtPrimaryDiagonal()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 0].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[2, 2].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 0]);
        }
        [TestMethod]
        public void checkForSpecialCases_SpecialCasesXAtSecondaryDiagonal()
        {
            TicTacToeMainForm ticTacToeMainForm = new TicTacToeMainForm();
            ticTacToeMainForm.Board[0, 2].Text = "X";
            ticTacToeMainForm.Board[1, 1].Text = "O";
            ticTacToeMainForm.Board[2, 0].Text = "X";
            Button b = ticTacToeMainForm.checkForSpecialCases();
            Assert.AreEqual(b, ticTacToeMainForm.Board[1, 0]);
        }


    }
}
