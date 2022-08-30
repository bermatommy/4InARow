using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4InARow
{
    public class InARow
    {
        public char[,] boardVal;
        private string player1;
        private string player2;
        private int size;
        public bool whoIsPlaying; /// true --> blue, false   --> red
        private bool gameOver;
        public string winner;
        private int scoreToWin;
        private GameBoard gameBoard;

        /// <summary>
        /// Init all the variables
        /// </summary>
        /// <param name="size"> give size the the board </param>
        /// <param name="gameBoard"> gets a variable from the same type </param>
        public InARow(int size, GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
            this.size = size;
            this.boardVal = new char[this.size, this.size];
            this.player1 = "";
            this.player2 = "";
            this.whoIsPlaying = true;
            this.winner = "";
            this.scoreToWin = 4;
            for (int i = 0; i < boardVal.GetLength(0); i++)
            {
                for (int j = 0; j < boardVal.GetLength(1); j++)
                {
                    this.boardVal[i, j] = '@';
                }
            }
        }

        /// <summary>
        /// get name of player1
        /// </summary>
        /// <returns> name of player1(string) </returns>
        public string GetPlayer1()
        {
            return this.player1;
        }

        /// <summary>
        /// get name of player2
        /// </summary>
        /// <returns> name of player2(string) </returns>
        public string GetPlayer2()
        {
            return this.player2;
        }

        /// <summary>
        /// set the name of player1
        /// </summary>
        /// <param name="player1"> set the name to the name the function got </param>
        public void SetPlayer1(string player1)
        {
            this.player1 = player1;
        }

        /// <summary>
        /// set the name of player2
        /// </summary>
        /// <param name="player2"> set the name to the name the function got </param>
        public void SetPlayer2(string player2)
        {
            this.player2 = player2;
        }

        /// <summary>
        /// say who is playing
        /// </summary>
        /// <returns> who is playing(string) </returns>
        public string NowPlaying()
        {
            if (whoIsPlaying)
                return this.player1;
            else
                return this.player2;
        }

        /// <summary>
        /// get the color of the player
        /// </summary>
        /// <returns> color of the button(char - R or B) </returns>
        public char GetColor()
        {
            if (whoIsPlaying)
                return 'R';
            else
                return 'B';
        }

        /// <summary>
        /// change turn
        /// </summary>
        public void ChangeTurn()
        {
            whoIsPlaying = !whoIsPlaying;
        }

        /// <summary>
        /// declare winner
        /// </summary>
        /// <returns> the winner(string) </returns>
        public string Winner()
        {
            return this.winner;
        }

        /// <summary>
        /// check the rows and cols to check if theres a winner (true or false)
        /// check if the same color is scoreToWin times in a row (4 times)
        /// </summary>
        /// <returns> true or false </returns>
        public bool CheckWinRC()
        {
            bool win = false;
            int counterA = 0, counterB = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(boardVal[i,j] == GetColor())
                    {
                        counterA++;
                        if (counterA == scoreToWin)
                            win = true;
                    }
                    else
                        counterA = 0;
                    if (boardVal[j, i] == GetColor())
                    {
                        counterB++;
                        if (counterB == scoreToWin)
                            win = true;
                    }
                    else
                        counterB = 0;
                }
            }
            return win;
        }

        /// <summary>
        /// check a win for a diagonal, the first part check from upper left to lower right
        /// the second part check from lower left to upper right
        /// </summary>
        /// <returns> true or false </returns>
        public bool CheckDiagonals()
        {
            bool win = false, win1 = false, win2 = false;
            int counterA = 0, limit = size + 1 - scoreToWin;
            // check upper left to lower right
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    if (boardVal[i, j] == GetColor())
                    {
                        counterA++;
                        for (int k = 1; k < scoreToWin; k++)
                        {
                            if (boardVal[i + k, j + k] == GetColor())
                            {
                                counterA++;
                                if (counterA == scoreToWin)
                                    win = true;
                            }
                        }
                    }
                    else
                        counterA = 0;
                }
            }

            //check lower left to upper right
            counterA = 0;
            for (int i = size - 1; i > scoreToWin; i--)
            {
                for (int j = 0; j < limit; j++)
                {
                    if (boardVal[i, j] == GetColor())
                    {
                        counterA++;
                        for (int k = 1; k < scoreToWin; k++)
                        {
                            if (boardVal[i - k, j + k] == GetColor())
                            {
                                counterA++;

                                if (counterA == scoreToWin)
                                    win1 = true;
                            }
                        }
                    }
                    else
                        counterA = 0;
                }
            }
            if (win || win1)
                win2 = true;
            return win2;
        }


        /// <summary>
        /// check if the player can click the button
        /// </summary>
        /// <param name="col"> user decide what col to place a chip(red or blue) </param>
        /// <returns> array </returns>
        public int[] Move(int col)
        {
            int[] arr = new int[2];
            arr[0] = 0;
            arr[1] = size;
            int found = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                if(boardVal[i,col] == '@' && found == 0)
                {
                    boardVal[i, col] = GetColor();
                    arr[0] = 1;
                    arr[1] = i;
                    found = 1;
                }

            }
            return arr;
        }

        /// <summary>
        /// check if the same color is scoreToWin(4) times in a row
        /// </summary>
        /// <param name="a"> size of board </param>
        /// <param name="b"> size of board </param>
        /// <param name="color"> check the color that got entered </param>
        /// <returns> true or false </returns>
        public bool CheckRB(int a, int b, char color)
        {
            int counter = 0;
            if (whoIsPlaying)
                color = 'R';
            else
                color = 'B';
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if(boardVal[i,j] == color)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if(counter == scoreToWin)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// check if theres a tie
        /// </summary>
        /// <returns> true or false </returns>
        public bool CheckTie()
        {
            int counter = 0;
            bool a = false;
            for (int i = size - 1; i >= 0; i--)
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    if (boardVal[i, j] == '@')
                        counter++;
                }
            }
            if(counter == 0)
                a = true;
            return a;
        }

        /// <summary>
        /// check if one of the 3 is true
        /// if one of them is true theres a win
        /// </summary>
        /// <returns> true or false </returns>
        public bool CheckGameOver()
        {
            bool a = false;
            if(CheckWinRC() || CheckTie() || CheckDiagonals())
                a = true;
            return a;
        }
    }
}
