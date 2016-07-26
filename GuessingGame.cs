using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_7GuessingGame
{
    class GuessingGame
    {
        // PRIVATE INSTANCE VARIABLES
        private Dictionary<string, object> GGString; // TODO: is object the most appropriate here?
        private int randomNumber, score, lives;
        private Random r;


        // CONSTRUCTOR
        public GuessingGame()
        {
            // initialize variables
            r = new Random();
            randomNumber = 0;
            GGString = new Dictionary<string,object>();
            

            // insert Dictionary values
            GGString.Add("startGame", "Start the Game");
            GGString.Add("failMessage", "SORRY, GAME OVER");
            GGString.Add("winMessage", "CONGRATULATIONS! YOU WIN!");
            GGString.Add("infMessage", "Number provided is less than the number picked by the program... Please try again");
            GGString.Add("supMessage", "Number provided is greater than the number picked by the program... Please try again");
            GGString.Add("playAgainMessage", "Would you like to play again?");
            GGString.Add("score", 100);
            GGString.Add("lives", 10);

            //grabbing the values of lives and score from the dictionary
            score = Convert.ToInt32(GGString["score"]);
            lives = Convert.ToInt32(GGString["lives"]);

        }

        // PUBLIC METHODS
        // resets the game to initial state
        public void StartGame()
        {
            //reseting the values of score and lives to original values
            GGString["score"] = 100;
            GGString["lives"] = 10;
            // choose a new random number
            randomNumber = r.Next(1, 101);

            Console.WriteLine(randomNumber);
        }       
        
        public void Miss()
        {
            //decrementing the lives and score
            score -= 10;
            lives -= 1;
            //storing them back in the dictionary
            GGString["score"] = score;
            GGString["lives"] = lives;
           
        }

        // Method compares value to random number and returns string array based on results
        public string[] CheckGuess(int guessValue)
        {
            //function will return a string array of the message(s) to display, the score, lives and the new box color
            string[] message;
            //if the guessed value is less than the random num 
            if (randomNumber > guessValue && lives>=1) {
                this.Miss();
                message = new string[] { GGString["infMessage"].ToString(), "",score.ToString(), lives.ToString(), "yellow" };
                return message;

            }
            //if the guessed value is greater than the random num
            else if (randomNumber < guessValue && lives >= 1)
            {
                this.Miss();
                message = new string[] { GGString["supMessage"].ToString(), "", score.ToString(), lives.ToString(), "red"};
                return message;
            }
            else if (randomNumber != guessValue && lives <=0)
            {
                message = new string[] { GGString["failMessage"].ToString(), GGString["playAgainMessage"].ToString(),score.ToString(), lives.ToString(),"red"};
                return message;
            }
            else
            {
                message = new string[] { GGString["winMessage"].ToString(), GGString["playAgainMessage"].ToString(), score.ToString(), lives.ToString(), "lime" };
                return message;
            }
        }
    }
}
