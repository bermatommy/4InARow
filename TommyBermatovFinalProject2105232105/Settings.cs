using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4InARow
{

    /// <summary>
    /// default values to the variables
    /// </summary>
    public class Settings
    {
        private int boardSize = 6; /// default board size
        private int buttonSize = 75; /// size of buttons
        private string name1; /// name of player1
        private string name2; /// name of player2

        /// <summary>
        /// get the board size
        /// </summary>
        /// <returns> board size(int) </returns>
        public int GetBoardSize()
        {
            return this.boardSize;
        }

        /// <summary>
        /// get button size
        /// </summary>
        /// <returns> button size(int) </returns>
        public int GetButtonSize()
        {
            return this.buttonSize;
        }

        /// <summary>
        /// get the name of the player
        /// </summary>
        /// <returns> name(string) </returns>
        public string GetName1()
        {
            return this.name1;
        }

        /// <summary>
        /// get the name of the player
        /// </summary>
        /// <returns> name(string) </returns>
        public string GetName2()
        {
            return this.name2;
        }

        /// <summary>
        /// change the boardsize acording to the size that was given
        /// </summary>
        /// <param name="boardSize"> new value to the board size </param>
        public void SetBoardSize(int boardSize)
        {
            this.boardSize = boardSize;
        }

        /// <summary>
        /// change the boardsize acording to the size that was given
        /// </summary>
        /// <param name="buttonSize"> new value to the buttonsize </param>
        public void SetButtonSize(int buttonSize)
        {
            this.buttonSize = buttonSize;
        }

        /// <summary>
        /// set the name acording to the size that was given
        /// </summary>
        /// <param name="name1"> new name </param>
        public void SetName1(string name1)
        {
            this.name1 = name1;
        }

        /// <summary>
        /// set the name acording to the size that was given
        /// </summary>
        /// <param name="name2"> new name </param>
        public void SetName2(string name2)
        {
            this.name2 = name2;
        }
    }
}
