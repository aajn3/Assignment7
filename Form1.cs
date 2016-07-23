using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_7GuessingGame
{
    public partial class Form1 : Form
    {
        GuessingGame game = new GuessingGame();
        Color previousBgColour;
        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        // method to reset game state
        void Restart()
        {
            game.StartGame();
            // reset board colors
            // enable grid

            // hide startgame button
            BtnStart.Visible = false;
        }

        // method to display 'play again' message
        void PlayAgain()
        {
            // show messagebox with playAgainMessage
            // yes: StartGame()
            // no: close messagebox
        }

        // check guess
        void ClickGuess() {
            //// assign reference to clicked cell
            //int guessResult = game.CheckGuess(clickedCell value);
	
            //if (guessResult.Equals(-1)) {		        
            //    Miss();
            //    // turn cell yellow, display infMessage
            //    // update labels on GUI

            //} else if (guessResult.Equals(1)) {		        
            //    Miss();
            //    // turn cell red, display supMessage
            //    // update labels on GUI
            //} else {
            //    // turn cell green, display winMessage
            //    EndGame();                
            //}

        }

        void EndGame()
        {
            // disable grid

            // display startgame button
            BtnStart.Visible = true;

            PlayAgain();
        }

        void Miss()
        {
            // check score & lives values
            //if (score <= 0 || lives <= 0)
            //{
            // disable grid
            // display failMessage
            //    EndGame();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int LblIndex = 1;
            Label tmpLbl;
            for (int i = 0; i <= 9; i++)
            {

                for (int j = 0; j <= 9; j++)
                {
                    tmpLbl = new Label();
                    tmpLbl.AutoSize = true;
                    tmpLbl.Text = LblIndex.ToString();
                    tmpLbl.Font = new Font("Sans", 20);
                    tmpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));

                    if (i == 4 && j == 3)
                    {
                        tmpLbl.BackColor = Color.FromArgb(0, 255, 0);
                    }


                    tmpLbl.Click += ggTable_Click;
                    //tmpLbl.MouseEnter += ggTable_Hover;
                    //tmpLbl.MouseLeave += ggTable_Leave;

                    ggTable.Controls.Add(tmpLbl, j, i);
                    LblIndex++;

                }
            }
        }



        private void ggTable_Click(object sender, EventArgs e)
        {
            Label l = ((Label)sender);
            previousBgColour = l.BackColor;

            l.BackColor = Color.FromArgb(0, 0, 255);
        }

        //private void ggTable_Leave(object sender, EventArgs e)
        //{
        //    Label l = ((Label)sender);
        //    l.BackColor = previousBgColour;
        //}

        //private void ggTable_Hover(object sender, EventArgs e)
        //{
        //    Label l = ((Label)sender);
        //    previousBgColour = l.BackColor;
        //    if (previousBgColour != Color.FromArgb(0, 0, 255))
        //    {
        //        l.BackColor = Color.FromArgb(255, 0, 0);
        //    }
        //}
    }
}
