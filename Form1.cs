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
            //reseting labels
            lblLives.Text = "Score: 100";
            lblScore.Text = "Lives: 10";
            txtBoxMessage.Text = " ";
            txtBoxMessage.Enabled = false;

            // reset board colors
            Form1_Load(this, null);


            // enable grid
            ggTable.Enabled = true;

            // hide startgame button
            BtnStart.Visible = false;
        }

        // method to display 'play again' message
        void PlayAgain()
        {
            // show messagebox with playAgainMessage
            if (MessageBox.Show("Would you like to play again? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Restart();
            }
            else
            {
                this.Close();
            }
        }

        // Method to apply all the changes and text values to the form 
        void ClickGuess(int cellValue, Label lbl) {

            string[] changes = new string[5];
            changes = game.CheckGuess(cellValue);

            //if statement to check if there are still lives
            if (Convert.ToInt32(changes[3]) <= 0)
            {
                EndGame();
            }
            else if (changes[0] == "CONGRATULATIONS! YOU WIN!")
            {
                txtBoxMessage.Text = changes[0];
                lblScore.Text = "Score: " + changes[2];
                lblLives.Text = "Lives: " + changes[3];

                //this will change the label color
                Color col = Color.FromName(changes[4]);
                lbl.BackColor = col;
                EndGame();
            }
            else
            {
                // changing the text values to match the picked values
                txtBoxMessage.Text = changes[0];
                lblScore.Text = "Score: " + changes[2];
                lblLives.Text = "Lives: " + changes[3];

                //this will change the label color
                Color col = Color.FromName(changes[4]);
                lbl.BackColor = col;
            }
           

        }

        void EndGame()
        {
            // disable grid
            ggTable.Enabled = false;
            // display startgame button
            BtnStart.Visible = true;

            //PlayAgain();
        }
        //click event for the table
        private void ggTable_Click(object sender, EventArgs e)
        {
            //getting the label that was clicked
            Label l = ((Label)sender);
            previousBgColour = l.BackColor;
            //calling the ClickGuess function and passing through the value of the label and the label itself
            ClickGuess(Convert.ToInt32(l.Text), l);

            //l.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            ggTable.Controls.Clear();
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

                    //if (i == 4 && j == 3)
                    //{
                    //    tmpLbl.BackColor = Color.FromArgb(0, 255, 0);
                    //}


                    tmpLbl.Click += ggTable_Click;
                    //tmpLbl.MouseEnter += ggTable_Hover;
                    //tmpLbl.MouseLeave += ggTable_Leave;

                    ggTable.Controls.Add(tmpLbl, j, i);
                    LblIndex++;

                }
            }
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
