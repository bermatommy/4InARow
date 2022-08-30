using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4InARow
{
    public partial class SettingsForm2 : Form
    {
        public int brdVal;
        public int butVal;  
        public GameBoard gameBoard;
        public Settings settings;
        public int counter = 1;

        /// <summary>
        /// reset the board acording to settings
        /// </summary>
        /// <param name="settings">  board size, button size </param>
        public SettingsForm2(Settings settings)
        {
            InitializeComponent();
            Init(settings);
        }

        /// <summary>
        /// get the board size and button size
        /// </summary>
        /// <param name="settings"> use acording to settings </param>
        public void Init(Settings settings)
        {
            this.settings = settings;
            tb_buttonSize.Text = settings.GetButtonSize().ToString(); // text in tb
            tb_boardSize.Text = settings.GetBoardSize().ToString(); // text in tb
        }

        /// <summary>
        /// if pressed, it reset the gameboard
        /// </summary>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            brdVal = settings.GetBoardSize();
            butVal = settings.GetButtonSize();
            this.Dispose();
            this.Dispose();
            settings.SetButtonSize(butVal);
            settings.SetBoardSize(brdVal);
            gameBoard = new GameBoard(settings, this);
            gameBoard.Show();
        }

        /// <summary>
        /// when form is loaded , it hides the form (for the 2nd run and above)
        /// </summary>
        private void SettingsForm2_Load(object sender, EventArgs e)
        {
            if (gameBoard != null)
                gameBoard.Hide();
        }

        /// <summary>
        /// check that the board size the button size are ok, create a board acording to the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            int.TryParse(tb_buttonSize.Text, out butVal);
            if (butVal < 50 || butVal > 75)
            {
                check = false;
            }

            int.TryParse(tb_boardSize.Text, out brdVal);
            if (brdVal < 6 || brdVal > 8)
                check = false;


            if (!check) // check that the size of all is in the range
            {
                return;
            }

            settings.SetBoardSize(butVal);
            settings.SetBoardSize(brdVal);

            if (gameBoard == null)
            {
                if (counter == 1)
                {
                    counter++;
                    this.Hide();
                }
                gameBoard = new GameBoard(settings, this);
                gameBoard.Init(settings);
                this.Hide();
                gameBoard.Show();
            }
            else
            {
                if (counter == 1)
                {
                    counter++;
                    this.Hide();
                }
                gameBoard = new GameBoard(settings, this);
                gameBoard.Init(settings);
                this.Hide();
                gameBoard.Show();
            }
        }
    }
}
