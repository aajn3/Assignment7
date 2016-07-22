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
            startButton.Visible = false;
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
            startButton.Visible = true;

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

    }
}
