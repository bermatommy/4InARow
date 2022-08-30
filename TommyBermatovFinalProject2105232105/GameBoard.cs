using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _4InARow
{
    public partial class GameBoard : Form
    {
        SoundPlayer sound = new SoundPlayer(Properties.Resources.Tap);
        private InARow game;
        private Button[,] boardButton;
        private int space;
        private bool gameOver;
        private Settings settings;
        private Timer timer;
        private int timerCounter;
        private SettingsForm2 settingsForm2;
        public int counter;

        /// <summary>
        /// Init all the variables acording to the variables the function got
        /// </summary>
        /// <param name="settings"> set the info for the variables </param>
        /// <param name="settingsForm2"> set the info for the variables </param>
        public GameBoard(Settings settings, SettingsForm2 settingsForm2)
        {
            InitializeComponent();
            this.settingsForm2 = settingsForm2;
            this.counter = 1;
            this.settings = settings;
            Form names = new PlayerNames(settings);
            names.ShowDialog();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            Init();
        }

        /// <summary>
        /// show timer while playing
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            int seconds = timerCounter % 60;
            int minute = timerCounter / 60;
            lbl_Time.Text = $"{minute,2:00}:{seconds,2:00}";
        }
        
        /// <summary>
        /// build the board
        /// </summary>
        /// <returns> board(button) </returns>
        private Button[,] BuildBoard()
        {
            int size = settings.GetBoardSize();
            Button[,] board2 = new Button[size, size];
            for (int i = 0; i < board2.GetLength(0); i++)
            {
                for (int j = 0; j < board2.GetLength(1); j++)
                {
                    board2[i, j] = BuildButton(i, j);
                }
            }
            return board2;
        }

        /// <summary>
        /// design the button (size, space between each button, location)
        /// </summary>
        /// <param name="row" >row to put button </param>
        /// <param name="col"> column to put button </param>
        /// <returns> button </returns>
        private Button BuildButton(int row, int col)
        {
            Button b = new Button();
            int buttonSize = settings.GetButtonSize();
            b.Size = new Size(buttonSize, buttonSize);
            int x = col * (buttonSize + space);
            int y = row * (buttonSize + space);
            b.Location = new Point(x, y);
            b.Tag = new int[] { row, col };
            b.Click += button_click;
            pnlBoardCanvas.Controls.Add(b);
            return b;
        }

        /// <summary>
        /// play click sound, change turn, check the moves on the board
        /// check win, tie and reset the game
        /// </summary>
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!gameOver && b.Text == "")
            {
                sound.Play();
                game.ChangeTurn();
                int[] square = (int[])b.Tag;
                int row = square[0];
                int col = square[1];
                int[] arr1 = new int[2];
                arr1 = game.Move(col);
                boardButton[arr1[1], col].Text = game.boardVal[arr1[1], col].ToString();
                lbl_whoIsPlaying.Text = game.NowPlaying();
                if (boardButton[arr1[1], col].Text == "R")
                {
                    boardButton[arr1[1], col].BackColor = Color.Red;
                    boardButton[arr1[1], col].Text = game.GetColor().ToString();
                }
                else
                {
                    boardButton[arr1[1], col].BackColor = Color.Blue;
                    boardButton[arr1[1], col].Text = game.GetColor().ToString();
                }
                if (game.CheckGameOver())
                {
                    if(game.CheckWinRC() || game.CheckDiagonals())
                    {
                        if (game.whoIsPlaying)
                            game.winner = game.GetPlayer2();
                        else
                            game.winner = game.GetPlayer1();
                        MessageBox.Show("The winner is " + game.winner, "Winner");
                    }
                    if (game.CheckTie())
                    {
                        game.winner = "Tie";
                        MessageBox.Show("Its a tie ", "Tie");
                    }

                    DialogResult ok = MessageBox.Show("Play Again?", "Game Over!", MessageBoxButtons.YesNo);
                    if (ok == DialogResult.Yes)
                    {
                        Init();
                    }
                    else if (ok == DialogResult.No)
                    {
                        gameOver = true;
                        Close();
                    }
                }
            }
        }

        /// <summary>
        /// clear the buttons from the board
        /// </summary>
        public void ClearBoard()
        {
            foreach (Control c in pnlBoardCanvas.Controls)
                c.Dispose();
            pnlBoardCanvas.Controls.Clear();
        }

        /// <summary>
        /// reset the game
        /// </summary>
        /// <param name="settings"> give the size of buttons and panel </param>
        public void Init(Settings settings)
        {
            int boardSize = settings.GetBoardSize();
            int buttonSize = settings.GetButtonSize();
            this.game = new InARow(boardSize, this);
            int canvasSize = boardSize * (buttonSize + space);
            pnlBoardCanvas.Width = canvasSize;
            pnlBoardCanvas.Height = canvasSize;
            game.SetPlayer1(settings.GetName1());
            game.SetPlayer2(settings.GetName2());
            lbl_whoIsPlaying.Text = game.NowPlaying();

            timer.Start();
            timerCounter = 0;
            lbl_Time.Text = "00:00";
            gameOver = false;
        }

        /// <summary>
        /// reset the game
        /// </summary>
        public void Init()
        {
            int boardSize = settings.GetBoardSize();
            int buttonSize = settings.GetButtonSize();
            space = 5;
            ClearBoard();
            this.boardButton = BuildBoard();
            counter++;
            this.game = new InARow(boardSize, this);
            int canvasSize = boardSize * (buttonSize + space);
            pnlBoardCanvas.Width = canvasSize;
            pnlBoardCanvas.Height = canvasSize;
            game.SetPlayer1(settings.GetName1());
            game.SetPlayer2(settings.GetName2());

            lbl_whoIsPlaying.Text = game.NowPlaying();
            timer.Start();
            timerCounter = 0;
            lbl_Time.Text = "00:00";
            gameOver = false;
        }

        /// <summary>
        /// reset the game if user answered yes, if answered no nothing happends
        /// </summary>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("New Game?", "New Game", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
            {
                Init();
            }
        }

        /// <summary>
        /// reset the board acording the the changed settings
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm2.Init(settings);
            Form sf = settingsForm2;
            sf.Show();
            this.Init();
        }

        /// <summary>
        /// close the form
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
