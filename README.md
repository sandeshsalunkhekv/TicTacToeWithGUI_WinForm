<img src="TicTacToeWithUI/logos/tictactoe_1_low_resolution.jpg"
     alt="Tic-Tac-Toe icon"
     style="float: left; margin-right: 10px;" />
<br />
**Challenge Name and Description :- Tic-Tac-Toe game - implement the game with the user interface of your choice. Should include human vs human and human vs machine mode.**

# Solution:
------------
**NOTE:**
Assumptions:
* X gets to play the first Move, and in case of Player VS Computer, Player gets to play first move followed By Computer who will mark all its moves by O.
* Players will input only their first names, and none of the player names will be "Computer", as we have used it for player 2 while programming it for Player VS Computer Mode.
* At your end, you also work on latest framework, or at least at .NET Framework 4.5+, as this project is developed on .NET Framework 4.7.2.
------------
## I. Talking About the UI:
------------
Created a C# Project(.NET Framework 4.7.2) for the above problem, with the User Interface being implemented using Windows Forms (Winforms).
As a part of the solution, there are 5 forms in all, namely - Introduction, RulesForTicTacToe, TicTacToeLauncherForm, TicTacToeMainForm, & AcceptPlayerNames.
* Introduction - Here, we give a brief introduction about the Tic-Tac-Toe game.
* RulesForTicTacToe - Here, we state all the rulesand basic scenarios of playing the Tic-Tac-Toe game.
* TicTacToeLauncherForm - Here, we ask user to input the names for both the Players and if not entered player 1 name, the game will default it to X (keep the Player 2 blank if he/she wants to play against computer).
* TicTacToeMainForm - Here, the real game begins. We have 9 Buttons for the Game-Board, a Menu Strip that has 2 sub-menu strips (Game, Help). In Game Sub-Menu Strip, we have options - New Game, Reset Scores and Exit.
	In Help, we just show About, where a MessageBox is launched with reference to Sandesh Salunkhe's (i.e. me) LinkedIn Profile.
        Then there is a button showing "Switch to Player VS Player" or "Switch to Player VS Computer" as the text.
	If you are playing in Player VS Computer Mode, then on click, you will be asked for player names through AcceptPlayerNames form and the text will change to Switch to Player VS Computer.
        If you are playing in Player VS Player Mode, then on click, the game will switch to Player VS Computer Mode and the text will change to Switch to Player VS Player.
	On the TicTacToeMainForm, there are labels that show whose turn it is, how many games each player won and how many were draws (tie in a game), which gets updated after each game ends.
* AcceptPlayerNames - Here, similar to TicTacToeLauncherForm, we have the text input fields for player 1 and player 2 names, but if you don't enter anything into either these text fields, default names for player 1 and player 2 (i.e., X and O respectively) will be chosen.
------------
## II. Talking About the Thought-Process:
------------
In Player VS Player Mode, it is simple and straight forward, the turn switches after each player makes a move and before switching, we check for a winner. If there are consecutive 3 Xs or Os in a row, a column or in any of the diagonals, then we consider it as a win, and display a message that "Player X Won!" or ""Player O Won!" depending upon who has won, and if total number of moves for that game is equal to 9 and still noone has won, it's a draw and display a message that states "This Game ended in a DRAW!".
In Player VS Computer Mode, there is an Algorithm known as MiniMax Algorithm, which checks for the current state of the board, goes on to the end points where all the board elements will be filled for all the possible moves and return a score depending upon who wins for that particular move to the previous level. This helps us to analyze the current as well as future scenarios that might be occuring depending upon player's moves if he/she plays optimally (i.e., tries to win the game, or draw).
The MiniMax Algorithm is a very time-expensive algorithm, and the time complexity is too much, so I have modified the approach a little bit, and have my own way of approaching to solve this problem, which is discussed below.
The approach has been divided into 5 steps:
* Check for A Win :-
	If computer is one move away from a win, then the next move computer needs to perform is just that desired move, so here we just check whether there are 2 consecutive Os in a row, column or any of the diagonals.
	If we encounter one, then we make a move by marking the third one as O if it has not been marked earlier.
* Block X's Win if it is to win:-
	We check the similar condition, but now this time we check whether X is one move away from a win or not.
	If so, we mark the third element as O if it is not marked earlier. This blocks X's Win!
* We check for Special Cases:- (the part of MiniMax which is simplified below)
1. If any of the corners occupied by X:	Try to return Centre of the Board if not marked earlier.
	

1. If Diagonally Opposite buttons marked as X and centre marked as O:	Try to return Mid-element of any of the outer Row/Column if not marked earlier.
If any 2 opposite corners occupied by Player 1 (X) and the center occupied by O, go for middle of outer rows or columns.

1. If one Mid-Row and adjacent Mid-Column marked as X: Try to return the adjacent common corner if not marked earlier otherwise try to return centre of the board if not marked earlier.
If 2 diagnoally adjacent (not lying on the diagonal) are marked X by Player 1, block the corner in common to the row and column.

1. If only one Mid-Row or Mid-Column is marked as X:Try to return centre of the board if not marked earlier, otherwise try to return any of the end-points of Mid-Column (if Mid-Row was marked as X) or Mid-Row (if Mid-Column was marked as X).
If any of the non-central row/column's mid is marked as X by Player 1, mark center of the tic tac toe board as visited with O or mark any of the central row or central column's element as visited with O to prevent the inverse-L that Player 1 is planning to form at middle of tic tac toe board.
1. Otherwise return null
* Check for Corners:-
If the computer has already marked any of the corners as O, then it checks for the next suitable corner which it can mark as O, prioritizing the Diagonally Opposite button, then the current Row opposite Corner and at the end current Column Opposite Corner, otherwise return the first available (not marked) corner.
* Check for any Open Space :-
If none of the above cases satisfy, then the computer will just choose first open or space available, and mark it as O.
------------
## III. Contents:
------------
This Submission consist of 2 projects - TicTacToeWithUI, and TicTacToeWithUI.Tests.
TicTacToeWithUI has the above mentioned files as discussed in Part I (Talking About the UI), and TicTacToeWithUI.Tests contains the Unit Tests built and run for all testable units (methods) for the TicTacToeWithUI Project.

------------
## IV. Test Cases considered:
------------
(Note: here, X1 refers to the action of setting 1st button on board with X and similar for all others)
* Human VS Human:
1. X1 -> O2 -> X3 -> O4 -> X5 -> O6 -> X7 -> Message - Player X Won!
1. X2 -> O1 -> X3 -> O5 -> X6 -> O9 -> Message - Player O Won!
1. X3 -> O2 -> X1 -> O5 -> X8 -> O6 -> X4 -> O7 -> X9 -> Message - The game ended in a DRAW!
1. X4 -> O2 -> X6 -> O5 -> X8 -> O1 -> X3 -> O9 -> Message - Player O Won!
1. X1 -> O5 -> X9 -> O3 -> X7 -> O8 -> X4 -> Message - Player X Won!
1. X5 -> O1 -> X7 -> O3 -> X2 -> O8 -> X4 -> O9 -> X6 -> Message - Player X Won!
1. X5 -> O1 -> X7 -> O3 -> X2 -> O8 -> X4 -> O6 -> X9 -> Message - The game ended in a DRAW!
1. X2 -> O1 -> X3 -> O7 -> X4 -> O9 -> O8 -> Player O Won!
* Human VS Computer/Machine:
1. X1 -> O5 -> X2 -> O3 -> X7 -> O4 -> X6 -> O9 -> X8 -> Message - The game ended in a DRAW!
1. X5 -> O1 -> X7 -> O3 -> X2 -> O8 -> X4 -> O6 -> X9 -> Message - The game ended in a DRAW!
1. X2 -> O5 -> X4 -> O1 -> X9 -> O3 -> X7 -> O8 -> X6 -> Message - The game ended in a DRAW!
1. X3 -> O5 -> X9 -> O6 -> X4 -> O2 -> X8 -> O7 -> X1 -> Message - The game ended in a DRAW!
1. X4 -> O5 -> X8 -> O7 -> X3 -> O9 -> X1 -> O2 -> X6 -> Message - The game ended in a DRAW!
1. X6 -> O5 -> X7 -> O2 -> X8 -> O9 -> X1 -> O4 -> X3 -> Message - The game ended in a DRAW!
1. X7 -> O5 -> X2 -> O4 -> X6 -> O3 -> X1 -> O9 -> X8 -> Message - The game ended in a DRAW!
1. X8 -> O5 -> X1 -> O4 -> X6 -> O9 -> X7 -> O3 -> X2 -> Message - The game ended in a DRAW!
1. X9 -> O5 -> X7 -> O8 -> X2 -> O4 -> X6 -> O3 -> X1 -> Message - The game ended in a DRAW!
1. X5 -> O1 -> X6 -> O4 -> X7 -> O3 -> X2 -> O8 -> X9 -> Message - The game ended in a DRAW!
1. X5 -> O1 -> X4 -> O6 -> X7 -> O3 -> X9 -> O2 -> Player Computer Won!
1. X3 -> O5 -> X4 -> O2 -> X1 -> O8 -> Player Computer Won!
1. No Test Cases where Human Wins From AI, Only Draws / Ties Possible for the project!
------------
## V. How to RUN:
------------
This project was developed on Visual Studio 2019 Version 16.8.2 (latest at the time of development), on .NET Framework 4.7.2 (latest at the time of development).
Steps:
1. Open VS 2019 (preferably).
1. Click on Open a Project or Solution
1. Navigate to the Solution Location
1. Select .sln file.
1. Open.
1. Move to next step if the Project TicTacToeWithUI is the Startup Project. Otherwise, once the Project Loads, set the Project TicTacToeWithUI as Startup Project by doing a right-click on the Project TicTacToeWithUI and clicking on "Set as Startup Project".
1. Press F5 or Click on Start. The game has launched.

-----------
Algorithmic and Understandability Reference of the **Human VS Computer** - [Play Tic-Tac-Toe](https://playtictactoe.org)
